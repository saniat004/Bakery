using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SaniatsCakeShop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SaniatsCakeShop.ViewModels
{
    public class CakeEditViewModel
    {
        public Cake Cake { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public int CategoryId { get; set; }

        public Controllers.AdminController AdminController
        {
            get => default;
            set
            {
            }
        }
    }
}
