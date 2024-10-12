using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Ornekleri

            //2.4.6.8
            //sari, mavi, yesil, kirmizi
            //adana, ankara, istanbul, izmir
            //DegiskenTur[] DiziAdi = new DegiskenTur[ElemanSayisi];

            //string[] colors = new string[4];

            //colors[0] = "sari";
            //colors[1] = "mavi";
            //colors[2] = "yesil";
            //colors[3] = "kirmizi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "adana";
            //cities[1] = "ankara";
            //cities[2] = "istanbul";
            //cities[3] = "izmir";
            //cities[4] = "bursa";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[7] = 756;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "adana", "ankara", "istanbul", "izmir", "bursa" };

            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki Tum Elemanlari Listeleme

            //string[] colors = { "sari", "mavi", "yesil", "kirmizi" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 10, 20, 325, 676, 789, 34, 70, 80, 90, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = {'a', 'b', 'c', '*', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // Dizideki en buyuk sayiyi bulma
            //int[] myArray = { 34, 56, 78, 90, 345, 55, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "veli", "ayse", "fatma", "mehmet" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 34, 56, 12, 45, 67 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 34, 56, 12, 45, 67 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metodlari

            //string[] customer = { "ali", "veli", "ayse", "fatma", "mehmet" };
            //int index = Array.IndexOf(customer, "ayse");

            //Console.WriteLine(index);

            //int[] numbers = { 34, 56, 12, 45, 67 };
            //Console.WriteLine("Dizinin en buyuk elemani: " + numbers.Max() + " , Dizinin en kucuk elemani: " + numbers.Min());

            #endregion

            #region Kullanicidan Deger Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lutfen {i + 1}. Sehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30, 40, 50 };

            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] numbers = {13, 24, 35, 46, 57, 68, 79, 80, 98, 230 };

            //Console.WriteLine("Cift Sayilar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("\nTek Sayilar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
        }
    }
}
