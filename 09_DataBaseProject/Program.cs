using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net

            //Console.WriteLine("***** C# Veri Tabanli Urun-Kategori Bilgi Sistemi *****");
            //Console.WriteLine();
            //Console.WriteLine();

            //string tableNumer;

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Kategoriler");
            //Console.WriteLine("2-Urunler");
            //Console.WriteLine("3-Siparisler");
            //Console.WriteLine("4-Cikis Yap");
            //Console.Write("Lutfen girmek istediginiz tablo numrasini giriniz: ");
            //tableNumer = Console.ReadLine();
            //Console.WriteLine("--------------------------------------");

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-G1HGNHG3\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // C# ile sql arasinda veri alisverisi yapmamizi saglar
            //DataTable dataTable = new DataTable(); // Verileri gecici olarak tutmak icin
            //adapter.Fill(dataTable); // Verileri tabloya doldurur

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            //Console.Read();
        }
    }
}
