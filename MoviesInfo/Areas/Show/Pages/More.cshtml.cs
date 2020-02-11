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

namespace MoviesInfo.Areas.Show.Pages
{
    public class MoreModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<CustomUser> userManager;

        public MoreModel(ApplicationDbContext context, UserManager<CustomUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public bool IsFollow { get; set; }
        public ShowModel ShowModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShowModel = await context.Shows
                .Include(s => s.Details)
                .Include(s => s.Episodes)
                .FirstOrDefaultAsync(m => m.Id == id);

            var user = await GetUserModel();
            if(user != null)
            {
                if (ShowModel == null)
                {
                    return NotFound();
                }
                if (user == null)
                {
                    return Redirect("/");
                }

                IsFollow = user.Favorites.Where(f => f.ShowId == id).Any();
            }
            
            return Page();
        }

        public async Task<IActionResult> OnPostFollow(int? showId)
        {
            if(showId == null)
            {
                return NotFound();
            }
            var user = await GetUserModel();
            if(user != null)
            {
                var favorite = new FavoriteModel()
                {
                    ShowId = (int)showId
                };

                if (!IsFollow)
                {
                    user.Favorites.Add(favorite);
                    context.Users.Update(user);
                    context.SaveChanges();
                }
            }

            return RedirectToPage("/More", new { id = showId });
        }

        private async Task<CustomUser> GetUserModel()
        {
            if(User.Identity.IsAuthenticated)
            {
                return await context.Users
                .Include(u => u.Favorites)
                .FirstAsync(u => u.Id == userManager.GetUserId(User));
            }
            return null;
        }
    }
}