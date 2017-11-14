using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my elevator program");
            Console.WriteLine("Please enter a PIN");
            int myPin = Convert.ToInt32(Console.ReadLine());

            Elevator elevatorOne = new Elevator(myPin);
            elevatorOne.callElevator(1);
        }
    }
}