using BiddingPlatform.User;

namespace BiddingPlatform.Bid
{
    public interface IBidModel
    {
        DateTime BidDateTime { get; set; }
        int BidId { get; set; }
        float BidSum { get; set; }
        BasicUser BasicUser { get; set; }
    }
}