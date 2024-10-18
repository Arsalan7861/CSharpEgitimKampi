using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Froeach Dongusu

            // Foreach(1;2;3;4)

            // 1:Degisken turu
            // 2:Degisken ismi
            // 3:In
            // 4:Liste, Koleksiyon, Dizi

            //string[] cities = { "adana", "ankara", "istanbul", "izmir", "bursa" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 23, 45, 67, 89, 12, 34, 56, 78, 90, 11 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number); 
            //    }
            //}

            //int[] numbers = { 23, 45, 67, 89, 12, 34, 56, 78, 90, 11 };

            //int totatl = 0;

            //foreach (var number in numbers)
            //{
            //    totatl += number;
            //}
            //Console.WriteLine(totatl);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello World";

            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}
            #endregion

            #region Ornek Sinav Uygulamasi

            //Console.WriteLine("***** C# Egitim Kampi Sinav Uygulamasi *****");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("--------------------------");
            //Console.Write("Sinavinizda Kac Ogrenci Var: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. ogrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    // Her bir ogrenci icin 3 sinav notu al
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli ogrencinin {j + 1}. sinav notunu giriniz: ");
            //        totalExamResult += double.Parse(Console.ReadLine());// notlari topluyoruz.
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //// Ogrencilerin ortalamasi ve gecip kalan durumlari

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("------------------------------");
            //    Console.WriteLine($"{studentNames[i]} isimli ogrencinin sinav ortalamasi: {studentExamAvg[i]}");

            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adli ogrenci dersi gecti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adli ogrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("------------------------------");
            //}
            #endregion

            Console.Read();
        }
    }
}
