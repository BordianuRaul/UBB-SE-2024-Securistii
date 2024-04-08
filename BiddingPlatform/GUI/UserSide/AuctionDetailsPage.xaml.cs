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

namespace BiddingPlatform.GUI
{
    /// <summary>
    /// Interaction logic for AuctionDetailsPage.xaml
    /// </summary>
    public partial class AuctionDetailsPage : Page
    {
        public AuctionDetailsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LiveAuctionPage LiveAuctionPage = new LiveAuctionPage();
            NavigationService?.Navigate(LiveAuctionPage);
        }

        private void JoinAuction(object sender, RoutedEventArgs e)
        {
            EnterAuctionPage EnterAuctionPage = new EnterAuctionPage();
            NavigationService?.Navigate(EnterAuctionPage);
        }
    }
}
