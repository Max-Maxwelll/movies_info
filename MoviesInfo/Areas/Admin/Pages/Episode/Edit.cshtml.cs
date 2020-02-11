using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Episode
{
    public class EditModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;

        public EditModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public EpisodeModel EpisodeModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EpisodeModel = await context.Episodes.FirstOrDefaultAsync(m => m.Id == id);

            if (EpisodeModel == null)
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

            context.Attach(EpisodeModel).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpisodeModelExists(EpisodeModel.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Show/Details", new { id = EpisodeModel.ShowId });
        }

        private bool EpisodeModelExists(int id)
        {
            return context.Episodes.Any(e => e.Id == id);
        }
    }
}
