using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for EnterAuctionPage.xaml
    /// </summary>
    public partial class EnterAuctionPage : Page
    {
        public int auctionIndex;
        public AuctionService AuctionService;
        public BidService BidService;
        public List<BidModel> bidModels;
        public List<AuctionModel> auctions;
        public EnterAuctionPage(int index, AuctionService auctionService, BidService bidService)
        {
            InitializeComponent();
            auctionIndex = index;
            this.AuctionService = auctionService;
            this.BidService = bidService;
            List<AuctionModel> auctions = this.AuctionService.getAuctions();

            AuctionNameBid.Text = auctions[index].name;
            CurrentBid.Text = auctions[index].currentMaxSum.ToString();
            TimeLeft.Text = (DateTime.Now - auctions[index].startingDate).Hours.ToString();


            int n = auctions[index].listOfBids.Count;
            for (int i = 0; i < n; i++)
            {
                BidHistory.Text += auctions[index].listOfBids[i].bidSum.ToString() + "\n";
            }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(auctionIndex, this.AuctionService, this.BidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int suminput = 0;
            if (!int.TryParse(SumInput.Text, out suminput))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
            suminput = Convert.ToInt32(SumInput.Text);
            if (suminput <= this.AuctionService.getMaxBidSum(auctionIndex))
            {
                MessageBox.Show("Invalid bid sum!\n The bid must be greater than that current maximum one.");
            }
            suminput = Convert.ToInt32(SumInput.Text);
            BidHistory.Text += suminput.ToString() + "\n";

        }
    }
}
