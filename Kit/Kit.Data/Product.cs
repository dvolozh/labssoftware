using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kit.Data
{
    public class Product : Base
    {
        public static List<Product> Products = new List<Product>();

        private Guid _dishId;

        public Dish Dish
        {
            get { return Dish.Dishes.Where(d => d.Id == _dishId).SingleOrDefault(); }
            set { _dishId = value.Id; }
        }
        public int Price { get; set; }
        public int Weight { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime ExpDate { get; set; }

        public Product()
        {

        }

        public Product(int a)
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
    }
}
