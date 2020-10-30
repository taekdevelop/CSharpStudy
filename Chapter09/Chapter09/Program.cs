using System;

namespace Chapter09
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("1번");
            One();
            Print();

            Print("2번");
            Two();
            Print();
        }

        static void Print(string message = "")
        {
            Console.WriteLine(message);
        }

        static void One()
        {
            NameCard myCard = new NameCard();

            myCard.Age = 24;
            myCard.Name = "상현";

            Console.WriteLine("나이 : {0}", myCard.Age);
            Console.WriteLine("나이 : {0}", myCard.Name);
        }

        static void Two()
        {
            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine($"이름 : {nameCard.Name}, 나이 : {nameCard.Age}");

            var complex = new { Real = 3, Imaginary = -12 };
            Console.WriteLine($"Real : {complex.Real}, Imaginary : {complex.Imaginary}");
        }
    }
}
