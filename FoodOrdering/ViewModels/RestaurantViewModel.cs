using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.ViewModels
{
    public class RestaurantViewModel
    {
        public ObservableCollection<string> RestaurantList { get; set; }

       public RestaurantViewModel()
        {
            RestaurantList = new ObservableCollection<string>();

            //foreach(var item in StaticResources.RestaurantImageUrls)
            //    RestaurantList.Add(item);
        }
    }
}
