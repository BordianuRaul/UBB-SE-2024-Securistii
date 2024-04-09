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

        private string generateNickname()
        {
            Random rand = new Random();
            return "MaliciousUser" + rand.Next(100000, 1000000).ToString();
        }

        public void addBasicUser(int id, string username)
        {
            BasicUser toAdd = new BasicUser(id, username, generateNickname());
            this.UserRepository.addUserToRepo(toAdd);
        }

        public void addAdminUser(int id, string username)
        {
            AdminUser toAdd = new AdminUser(id, username);
            this.UserRepository.addUserToRepo(toAdd);
        }

        public void removeUser(int id, string username)
        {
            UserTemplate toremove = new UserTemplate(id, username);
            this.UserRepository.removeUserFromRepo(toremove);
        }

        public void updateUser(int id, string oldname, string newname)
        {
            UserTemplate olduser = new UserTemplate(id, oldname);
            UserTemplate newuser = new UserTemplate(id, newname);
            this.UserRepository.updateUserIntoRepo(olduser, newuser);
        }

        public List<UserTemplate> getListOfUsers()
        {
            return this.UserRepository.GetListOfUsers();
        }
    }
}
