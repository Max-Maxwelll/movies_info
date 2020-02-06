using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesInfo.Data.Models
{
    public class DetailsModel
    {
        public int Id { get; set; }
        public int ShowId { get; set; }
        public string Network { get; set; }
        public string Schedule { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public string Developer { get; set; }
    }
}
