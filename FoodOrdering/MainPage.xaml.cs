using FoodOrdering.Pages;
using FoodOrdering.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FoodOrdering
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainViewModel vm = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = vm;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            frame.Navigate(typeof(RestaurantPage));

            SystemNavigationManager.GetForCurrentView().BackRequested += (sender, _e) => frame.GoBack();
        }

        private void frame_Navigated(object sender, NavigationEventArgs e)
        {
            if (frame.Content.GetType() != typeof(RestaurantPage))
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            else
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

    }
}
