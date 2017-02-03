using FoodOrdering.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FoodOrdering.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CheckOutPage : Page
    {
        public CheckOutPage()
        {
            this.InitializeComponent();
            MainPage.vm.Title = "CHECK OUT";
        }

           private async void proceedBtn_Click(object sender, RoutedEventArgs e)
        {
            var db = new DatabaseContext();
            db.Orders.Add(new Order()
            {
                AccountNumber = "",
                Name     = "",
                Address1 = "",
                Address2 = "",
                City     = "",
                State    = "",
                Zip      = "",
                Phone    = ""
            });

            await db.SaveChangesAsync();

            Frame.Navigate(typeof(FeedbackPage));
        }
    }
}
