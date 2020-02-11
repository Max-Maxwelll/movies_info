using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesInfo.Data;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.User.Pages
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class FavoritesModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<CustomUser> userManager;

        public FavoritesModel(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public List<FavoriteModel> Favorites { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await GetUserModel();
            if(user.Favorites != null)
            {
                Favorites = user.Favorites;
            }
            
            return Page();
        }

        public async Task<IActionResult> OnPostUnfollow(int? showId)
        {
            if (showId == null)
            {
                return NotFound();
            }
            var user = await GetUserModel();
            if (user != null)
            {
                var favorite = user.Favorites.First(f => f.ShowId == showId);
                if(favorite != null)
                {
                    context.Favorites.Remove(favorite);
                    context.SaveChanges();
                }
            }

            return RedirectToPage("/Favorites");
        }

        private async Task<CustomUser> GetUserModel()
        {
            if (User.Identity.IsAuthenticated)
            {
                return await context.Users
                .Include(u => u.Favorites)
                .ThenInclude(f => f.Show)
                .FirstAsync(u => u.Id == userManager.GetUserId(User));
            }
            return null;
        }
    }
}