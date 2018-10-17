using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOExamples
{
    class StudentInfo
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                SqlCommand cm = new SqlCommand("create table studentIInfo(rollNo int unique,name varchar(100),class varchar(100))", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("Student Table created Successfully");
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
