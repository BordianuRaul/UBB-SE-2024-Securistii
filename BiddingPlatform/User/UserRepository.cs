using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserRepository
    {
        private List<UserTemplate> listOfUsers { get; set; }
        public UserRepository() { 
            this.listOfUsers = new List<UserTemplate>();
        }

        public UserRepository(List<UserTemplate> _listOfUsers)
        {
            this.listOfUsers = _listOfUsers;
        }

        public void addUserToRepo(UserTemplate User) 
        {
            this.listOfUsers.Add(User);
        }

        public void removeUserFromRepo(UserTemplate User)
        {
            this.listOfUsers.Remove(User);
        }

        public void updateUserIntoRepo(UserTemplate olduser, UserTemplate newuser)
        {
            int olduserIndex = this.listOfUsers.FindIndex(user => user == olduser);
            if (olduserIndex != -1)
            {
                this.listOfUsers[olduserIndex] = newuser;
            }
        }
        public List<UserTemplate> GetListOfUsers()
        {
            return this.listOfUsers;
        }
    }
}
