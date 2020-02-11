using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MoviesInfo.Areas.Admin.Pages.Show
{
    public class DelFileModel : PageModel
    {
        public void OnGet()
        {
            string path = "wwwroot/images/9CDBEC2262975DCD2113DD54946C5353D0EDD1820B34AD4A399785BE666EA51D.jpg";
            System.IO.File.Delete(path);
        }
    }
}