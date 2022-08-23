using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SaniatsCakeShop.Models
{
    public class CakeRepository: ICakeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Cake> AllCakes
        {
            get
            {
                return _appDbContext.Cakes.Include(c => c.Category);
            }
        }

        public IEnumerable<Cake> CakesOfTheWeek
        {
            get
            {
                return _appDbContext.Cakes.Include(c => c.Category).Where(p => p.IsCakeOfTheWeek);
            }
        }

        public Cake GetCakeById(int cakeId)
        {
            return _appDbContext.Cakes.FirstOrDefault(p => p.CakeId == cakeId);
        }
        public void UpdateCake(Cake cake)
        {
            _appDbContext.Cakes.Update(cake);
            _appDbContext.SaveChanges();
        }

        public void CreateCake(Cake cake)
        {
            _appDbContext.Cakes.Add(cake);
            _appDbContext.SaveChanges();
        }
    }
}
