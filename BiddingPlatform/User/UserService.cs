using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserService : IUserService
    {
        private IUserRepository UserRepository { get; set; }

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        private string GenerateNickname()
        {
            const int RANDOM_RANGE_MINIMUM_VALUE = 100000;
            const int RANDOM_RANGE_MAXIMUM_VALUE = 1000000;
            Random rand = new Random();
            string randomId = rand.Next(RANDOM_RANGE_MINIMUM_VALUE, RANDOM_RANGE_MAXIMUM_VALUE).ToString();
            return "MaliciousUser" + randomId;
        }

        public void AddBasicUser(int id, string username)
        {
            IUserTemplate toAdd = new BasicUser(id, username, GenerateNickname());
            this.UserRepository.AddUserToRepo(toAdd);
        }

        public void AddAdminUser(int id, string username)
        {
            IUserTemplate toAdd = new AdminUser(id, username);
            this.UserRepository.AddUserToRepo(toAdd);
        }

        public void RemoveUser(int id, string username)
        {
            IUserTemplate toremove = new UserTemplate(id, username);
            this.UserRepository.RemoveUserFromRepo(toremove);
        }

        public void UpdateUser(int id, string oldname, string newname)
        {
            IUserTemplate olduser = new UserTemplate(id, oldname);
            IUserTemplate newuser = new UserTemplate(id, newname);
            this.UserRepository.UpdateUserIntoRepo(olduser, newuser);
        }

        public List<IUserTemplate> GetListOfUsers()
        {
            return this.UserRepository.GetListOfUsers();
        }
    }
}
