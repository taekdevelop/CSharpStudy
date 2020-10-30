using System;
using static System.Console;

namespace Chapter06
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("1번 ");
            One();
            Print("");

            Print("3번 ");
            Three();
            Print("");
        }

        static void Print(string message)
        {
            WriteLine(message);
        }

        static double Square(double arg)
        {
            return arg * arg;
        }

        static void One()
        {
            Write("수를 입력하세요 : ");

            double data = double.Parse(ReadLine());

            WriteLine("결과 : " + Square(data));
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

        static void Three()
        {
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);

            WriteLine("{0} + {1} = {2}", x, y, resultB);
        }
    }
}
