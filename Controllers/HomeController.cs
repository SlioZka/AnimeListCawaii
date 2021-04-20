using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeList.Models;
using Microsoft.AspNetCore.Mvc;
using AnimeList.Models.ViewModels;

namespace AnimeList.Controllers
{
    public class HomeController : Controller
    {
        private IAnimeListRepository repository;
        private int PageSize = 2;
        public HomeController(IAnimeListRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int productPage = 1)
         => View(new AnimeListViewModel
         {
             Titles = repository.Titles
         .OrderBy(p => p.AnimeTitleID)
         .Skip((productPage - 1) * PageSize)
         .Take(PageSize),
             PagingInfo = new PagingInfo
             {
                 CurrentPage = productPage,
                 ItemsPerPage = PageSize,
                 TotalItems = repository.Titles.Count()
             }
         });
    }
}
