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
    /// Interaction logic for LiveAuctionPage.xaml
    /// </summary>
    public partial class LiveAuctionPage : Page
    {
        public LiveAuctionPage()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage();
            NavigationService?.Navigate(auctionDetailsPage);
            
        }
    }
}
