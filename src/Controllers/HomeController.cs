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


namespace SaniatsCakeShop.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ICakeRepository _cakeRepository;

        public HomeController(ICakeRepository cakeRepository)
        {
            _cakeRepository = cakeRepository;
          
        }


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
