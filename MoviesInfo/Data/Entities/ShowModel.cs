using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data.Entities
{
    public class ShowModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Portrait { get; set; }
        public DetailsModel Details { get; set; }
        public int DetailsId { get; set; }
        public List<EpisodeModel> Episodes { get; set; }
    }
}
