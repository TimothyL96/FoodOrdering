using FoodOrdering.Items;
using FoodOrdering.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class FoodPage : Page
    {
        FoodViewModel vm = new FoodViewModel();
        public FoodPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;

            NavigationCacheMode = NavigationCacheMode.Enabled;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            MainPage.vm.Title = "SELECT FOOD";
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            var fe = sender as FrameworkElement;
            var context = fe.DataContext as FoodItem;
            var index = context.Id;

            vm.FoodList[index].Count += 1;
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            var fe = sender as FrameworkElement;
            var context = fe.DataContext as FoodItem;
            var index = context.Id;

            if (vm.FoodList[index].Count > 0)
                vm.FoodList[index].Count -= 1;
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OrderPage), vm);
        }
    }
}
