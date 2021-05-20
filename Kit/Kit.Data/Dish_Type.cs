using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kit.Data
{
    public class Dish_Type : Base
    {
        public static List<Dish_Type> DishTypes = new List<Dish_Type>();

        public bool IsSalad { get; set; }
        public bool IsPasta { get; set; }
        public bool IsSoup { get; set; }
        public bool IsPizza { get; set; }
        public bool IsDessert { get; set; }

        public Dish_Type()
        {

        }

        public Dish_Type(bool a)
        {
            IsSalad = a;
        }

        public List<Cuisine> Cuisines
        {
            get { return Cuisine.Cuisines.Where(c => c.DishType == this).ToList(); }
        }
    }
}
