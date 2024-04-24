using BiddingPlatform;
using BiddingPlatform.Bid;
using BiddingPlatform.User;

namespace NUnitMacrow.BidTests
{
    public class BidModelTest
    {
        private BidModel bidModel { get; set; }
        private BasicUser basicUser { get; set; }

        [SetUp]
        public void Setup()
        {
            this.basicUser = new BasicUser(1, "basicUserName1", "basicUserNickname1");
            DateTime dateTime = new DateTime(2024, 4, 23, 20, 34, 33);  // YYYY/MM/dd HH:mm:ss
            this.bidModel = new BidModel(2, this.basicUser, 40, dateTime);
        }

        [Test]
        public void GetBidId_EqualTest()
        {
            int bidId = this.bidModel.BidId;

            Assert.AreEqual(2, bidId);
        }

        [Test]
        public void SetBidId_EqualTest()
        {
            this.bidModel.BidId = 4;

            int bidId = this.bidModel.BidId;

            Assert.AreEqual(4, bidId);
        }

        [Test]
        public void GetBasicUser_EqualTest()
        {
            BasicUser basicUser = this.bidModel.BasicUser;

            Assert.AreEqual(this.basicUser, basicUser);
        }

        [Test]
        public void SetBasicUser_EqualTest()
        {
            BasicUser newUser = new(11, "basicUserName2", "basicUserNickname2");
            this.bidModel.BasicUser = newUser;

            BasicUser basicUser = this.bidModel.BasicUser;

            Assert.AreEqual(newUser, basicUser);
        }

        [Test]
        public void GetBidSum_EqualTest()
        {
            float bidSum = this.bidModel.BidSum;

            Assert.AreEqual(40, bidSum);
        }

        [Test]
        public void SetBidSum_EqualTest()
        {
            this.bidModel.BidSum = 666;

            float bidSum = this.bidModel.BidSum;

            Assert.AreEqual(666, bidSum);
        }

        [Test]
        public void GetBidDate_EqualTest()
        {
            DateTime dateTime = this.bidModel.BidDateTime;
            DateTime expectedDateTime = new DateTime(2024, 4, 23, 20, 34, 33);

            Assert.AreEqual(expectedDateTime, dateTime);
        }

        [Test]
        public void SetBidDate_EqualTest()
        {
            DateTime newDateTime = new DateTime(2048, 8, 16, 16, 32, 32);
            this.bidModel.BidDateTime = newDateTime;

            DateTime dateTime = this.bidModel.BidDateTime;

            Assert.AreEqual(newDateTime, dateTime);
        }
    }
}
