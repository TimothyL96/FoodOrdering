using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string title;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Title = "SELECT RESTAURANT";
        }

   
    }
}
