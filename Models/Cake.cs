using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaniatsCakeShop.Models
{
    public class Cake
    {
        public int CakeId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsCakeOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }

       

        public string NutritionName { get; set; }
        public string Calorie { get; set; }
        public string Protein { get; set; }
        public string niacin { get; set; }
        public string fiber { get; set; }
        public string magnesium { get; set; }
        public Category Category { get; set; }
    }
}
