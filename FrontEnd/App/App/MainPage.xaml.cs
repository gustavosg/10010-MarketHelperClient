using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace MarketHelperClient
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            SystemTray.IsVisible = false;
        }

        private void Produtos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Product/ChooseProductOption.xaml", UriKind.Relative));
        }
    }
}