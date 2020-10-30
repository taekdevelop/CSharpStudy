using System;
using System.Collections;

namespace Chapter10
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("2번");
            Two();
            Print();

            Print("5번");
            Five();
            Print();
        }

        static void Print(string message = "")
        {
            Console.WriteLine(message);
        }

        static void Two()
        {
            Matrix a = new Matrix(3, 2, 1, 4);
            Matrix b = new Matrix(9, 2, 1, 7);

            a = a.Multiply(ref b);
        }

        static void Five()
        {
            Hashtable ht = new Hashtable();

            ht["Company"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine($"회사 : {ht["Company"]}");
            Console.WriteLine($"URL : {ht["URL"]}");
        }
    }
}
