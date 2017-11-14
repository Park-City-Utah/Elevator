using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        private const int FLOORS_IN_BLDING = 5;
        private const int PIN_ATTEMPT_LIMIT = 5;
        private const int PENTHOUSE = 5;

        private int currentFloor;
        private string pin;

        public Elevator()
        {
            Console.WriteLine("Please enter a PIN");
            this.pin = Console.ReadLine();
        }

        public void callElevator()
        {
            Console.WriteLine("Please select a floor between 1 and 5");
            int selectedFloor = Convert.ToInt32(Console.ReadLine());
            if (0 < selectedFloor && selectedFloor <= FLOORS_IN_BLDING)
            {
                Console.WriteLine("You have selected floor: " + selectedFloor);
                //move
                moveElevator(selectedFloor);
            }
            else
            {
                Console.WriteLine("You have selected and incorrect floor!");
            }
        }

        //Will allow elevator to move currentFloor = selectedFloor
        public void moveElevator(int selectedFloor)
        {
            if (0 < selectedFloor && selectedFloor < PENTHOUSE)
            {
                this.currentFloor = selectedFloor;
                Console.WriteLine("You have arrived at floor: " + this.currentFloor + ". Goodbye");

            }
            else if (selectedFloor == PENTHOUSE)
            {
                if (enterPin())
                {
                    this.currentFloor = selectedFloor;
                    Console.WriteLine("You have arrived at floor: " + this.currentFloor + ". Goodbye");
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
        }

        //Allows for penthouse acccess
        public bool enterPin()
        {
            int noAttempts = 0;
            bool result = false;
            string myPin;

            do {
                Console.WriteLine("Please enter your pin for penthouse access: ");
                myPin = Console.ReadLine();
                result = validatePin(myPin);
                if (result)
                {
                    Console.WriteLine("Acces Granted");
                    return true;
                }else
                {
                    Console.WriteLine("Incorrect pin.");
                    noAttempts++;
                }
            }while(result == false && noAttempts < PIN_ATTEMPT_LIMIT);

            Console.WriteLine("Number of attempts exceeded.");
            return false;
        }

        public bool validatePin(string myPin)
        {
            if (this.pin == myPin)
                return true;
            else
                return false;
        }
       

    }
}
