using SaniatsCakeShop.Controllers;
using SaniatsCakeShop.ViewModels;
using Tests.Mocks;
using System.Linq;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SaniatsCakeShop.Models;

namespace Tests.Controllers
{
    public class CakeManagementControllerTests
    {
        
         
        
        [Fact]
        public void Index_ReturnsAViewResult_ContainsAllCakes()
        {
            //arrange
            var mockCategoryRepository = RepositoryMocks.GetCategoryRepository();
            var mockCakeRepository = RepositoryMocks.GetCakeRepository();

            var CakeManagementController = new CakeManagementController(mockCakeRepository.Object, mockCategoryRepository.Object);

            //act
            var result = CakeManagementController.Index();

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var cakes = Assert.IsAssignableFrom<IEnumerable<Cake>>(viewResult.ViewData.Model);
            Assert.Equal(11, cakes.Count());
        }

        [Fact]
        public void AddCake_Redirects_ValidCakeViewModel()
        {
            //arrange
            var cakeEditViewModel = new CakeEditViewModel();
            var mockPieRepository = RepositoryMocks.GetCakeRepository();
            var cake = mockPieRepository.Object.GetCakeById(1);
            cakeEditViewModel.Cake = cake;
            cakeEditViewModel.CategoryId = 1;

            var mockCategoryRepository = new Mock<ICategoryRepository>();

            var cakeManagementController = new CakeManagementController(mockPieRepository.Object, mockCategoryRepository.Object);

            //act
            var result = cakeManagementController.AddCake(cakeEditViewModel);

            //assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }


        [Fact]
        public void AddPie_ReturnsViewResultWithViewModel_InvalidCakeViewModel()
        {
            //arrange


            var cakeEditViewModel = new CakeEditViewModel();
            var mockPieRepository = RepositoryMocks.GetCakeRepository();
            var cake = mockPieRepository.Object.GetCakeById(1);

            cake.IsCakeOfTheWeek = true;
            cake.InStock = false;
            cakeEditViewModel.Cake = cake;
            cakeEditViewModel.CategoryId = 1;

            var mockCategoryRepository = new Mock<ICategoryRepository>();

            var cakeManagementController = new CakeManagementController(mockPieRepository.Object, mockCategoryRepository.Object);

            //act
            var result = cakeManagementController.AddCake(cakeEditViewModel);

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
            Assert.True(string.IsNullOrEmpty(viewResult.ViewName));
        }


        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        public void AddPie_ReturnsViewResultWithViewModel_InvalidCakeViewModel_NegativePrice(int price)
        {
            //arrange

            var cakeEditViewModel = new CakeEditViewModel();
            var mockPieRepository = RepositoryMocks.GetCakeRepository();
            var cake = mockPieRepository.Object.GetCakeById(1);

            cake.IsCakeOfTheWeek = true;
            cake.InStock = false;


            cake.Price = price;
            cakeEditViewModel.Cake = cake;
            cakeEditViewModel.CategoryId = 1;


            var mockCategoryRepository = new Mock<ICategoryRepository>();
            var cakeManagementController = new CakeManagementController(mockPieRepository.Object, mockCategoryRepository.Object);




            //act
            var result = cakeManagementController.AddCake(cakeEditViewModel);

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.NotNull(viewResult.Model);
            Assert.True(string.IsNullOrEmpty(viewResult.ViewName));

        }

   
}
}
