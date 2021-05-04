using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeList.Models;

namespace AnimeList.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IAnimeListRepository repo;
        public NavigationMenuViewComponent(IAnimeListRepository _repo)
        {
            repo = _repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repo.Titles
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
