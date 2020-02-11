using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Show
{
    public class DetailsModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;

        public DetailsModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            this.context = context;
        }

        public ShowModel ShowModel { get; set; }

        public List<Data.Entities.EpisodeModel> EpisodeModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShowModel = await context.Shows.Include(s => s.Details).FirstOrDefaultAsync(m => m.Id == id);
            EpisodeModel = await context.Episodes.Where(e => e.Show.Id == id).ToListAsync();
            if (EpisodeModel == null)
            {
                return NotFound();
            }
            if(ShowModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
