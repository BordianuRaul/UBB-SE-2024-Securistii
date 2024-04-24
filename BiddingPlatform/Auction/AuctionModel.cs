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
        public List<BasicUser> UserList { get; set; }
        public List<IBidModel> BidList { get; set; }

        public AuctionModel(int id, DateTime startingDate, string description, string name, float currentMaxBid, List<BasicUser> userList, List<IBidModel> bidList)
        {
            this.AuctionId = id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxBid = currentMaxBid;
            this.UserList = userList;
            this.BidList = bidList;
        }

        public AuctionModel(int _id, DateTime startingDate, string description, string name, float currentMaxBid)
        {
            this.AuctionId = _id;
            this.StartingDate = startingDate;
            this.Description = description;
            this.Name = name;
            this.CurrentMaxBid = currentMaxBid;
            this.UserList = new List<BasicUser>();
            this.BidList = new List<IBidModel>();
        }

        public void AddUserToAuction(BasicUser user)
        {
            this.UserList.Add(user);
        }

        public void AddBidToAuction(IBidModel bid)
        {
            this.BidList.Add(bid);
        }
    }
}
