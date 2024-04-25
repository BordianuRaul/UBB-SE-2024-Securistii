using System.Windows;
using System.Windows.Controls;
using BiddingPlatform.Auction;
using BiddingPlatform.Bid;

namespace BiddingPlatform.GUI
{
    /// <summary>
    /// Interaction logic for EnterAuctionPage.xaml
    /// </summary>
    public partial class EnterAuctionPage : Page
    {
        public int AuctionIndex;
        public IAuctionService AuctionService;
        public IBidService BidService;
        public List<IBidModel> BidModels;
        public List<IAuctionModel> Auctions;
        public EnterAuctionPage(int index, IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            AuctionIndex = index;
            this.AuctionService = auctionService;
            this.BidService = bidService;
            Auctions = this.AuctionService.GetAuctions();

            AuctionNameBid.Text = Auctions[index].Name;
            CurrentBid.Text = Auctions[index].CurrentMaxBid.ToString();
            TimeLeft.Text = (DateTime.Now - Auctions[index].StartingDate).Hours.ToString();
            int n = Auctions[index].ListOfBids.Count;
            for (int i = 0; i < n; i++)
            {
                BidHistory.Text += Auctions[index].ListOfBids[i].BidSum.ToString() + "\n";
            }
        }
        private void Back_Button_Clicked(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(AuctionIndex, this.AuctionService, this.BidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void Bid_Button_Clicked(object sender, RoutedEventArgs e)
        {
            int suminput = 0;
            if (!int.TryParse(SumInput.Text, out suminput))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
            suminput = Convert.ToInt32(SumInput.Text);
            if (suminput <= this.AuctionService.GetMaxBidSum(AuctionIndex))
            {
                MessageBox.Show("Invalid bid sum!\n The bid must be greater than that current maximum one.");
            }
            suminput = Convert.ToInt32(SumInput.Text);
            BidHistory.Text += suminput.ToString() + "\n";
        }
    }
}
