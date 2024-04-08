using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserTemplate
    {
        private string username { get; set; }

        public UserTemplate(string _username)
        {
            this.username = _username;
        }

        public string getUsername() {  return username; }

        public void setUsername(string _username) {  username = _username; }
    }
}
