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
    public partial class DishForm : Form
    {
        private ProductForm _pform;
        private CuisineForm _cForm;
        public DishForm()
        {
            InitializeComponent();
        }

        public DishForm(CuisineForm cform)
        {
            InitializeComponent();
            this._cForm = cform;
        }

        public ListBox DishList
        {
            get { return lbDish; }
        }

        private void DishForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpenProducts_Click(object sender, EventArgs e)
        {
            _pform = new ProductForm(this);
            _pform.ProductList.DataSource = null;
            _pform.ProductList.DataSource = ((Dish)(lbDish.SelectedItem)).Products;
            _pform.ShowDialog();
        }

        private void lbDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RefreshDishes()
        {
            lbDish.DataSource = null;
            lbDish.DataSource = ((Cuisine)(_cForm.CuisineList.SelectedItem)).Dishes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dish.Dishes.Add(new Dish()
            {
                Name = tbAddDish.Text,
                Price = 2,
                Weight = 1,
                Cuisine = ((Cuisine)(_cForm.CuisineList.SelectedItem))
            });
            RefreshDishes();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Dish.Dishes.Remove((Dish)lbDish.SelectedItem);
            RefreshDishes();
        }
    }
}
