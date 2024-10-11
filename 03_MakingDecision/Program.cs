using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Luften Sifreyi giriniz: ");
            //string password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Sifre dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre yanlis");
            //}

            //string capital, country;

            //Console.Write("Baskenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ulkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "turkiye")
            //{
            //    Console.WriteLine("Veriler Dogrulandi");
            //}
            //else
            //{
            //    Console.WriteLine("Hatali Bilgi");
            //}

            //int number;
            //Console.Write("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi hatali");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sinav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sinav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sinavlarn Otalamasi: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuc vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuc Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc Iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc Cok Iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lutfen sehir girisi yapiniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "trabzon" | city == "trabzon")
            //{
            //    Console.WriteLine("Sehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Sehir Mevcut Degil");
            //}

            //Console.Write("Lutfen Kullanici adini giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanici adi kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hos Geldiniz");
            //}
            #endregion

            #region Mod islemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lutfen 1. sayiyi giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2. sayiyi giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayinin 2. sayiya bolumunden kalan: " + result);

            //Console.Write("Lutfen sayiyi giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi cifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi tektir");
            //}

            #endregion

            #region Char Degiskenler ile Karar Yapilari
            //char team;
            //Console.Write("Lutfen takim sembolunu giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Besiktas");
            //}
            #endregion

            #region Ornek Proje Uygulamasi

            //Console.WriteLine("***** C# Egitim Kampi Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayini gormek istediginiz menu secimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("3-Kuzu Tandir");
            //    Console.WriteLine("4-Karisik Izgara");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine("-----------Ana Yemekler-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Corbalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Domates Corbasi");
            //    Console.WriteLine("3-Tarhana Corbasi");
            //    Console.WriteLine("4-Ezogelin Corbasi");
            //    Console.WriteLine("5-Yayla Corbasi");
            //    Console.WriteLine("-----------Corbalar-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita Pizza");
            //    Console.WriteLine("2-Karisik Pizza");
            //    Console.WriteLine("3-Kasarli Pizza");
            //    Console.WriteLine("4-Sucuklu Pizza");
            //    Console.WriteLine("5-Ananasli Pizza");
            //    Console.WriteLine("-----------Pizzalar-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Icecekler-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Su");
            //    Console.WriteLine("5-Limonata");
            //    Console.WriteLine("-----------Icecekler-----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlilar-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Kunefe");
            //    Console.WriteLine("3-Baklava");
            //    Console.WriteLine("4-Sutlac");
            //    Console.WriteLine("5-Revani");
            //    Console.WriteLine("-----------Tatlilar-----------");
            //    Console.WriteLine();
            //}

            #endregion

            #region Switch Case

            //Console.Write("Lutfen Ay Girisi Yapiniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Subat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayis");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylul");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasim");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralik");
            //        break;

            //    default:
            //        Console.WriteLine("Hatali Veri Girisi");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char operation;

            //Console.Write("1. Sayiyi Girinis: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayiyi Girinis: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen yapmak istediginiz islemi giriniz: ");
            //operation = char.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpim: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bolum: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("Hatali Veri Girisi");
            //        break;
            //}

            #endregion

        }
    }
}
