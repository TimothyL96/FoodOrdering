using FoodOrdering.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        private double totalPrice;

        public double TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<OrderItem> OrderList { get; set; }
        
        public OrderViewModel()
        {
            OrderList = new ObservableCollection<OrderItem>();
        }
    }
}
