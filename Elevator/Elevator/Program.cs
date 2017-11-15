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
            Elevator elevatorOne = new Elevator("1234");
            elevatorOne.callElevator();
            Console.ReadLine();
        }
    }
}