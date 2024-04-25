using BiddingPlatform.Auction;
using BiddingPlatform.Bid;
using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMacrow.AuctionTests
{
    public class MockAuction : IAuctionModel
    {
        public List<IBidModel> listOfBids { get; set; }
        public int auctionId { get; set; }
        public DateTime startingDate { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public float currentMaxSum { get; set; }

        public void addUserToAuction(BasicUser user)
        {
            throw new NotImplementedException();
        }

        public void addBidToAuction(IBidModel bid)
        {
            throw new NotImplementedException();
        }

    }
    internal class AuctionRepositoryTest {
        

        [Test]
        public void TestAddingToRepo()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true;");

            IAuctionModel auction = new MockAuction();
            auction.auctionId = 99;
            auction.currentMaxSum = 100;
            auction.description = "Test";
            auction.name = "Test";
            auction.startingDate = DateTime.MinValue;
            auctionRepository.AddAuctionToRepo(auction);
            Assert.That(auctionRepository.ListOfAuctions.Last().auctionId, Is.EqualTo(99));
        }

        [Test]
        public void TestRemovingFromRepo()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true;");

            IAuctionModel auction = new MockAuction();
            auction.auctionId = 99;
            auction.currentMaxSum = 100;
            auction.description = "Test";
            auction.name = "Test";
            auction.startingDate = DateTime.MinValue;
            auctionRepository.AddAuctionToRepo(auction);
            int beforeRemoval = auctionRepository.ListOfAuctions.Count;
            auctionRepository.RemoveAuctionFromRepo(auction);
            int afterRemoval = auctionRepository.ListOfAuctions.Count;
            Assert.That(beforeRemoval, Is.EqualTo(afterRemoval + 1));
        }

        [Test]
        public void TestUpdatingIntoRepo()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true;");

            IAuctionModel auction = new MockAuction();
            auction.auctionId = 99;
            auction.currentMaxSum = 100;
            auction.description = "Test";
            auction.name = "Test";
            auction.startingDate = DateTime.MinValue;
            auctionRepository.AddAuctionToRepo(auction);

            IAuctionModel newAuction = new MockAuction();
            newAuction.auctionId = 100;
            newAuction.currentMaxSum = 200;
            newAuction.description = "Test";
            newAuction.name = "Test";
            newAuction.startingDate = DateTime.MinValue;

            auctionRepository.UpdateAuctionIntoRepo(auction, newAuction);
            Assert.That(auctionRepository.ListOfAuctions.Contains(auction), Is.False);
            Assert.That(auctionRepository.ListOfAuctions[1].auctionId, Is.EqualTo(100));
        }

        [Test]
        public void TestRepoConstructor()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=ISSsecuristii;Integrated Security=true;");
            Assert.That(auctionRepository.ListOfAuctions.Count, Is.EqualTo(6));
        }

        [Test]
        public void TestGetMaxBidSum()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=ISSsecuristii;Integrated Security=true;");
            Assert.That(auctionRepository.GetBidMaxSum(1), Is.EqualTo(300.3f));
        }

        [Test]
        public void TestAddToDB()
        {
            IAuctionRepository auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true;");
            auctionRepository.AddToDB("Test", "Test", DateTime.Now, 100);
            IAuctionRepository resultingRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true;");
            Assert.That(resultingRepository.ListOfAuctions.Count, Is.EqualTo(1));
        }
    }
}
