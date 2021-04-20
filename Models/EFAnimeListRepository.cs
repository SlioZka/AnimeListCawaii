using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models
{
    public class EFAnimeListRepository: IAnimeListRepository
    {
        private AnimeDbContext context;
        public EFAnimeListRepository(AnimeDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<AnimeTitle> Titles => context.AnimeTitles;
    }
}
