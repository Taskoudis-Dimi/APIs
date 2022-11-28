﻿using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Database
{
    public class Connect
    {
        SqlConnection con = new SqlConnection();
        public DataTable table = new DataTable();

        public Connect()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["smarketdb"].ConnectionString;
            //con = new SqlConnection("server=DESKTOP-FF268DF\\SQLEXPRESS;database=smarketdb;Integrated Security=SSPI;");
        }


        public void retrieveData(string command)
        {
            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command, con);
                adapter.Fill(table);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        public void commandExc(string command)
        {
            try
            {
                con.Open();
                SqlCommand sqlcomm = new SqlCommand(command, con);

                int rowInfected = sqlcomm.ExecuteNonQuery();
                if (rowInfected > 0)
                {
                    Console.WriteLine("Success to connect with db!");
                }
                else
                {
                    Console.WriteLine("Fail to connect with db!");
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}