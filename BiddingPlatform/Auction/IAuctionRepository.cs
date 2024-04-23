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
        void addAuctionToRepo(IAuctionModel auction);
        void addToDB(string name, string description, DateTime date, float currentMaxSum);
        void removeAuctionFromRepo(IAuctionModel auction);
        void updateAuctionIntoRepo(IAuctionModel oldauction, IAuctionModel newauction);
        float getBidMaxSum(int index);

    }
}
