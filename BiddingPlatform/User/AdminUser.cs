using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class AdminUser : UserTemplate
    {
        private string Username { get; set; }
        private int UserID { get; set; }
        public AdminUser(int giveUserID, string givenUsername) : base(giveUserID, givenUsername)
        {
            this.Username = givenUsername;
            this.UserID = giveUserID;
        }
    }
}
