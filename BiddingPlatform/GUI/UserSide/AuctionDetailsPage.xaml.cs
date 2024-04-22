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

        public AuctionService AuctionService;
        public BidService BidService;

        public List<BidModel> bidModels;
        public List<AuctionModel> auctions;
        public AuctionDetailsPage(int index, AuctionService auctionService, BidService bidService)
        {
            InitializeComponent();
            auctionIndex = index;
            this.BidService = bidService;
            this.AuctionService = auctionService;
            //List<BidModel> bidModels = this.BidService.getBids();
            List<AuctionModel> auctions = this.AuctionService.getAuctions();
            

            AuctionNameBid.Text= auctions[index].name;
            CurrentBid.Text = auctions[index].currentMaxSum.ToString();
            TimeLeft.Text= (DateTime.Now - auctions[index].startingDate).Hours.ToString();


            int n= auctions[index].listOfBids.Count;
            for(int i=0; i<n; i++)
            {
                BidHistory.Text += auctions[index].listOfBids[i].bidSum.ToString() + "\n";
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
