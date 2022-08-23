using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaniatsCakeShop.ViewModels
{
    public class CakeViewModel
    {
        public int CakeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
    }
}
