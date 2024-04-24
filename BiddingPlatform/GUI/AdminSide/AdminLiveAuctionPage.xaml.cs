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

    public partial class AdminLiveAuctionPage : Page
    {
        public IAuctionService AuctionService;
        public IBidService BidService;
        public List<IAuctionModel> AuctionList;

        public AdminLiveAuctionPage(IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            this.AuctionService = auctionService;
            this.BidService = bidService;
            this.AuctionList = this.AuctionService.getAuctions();

            FirstNameTextbox.Text = AuctionList[0].Name;
            SecondNameTextbox.Text = AuctionList[1].Name;
            
            FirstDescriptionTextbox.Text = AuctionList[0].Description;
            SecondDescriptionTextbox.Text = AuctionList[1].Description;
            
            FirstPriceTextbox.Text = AuctionList[0].CurrentMaxBid.ToString();
            SecondPriceTextbox.Text = AuctionList[1].CurrentMaxBid.ToString();
            

            FirstDurationTextbox.Text = (DateTime.Now - AuctionList[0].StartingDate).Hours.ToString();
            SecondDurationTextbox.Text = (DateTime.Now - AuctionList[1].StartingDate).Hours.ToString();
            
        }

        private void HandleEnterAuctionButtonClick(object sender, RoutedEventArgs e)
        {
            var auctionDetailsPage = new AuctionDetailsPage(1, this.AuctionService, this.BidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void HandleAddAuctionButtonClick(object sender, RoutedEventArgs e)
        {
            var AddAuctionPage = new AddAuctionPage(this.AuctionService, this.BidService);
            NavigationService?.Navigate(AddAuctionPage);
        }
    }
}
