using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
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

namespace BiddingPlatform.GUI
{
    /// <summary>
    /// Interaction logic for EnterAuctionPage.xaml
    /// </summary>
    public partial class EnterAuctionPage : Page
    {
        public AuctionRepository auctionrepository;
        public AuctionService AuctionService;
        public BidRepository BidRepository;
        public BidService BidService;
        public List<BidModel> bidModels;
        public EnterAuctionPage()
        {
            InitializeComponent();
            this.auctionrepository = new AuctionRepository();
            this.BidRepository = new BidRepository();
            this.BidService = new BidService(BidRepository);
            this.AuctionService = new AuctionService(auctionrepository);
            List<BidModel> bidModels = this.BidService.getBids();

            BidHisotryBox.Text = bidModels[0].bidSum.ToString();

        }
    }
}
