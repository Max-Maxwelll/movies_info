using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Show
{
    public class EditModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;

        public EditModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public ShowModel ShowModel { get; set; }

        [BindProperty]
        public IFormFile PortaritFile { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShowModel = await context.Shows
                .Include(s => s.Details)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (ShowModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if(PortaritFile != null)
            {
                string imageName = await CreatePortrait(PortaritFile, ShowModel);
                ShowModel.Portrait = $"/images/{imageName}.jpg";
            }

            context.Update(ShowModel);

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowModelExists(ShowModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ShowModelExists(int id)
        {
            return context.Shows.Any(e => e.Id == id);
        }

        private async Task<string> CreatePortrait(IFormFile file, ShowModel model)
        {
            string imageName = model.Name + model.Description + DateTime.Now;
            using (Stream stream = file.OpenReadStream())
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(imageName);
                    imageName = BitConverter.ToString(sha256.ComputeHash(buffer, 0, buffer.Length));

                    using (FileStream fs = new FileStream($"wwwroot/images/{imageName}.jpg", FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        await stream.CopyToAsync(fs);
                    }
                }
            }

            return imageName;
        }
    }
}
