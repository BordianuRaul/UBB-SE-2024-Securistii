using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserService
    {
        void addBasicUser(int id, string username);
        void addAdminUser(int id, string username);
        void removeUser(int id, string username);
        void updateUser(int id, string oldname, string newname);
        List<IUserTemplate> getListOfUsers();
    }
}
