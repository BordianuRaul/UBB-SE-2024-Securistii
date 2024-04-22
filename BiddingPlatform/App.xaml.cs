using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
using BiddingPlatform.GUI;
using BiddingPlatform.GUI.AdminSide;

namespace BiddingPlatform
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var auctionRepository = new AuctionRepository();
            var auctionService = new AuctionService(auctionRepository);
            var bidRepository = new BidRepository();
            var bidService = new BidService(bidRepository);
            Page liveAuctionPage = new LiveAuctionPage(auctionService, bidService);
            Page adminLiveAuctionPage = new AdminLiveAuctionPage(auctionService,bidService);
            Window mainWindow = new MainWindow(liveAuctionPage, adminLiveAuctionPage);
            mainWindow.Show();

           //  <!-- 
           //  StartupUri="MainWindow.xaml"
           //      -->
        }
    }

}
