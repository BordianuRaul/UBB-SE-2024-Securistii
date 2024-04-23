using BiddingPlatform.User;

namespace BiddingPlatform.Bid
{
    public interface IBidService
    {
        IBidRepository BidRepository { get; set; }

        void addBid(int id, BasicUser user, float bidSum, DateTime biddate);
        List<IBidModel> getBids();
        void removeBid(int id, BasicUser user, float bidSum, DateTime biddate);
        void updateBid(int id, BasicUser olduser, float oldbidSum, DateTime oldbiddate, BasicUser newuser, float newbidSum, DateTime newbiddate);
    }
}