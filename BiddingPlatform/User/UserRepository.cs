using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiddingPlatform.User
{
    public class UserRepository
    {
        private string ConnectionString { get; set; }
        private List<UserTemplate> listOfUsers { get; set; }
        private string mihhConnectionString="Data Source=localhost\\SQLEXPRESS;Initial Catalog=BidingSystem;Integrated Security=True";
        public UserRepository() { 
            this.listOfUsers = new List<UserTemplate>();
            this.LoadUsersFromDataBase();
        }


        public UserRepository(List<UserTemplate> _listOfUsers)
        {
            this.ConnectionString = mihhConnectionString;
            this.listOfUsers = _listOfUsers;
        }
        private void LoadUsersFromDataBase()
        {
            string query = "SELECT * FROM Users";
            using (SqlConnection connection = new SqlConnection(this.ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string username = reader["Username"].ToString();
                    string nickname = reader["Nickname"].ToString();
                    string userType = reader["UserType"].ToString();

                    UserTemplate user;
                    if (userType == "Basic")
                    {
                        user = new BasicUser(userId, username, nickname);
                    }
                    else
                    {
                        user = new AdminUser(userId, username);
                    }

                    this.addUserToRepo(user);
                }
            }
        }

        public void addUserToRepo(UserTemplate User) 
        {
            this.ConnectionString = "Data Source=DESKTOP-UELLOC9;Initial Catalog=BidingSystem;Integrated Security=true";
            this.listOfUsers.Add(User);
        }

        public void removeUserFromRepo(UserTemplate User)
        {
            this.listOfUsers.Remove(User);
        }

        public void updateUserIntoRepo(UserTemplate olduser, UserTemplate newuser)
        {
            int olduserIndex = this.listOfUsers.FindIndex(user => user == olduser);
            if (olduserIndex != -1)
            {
                this.listOfUsers[olduserIndex] = newuser;
            }
        }
        public List<UserTemplate> GetListOfUsers()
        {
            return this.listOfUsers;
        }
    }
}
