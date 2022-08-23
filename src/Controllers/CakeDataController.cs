using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaniatsCakeShop.Models;
using SaniatsCakeShop.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SaniatsCakeShop.Controllers
{
    [Route("api/[controller]")]
    public class CakeDataController : Controller
    {
        private readonly ICakeRepository _cakeRepository;

        public CakeDataController(ICakeRepository cakeRepository)
        {
            this._cakeRepository = cakeRepository;
        }

        [HttpGet]
        public IEnumerable<CakeViewModel> LoadMoreCakes()
        {
            IEnumerable<Cake> dbCakes = null;

            dbCakes = _cakeRepository.AllCakes
                .OrderBy(p => p.CakeId).Take(10);

            List<CakeViewModel> cakes = new List<CakeViewModel>();

            foreach (var dbCake in dbCakes)
            {
                cakes.Add(MapDbCakeToCakeViewModel(dbCake));
            }
            return cakes;
        }

        private CakeViewModel MapDbCakeToCakeViewModel(Cake dbCake)
        {
            return new CakeViewModel()
            {
                CakeId = dbCake.CakeId,
                Name = dbCake.Name,
                Price = dbCake.Price,
                ShortDescription = dbCake.ShortDescription,
                ImageThumbnailUrl = dbCake.ImageThumbnailUrl
            };
        }
    }
}
