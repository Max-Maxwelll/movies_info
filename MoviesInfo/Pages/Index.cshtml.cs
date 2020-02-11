using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<CustomUser> userManager;

        public IndexModel(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IList<ShowModel> ShowModel { get; set; }
        public IList<FavoriteModel> Favorites { get; set; }

        [BindProperty(SupportsGet = true, Name = "SearchString")]
        public string SearchString { get; set; }

        public async Task OnGetAsync()
        {
            ShowModel = await context.Shows.ToListAsync();

            if (SearchString != null)
            {
                ShowModel = ShowModel.Where(s => s.Name.ToLower().Contains(SearchString)).ToList();
            }

            if (User.Identity.IsAuthenticated)
            {
                var user = await GetUserModel();
                Favorites = user.Favorites;
            }
        }

        private async Task<CustomUser> GetUserModel()
        {
            if (User.Identity.IsAuthenticated)
            {
                return await context.Users
                .Include(u => u.Favorites)
                .FirstAsync(u => u.Id == userManager.GetUserId(User));
            }
            return null;
        }
    }
}
