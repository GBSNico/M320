using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_001
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;

            while (b != 0)
            {
                z = a % b;

                a = b;

                b = z;
            }

            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return ((a * b) / Calc_ggT((int)a, (int)b));
        }

        public static float Average(int[] values)
        {
            return (float)values.Average();
        }

        public static int Max(int[] values)
        {
            return values.Max();
        }

        public static int Min(int[] values)
        {
            return values.Min();
        }

        public static int ReadInt()
        {
            int number = 0;

            while (number == 0 || int.IsNegative(number))
            {
                Console.WriteLine("Bitte gib eine Zahl die grösser als 0 ist ein:");

                number = Convert.ToInt32(Console.ReadLine());
            }

            return (int)number;
        }
    }
}
