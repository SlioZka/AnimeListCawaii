using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models.ViewModels
{
    public class AnimeListViewModel
    {
        public IEnumerable<AnimeTitle> Titles { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
