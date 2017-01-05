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
            string x = Console.ReadLine();

            //Create two elevator objects
            Elevator elevatorOne = new Elevator(1);
           // Elevator elevatorTwo = new Elevator(2);

            elevatorOne.callElevator(1);
        }
    }
}