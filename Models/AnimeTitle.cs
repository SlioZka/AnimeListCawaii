using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models
{
    public class AnimeTitle
    {
        public long AnimeTitleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Year { get; set; }
        public string Category { get; set; }
    }
}
