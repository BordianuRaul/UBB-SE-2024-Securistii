using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public interface IUserTemplate
    {
        string getUsername();
        void setUsername(string _username);
        int getId();
        void setId(int _id);
    }
}
