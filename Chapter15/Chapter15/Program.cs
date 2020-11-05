using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15
{
    class Program
    {
        delegate void PrintMessage(string str);

        static void Main(string[] args)
        {
            PrintMessage message = delegate (string str) { Console.WriteLine(str); };

            message.Invoke("1번");
            One();
            message.Invoke("");

            message.Invoke("2번");
            Two();
            message.Invoke("");
        }

        static void One()
        {
            Car[] cars =
            {
                new Car() { Cost = 56, MaxSpeed = 120},
                new Car() { Cost = 70, MaxSpeed = 150},
                new Car() { Cost = 45, MaxSpeed = 180},
                new Car() { Cost = 32, MaxSpeed = 200},
                new Car() { Cost = 82, MaxSpeed = 280},
            };

            //var selected = from car in cars
            //               where car.Cost >= 50 && car.MaxSpeed >= 150
            //               select car;

            var selected = cars
                            .Where(car => car.Cost >= 50 && car.MaxSpeed >= 150);

            foreach(var selectedCar in selected)
            {
                Console.WriteLine("Cost : " + selectedCar.Cost + ", MaxSpeed : " + selectedCar.MaxSpeed);
            }
        }

        static void Two()
        {
            Car[] cars =
            {
                new Car() { Cost = 56, MaxSpeed = 120},
                new Car() { Cost = 70, MaxSpeed = 150},
                new Car() { Cost = 45, MaxSpeed = 180},
                new Car() { Cost = 32, MaxSpeed = 200},
                new Car() { Cost = 82, MaxSpeed = 280},
                new Car() { Cost = 12, MaxSpeed = 100},
                new Car() { Cost = 22, MaxSpeed = 110},
            };

            var selected = from car in cars
                           where car.Cost < 60
                           orderby car.Cost ascending
                           select car;

            foreach (var selectedCar in selected)
            {
                Console.WriteLine("Cost : " + selectedCar.Cost + ", MaxSpeed : " + selectedCar.MaxSpeed);
            }
        }
    }
}
