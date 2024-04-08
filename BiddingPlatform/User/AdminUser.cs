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
        public AdminUser(string _username) : base(_username)
        {
            this.username = _username;
        }
    }
}
