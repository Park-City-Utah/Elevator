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
        private string pin;

        private int currentFloor { get; set; }
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        public Elevator()
        {
            this.pin = "0000";
            this.currentFloor = 1;
        }

        public Elevator(string pinIn)
        {
            this.pin = pinIn;
            this.currentFloor = 1;
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
            if ((0 < selectedFloor) && (selectedFloor < PENTHOUSE))
            {
                floorTravelMessage(selectedFloor);
                this.currentFloor = selectedFloor;
                Console.WriteLine("You have arrived at floor: " + this.currentFloor + ". Goodbye");

            }
            else if (selectedFloor == PENTHOUSE)
            {
                if (enterPin())
                {
                    floorTravelMessage(selectedFloor);
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

            do
            {
                Console.WriteLine("Please enter your pin for penthouse access: ");
                myPin = Console.ReadLine();

                result = validatePin(myPin);
                if (result)
                {
                    Console.WriteLine("Access Granted");
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect pin.");
                    noAttempts++;
                }
            } while ((result == false) && (noAttempts < PIN_ATTEMPT_LIMIT));

            Console.WriteLine("Number of attempts exceeded.");
            return false;
        }

        public bool validatePin(string myPin)
        {
            if (this.pin.Equals(myPin))
                return true;
            else
                return false;
        }

        public void floorTravelMessage(int selectedFloorIn)
        {
            for (int i = this.currentFloor; i <= selectedFloorIn; i++)
            {
                if (i == 1)
                    Console.WriteLine("Floor: Lobby");
                else
                    Console.WriteLine("Floor: " + i);
            }

        }
       

    }
}
