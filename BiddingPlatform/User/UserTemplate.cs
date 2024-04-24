using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserTemplate : IUserTemplate
    {
        private int Userid { get; set; }
        private string username { get; set; }

        public UserTemplate(int _id, string _username)
        {
            this.Userid = _id;
            this.username = _username;
        }

        public string getUsername() { return username; }

        public void setUsername(string _username) { username = _username; }
        public int getId() { return Userid; }
        public void setId(int _id)
        {
            Userid = _id;
        }
    }
}