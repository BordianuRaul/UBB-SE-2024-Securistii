using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public class AuctionService
    {
        public AuctionRepository AuctionRepository { get; set; }

        public AuctionService(AuctionRepository auctionRepository) 
        {
            this.AuctionRepository = auctionRepository;
        }

        public void addAuction(AuctionModel auction)
        {
            this.AuctionRepository.addAuctionToRepo(auction);
        }

        public void removeAuction(AuctionModel auction)
        {
            this.AuctionRepository.removeAuctionFromRepo(auction);
        }

        public List<AuctionModel> getAuctions()
        {
            return this.AuctionRepository.listOfAuctions;
        }

        public void updateAuction(AuctionModel oldauction, AuctionModel newauction)
        {
            this.AuctionRepository.updateAuctionIntoRepo(oldauction, newauction);
        }
    }
}
