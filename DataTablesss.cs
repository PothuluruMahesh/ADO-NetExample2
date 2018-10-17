using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ADOExamples
{
    class DataTablesss
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                DataTable table = new DataTable();
                table.Columns.Add("ID");
                table.Columns.Add("Name");
                table.Columns.Add("Email");
                table.Rows.Add("101", "Rameez", "rameez@example.com");
                table.Rows.Add("102", "Sam Nicolus", "sam@example.com");
                table.Rows.Add("103", "Subramanium", "subramanium@example.com");
                table.Rows.Add("104", "Ankur Kumar", "ankur@example.com");
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
