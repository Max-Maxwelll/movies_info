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
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Show
{
    public class CreateModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext _context;

        public CreateModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ShowModel ShowModel { get; set; }

        [BindProperty]
        public IFormFile PortaritFile { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string imageName = await CreatePortrait(PortaritFile, ShowModel);

            ShowModel.Portrait = $"/images/{imageName}.jpg ";
            _context.Shows.Add(ShowModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private async Task<string> CreatePortrait(IFormFile file, ShowModel model)
        {
            string imageName = model.Name + model.Description + DateTime.Now;
            using (Stream stream = file.OpenReadStream())
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(imageName);
                    imageName = BitConverter.ToString(sha256.ComputeHash(buffer, 0, buffer.Length)).Replace("-", "");

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