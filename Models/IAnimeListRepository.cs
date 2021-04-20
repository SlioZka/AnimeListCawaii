using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models
{
    public interface IAnimeListRepository
    {
        IQueryable<AnimeTitle> Titles { get; }
    }
}
