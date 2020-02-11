using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MoviesInfo.Data.Entities;

namespace MoviesInfo.Areas.Admin.Pages.Show
{
    public class DeleteModel : PageModel
    {
        private readonly MoviesInfo.Data.ApplicationDbContext context;
        private readonly ILogger<DeleteModel> logger;

        public DeleteModel(MoviesInfo.Data.ApplicationDbContext context, ILogger<DeleteModel> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        [BindProperty]
        public ShowModel ShowModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ShowModel = await context.Shows.FirstOrDefaultAsync(m => m.Id == id);

            if (ShowModel == null)
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

            ShowModel = await context.Shows
                .Include(m => m.Details)
                .FirstAsync(s => s.Id == id);
            
            if (ShowModel != null)
            {
                context.Shows.Remove(ShowModel);
                await context.SaveChangesAsync();
            }
            

            return RedirectToPage("./Index");
        }
    }
}
