using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Kit_MVVM.Models;
using Kit_MVVM.ViewModels;

namespace Kit_MVVM.ViewModels
{
    class MainViewModel
    {
        public MainViewModel()
        {
            Recipes = new ObservableCollection<Recipe> { };
        }
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ICommand AddItem => new DelegateCommand(_AddItem);

        int c = 0;

        void _AddItem()
        {
            string[] names = { "Meat steak", "Pasta Carbonara" };
            string[] recipes = { "Meat, Rosemary, Oregano", "Spaghetti, Bacon, etc" };
            if (c < names.Length)
            {
                Recipes.Add(new Recipe
                {
                    Id = (uint)c,
                    name = names[c],
                    text = recipes[c]
                });
                c++;
            }
        }
    }
}
