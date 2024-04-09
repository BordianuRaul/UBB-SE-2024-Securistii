using BiddingPlatform.User;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.Bid
{
    public class BidRepository
    {
        private string connectionString;
        public List<BidModel> Bids { get; set; }

        public BidRepository() 
        {
            this.connectionString = "Data Source=Birou;Initial Catalog=BidingSystem;Integrated Security=true";
            this.Bids = new List<BidModel>();
            this.LoadBidsFromDatabase();
        }

        public BidRepository(List<BidModel> bids)
        {
            this.connectionString = "Data Source=Birou;Initial Catalog=BidingSystem;Integrated Security=true";
            Bids = bids;
        }

        private void LoadBidsFromDatabase()
        {
            string query = "SELECT * FROM Bid";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int bidId = Convert.ToInt32(reader["BidID"]);
                    float bidSum = Convert.ToSingle(reader["BidSum"]);
                    DateTime timeOfBid = Convert.ToDateTime(reader["TimeOfBid"]);
                    int userId = Convert.ToInt32(reader["UserID"]);

                    BasicUser user = this.getUserFromDataBase(userId);

                    BidModel bid = new BidModel(bidId, user, bidSum, timeOfBid);
                    Bids.Add(bid);
                }
            }
        }

        private BasicUser getUserFromDataBase(int userID)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {userID}";

            using (SqlConnection connection = new SqlConnection(connectionString))
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

        public void addBidToRepo(BidModel bid)
        {
            this.Bids.Add(bid);
        }

        public List<BidModel> getBids()
        {
            return this.Bids;
        }

        public void deleteBidFromRepo(BidModel bid) 
        {
            this.Bids.Remove(bid);
        }

        public void updateBidIntoRepo(BidModel oldbid, BidModel newbid)
        {
            int oldbidIndex = this.Bids.FindIndex(bid => bid == oldbid);
            if (oldbidIndex != -1)
            {
                this.Bids[oldbidIndex] = newbid;
            }
        }
    }
}
