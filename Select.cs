using System;
using System.Data.SqlClient;
using System.Configuration;
namespace ADOxamples
{
    class Select
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                SqlCommand cm = new SqlCommand("Select * from student6", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}