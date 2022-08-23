using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaniatsCakeShop.Models;
using SaniatsCakeShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaniatsCakeShop.Controllers
{
    public class CakeController : Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

     

        public ViewResult List(string category)
        {
            IEnumerable<Cake> cakes;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                cakes = _cakeRepository.AllCakes.OrderBy(p => p.CakeId);
                currentCategory = "All Cakes";
            }
            else
            {
                cakes = _cakeRepository.AllCakes.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.CakeId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CakesListViewModel
            {
                Cakes = cakes,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var cake = _cakeRepository.GetCakeById(id);
            if (cake == null)
                return NotFound();

            return View(cake);
        }
    }
}
