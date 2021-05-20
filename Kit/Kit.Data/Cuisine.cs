using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kit.Data
{
    public class Cuisine : Base
    {
        public static List<Cuisine> Cuisines = new List<Cuisine>();

        private Guid _dtypeId;

        public Dish_Type DishType
        {
            get { return Dish_Type.DishTypes.Where(dtype => dtype.Id == _dtypeId).SingleOrDefault(); }
            set { _dtypeId = value.Id; }
        }

        public string MostUsedProduct { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsEuropean { get; set; }
        public bool IsAmerican { get; set; }

        public Cuisine()
        {
            
        }

        public Cuisine(string a)
        {
            MostUsedProduct = a;
        }

        public bool IsHealthy(bool isSpicy)
        {
            if (isSpicy)
            {
                return false;
            }

            return true;
        }

        public List<Dish> Dishes
        {
            get { return Dish.Dishes.Where(d => d.Cuisine == this).ToList(); }
        }
    }
}
