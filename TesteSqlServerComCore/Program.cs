using System;
using System.Data;
using System.Data.SqlClient;


namespace TesteSqlServerComCore
{
    class Program
    {
        static void Main(string[] args)
        {
            string constring = @"server=DESKTOP-NQP6NJ3\WCASTRO;DataBase=WEBAPIS;Trusted_Connection=true;";
            var con = new SqlConnection(constring);
            con.Open();

            var comando = new SqlCommand("select * from Products", con);

            DataTable dt = new DataTable();

            dt.Load(comando.ExecuteReader());
            con.Close();

            foreach (DataRow item in dt.Rows)
            {
                Console.WriteLine($"id:{item.ItemArray[0]} nome: {item.ItemArray[1]}");
            }

            Console.ReadLine();
        }
    }
}
