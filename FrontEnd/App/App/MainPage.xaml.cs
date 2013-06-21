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

        private void ProcurarProdutos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Product/ChooseProductOption.xaml", UriKind.Relative));
        }

        private void Criar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/ShoppingList/Create.xaml", UriKind.Relative));
        }
    }
}