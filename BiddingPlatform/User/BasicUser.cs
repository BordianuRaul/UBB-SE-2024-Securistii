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
        private string username { get; set; }
        private string nickname { get; set; }

        public BasicUser(int givenUserID, string giveUserUsername, string giveUserNickname) : base(givenUserID, giveUserUsername)
        {
            this.username = giveUserUsername;
            this.nickname = giveUserNickname;
            this.UserID = givenUserID;
        }

        public string GetNickname() {  return nickname; }
        public void SetNickname(string nicknameToBeSet) {  nickname = nicknameToBeSet; }
    }
}
