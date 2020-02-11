using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data.Entities
{
    public class FavoriteModel
    {
        public int Id { get; set; }
        public CustomUser User { get; set; }
        public int ShowId { get; set; }
        public ShowModel Show { get; set; }
    }
}
