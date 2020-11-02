using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
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
            One test = new Chapter13.One();

            test.Run();
        }

        static void Two()
        {
            Two test = new Two();
            test.CustomerEvent += delegate(int num)
            {
                Console.WriteLine("축하합니다! " + num + "번째 고객 이벤트에 당첨되셨습니다.");
            };

            for (int i = 0; i < 100; i += 10)
            {
                test.BuySomething(i);
            }
        }
    }
}
