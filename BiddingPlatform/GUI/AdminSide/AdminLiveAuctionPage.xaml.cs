using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BiddingPlatform.GUI.AdminSide
{
    /// <summary>
    /// Interaction logic for AdminLiveAuctionPage.xaml
    /// </summary>
    public partial class AdminLiveAuctionPage : Page
    {
        public AdminLiveAuctionPage()
        {
            InitializeComponent();
        }

        private void EnterAuction(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage();
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void AddAuction(object sender, RoutedEventArgs e)
        {
            AddAuctionPage AddAuctionPage = new AddAuctionPage();
            NavigationService?.Navigate(AddAuctionPage);
        }
    }
}
