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
    public class IndexModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext _context;

        public IndexModel(MoviesInfo.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Data.Entities.ShowModel> ShowModel { get;set; }

        public async Task OnGetAsync()
        {
            ShowModel = await _context.Shows.ToListAsync();
        }
    }
}
