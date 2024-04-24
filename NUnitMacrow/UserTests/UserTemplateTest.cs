using BiddingPlatform;
using BiddingPlatform.User;

namespace NUnitMacrow.UserTests
{
    public class UserTemplateTest
    {
        private UserTemplate userTemplate { get; set; }

        [SetUp]
        public void Setup()
        {
            this.userTemplate = new UserTemplate(1, "Username1");
        }

        [Test]
        public void GetId_EqualTest()
        {
            int id = this.userTemplate.GetId();

            Assert.AreEqual(1, id);
        }

        [Test]
        public void SetId_EqualTest()
        {
            this.userTemplate.SetId(10);

            int id = this.userTemplate.GetId();

            Assert.AreEqual(10, id);
        }

        [Test]
        public void GetUsername_EqualTest()
        {
            string username = this.userTemplate.GetUsername();

            Assert.AreEqual("Username1", username);
        }

        [Test]
        public void SetUsername_EqualTest()
        {
            this.userTemplate.SetUsername("Username222");

            string username = this.userTemplate.GetUsername();

            Assert.AreEqual("Username222", username);
        }
    }
}
