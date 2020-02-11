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
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public EpisodeModel EpisodeModel { get; set; } = new Data.Entities.EpisodeModel();

        public IActionResult OnGet(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            EpisodeModel.ShowId = (int)id;
            EpisodeModel.AirDate = DateTime.Now;
            //Show = context.Shows.FirstOrDefault(s => s.Id == id);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var show = context.Shows
                .Include(s => s.Episodes)
                .FirstOrDefault(s => s.Id == EpisodeModel.ShowId);

            if (show != null)
            {
                show.Episodes.Add(EpisodeModel);
                context.Shows.Update(show);
                await context.SaveChangesAsync();
                return RedirectToPage($"/Show/Details", new { id = show.Id });
            }

            return RedirectToPage("/Show/Index");
        }
    }
}