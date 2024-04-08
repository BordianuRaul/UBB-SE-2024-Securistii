using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiddingPlatform.Bid;
using BiddingPlatform.User;

namespace BiddingPlatform.Auction
{
    public class AuctionModel
    {
        public DateTime startingDate { get; set; }
        public string description {  get; set; }
        public string name { get; set; }
        public float currentMaxSum {  get; set; }
        public List<UserTemplate> listOfUsers { get; set; }
        public List<BidModel> listOfBids { get; set; }

        public AuctionModel(DateTime startingDate, string description, string name, float currentMaxSum, List<UserTemplate> listOfUsers, List<BidModel> listOfBids)
        {
            this.startingDate = startingDate;
            this.description = description;
            this.name = name;
            this.currentMaxSum = currentMaxSum;
            this.listOfUsers = listOfUsers;
            this.listOfBids = listOfBids;
        }

        public AuctionModel(DateTime startingDate, string description, string name, float currentMaxSum)
        {
            this.startingDate = startingDate;
            this.description = description;
            this.name = name;
            this.currentMaxSum = currentMaxSum;
            this.listOfUsers = new List<UserTemplate>();
            this.listOfBids = new List<BidModel>();
        }

        public void addUserToAuction(UserTemplate user)
        {
            this.listOfUsers.Add(user);
        }

        public void addBidToAuction(BidModel bid)
        {
            this.listOfBids.Add(bid);
        }
    }
}
