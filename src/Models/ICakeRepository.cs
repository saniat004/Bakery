using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaniatsCakeShop.Models
{
    public interface ICakeRepository
    {
        IEnumerable<Cake> AllCakes { get; }
        IEnumerable<Cake> CakesOfTheWeek { get; }
        Cake GetCakeById(int cakeId);
        void CreateCake(Cake cake);

        void UpdateCake(Cake cake);
    }
}
