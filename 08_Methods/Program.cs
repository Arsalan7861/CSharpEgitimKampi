using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            // ()
            // Geriye deger dondurmeyen metotlar
            // Customer --> Listele, ekle, sil, guncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yildiz");
            //    Console.WriteLine("Ahmet Yildiz");
            //    Console.WriteLine("Mehmet Yildiz");
            //    Console.WriteLine("Ayse Yildiz");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 10;
            //    int y = 20;
            //    int sum = x + y;
            //    Console.WriteLine(sum);
            //}

            //Sum();
            #endregion

            #region Geriye Deger Dondurmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Ali Yildiz");

            //void CustomerCard(String name, String surname)
            //{
            //    Console.WriteLine("Musteri: " + name + " " + surname);
            //}

            //CustomerCard("Ali", "Yildiz");
            //CustomerCard("Ahmet", "Yildiz");
            #endregion

            #region Geriye Deger Dondurmeyen Int Parametreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine("Sonuc: " + result);
            //}

            //Sum(10, 20, 30);

            #endregion

            #region Geriye Deger Donduren Metotlar

            //string CustomerName()
            //{
            //    return "Ali Yildiz";
            //}

            // CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Yildiz";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Deger Donduren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ulke: " + countryName + " - Baskent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ulke Adini Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Baskent Adini Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Turkiye", "Ankara", "Kirmizi-Beyaz"));
            #endregion

            #region Geriye Deger Donduren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(10, 20));
            //Console.WriteLine(Sum(20, 30));
            //Console.WriteLine(Sum(30, 40));
            //Console.WriteLine(Sum(34, 67));

            #endregion

            #region Ornek Uygulamasi

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;

            //    if (result >= 50)
            //    {
            //        return student + " isimli ogrenci sinavi gecti " + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli ogrenci sinavi gecemedi " + "Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 34, 56, 30));
            //Console.WriteLine(ExamResult("Ahmet", 78, 89, 90));

            #endregion

            Console.Read();
        }
    }
}
