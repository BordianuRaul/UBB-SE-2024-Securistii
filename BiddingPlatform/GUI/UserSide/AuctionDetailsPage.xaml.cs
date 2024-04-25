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
        public int auctionIndex;

        public IAuctionService AuctionService;
        public IBidService BidService;

        public List<IBidModel> bidModels;
        public List<IAuctionModel> auctions;

        public AuctionDetailsPage(int currentAuctionIndex, IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            auctionIndex = currentAuctionIndex;
            this.BidService = bidService;
            this.AuctionService = auctionService;
            //List<BidModel> bidModels = this.BidService.getBids();
            auctions = this.AuctionService.GetAuctions();
            

            AuctionNameBid.Text = auctions[currentAuctionIndex].Name;
            CurrentBid.Text = auctions[currentAuctionIndex].CurrentMaxBid.ToString();
            TimeLeft.Text= (DateTime.Now - auctions[currentAuctionIndex].StartingDate).Hours.ToString();

            foreach(IBidModel bid in auctions[currentAuctionIndex].ListOfBids) 
            {
                BidHistory.Text += bid.BidSum.ToString() + "\n";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LiveAuctionPage LiveAuctionPage = new LiveAuctionPage(this.AuctionService, this.BidService);
            NavigationService?.Navigate(LiveAuctionPage);
        }

        private void JoinAuction(object sender, RoutedEventArgs e)
        {
            EnterAuctionPage EnterAuctionPage = new EnterAuctionPage(auctionIndex, this.AuctionService, this.BidService);
            NavigationService?.Navigate(EnterAuctionPage);
        }
    }
}
