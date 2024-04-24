using BiddingPlatform.Bid;
using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public interface IAuctionModel
    {
        public List<IBidModel> ListOfBids { get; set; }
        public int AuctionId { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public float CurrentMaxSum { get; set; }

        public void addUserToAuction(BasicUser user);
        public void addBidToAuction(IBidModel bid);
    }
}
