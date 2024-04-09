using BiddingPlatform.Bid;
using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Auction
{
    public class AuctionRepository
    {
        private string ConnectionString;
        public List<AuctionModel> listOfAuctions {  get; set; }
        public AuctionRepository() 
        {
            this.ConnectionString = "Data Source=DESKTOP-UELLOC9;Initial Catalog=Lab3_Week8;Integrated Security=true";
            this.listOfAuctions = new List<AuctionModel>();
        }

        public AuctionRepository(List<AuctionModel> listOfAuctions)
        {
            this.ConnectionString = "Data Source=DESKTOP-UELLOC9;Initial Catalog=Lab3_Week8;Integrated Security=true";
            this.listOfAuctions = listOfAuctions;
        }

        private void LoadAuctionsFromDatabase()
        {
            string query = "SELECT * FROM Auction";

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int auctionId = Convert.ToInt32(reader["AuctionID"]);
                    string auctionDescription = reader["AuctionDescription"].ToString();
                    string auctionName = reader["AuctionName"].ToString();
                    float currentMaxSum = Convert.ToSingle(reader["CurrentMaxSum"]);
                    DateTime dateOfStart = Convert.ToDateTime(reader["DateOfStart"]);
                    int userId = Convert.ToInt32(reader["UserID"]);
                    int bidId = Convert.ToInt32(reader["BidID"]);


                    List<BasicUser> users = LoadUserFromDatabase(userId);
                    List<BidModel> bids = LoadBidFromDatabase(bidId);


                    AuctionModel auction = new AuctionModel(auctionId, dateOfStart, auctionDescription, auctionName, currentMaxSum, users, bids);
                    listOfAuctions.Add(auction);
                }
            }
        }

        private List<BasicUser> LoadUserFromDatabase(int auctionId)
        {
            List<BasicUser> users = new List<BasicUser>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                string query = @"EXEC GetUniqueUsersFromAuctionBids @AuctionID = @auctionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@auctionId", auctionId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string username = reader["Username"].ToString();
                    string nickname = reader["Nickname"].ToString();

                    BasicUser user = new BasicUser(userId, username, nickname);
                    users.Add(user);
                }
            }

            return users;
        }


        private List<BidModel> LoadBidFromDatabase(int bidId)
        {
            List<BidModel> bids = new List<BidModel>();

            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                string query = "SELECT * FROM Bid WHERE BidID = @bidId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bidId", bidId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int bidID = Convert.ToInt32(reader["BidID"]);
                    float bidSum = Convert.ToSingle(reader["BidSum"]);
                    DateTime timeOfBid = Convert.ToDateTime(reader["TimeOfBid"]);
                    int userId = Convert.ToInt32(reader["UserID"]);
                    BasicUser user = this.getUserFromDataBase(userId);
                    BidModel bid = new BidModel(bidID, user, bidSum, timeOfBid);
                    bids.Add(bid);
                }
            }

            return bids;
        }

        private BasicUser getUserFromDataBase(int userID)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {userID}";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    string username = reader["Username"].ToString();
                    string nickname = reader["Nickname"].ToString();
                    string userType = reader["UserType"].ToString();

                    BasicUser user;


                    user = new BasicUser(userID, username, nickname);

                    return user;
                }
            }

            return null;

        }



        public void addAuctionToRepo(AuctionModel auction)
        {
            listOfAuctions.Add(auction);
        }

        public void removeAuctionFromRepo(AuctionModel auction)
        {
            listOfAuctions.Remove(auction);
        }

        public void updateAuctionIntoRepo(AuctionModel oldauction, AuctionModel newauction)
        {
            int oldauctionIndex = this.listOfAuctions.FindIndex(auction => auction == oldauction);
            if (oldauctionIndex != -1)
            {
                this.listOfAuctions[oldauctionIndex] = newauction;
            }
        }
    }
}
