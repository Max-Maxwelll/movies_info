using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data.Entities
{
    public class DetailsModel
    {
        public int Id { get; set; }
        public string Network { get; set; }
        public string Schedule { get; set; }
        [Required]
        public string Genres { get; set; }
        [Required]
        public string Developer { get; set; }
    }
}
