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

        private int elevatorId;
        private int currentFloor;
        private int selectedFloor;
        private string pin;

        public Elevator(int idIn)
        {
            this.elevatorId = idIn;

        }

        //Allows us to select an elevator
        public void callElevator(int id)
        {
            //move
            moveElevator();
        }

        //Will allow elevator to move currentFloor = selectedFloor
        public void moveElevator()
        {
            if (0 < selectedFloor && selectedFloor < 5)
                this.currentFloor = selectedFloor;
            else if (selectedFloor == 5)
            {
                if (enterPin())
                    this.currentFloor = selectedFloor;

            }
        }

        //Allows for penthouse acccess
        public bool enterPin()
        {
            Console.WriteLine("Please enter your pin for penthour access: ");
            string myPin = Console.ReadLine();
            return validatePin(myPin);
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
