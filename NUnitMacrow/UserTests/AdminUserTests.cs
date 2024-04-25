using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiddingPlatform.User;

namespace NUnitMacrow.UserTests
{
    internal class AdminUserTests
    {
        AdminUser adminUser;
        int giveUserID = 0;
        string givenUsername="coolAdmin";
        [SetUp]
        public void Setup()
        {
            adminUser = new AdminUser(0, givenUsername);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}
