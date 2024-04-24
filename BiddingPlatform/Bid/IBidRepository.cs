
namespace BiddingPlatform.Bid
{
    public interface IBidRepository
    {
        List<IBidModel> Bids { get; set; }

        void addBidToRepo(IBidModel bid);
        void deleteBidFromRepo(IBidModel bid);
        List<IBidModel> getBids();
        void updateBidIntoRepo(IBidModel oldbid, IBidModel newbid);
    }
}