using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Episode
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;

        public DeleteModel(MoviesInfo.Data.ApplicationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EpisodeModel = await context.Episodes.FindAsync(id);

            if (EpisodeModel != null)
            {
                context.Episodes.Remove(EpisodeModel);
                await context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
