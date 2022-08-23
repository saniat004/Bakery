using System.Linq;
using SaniatsCakeShop.Models;
using SaniatsCakeShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SaniatsCakeShop.Controllers
{
    [Authorize(Roles = "Administrator")]
   // [Authorize(Policy = "DeletePie")]
    public class CakeManagementController: Controller
    {
        private readonly ICakeRepository _cakeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CakeManagementController(ICakeRepository cakeRepository, ICategoryRepository categoryRepository)
        {
            _cakeRepository = cakeRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Index()
        {
            var cakes = _cakeRepository.AllCakes.OrderBy(p => p.CakeId);
            return View(cakes);
        }

        public IActionResult AddCake()
        {
            var categories = _categoryRepository.AllCategories;
            var cakeEditViewModel = new CakeEditViewModel
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                CategoryId = categories.FirstOrDefault().CategoryId
            };
            return View(cakeEditViewModel);
        }

        [HttpPost]
        public IActionResult AddCake(CakeEditViewModel cakeEditViewModel)
        {
         /*
            //Basic validation
            if (ModelState.IsValid)
            {
                _cakeRepository.CreateCake(cakeEditViewModel.Cake);
                return RedirectToAction("Index");
            }
            return View(cakeEditViewModel);

            */


            if (ModelState.GetValidationState("Cake.Price") == ModelValidationState.Valid
               || cakeEditViewModel.Cake.Price < 0)
                ModelState.AddModelError(nameof(cakeEditViewModel.Cake.Price), "The price of the cake should be higher than 0");

            if (cakeEditViewModel.Cake.IsCakeOfTheWeek && !cakeEditViewModel.Cake.InStock)
                ModelState.AddModelError(nameof(cakeEditViewModel.Cake.IsCakeOfTheWeek), "Only cakes that are in stock should be Most Sold Cake of the Week");

            if (ModelState.IsValid)
            {
                _cakeRepository.CreateCake(cakeEditViewModel.Cake);
                return RedirectToAction("Index");
            }

            return View(cakeEditViewModel);
        }

        public IActionResult EditCake(int cakeId)
        {
            var categories = _categoryRepository.AllCategories;

            var cake = _cakeRepository.AllCakes.FirstOrDefault(p => p.CakeId == cakeId);

            var cakeEditViewModel = new CakeEditViewModel
            {
                Categories = categories.Select(c => new SelectListItem() { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList(),
                Cake = cake,
                CategoryId = cake.CategoryId
            };

            var item = cakeEditViewModel.Categories.FirstOrDefault(c => c.Value == cake.CategoryId.ToString());
            item.Selected = true;

            return View(cakeEditViewModel);
        }

        [HttpPost]
        public IActionResult EditCake(CakeEditViewModel cakeEditViewModel)
        {
            cakeEditViewModel.Cake.CategoryId = cakeEditViewModel.CategoryId;

            if (ModelState.IsValid)
            {
                _cakeRepository.UpdateCake(cakeEditViewModel.Cake);
                return RedirectToAction("Index");
            }
            return View(cakeEditViewModel);
        }

        [HttpPost]
        public IActionResult DeleteCake(string cakeId)
        {
            return View();
        }

    }
}