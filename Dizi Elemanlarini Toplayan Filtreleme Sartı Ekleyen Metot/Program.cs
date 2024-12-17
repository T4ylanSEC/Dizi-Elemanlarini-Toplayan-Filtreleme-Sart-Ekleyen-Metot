using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizi_Elemanlarini_Toplayan_Filtreleme_Sartı_Ekleyen_Metot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 96, 8, 34, 128, 12, 73 };
            int filterValue = 50;

            int result = SumGreaterThan(numbers, filterValue);
            Console.WriteLine($"Filtre Değerinden Büyük Olan Sayıların Toplamı: {result}");

            Console.ReadKey();

        }

         static int SumGreaterThan(int[] array, int filter)
         {
             int sum = 0;

                foreach (int number in array)
                {
                    if (number > filter)
                    {
                        sum += number;
                    }
                }

             return sum;
         }
    }
}