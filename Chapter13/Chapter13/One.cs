using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{

    public class One
    {
        delegate int MyDelegate(int a, int b);

        public void Run()
        {
            MyDelegate Callback;

            Callback = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(Callback(3, 4));

            Callback = delegate (int a, int b)
            {
                return a - b;
            };

            Console.WriteLine(Callback(7, 5));
        }
    }
}
