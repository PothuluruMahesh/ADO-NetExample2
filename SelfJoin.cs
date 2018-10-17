using System;
using System.Data.SqlClient;
using System.Configuration;
namespace ADOxamples
{
    class SelfJoin
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                SqlCommand cm = new SqlCommand("SELECT  a.ID, b.NAME, a.SALARY FROM Selfjoin a, Selfjoin b WHERE a.SALARY < b.SALARY; ", con);
                con.Open();
                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + "  " + sdr["name"]+"  "+sdr["salary"]);

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