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
    public partial class Dish_TypeForm : Form
    {
        private CuisineForm _cform;
        public Dish_TypeForm()
        {
            InitializeComponent();
        }

        private void RefreshDishTypes()
        {
            lbDishType.DataSource = null;
            lbDishType.DataSource = Dish_Type.DishTypes;
        }

        public ListBox DishTypeList
        {
            get { return lbDishType; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Dish_Type.DishTypes.Add(new Dish_Type()
            {
                Name = tbAddDishType.Text
            });
            RefreshDishTypes();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Dish_Type.DishTypes.Remove((Dish_Type)lbDishType.SelectedItem);
            RefreshDishTypes();
        }

        private void BtnOpenCuisines_Click(object sender, EventArgs e)
        {
            _cform = new CuisineForm(this);
            _cform.CuisineList.DataSource = null;
            _cform.CuisineList.DataSource = ((Dish_Type)(lbDishType.SelectedItem)).Cuisines;
            _cform.ShowDialog();
        }

        private void Dish_TypeForm_Load(object sender, EventArgs e)
        {
            RefreshDishTypes();
        }
    }
}
