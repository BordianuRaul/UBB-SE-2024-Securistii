using BiddingPlatform.User;

namespace BiddingPlatform.Bid
{
    public class BidService : IBidService
    {
        public IBidRepository BidRepository { get; set; }
        public BidService(IBidRepository bidRepository)
        {
            BidRepository = bidRepository;
        }

        public void AddBid(int id, BasicUser user, float bidSum, DateTime biddate)
        {
            IBidModel toadd = new BidModel(id, user, bidSum, biddate);

            this.BidRepository.AddBidToRepo(toadd);
        }

        public void RemoveBid(int id, BasicUser user, float bidSum, DateTime biddate)
        {
            IBidModel toremove = new BidModel(id, user, bidSum, biddate);
            this.BidRepository.DeleteBidFromRepo(toremove);
        }

        public void UpdateBid(int id, BasicUser olduser, float oldbidSum, DateTime oldbiddate, BasicUser newuser, float newbidSum, DateTime newbiddate)
        {
            IBidModel oldbid = new BidModel(id, olduser, oldbidSum, oldbiddate);
            IBidModel newbid = new BidModel(id, newuser, newbidSum, newbiddate);
            this.BidRepository.UpdateBidIntoRepo(oldbid, newbid);
        }

        public List<IBidModel> GetBids()
        {
            return this.BidRepository.GetBids();
        }
    }
}
