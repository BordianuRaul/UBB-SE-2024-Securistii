using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Bid
{
    public class BidModel : IBidModel
    {
        public int bidId { get; set; }
        public BasicUser user { get; set; }
        public float bidSum { get; set; }
        public DateTime bidDate { get; set; }

        public BidModel(int _id, BasicUser _user, float _bidSum, DateTime _bidDate)
        {
            this.bidId = _id;
            this.user = _user;
            this.bidSum = _bidSum;
            this.bidDate = _bidDate;
        }
    }
}
