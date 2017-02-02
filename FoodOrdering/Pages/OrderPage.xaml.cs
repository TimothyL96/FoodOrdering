using FoodOrdering.Items;
using FoodOrdering.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodOrdering.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        OrderViewModel vm = new OrderViewModel();
        public OrderPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.vm.Title = "CONFIRM ORDER";

            var foodVm = e.Parameter as FoodViewModel;
                        
            foreach(var item in foodVm.FoodList)
            {
                vm.OrderList.Add(new OrderItem()
                {
                    Name = item.Name,
                    Unit = item.Count,
                    Price = item.Price * item.Count
                });
            }

            //vm.TotalPrice = vm.OrderList.Aggregate(0.0, (sum, item) => sum += item.Price);
            
            vm.TotalPrice = vm.OrderList.Sum(x => x.Price);
        }

        private void orderBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CheckOutPage));
        }
    }
}
