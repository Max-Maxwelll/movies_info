using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data.Entities
{
    public class EpisodeModel
    {
        public int Id { get; set; }
        public int ShowId { get; set; }
        public ShowModel Show { get; set; }
        [Required]
        public int Season { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string EpisodeName { get; set; }
        [Required]
        public DateTime AirDate { get; set; }
    }
}
