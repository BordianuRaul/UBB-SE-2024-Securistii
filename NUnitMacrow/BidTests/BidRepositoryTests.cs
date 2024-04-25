using BiddingPlatform.Bid;
using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMacrow.BidTests
{
    internal class BidRepositoryTests
    {
        private string connectionString = "Server=DESKTOP-P38TJBL\\SQLEXPRESS;Database=BiddingPlatformDB;Integrated Security=True;";
        private BidRepository bidRepository;

        [SetUp]
        public void Setup()
        {
            bidRepository = new BidRepository(connectionString);
        }

        [TearDown]
        public void TearDown()
        {
            bidRepository.Bids.Clear();
        }

        [Test]
        public void TestAddBidToRepository()
        {
            // Arrange
            BasicUser user = new BasicUser(1, "UserName", "User");
            IBidModel mockBid = new BidModel(1, user, 100.0f, DateTime.UtcNow);

            // Act
            bidRepository.AddBidToRepo(mockBid);

            // Assert
            Assert.That(bidRepository.Bids.Count, Is.EqualTo(1));
            Assert.IsTrue(bidRepository.Bids.Contains(mockBid));
        }

        [Test]
        public void TestDeleteBidFromRepository()
        {
            // Arrange
            BasicUser user = new BasicUser(1, "UserName", "User");
            IBidModel mockBid = new BidModel(1, user, 100.0f, DateTime.UtcNow);
            bidRepository.Bids.Add(mockBid);

            // Act
            bidRepository.DeleteBidFromRepo(mockBid);

            // Assert
            Assert.That(bidRepository.Bids.Count, Is.EqualTo(0));
            Assert.IsFalse(bidRepository.Bids.Contains(mockBid));
        }

        [Test]
        public void TestUpdateBidIntoRepository()
        {
            // Arrange
            BasicUser user1 = new BasicUser(1, "UserName", "User");
            BasicUser user2 = new BasicUser(2, "NewUserName", "NewUser");

            IBidModel oldBid = new BidModel(1, user1, 100.0f, DateTime.UtcNow);
            IBidModel newBid = new BidModel(1, user2, 150.0f, DateTime.UtcNow);

            bidRepository.Bids.Add(oldBid);

            // Act
            bidRepository.UpdateBidIntoRepo(oldBid, newBid);

            // Assert
            Assert.That(bidRepository.Bids.Count, Is.EqualTo(1));
            Assert.IsFalse(bidRepository.Bids.Contains(oldBid));
            Assert.IsTrue(bidRepository.Bids.Contains(newBid));
        }

        [Test]
        public void TestGetAllBidsFromRepository()
        {
            // Arrange
            BasicUser user1 = new BasicUser(1, "UserName", "User");
            BasicUser user2 = new BasicUser(2, "SecondUserName", "User2");

            IBidModel bid1 = new BidModel(1, user1, 100.0f, DateTime.UtcNow);
            IBidModel bid2 = new BidModel(2, user2, 150.0f, DateTime.UtcNow);

            bidRepository.Bids.Add(bid1);
            bidRepository.Bids.Add(bid2);

            // Act
            List<IBidModel> retrievedBids = bidRepository.GetBids();

            // Assert
            Assert.That(retrievedBids.Count, Is.EqualTo(2));
            Assert.IsTrue(retrievedBids.Contains(bid1));
            Assert.IsTrue(retrievedBids.Contains(bid2));
        }



    }
}
