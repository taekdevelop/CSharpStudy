using System;

namespace Chapter14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            Action<int> action = (int data) => Console.WriteLine(data * data);

            foreach (var s in array)
            {
                action(s);
            }
        }
    }
}
