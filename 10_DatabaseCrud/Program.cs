using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud --> Create, Read, Update, Delete

            //Console.WriteLine("***** Menu Siparis Islem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");

            #region Kategori Ekleme islemi
            //Console.Write("Eklemek istediginiz Kategori Adi: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G1HGNHG3\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Basariyla Eklendi.");
            #endregion

            #region Urun Ekleme Islemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Urun Adi: ");
            //productName = Console.ReadLine();
            //Console.Write("Urun Fiyati: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G1HGNHG3\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TblProducts (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Urun Eklemesi Basarili.");
            #endregion

            #region Urun Listeleme Islemi

            //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G1HGNHG3\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TblProducts", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //foreach (DataRow item in dataTable.Rows)
            //{
            //    Console.WriteLine("Urun Adi: " + item["ProductName"]);
            //    Console.WriteLine("Urun Fiyati: " + item["ProductPrice"]);
            //    Console.WriteLine("Urun Durumu: " + item["ProductStatus"]);
            //    Console.WriteLine("---------------------------------");
            //}

            //connection.Close();

            #endregion

            #region Urun Silme Islemi

            //Console.Write("Silinecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G1HGNHG3\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("DELETE FROM TblProducts WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Urun Silme Islemi Basarili.");

            #endregion

            #region Urun Guncelleme Islemi

            //Console.Write("Guncellenecek Urun Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Guncellenecek Urun Adi: ");
            //string productName = Console.ReadLine();

            //Console.Write("Guncellenecek Urun Fiyati: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G1HGNHG3\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE TblProducts SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Urun Guncelleme Islemi Basarili.");

            #endregion

            Console.Read();
        }
    }
}
