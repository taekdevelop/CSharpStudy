using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; ++i)
            {
                arr[i] = i;
            }

            for (int i = 0; i < 11; ++i)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch(IndexOutOfRangeException e) when (i >= arr.Length)
                {
                    Array.Resize<int>(ref arr, 11);
                    Console.WriteLine(e.Message + " 11 크기로 변경함.");
                }
            }
        }
    }
}
