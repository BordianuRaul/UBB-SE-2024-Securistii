using BiddingPlatform.GUI;
using BiddingPlatform.GUI.AdminSide;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BiddingPlatform
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserClick(object sender, RoutedEventArgs e)
        {
            //LiveAuctionPage page = new LiveAuctionPage();
            //this.Content = page;
            MainFrame.Content = null;
            MainFrame.NavigationService.Navigate(new LiveAuctionPage());
            (sender as Button).Visibility = Visibility.Collapsed;
            AdminButton.Visibility = Visibility.Collapsed;
        }

        private void AdminClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = null;
            MainFrame.NavigationService.Navigate(new AdminLiveAuctionPage());
            (sender as Button).Visibility = Visibility.Collapsed;
            UserButton.Visibility = Visibility.Collapsed;
        }
    }
}