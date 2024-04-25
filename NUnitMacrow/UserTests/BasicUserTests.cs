using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using BiddingPlatform.User;

namespace NUnitMacrow.UserTests
{
    internal class BasicUserTests
    {
        private BasicUser basicUser;
        private int userID = 0;
        private string username = "gelu";
        private string userNickname = "gelusor";

        [SetUp]
        public void Setup()
        {
            basicUser = new BasicUser(userID, username, userNickname);
        }

        [TearDown]
        public void TearDown()
        {
        }
        [Test]
        public void TestUsernameGetterAndConstructor()
        {
            Assert.That(this.basicUser.GetUsername(), Is.EqualTo(username));
        }
        [Test]
        public void TestNicknameGetterAndConstructor()
        {
            Assert.That(this.basicUser.GetNickname(), Is.EqualTo(this.userNickname));
        }
        [Test]
        public void TestUsernameSetter()
        {
            string testUsername = "gigel";
            basicUser.SetUsername(testUsername);
            Assert.That(this.basicUser.GetUsername(), Is.EqualTo(testUsername));
        }
        [Test]
        public void TestUserNicknameSetter()
        {
            string testNickname = "gigelescu";
            basicUser.SetNickname(testNickname);
            Assert.That(this.basicUser.GetNickname(), Is.EqualTo(testNickname));
        }
    }
}
