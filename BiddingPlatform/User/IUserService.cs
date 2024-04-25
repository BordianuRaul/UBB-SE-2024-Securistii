using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserService
    {
        void AddBasicUser(int id, string username);
        void AddAdminUser(int id, string username);
        void RemoveUser(int id, string username);
        void UpdateUser(int id, string oldname, string newname);
        List<IUserTemplate> GetListOfUsers();
    }
}
