using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaniatsCakeShop.Models;
using SaniatsCakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Localization;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaniatsCakeShop.Controllers
{
    public class HomeController : Controller
    {
        // private readonly IStringLocalizer<HomeController> _stringLocalizer;
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
           // _stringLocalizer = stringLocalizer;
        }
/*
        public IActionResult Index()
        {

            
            var homeViewModel = new HomeViewModel
            {
                CakesOfTheWeek = _cakeRepository.CakesOfTheWeek
            };

            return View(homeViewModel);
        }
*/

        public ViewResult Index()
        {


            var homeViewModel = new HomeViewModel
            {
                CakesOfTheWeek = _cakeRepository.CakesOfTheWeek
            };

            return View(homeViewModel);
        }


    }
}
