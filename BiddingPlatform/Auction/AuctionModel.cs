using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BiddingPlatform.Bid;
using BiddingPlatform.User;

namespace BiddingPlatform.Auction
{
    public class AuctionModel : IAuctionModel
    {
        public int AuctionId {  get; set; }
        public DateTime StartingDate { get; set; }
        public string Description {  get; set; }
        public string Name { get; set; }
        public float CurrentMaxSum {  get; set; }
        private List<BasicUser> ListOfUsers { get; set; }
        public List<IBidModel> ListOfBids { get; set; }

        public AuctionModel(int _id, DateTime startingDate, string description, string name, float currentMaxSum, List<BasicUser> listOfUsers, List<IBidModel> listOfBids)
        {
            this.AuctionId = _id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxSum = currentMaxSum;
            this.ListOfUsers = listOfUsers;
            this.ListOfBids = listOfBids;
        }

        public AuctionModel(int _id, DateTime startingDate, string description, string name, float currentMaxSum)
        {
            this.AuctionId = _id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxSum = currentMaxSum;
            this.ListOfUsers = new List<BasicUser>();
            this.ListOfBids = new List<IBidModel>();
        }

        public void addUserToAuction(BasicUser user)
        {
            this.ListOfUsers.Add(user);
        }

        public void addBidToAuction(IBidModel bid)
        {
            this.ListOfBids.Add(bid);
        }
    }
}
