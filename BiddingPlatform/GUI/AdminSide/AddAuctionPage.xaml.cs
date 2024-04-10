using BiddingPlatform.Auction;
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

namespace BiddingPlatform.GUI.AdminSide
{
    /// <summary>
    /// Interaction logic for AddAuctionPage.xaml
    /// </summary>
    public partial class AddAuctionPage : Page
    {
        public AuctionRepository auctionrepository;
        public AuctionService AuctionService;
        public List<AuctionModel> auctions;
        public AddAuctionPage()
        {
            InitializeComponent();
            this.auctionrepository = new AuctionRepository();
            this.AuctionService = new AuctionService(auctionrepository);
            List<AuctionModel> auctions = this.AuctionService.getAuctions();


        }

        private void CancelAddAuction(object sender, RoutedEventArgs e)
        {
            AdminLiveAuctionPage AdminLiveAuctionPage = new AdminLiveAuctionPage();
            NavigationService?.Navigate(AdminLiveAuctionPage);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            String name = AddName.Text;
            string description = AddDescription.Text;
            string dateString = AddDeadline.Text;
       

            DateTime deadlineDate;
            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out deadlineDate))
            {
                Console.WriteLine("Parsed date: " + deadlineDate);
            }
            else
            {
                Console.WriteLine("Unable to parse the date string.");
            }
            //String date = AddDeadline.Text;
            int suminput = 0;
            if (!int.TryParse(AddStartingPrice.Text, out suminput))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }
            this.AuctionService.addBid(name, description, deadlineDate, suminput);
        }
    }
}
