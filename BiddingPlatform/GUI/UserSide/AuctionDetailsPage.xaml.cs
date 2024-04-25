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
using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
using BiddingPlatform.User;

namespace BiddingPlatform.GUI
{
    /// <summary>
    /// Interaction logic for AuctionDetailsPage.xaml
    /// </summary>
    public partial class AuctionDetailsPage : Page
    {
        public int AuctionIndex;

        public IAuctionService AuctionService;
        public IBidService BidService;

        public List<IBidModel> BidModels;
        public List<IAuctionModel> Auctions;

        public AuctionDetailsPage(int currentAuctionIndex, IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            AuctionIndex = currentAuctionIndex;
            this.BidService = bidService;
            this.AuctionService = auctionService;
            Auctions = this.AuctionService.GetAuctions();
            AuctionNameBid.Text = Auctions[currentAuctionIndex].Name;
            CurrentBid.Text = Auctions[currentAuctionIndex].CurrentMaxBid.ToString();
            TimeLeft.Text = (DateTime.Now - Auctions[currentAuctionIndex].StartingDate).Hours.ToString();
            foreach (IBidModel bid in Auctions[currentAuctionIndex].ListOfBids)
            {
                BidHistory.Text += bid.BidSum.ToString() + "\n";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LiveAuctionPage liveAuctionPage = new LiveAuctionPage(this.AuctionService, this.BidService);
            NavigationService?.Navigate(liveAuctionPage);
        }

        private void JoinAuction(object sender, RoutedEventArgs e)
        {
            EnterAuctionPage enterAuctionPage = new EnterAuctionPage(AuctionIndex, this.AuctionService, this.BidService);
            NavigationService?.Navigate(enterAuctionPage);
        }
    }
}
