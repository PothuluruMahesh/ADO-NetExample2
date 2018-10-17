using System;
using System.Data.SqlClient;

namespace ADOxamples
{
    class Update
    {
        static void Main(string[] args)       
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-5972U908\\MSSQLSERVER01; database=Student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("UPDATE student6 SET email = 'update@gmail.com' WHERE id = 105", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Updated Successfully");
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