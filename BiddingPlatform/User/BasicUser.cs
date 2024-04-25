using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class BasicUser : UserTemplate
    {
        private int UserID { get; set; }
        private string Username { get; set; }
        private string Nickname { get; set; }

        public BasicUser(int givenUserID, string giveUserUsername, string giveUserNickname) : base(givenUserID, giveUserUsername)
        {
            this.Username = giveUserUsername;
            this.Nickname = giveUserNickname;
            this.UserID = givenUserID;
        }

        public string GetNickname()
        {
            return Nickname;
        }
        public void SetNickname(string nicknameToBeSet)
        {
            Nickname = nicknameToBeSet;
        }
    }
}
