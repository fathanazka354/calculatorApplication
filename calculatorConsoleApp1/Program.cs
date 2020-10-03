using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi calculator versi App";

            Console.Write("Inputkan a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Hasil Penambahan dari : {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasil Pengurangan dari : {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasil Perkalian dari : {0} x {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil Pembagian dari : {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a,int b)
        {
            return a / b;
        }
    }
}
