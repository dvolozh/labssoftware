using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kit.Data;

namespace Kit
{
    public partial class ProductForm : Form
    {
        private DishForm _dForm;
        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(DishForm dform)
        {
            InitializeComponent();
            this._dForm = dform;
        }

        public ListBox ProductList
        {
            get { return this.lbProduct; }
        }

        private void RefreshProducts()
        {
            lbProduct.DataSource = null; 
            lbProduct.DataSource = ((Dish)(_dForm.DishList.SelectedItem)).Products;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product.Products.Add(new Product()
            {
                Name = tbAddProduct.Text,
                Price = 2,
                Weight = 1,
                Dish = ((Dish)(_dForm.DishList.SelectedItem))
            });
            RefreshProducts();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            Product.Products.Remove((Product)lbProduct.SelectedItem);
            RefreshProducts();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
