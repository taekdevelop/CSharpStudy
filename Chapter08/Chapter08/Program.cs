using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("비타민 퀴즈 8 - 1");
            QuizOne();
            Print("");
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        static void QuizOne()
        {
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            monitor.start();
        }
    }
}
