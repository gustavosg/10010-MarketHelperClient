using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace TestProject1
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
    }
}