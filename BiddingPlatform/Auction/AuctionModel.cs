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
        public float CurrentMaxBid {  get; set; }
        private List<BasicUser> ListOfUsers { get; set; }
        public List<IBidModel> ListOfBids { get; set; }

        public AuctionModel(int id, DateTime startingDate, string description, string name, float currentMaxBid, List<BasicUser> userList, List<IBidModel> bidList)
        {
            this.AuctionId = id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxBid = currentMaxBid;
            this.ListOfUsers = listOfUsers;
            this.ListOfBids = listOfBids;

        }

        public AuctionModel(int _id, DateTime startingDate, string description, string name, float currentMaxBid)
        {
            this.AuctionId = _id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxBid = currentMaxBid;
            this.ListOfUsers = new List<BasicUser>();
            this.ListOfBids = new List<IBidModel>();
        }

        public void AddUserToAuction(BasicUser user)
        {
            this.ListOfUsers.Add(user);
        }

        public void AddBidToAuction(IBidModel bid)
        {
            this.ListOfBids.Add(bid);
        }
    }
}
