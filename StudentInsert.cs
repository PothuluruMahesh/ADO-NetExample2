using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOexamples
{
    class StudentInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                SqlCommand cm = new SqlCommand("insert into studentIInfo(rollNo,name)values('103','Mahi')", con);
                //   SqlCommand cm6 = new SqlCommand("insert into studentIInfo(rollNo,class)values('117','10')", con);
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
