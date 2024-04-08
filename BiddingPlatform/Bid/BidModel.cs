using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Bid
{
    public class BidModel
    {
        public UserTemplate user { get; set; }
        public float bidSum { get; set; }
        public DateTime bidDate { get; set; }

        public BidModel(UserTemplate user, float bidSum, DateTime bidDate)
        {
            this.user = user;
            this.bidSum = bidSum;
            this.bidDate = bidDate;
        }
    }
}
