using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    delegate void MyDelegate(int a);

    class Two
    {
        public event MyDelegate CustomerEvent;

        public void BuySomething(int customerNo)
        {
            if (30 == customerNo)
            {
                CustomerEvent(customerNo);
            }
        }
    }
}
