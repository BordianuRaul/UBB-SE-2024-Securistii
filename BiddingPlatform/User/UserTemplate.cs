using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserTemplate : IUserTemplate
    {
        private int UserId { get; set; }
        private string Username { get; set; }

        public UserTemplate(int id, string username)
        {
            this.UserId = id;
            this.Username = username;
        }

        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string username)
        {
            Username = username;
        }
        public int GetId()
        {
            return UserId;
        }
        public void SetId(int id)
        {
            UserId = id;
        }
    }
}
