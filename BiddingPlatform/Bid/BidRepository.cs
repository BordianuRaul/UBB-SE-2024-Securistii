using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Bid
{
    public class BidRepository
    {
        public List<BidModel> Bids { get; set; }

        public BidRepository() 
        {
            this.Bids = new List<BidModel>();
        }

        public BidRepository(List<BidModel> bids)
        {
            Bids = bids;
        }

        public void addBidToRepo(BidModel bid)
        {
            this.Bids.Add(bid);
        }

        public List<BidModel> getBids()
        {
            return this.Bids;
        }

        public void deleteBidFromRepo(BidModel bid) 
        {
            this.Bids.Remove(bid);
        }

        public void updateBidIntoRepo(BidModel oldbid, BidModel newbid)
        {
            int oldbidIndex = this.Bids.FindIndex(bid => bid == oldbid);
            if (oldbidIndex != -1)
            {
                this.Bids[oldbidIndex] = newbid;
            }
        }
    }
}
