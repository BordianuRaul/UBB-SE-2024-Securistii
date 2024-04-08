using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Bid
{
    public class BidService
    {
        public BidRepository BidRepository { get; set; }

        public BidService(BidRepository bidRepository)
        {
            BidRepository = bidRepository;
        }

        public void addBid(BidModel bid)
        {
            this.BidRepository.addBidToRepo(bid);
        }

        public void removeBid(BidModel bid)
        {
            this.BidRepository.deleteBidFromRepo(bid);
        }

        public void updateBid(BidModel oldbid, BidModel newbid)
        {
            this.BidRepository.updateBidIntoRepo(oldbid, newbid);
        }

        public List<BidModel> getBids() 
        { 
            return this.BidRepository.getBids();
        }
    }
}
