using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserService
    {
        private UserRepository UserRepository { get; set; }

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository; 
        }

        public void addUser(UserTemplate User)
        {
            this.UserRepository.addUserToRepo(User);
        }

        public void removeUser(UserTemplate User)
        {
            this.UserRepository.removeUserFromRepo(User);
        }

        public void updateUser(UserTemplate olduser, UserTemplate newuser) 
        {
            this.UserRepository.updateUserIntoRepo(olduser, newuser);
        }

        public List<UserTemplate> getListOfUsers()
        {
            return this.UserRepository.GetListOfUsers();
        }
    }
}
