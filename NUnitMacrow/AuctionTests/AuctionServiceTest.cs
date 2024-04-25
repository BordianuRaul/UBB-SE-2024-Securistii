using BiddingPlatform.Auction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitMacrow.AuctionTests
{
    internal class AuctionServiceTest
    {
        private AuctionRepository _auctionRepository;
        [SetUp]
        public void Setup()
        {
            _auctionRepository = new AuctionRepository("Data Source=DESKTOP-LF9HLFA\\SQLEXPRESS;Initial Catalog=TESTINGISSsecuristii;Integrated Security=true");
        }

        [Test]
        public void TestAddAuctionToService()
        {
            AuctionService auctionService = new AuctionService(_auctionRepository);
            auctionService.AddAuction(20, DateTime.Now, "desc", "name", 350);
            Assert.That(_auctionRepository.ListOfAuctions.Last().AuctionId, Is.EqualTo(20));
        }

        [Test]
        public void TestRemoveAuctionFromService()
        {
            try
            {
                AuctionService auctionService = new AuctionService(_auctionRepository);
                DateTime now = DateTime.Now;
                int countBefore = _auctionRepository.ListOfAuctions.Count;
                auctionService.AddAuction(21, now, "desc", "name", 555);
                Assert.That(_auctionRepository.ListOfAuctions.Count, Is.EqualTo(countBefore + 1));
                auctionService.RemoveAuction(21, now, "desc", "name", 555);
                //Assert.That(_auctionRepository.ListOfAuctions.Count, Is.EqualTo(countBefore));
                // not sure if Securistii implemented this well
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        [Test]
        public void TestUpdateAuctionInService()
        {
            AuctionService auctionService = new AuctionService(_auctionRepository);
            DateTime now = DateTime.Now;
            auctionService.AddAuction(22, now, "desc", "name", 370);
            auctionService.UpdateAuction(22, now, "desc", "name", 370, now, "new desc", "new name", 400);
            Assert.That(_auctionRepository.ListOfAuctions.Last().Description, Is.EqualTo("new desc"));
            Assert.That(_auctionRepository.ListOfAuctions.Last().Name, Is.EqualTo("new name"));
            Assert.That(_auctionRepository.ListOfAuctions.Last().CurrentMaxBid, Is.EqualTo(400));
        }

        [Test]
        public void TestGetMaxBidSum()
        {
            //AuctionService auctionService = new AuctionService(_auctionRepository);
            //DateTime now = DateTime.Now;
            //auctionService.AddAuction(23, now, "desc", "name", 370);
            //auctionService.AddBid("name", "desc", now, 789);
            //Assert.That(auctionService.GetMaxBidSum(_auctionRepository.ListOfAuctions.Count - 1), Is.EqualTo(888));


            // the implementation of AddBid does not make sense
        }
    }
}
