using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAPI
{
    public class DatabaseClass
    {
        static string connString = ConfigurationManager.AppSettings["connString"];

        static string connString2 = ConfigurationManager.AppSettings["connString2"];

        public static bool checkUser(string Username, string Password)
        {
            bool result = false;

            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * FROM Accounts";
            cmd.Connection = conn;
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                if ((rd[1].ToString() == Username) && (rd[2].ToString() == Password))
                {
                    result = true;
                }

            }

            if (result == true)
            {
                return result;
            }

            return result;
        }

        public static void logAction(string user, string serviceName, string action)
        {

            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "INSERT INTO LogData (Username, Action, Service) VALUES (@username, @action, @service)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", user);
                    command.Parameters.AddWithValue("@action", action);
                    command.Parameters.AddWithValue("@service", serviceName);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                }
            }

        }

        public static void getCharInfo(string characterName)
        {
            using (SqlConnection connection = new SqlConnection(connString2))
            {
                string query = "Select sID from tCharacter WHERE sID = @charName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@charName", characterName.ToString());

                    connection.Open();

                    

                }
            }
        }
    }
}