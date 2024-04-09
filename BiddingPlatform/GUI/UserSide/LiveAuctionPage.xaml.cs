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
        
        public AuctionRepository auctionrepository;
        public AuctionService AuctionService;
        public List<AuctionModel> auctions;

        public LiveAuctionPage()
        {
            InitializeComponent();
            this.auctionrepository = new AuctionRepository();
            this.AuctionService = new AuctionService(auctionrepository);
            List<AuctionModel> auctions = this.AuctionService.getAuctions();
            
            name1.Text= auctions[0].name;
            name2.Text = auctions[1].name;
            name3.Text= auctions[2].name;
            description1.Text = auctions[0].description;
            description2.Text = auctions[1].description;
            description3.Text = auctions[2].description;
            price1.Text = auctions[0].currentMaxSum.ToString();
            price2.Text = auctions[1].currentMaxSum.ToString();
            price3.Text = auctions[2].currentMaxSum.ToString();
            
            time1.Text= (DateTime.Now - auctions[0].startingDate).Hours.ToString();
            time2.Text = (DateTime.Now - auctions[1].startingDate).Hours.ToString();
            time3.Text = (DateTime.Now - auctions[2].startingDate).Hours.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button button = sender as Button;
            //int index = Convert.ToInt32(button.Tag); 
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(0);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(1);
            NavigationService?.Navigate(auctionDetailsPage);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AuctionDetailsPage auctionDetailsPage = new AuctionDetailsPage(2);
            NavigationService?.Navigate(auctionDetailsPage);
        }
    }
}
