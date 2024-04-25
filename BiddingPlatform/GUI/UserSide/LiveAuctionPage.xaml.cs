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
    /// Interaction logic for LiveAuctionPage.xaml
    /// </summary>
    public partial class LiveAuctionPage : Page
    {
        
        public IAuctionService AuctionService;
        public IBidService BidService;
        public List<IAuctionModel> Auctions;

        public LiveAuctionPage(IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            this.AuctionService= auctionService;
            this.BidService = bidService;
            Auctions = this.AuctionService.getAuctions();
            
            auctionNameTextBox1.Text= Auctions[0].Name;
            auctionNameTextBox2.Text = Auctions[1].Name;

            auctionDescriptionTextBox1.Text = Auctions[0].Description;
            auctionDescriptionTextBox2.Text = Auctions[1].Description;

            currentBidMinimumPriceTextBox1.Text = Auctions[0].CurrentMaxSum.ToString();
            currentBidMinimumPriceTextBox2.Text = Auctions[1].CurrentMaxSum.ToString();
            
            timeUntilAuctionEndsTextBox1.Text = (DateTime.Now - Auctions[0].StartingDate).Hours.ToString();
            timeUntilAuctionEndsTextBox2.Text = (DateTime.Now - Auctions[1].StartingDate).Hours.ToString();
        }


        private void NavigateToDetailsPage(int auctionIndex)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(auctionIndex, AuctionService, BidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void EnterAuctionButton1_Click(object sender, RoutedEventArgs e)
        {
            this.NavigateToDetailsPage(0);
        }

        private void EnterAuctionButton2_Click(object sender, RoutedEventArgs e)
        {
            this.NavigateToDetailsPage(1);
        }

        private void EnterAuctionButton3_Click(object sender, RoutedEventArgs e)
        {
            this.NavigateToDetailsPage(2);
        }
    }
}
