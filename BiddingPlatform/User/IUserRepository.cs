using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserRepository
    {
        void AddUserToRepo(IUserTemplate user);
        void RemoveUserFromRepo(IUserTemplate user);
        void UpdateUserIntoRepo(IUserTemplate olduser, IUserTemplate newuser);
        List<IUserTemplate> GetListOfUsers();
    }
}
