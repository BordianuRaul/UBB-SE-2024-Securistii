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
using System.Xml.Linq;
using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
using BiddingPlatform.User;


namespace BiddingPlatform.GUI.AdminSide
{
    /// <summary>
    /// Interaction logic for AdminLiveAuctionPage.xaml
    /// </summary>
    public partial class AdminLiveAuctionPage : Page
    {
        public IAuctionService AuctionService;
        public IBidService bidService;
        public List<IAuctionModel> auctions;

        public AdminLiveAuctionPage(IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            this.AuctionService = auctionService;
            this.bidService = bidService;
            auctions = this.AuctionService.getAuctions();

            name1.Text = auctions[0].name;
            name2.Text = auctions[1].name;
            //name3.Text = auctions[3].name;
            description1.Text = auctions[0].description;
            description2.Text = auctions[1].description;
            //description3.Text = auctions[2].description;
            price1.Text = auctions[0].currentMaxSum.ToString();
            price2.Text = auctions[1].currentMaxSum.ToString();
            //price3.Text = auctions[2].currentMaxSum.ToString();

            time1.Text = (DateTime.Now - auctions[0].startingDate).Hours.ToString();
            time2.Text = (DateTime.Now - auctions[1].startingDate).Hours.ToString();
            //time3.Text = (DateTime.Now - auctions[2].startingDate).Hours.ToString();
        }

        private void EnterAuction(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(1, this.AuctionService, this.bidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void AddAuction(object sender, RoutedEventArgs e)
        {
            AddAuctionPage AddAuctionPage = new AddAuctionPage(this.AuctionService);
            NavigationService?.Navigate(AddAuctionPage);
        }
    }
}
