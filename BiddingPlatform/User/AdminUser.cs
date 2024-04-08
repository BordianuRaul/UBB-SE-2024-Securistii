using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class AdminUser : UserTemplate
    {
        private string username { get; set; }
        private int Userid { get; set; }
        public AdminUser(int _id, string _username) : base(_id, _username)
        {
            this.username = _username;
            this.Userid = _id;
        }
    }
}
