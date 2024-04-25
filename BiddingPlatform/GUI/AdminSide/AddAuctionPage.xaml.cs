using System.Windows;
using System.Windows.Controls;
using BiddingPlatform.Bid;
using BiddingPlatform.Auction;

namespace BiddingPlatform.GUI.AdminSide
{
    /// <summary>
    /// Interaction logic for AddAuctionPage.xaml
    /// </summary>
    public partial class AddAuctionPage : Page
    {
        public IAuctionService AuctionService;
        public IBidService BidService;
        public List<IAuctionModel> AuctionList;
        public AddAuctionPage(IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            this.BidService = bidService;
            this.AuctionService = auctionService;
            this.AuctionList = this.AuctionService.GetAuctions();
        }

        private void NavigateBackToAdminLiveAuctionPage(object sender, RoutedEventArgs e)
        {
            var adminLiveAuctionPage = new AdminLiveAuctionPage(this.AuctionService, this.BidService);
            NavigationService?.Navigate(adminLiveAuctionPage);
        }

        private void HandleAddAuctionButtonClick(object sender, RoutedEventArgs e)
        {
            string auctionName = NameTextbox.Text;
            string auctionDescription = DescriptionTextbox.Text;
            string auctionDeadlineDateString = DeadlineTextbox.Text;
            if (DateTime.TryParseExact(auctionDeadlineDateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime auctionDeadlineDate))
            {
                Console.WriteLine("Parsed date: " + auctionDeadlineDate);
            }
            else
            {
                Console.WriteLine("Unable to parse the date string.");
            }

            if (!int.TryParse(StartingPriceTextbox.Text, out int auctionStartingBid))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
            this.AuctionService.AddBid(auctionName, auctionDescription, auctionDeadlineDate, auctionStartingBid);
        }
    }
}
