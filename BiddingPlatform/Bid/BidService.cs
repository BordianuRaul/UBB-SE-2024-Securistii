using BiddingPlatform.User;
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

        public void addBid(int id, BasicUser user, float bidSum, DateTime  biddate)
        {
            BidModel toadd = new BidModel(id, user, bidSum, biddate);
            this.BidRepository.addBidToRepo(toadd);
        }

        public void removeBid(int id, BasicUser user, float bidSum, DateTime biddate)
        {
            BidModel toremove = new BidModel(id, user, bidSum, biddate);
            this.BidRepository.deleteBidFromRepo(toremove);
        }

        public void updateBid(int id, BasicUser olduser, float oldbidSum, DateTime oldbiddate, BasicUser newuser, float newbidSum, DateTime newbiddate)
        {
            BidModel oldbid = new BidModel(id, olduser, oldbidSum, oldbiddate);
            BidModel newbid = new BidModel(id, newuser, newbidSum, newbiddate);
            this.BidRepository.updateBidIntoRepo(oldbid, newbid);
        }

        public List<BidModel> getBids() 
        { 
            return this.BidRepository.getBids();
        }
    }
}
