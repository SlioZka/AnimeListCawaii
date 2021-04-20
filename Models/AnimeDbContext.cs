using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models
{
    public class AnimeDbContext : DbContext
    {
        public AnimeDbContext(DbContextOptions<AnimeDbContext> options)
        : base(options) 
        {

        }
        public DbSet<AnimeTitle> AnimeTitles { get; set; }
    }
}
