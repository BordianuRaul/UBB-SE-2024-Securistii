using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserTemplate
    {
        string GetUsername();
        void SetUsername(string username);
        int GetId();
        void SetId(int id);
    }
}
