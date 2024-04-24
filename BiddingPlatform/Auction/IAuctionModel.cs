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
        public List<IBidModel> BidList { get; set; }
        public List<BasicUser> UserList { get; set; }
        public int AuctionId { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public float CurrentMaxBid { get; set; }

        public void AddUserToAuction(BasicUser user);
        public void AddBidToAuction(IBidModel bid);
    }
}
