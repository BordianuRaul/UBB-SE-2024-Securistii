using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BiddingPlatform.Auction
{
    public class AuctionService
    {
        public AuctionRepository AuctionRepository { get; set; }

        public AuctionService(AuctionRepository auctionRepository) 
        {
            this.AuctionRepository = auctionRepository;
        }

        public void addAuction(int id, DateTime startingDate, string description, string name, float currentMaxSum)
        {
            AuctionModel auction = new AuctionModel(id, startingDate, description, name, currentMaxSum);
            this.AuctionRepository.addAuctionToRepo(auction);
        }

        public void removeAuction(int id, DateTime startingDate, string description, string name, float currentMaxSum)
        {
            AuctionModel auction = new AuctionModel(id, startingDate, description, name, currentMaxSum);
            this.AuctionRepository.removeAuctionFromRepo(auction);
        }

        public List<AuctionModel> getAuctions()
        {
            return this.AuctionRepository.listOfAuctions;
        }

        public void updateAuction(int id, DateTime oldstartingDate, string olddescription, string oldname, float oldcurrentMaxSum, DateTime newstartingDate, string newdescription, string newname, float newcurrentMaxSum)
        {
            AuctionModel oldauction = new AuctionModel(id, oldstartingDate, olddescription, oldname, oldcurrentMaxSum);
            AuctionModel newauction = new AuctionModel(id, newstartingDate, newdescription, newname, newcurrentMaxSum);
            this.AuctionRepository.updateAuctionIntoRepo(oldauction, newauction);
        }
    }
}
