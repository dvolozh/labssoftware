using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kit.Data;

namespace Kit
{
    public partial class MainForm : Form
    {
        private void AddStuff()
        {
            var dtype1 = new Dish_Type() {Name = "Soup"};
            Dish_Type.DishTypes.Add(dtype1);
            var dtype2 = new Dish_Type() { Name = "Pasta" };
            Dish_Type.DishTypes.Add(dtype2);
            var dtype3 = new Dish_Type() { Name = "Meat" };
            Dish_Type.DishTypes.Add(dtype3);

            var c1 = new Cuisine()
            {
                Name = "Italian",
                DishType = dtype2
            };
            Cuisine.Cuisines.Add(c1);
            var c2 = new Cuisine()
            {
                Name = "American",
                DishType = dtype3
            };
            Cuisine.Cuisines.Add(c2);
            var c3 = new Cuisine()
            {
                Name = "Ukrainian",
                DishType = dtype1
            };
            Cuisine.Cuisines.Add(c3);

            var d1 = new Dish()
            {
                Name = "Spaghetti",
                Cuisine = c1
            };
            Dish.Dishes.Add(d1);
            var d2 = new Dish()
            {
                Name = "Meatball",
                Cuisine = c2
            };
            Dish.Dishes.Add(d2);
            var d3 = new Dish()
            {
                Name = "Borscht",
                Cuisine = c3
            };
            Dish.Dishes.Add(d3);

            Product.Products.Add(new Product()
            {
                Name = "Spaghetti",
                Price = 2,
                Weight = 1,
                Dish = d1
            });
            Product.Products.Add(new Product()
            {
                Name = "Meat",
                Price = 2,
                Weight = 1,
                Dish = d1
            });
            Product.Products.Add(new Product()
            {
                Name = "etc",
                Price = 2,
                Weight = 1,
                Dish = d1
            });
            Product.Products.Add(new Product()
            {
                Name = "Meat",
                Price = 2,
                Weight = 1,
                Dish = d2
            });
            Product.Products.Add(new Product()
            {
                Name = "etc",
                Price = 2,
                Weight = 1,
                Dish = d2
            });
            Product.Products.Add(new Product()
            {
                Name = "Beef",
                Price = 2,
                Weight = 1,
                Dish = d3
            });
            Product.Products.Add(new Product()
            {
                Name = "Meat",
                Price = 2,
                Weight = 1,
                Dish = d3
            });
            Product.Products.Add(new Product()
            {
                Name = "etc",
                Price = 2,
                Weight = 1,
                Dish = d3
            });

        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new ProductForm().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new DishForm().ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new CuisineForm().ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Dish_TypeForm().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddStuff();
        }
    }
}
