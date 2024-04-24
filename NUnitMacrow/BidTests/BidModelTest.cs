using BiddingPlatform;
using BiddingPlatform.Bid;
using BiddingPlatform.User;

namespace NUnitMacrow.BidTests
{
    public class BidModelTest
    {
        private BidModel _bidModel { get; set; }
        private BasicUser _basicUser { get; set; }

        [SetUp]
        public void Setup()
        {
            this._basicUser = new BasicUser(1, "basicUserName1", "basicUserNickname1");
            DateTime dateTime = new DateTime(2024, 4, 23, 20, 34, 33);  // YYYY/MM/dd HH:mm:ss
            this._bidModel = new BidModel(2, this._basicUser, 40, dateTime);
        }

        [Test]
        public void getBidId_EqualTest()
        {
            int bidId = this._bidModel.bidId;

            Assert.AreEqual(2, bidId);
        }

        [Test]
        public void setBidId_EqualTest()
        {
            this._bidModel.bidId = 4;

            int bidId = this._bidModel.bidId;

            Assert.AreEqual(4, bidId);
        }

        [Test]
        public void getBasicUser_EqualTest()
        {
            BasicUser basicUser = this._bidModel.user;

            Assert.AreEqual(this._basicUser, basicUser);
        }

        [Test]
        public void setBasicUser_EqualTest()
        {
            BasicUser newUser = new(11, "basicUserName2", "basicUserNickname2");
            this._bidModel.user = newUser;

            BasicUser basicUser = this._bidModel.user;

            Assert.AreEqual(newUser, basicUser);
        }

        [Test]
        public void getBidSum_EqualTest()
        {
            float bidSum = this._bidModel.bidSum;

            Assert.AreEqual(40, bidSum);
        }

        [Test]
        public void setBidSum_EqualTest()
        {
            this._bidModel.bidSum = 666;

            float bidSum = this._bidModel.bidSum;

            Assert.AreEqual(666, bidSum);
        }

        [Test]
        public void getBidDate_EqualTest()
        {
            DateTime date = this._bidModel.bidDate;
            DateTime expectedDate = new DateTime(2024, 4, 23, 20, 34, 33);

            Assert.AreEqual(expectedDate, date);
        }

        [Test]
        public void setBidDate_EqualTest()
        {
            DateTime newDate = new DateTime(2048, 8, 16, 16, 32, 32);
            this._bidModel.bidDate = newDate;

            DateTime dateTime = this._bidModel.bidDate;

            Assert.AreEqual(newDate, dateTime);
        }
    }
}