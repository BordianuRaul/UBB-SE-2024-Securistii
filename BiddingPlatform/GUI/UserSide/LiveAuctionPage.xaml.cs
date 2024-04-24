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
        public List<IAuctionModel> auctions;

        public LiveAuctionPage(IAuctionService auctionService, IBidService bidService)
        {
            InitializeComponent();
            this.AuctionService= auctionService;
            this.BidService = bidService;
            auctions = this.AuctionService.GetAuctions();
            
            name1.Text= auctions[0].name;
            name2.Text = auctions[1].name;
            //name3.Text= auctions[2].name;
            description1.Text = auctions[0].description;
            description2.Text = auctions[1].description;
            //description3.Text = auctions[2].description;
            price1.Text = auctions[0].currentMaxSum.ToString();
            price2.Text = auctions[1].currentMaxSum.ToString();
            //price3.Text = auctions[2].currentMaxSum.ToString();
            
            time1.Text= (DateTime.Now - auctions[0].startingDate).Hours.ToString();
            time2.Text = (DateTime.Now - auctions[1].startingDate).Hours.ToString();
            //time3.Text = (DateTime.Now - auctions[2].startingDate).Hours.ToString();
        }


        private void NavigateToDetailsPage(int index)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(index, AuctionService, BidService);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            //int index = Convert.ToInt32(button.Tag); 
            this.NavigateToDetailsPage(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigateToDetailsPage(1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.NavigateToDetailsPage(2);
        }
    }
}
