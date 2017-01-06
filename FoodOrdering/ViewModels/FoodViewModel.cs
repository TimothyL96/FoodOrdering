using FoodOrdering.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.ViewModels
{
    public class FoodViewModel
    {
        public ObservableCollection<FoodItem> FoodList { get; set; }

        public FoodViewModel()
        {
            FoodList = new ObservableCollection<FoodItem>();

            var foods = StaticResources.FoodList;
            var prices = StaticResources.FoodPrices;

            for(int i = 0; i < foods.Length; i++)
            {
                FoodList.Add(new FoodItem()
                {
                    Id=i,
                    Name = foods[i],
                    Price=prices[i],
                    Count = 0
                });
            }
        }
    }
}
