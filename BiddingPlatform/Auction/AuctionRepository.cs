using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public class AuctionRepository
    {
        public List<AuctionModel> listOfAuctions {  get; set; }
        public AuctionRepository() 
        {
            this.listOfAuctions = new List<AuctionModel>();
        }

        public AuctionRepository(List<AuctionModel> listOfAuctions)
        {
            this.listOfAuctions = listOfAuctions;
        }

        public void addAuctionToRepo(AuctionModel auction)
        {
            listOfAuctions.Add(auction);
        }

        public void removeAuctionFromRepo(AuctionModel auction)
        {
            listOfAuctions.Remove(auction);
        }

        public void updateAuctionIntoRepo(AuctionModel oldauction, AuctionModel newauction)
        {
            int oldauctionIndex = this.listOfAuctions.FindIndex(auction => auction == oldauction);
            if (oldauctionIndex != -1)
            {
                this.listOfAuctions[oldauctionIndex] = newauction;
            }
        }
    }
}
