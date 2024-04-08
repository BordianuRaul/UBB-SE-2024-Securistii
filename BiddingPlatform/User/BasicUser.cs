using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class BasicUser : UserTemplate
    {
        private int Userid { get; set; }
        private string username { get; set; }
        private string nickname { get; set; }

        public BasicUser(int _id, string _username, string _nickname) : base(_id, _username)
        {
            this.username = _username;
            this.nickname = _nickname;
            this.Userid = _id;
        }

        public string getNickname() {  return nickname; }
        public void setNickname(string _nickname) {  nickname = _nickname; }
    }
}
