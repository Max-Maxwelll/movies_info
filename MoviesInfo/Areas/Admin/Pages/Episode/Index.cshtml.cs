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
    public class IndexModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;

        public IndexModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            this.context = context;
        }

        public IList<EpisodeModel> EpisodeModel { get;set; }

        public async Task OnGetAsync()
        {
            EpisodeModel = await context.Episodes.ToListAsync();
        }
    }
}
