using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaniatsCakeShop.Models;

namespace SaniatsCakeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Cake> CakesOfTheWeek { get; set; }
    }
}
