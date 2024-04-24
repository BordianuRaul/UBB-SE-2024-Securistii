using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserRepository
    {
        void addUserToRepo(IUserTemplate User);
        void removeUserFromRepo(IUserTemplate User);
        void updateUserIntoRepo(IUserTemplate olduser, IUserTemplate newuser);
        List<IUserTemplate> GetListOfUsers();
    }
}
