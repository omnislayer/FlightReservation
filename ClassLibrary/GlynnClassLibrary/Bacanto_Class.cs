using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlynnClassLibrary
{
    public class Bacanto_Class
    {
        public string Email { get; private set; }
        public int UserID { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Birthday { get; private set; }

        //Text Randomizer
        private static string RandomString(int length)
        {
            const string pool = "abcdefghijklmnopqrstuvwxyz0123456789";
            var builder = new StringBuilder();
            Random rand = new Random();

            for (var i = 0; i < length; i++)
            {
                var c = pool[rand.Next(0, pool.Length)];
                builder.Append(c);
            }

            return builder.ToString();
        }

        static String connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\Projects\ASP 2017\FlightReservation\ClassLibrary\GlynnClassLibrary\LibriDatabase.mdf';Integrated Security=True";
        //static String connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\LibriDatabase.mdf;Integrated Security=True";
        //Online Connection String (UNFINISHED)
        //static String connectionString = @"workstation id=libridb.mssql.somee.com;packet size=4096;user id=omnislayer10_SQLLogin_1;pwd=22idr2n2z9;data source=libridb.mssql.somee.com;persist security info=False;initial catalog=libridb";
        SqlConnection connection = new SqlConnection(connectionString);

        public bool checkEmailExists(string email)
        {
            bool myBool = false;
            int hasEmail = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("checkEmailExists", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email",email);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read()) hasEmail = int.Parse(sdr["logInCorrect"].ToString());

                if (hasEmail > 0) myBool = true;

                connection.Close();
            }
            catch (Exception e) { }
            return myBool;
        }

        public Boolean addUser(string email, string firstname, string lastname, string password, DateTime birthday)
        {
            bool myBool = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("addUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.ExecuteNonQuery();
                connection.Close();
                myBool = true;
            }
            catch (Exception e) { }
            return myBool;
        }
        public bool checkLogin(string email, string password)
        {
            bool myBool = false;
            int logInCorrect = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("checkLogin", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read()) logInCorrect = int.Parse(sdr["logInCorrect"].ToString());
                if (logInCorrect > 0) myBool = true;

                connection.Close();
            }
            catch (Exception e) { }
            return myBool;
        }
        public void getUserInfo(string email)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("getUserInfo", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Email = email;
                    UserID = int.Parse(sdr["UserID"].ToString());
                    FirstName = sdr["FirstName"].ToString();
                    LastName = sdr["LastName"].ToString();
                    Birthday = sdr["Birthday"].ToString();
                }
                connection.Close();
            }
            catch (Exception e) { }
        }
        public DataTable getFlightsByCode(String airlineCode)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("getFlightsByCode", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@airlineCode", airlineCode);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception e) { }
            return dt;
        }
        public DataTable getFlightsByOriginDestination(String origin,String destination)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("getFlightsByOrigin", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@origin", origin);
                da.SelectCommand.Parameters.AddWithValue("@destination", destination);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception e) { }
            return dt;
        }
        public bool getFlightAvailability(int flightID)
        {
            bool myBool = false;
            int logInCorrect = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("getFlightByID", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@flightID", flightID);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read()) logInCorrect = int.Parse(sdr["logInCorrect"].ToString());
                if (logInCorrect > 0) myBool = true;

                connection.Close();
            }
            catch (Exception e) { }
            return myBool;
        }
        public Boolean addTicket(int flightID, int userID)
        {
            bool myBool = false;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("addTicket", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@reservationNumber", RandomString(5));//Randomized string lolz Change this when not lazy
                cmd.Parameters.AddWithValue("@flightID", flightID);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();
                connection.Close();
                myBool = true;
            }
            catch (Exception e) { }

            return myBool;
        }
        public DataTable getTicketsByUser(int userID)
        {
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("getTicketsByUser", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@userID", userID);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception e) { }
            return dt;
        }
    }//End Class
}
