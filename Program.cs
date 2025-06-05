using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlyanovAA
{
    internal class Program
    {
        static public double Sqr(double X)
        {
            return X * X;
        }

        static void TestSqr()
        {
            (double input, double expected)[] tests = new[]
            {
            (2.0, 4.0),
            (-3.0, 9.0),
            (0.0, 0.0),
            (1.5, 2.25),
            (0.1, 0.01)
            };

            foreach (var test in tests)
            {
                double result = Sqr(test.input);
                bool passed = Math.Abs(result - test.expected) < 1e-10; // Учитываем погрешность для дробных чисел
                Console.WriteLine($"Вход: {test.input}, Ожидаем: {test.expected}, Вывод: {result}, {(passed ? "+" : "-")}");
            }
        }

        static void Main()
        {
            TestSqr();
        }
    }
}
//UlyanovAA Am-1-24

//new_feature

//solve task2

//solve task4
