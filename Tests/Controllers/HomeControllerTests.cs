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
    public class HomeControllerTests
    {

        [Fact]
        public void Index_Use_CakesOfTheWeeks_FromRepository()
        {
            //arrange
            var mockCakeRepository = RepositoryMocks.GetCakeRepository();

            HomeController homeController = new HomeController(mockCakeRepository.Object);
            //act
            var result = homeController.Index().ViewData.Model
                     as HomeViewModel;

            //assert

            Assert.NotNull(result);

            var cakesOfTheWeek = result?.CakesOfTheWeek?.ToList();
            Assert.NotNull(cakesOfTheWeek);
            Assert.True(cakesOfTheWeek?.Count() == 3);
            Assert.Equal("FRESH FRUIT CAKE", cakesOfTheWeek?[0].Name);


        }

    }
}
