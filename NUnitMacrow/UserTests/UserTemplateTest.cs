using BiddingPlatform;
using BiddingPlatform.User;

namespace NUnitMacrow.UserTests
{
    public class UserTemplateTest
    {
        private UserTemplate _userTemplate { get; set; }

        [SetUp]
        public void Setup()
        {
            this._userTemplate = new UserTemplate(1, "Username1");
        }

        [Test]
        public void getId_EqualTest()
        {
            int id = this._userTemplate.getId();

            Assert.AreEqual(1, id);
        }

        [Test]
        public void setId_EqualTest()
        {
            this._userTemplate.setId(10);

            int id = this._userTemplate.getId();

            Assert.AreEqual(10, id);
        }

        [Test]
        public void getUsername_EqualTest()
        {
            string username = this._userTemplate.getUsername();

            Assert.AreEqual("Username1", username);
        }

        [Test]
        public void setUsername_EqualTest()
        {
            this._userTemplate.setUsername("Username222");

            string username = this._userTemplate.getUsername();

            Assert.AreEqual("Username222", username);
        }
    }
}
