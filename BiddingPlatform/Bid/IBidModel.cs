using BiddingPlatform.User;

namespace BiddingPlatform.Bid
{
    public interface IBidModel
    {
        DateTime bidDate { get; set; }
        int bidId { get; set; }
        float bidSum { get; set; }
        BasicUser user { get; set; }
    }
}