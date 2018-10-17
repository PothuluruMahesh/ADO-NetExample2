using System;
using System.Data.SqlClient;

namespace ADOExamples
{
    class StudentDelete
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-5972U908\\MSSQLSERVER01; database=Student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("delete from studentIInfo where rollNo = '119'", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
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