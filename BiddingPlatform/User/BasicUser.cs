using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class BasicUser : UserTemplate
    {
        private string username { get; set; }
        private string nickname { get; set; }

        public BasicUser(string _username) : base(_username)
        {
            this.username = _username;
            this.nickname = generateNickname();
        }

        private string generateNickname()
        {
            Random rand = new Random();
            return "MaliciousUser" + rand.Next(100000, 1000000).ToString();
        }

        public string getNickname() {  return nickname; }
    }
}
