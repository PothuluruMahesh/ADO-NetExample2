using System;
using System.Data.SqlClient;

namespace ADOExamples
{
    class Insert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                // SqlCommand cm = new SqlCommand("insert into student6(id, email, join_date)values('102','mahesh6343@example.com', '1/12/2017')", con);
                //  SqlCommand cm = new SqlCommand("insert into student6(id,name,join_date)values('103','Ramesh','10/10/2010')", con);
                //  SqlCommand cm = new SqlCommand("insert into student6(id,name, email, join_date)values('107','suresh','suresh@example.com', '1/8/2013')", con);
                // SqlCommand cm = new SqlCommand("insert into student6(id)values('108')", con);
                //  SqlCommand cm = new SqlCommand("insert into student6(id,join_date)values('109','9/10/2015')", con);
                //   SqlCommand cm = new SqlCommand("insert into student6(id,name,email, join_date)values('102','Hopper','hopperoak@example.com', '8/10/2018')", con);
                SqlCommand cm = new SqlCommand("insert into student6(id, email)values('111','exam@example.com')", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
