using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserService : IUserService
    {
        private UserRepository UserRepository { get; set; }

        public UserService(UserRepository userRepository)
        {
            UserRepository = userRepository; 
        }

        private string generateNickname()
        {
            const int RANDOM_RANGE_MINIMUM_VALUE = 100000;
            const int RANDOM_RANGE_MAXIMUM_VALUE = 1000000;
            Random rand = new Random();
            string randomId = rand.Next(RANDOM_RANGE_MINIMUM_VALUE, RANDOM_RANGE_MAXIMUM_VALUE).ToString();
            return "MaliciousUser" + randomId;
        }

        public void addBasicUser(int id, string username)
        {
            IUserTemplate toAdd = new BasicUser(id, username, generateNickname());
            this.UserRepository.addUserToRepo(toAdd);
        }

        public void addAdminUser(int id, string username)
        {
            IUserTemplate toAdd = new AdminUser(id, username);
            this.UserRepository.addUserToRepo(toAdd);
        }

        public void removeUser(int id, string username)
        {
            IUserTemplate toremove = new UserTemplate(id, username);
            this.UserRepository.removeUserFromRepo(toremove);
        }

        public void updateUser(int id, string oldname, string newname)
        {
            IUserTemplate olduser = new UserTemplate(id, oldname);
            IUserTemplate newuser = new UserTemplate(id, newname);
            this.UserRepository.updateUserIntoRepo(olduser, newuser);
        }

        public List<IUserTemplate> getListOfUsers()
        {
            return this.UserRepository.GetListOfUsers();
        }
    }
}
