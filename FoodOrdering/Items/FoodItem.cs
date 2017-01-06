using FoodOrdering.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Items
{
    public class FoodItem : BaseViewModel
    {
        public int Id { get; set; }

        private string name;
        private double price;
        private int count;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
                OnPropertyChanged();
            }
        }
        
    }
}
