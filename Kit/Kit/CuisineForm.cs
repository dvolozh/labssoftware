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
    public partial class CuisineForm : Form
    {
        private DishForm _dform;
        private Dish_TypeForm _dtypeform;
        public CuisineForm()
        {
            InitializeComponent();
        }

        public CuisineForm(Dish_TypeForm dtypeform)
        {
            InitializeComponent();
            this._dtypeform = dtypeform;
        }

        public ListBox CuisineList
        {
            get { return lbCuisine; }
        }

        private void RefreshCuisines()
        {
            lbCuisine.DataSource = null;
            lbCuisine.DataSource = ((Dish_Type)(_dtypeform.DishTypeList.SelectedItem)).Cuisines;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Cuisine.Cuisines.Add(new Cuisine()
            {
                Name = tbAddCuisine.Text,
                DishType = ((Dish_Type)(_dtypeform.DishTypeList.SelectedItem))
            });
            RefreshCuisines();
        }

        private void BtnOpenDishes_Click(object sender, EventArgs e)
        {
            _dform = new DishForm(this);
            _dform.DishList.DataSource = null;
            _dform.DishList.DataSource = ((Cuisine)(lbCuisine.SelectedItem)).Dishes;
            _dform.ShowDialog();
        }

        private void CuisineForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            Cuisine.Cuisines.Remove((Cuisine)lbCuisine.SelectedItem);
            RefreshCuisines();
        }
    }
}
