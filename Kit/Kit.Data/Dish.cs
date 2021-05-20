using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kit.Data
{
    public class Dish : Base
    {
        public static List<Dish> Dishes = new List<Dish>();

        private Guid _cuisineId;

        public Cuisine Cuisine
        {
            get { return Cuisine.Cuisines.Where(c => c.Id == _cuisineId).SingleOrDefault(); }
            set { _cuisineId = value.Id; }
        }

        public int Price { get; set; }
        public int Weight { get; set; }
        public DateTime CookedDate { get; set; }
        public DateTime ExpDate { get; set; }

        public Dish()
        {

        }

        public Dish(int a)
        {
            Price = a;
        }

        public int DoublePrice(int price)
        {
            return price * 2;
        }

        public bool IsFresh(DateTime ExpirationDate)
        {
            if (DateTime.Compare(DateTime.Now, ExpirationDate) > 0)
            {
                return false;
            }

            return true;
        }

        public List<Product> Products
        {
            get { return Product.Products.Where(p => p.Dish == this).ToList(); }
        }
    }
}
