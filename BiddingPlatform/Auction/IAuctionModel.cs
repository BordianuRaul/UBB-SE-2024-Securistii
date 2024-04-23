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
        public List<IBidModel> listOfBids { get; set; }
        public int auctionId { get; set; }
        public DateTime startingDate { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public float currentMaxSum { get; set; }

        public void addUserToAuction(BasicUser user);
        public void addBidToAuction(IBidModel bid);
    }
}
