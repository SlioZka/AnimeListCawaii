using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeList.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AnimeDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<AnimeDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.AnimeTitles.Any())
            {
                context.AnimeTitles.AddRange(
                new AnimeTitle
                {
                    Name = "Sword Art Online",
                    Description = "Play for your life...",
                    Year = 2012,
                    Category = "LitRPG"
                },
                new AnimeTitle
                {
                    Name = "Akame ga Kill",
                    Description = "Kill all pigs",
                    Year = 2010,
                    Category = "Blood"
                },
                new AnimeTitle
                {
                    Name = "Attack on Titan",
                    Description = "Eren will be free =(",
                    Year = 2012,
                    Category = "Drama"
                }
                );
                context.SaveChanges();
            }
        }
    }
}
