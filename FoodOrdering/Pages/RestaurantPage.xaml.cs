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
    public sealed partial class RestaurantPage : Page
    {
        RestaurantViewModel vm = new RestaurantViewModel();
        public RestaurantPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.vm.Title = "SELECT RESTAURANT";

            var list = await WebAPI.GetRestaurantsAsync();
            if (list != null)
            {
                foreach (var item in list)
                    vm.RestaurantList.Add(item);
            }
            else
            {
                MainPage.vm.Title = "NO INTERNET CONNECTION";
            }
        }

        private void gridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Frame.Navigate(typeof(FoodPage));

        }
    }
}
