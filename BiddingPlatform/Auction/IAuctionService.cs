using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public interface IAuctionService
    {
        void addAuction(int id, DateTime startingDate, string description, string name, float currentMaxSum);
        void removeAuction(int id, DateTime startingDate, string description, string name, float currentMaxSum);
        List<IAuctionModel> getAuctions();
        void updateAuction(int id, DateTime oldstartingDate, string olddescription, string oldname, float oldcurrentMaxSum, DateTime newstartingDate, string newdescription, string newname, float newcurrentMaxSum);
        float getMaxBidSum(int index);
        void addBid(string name, string description, DateTime date, float currentMaxSum);
    }
}
