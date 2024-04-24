using BiddingPlatform.Bid;
using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public interface IAuctionRepository
    {
        List<IAuctionModel> listOfAuctions { get; set; }
        void AddAuctionToRepo(IAuctionModel auction);
        void AddToDB(string name, string description, DateTime date, float currentMaxSum);
        void RemoveAuctionFromRepo(IAuctionModel auction);
        void UpdateAuctionIntoRepo(IAuctionModel oldauction, IAuctionModel newauction);
        float GetBidMaxSum(int index);

    }
}
