using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOexamples
{
    class ClassInsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
              //  SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub2,sub3)values('101','50','40','35')", con);
               // SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub2,sub3)values('15','70','80','75')", con);
               // SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub2,sub3)values('10','75','40','65')", con);
               // SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub2)values('11','55','45')", con);
              //  SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub3)values('11','55','45')", con);
             //   SqlCommand cm = new SqlCommand("insert into classInfo(class,sub2,sub3)values('12','55','45')", con);
             //   SqlCommand cm = new SqlCommand("insert into classInfo(class,sub1,sub2,sub3)values('11','77','88','99')", con);
             //   SqlCommand cm = new SqlCommand("insert into classInfo(class)values('10')", con);
              //  SqlCommand cm = new SqlCommand("insert into classInfo(sub1,sub2,sub3)values('100','90','80')", con);
                SqlCommand cm = new SqlCommand("insert into classInfo(sub1,sub3)values('90','80')", con);
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
