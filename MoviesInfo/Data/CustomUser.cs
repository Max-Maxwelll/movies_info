using Microsoft.AspNetCore.Identity;
using MoviesInfo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data
{
    public class CustomUser : IdentityUser
    {
        public List<FavoriteModel> Favorites { get; set; }
    }
}
