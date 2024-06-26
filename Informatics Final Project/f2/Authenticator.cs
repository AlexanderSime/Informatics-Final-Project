﻿using Azure.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f2
{
    public class Authenticator
    {
        public class User
        {
            public string Username { get; set; }
            public string Gender { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public DateTime Bday { get; set; }
            public byte[] Image { get; set; }
        }

        public class DatabaseManager
        {
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInfo(username, password);
                return user;
            }

            private static User RetrieveUserInfo(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=YAPMedia; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string Query = "SELECT COUNT(1) FROM [User] WHERE username=@username AND password=@password";
                    string imgQ = "SELECT * FROM [User] WHERE username = @username";

                    SqlCommand cmd = new SqlCommand(Query, sqlCon);
                    SqlCommand imgCmd = new SqlCommand(imgQ, sqlCon);

                    imgCmd.CommandType = CommandType.Text;
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    imgCmd.Parameters.AddWithValue("@username", username);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {

                        using (SqlDataReader reader = imgCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageData = reader["img"] as byte[];

                                return new User { Username = username, Image = imageData };
                            }
                        }
                    }
                    return null;
                }
            }
        }
    }
}
