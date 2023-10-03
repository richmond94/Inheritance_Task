using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task
{
    public class Car : Vehicle
    {
        public int doors;
        public int seats;

        public Car()
        {
            this.GetDoors();
            this.getSeats();
        }

        public Car(int doors, int seats)
        {
            this.doors = doors;
            this.seats = seats;
        }

        private void GetDoors()
        {
            Console.WriteLine("How Many Doors:");
            doors = Convert.ToInt32(Console.ReadLine());
        }

        private void getSeats()
        {
            Console.WriteLine("How Many Seats:");
            seats = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {

            Console.WriteLine("Make: " + this.make + "\n"
                   + "Model: " + this.model + "\n"
                   + "Build Year: " + this.year + "\n"
                   + "Fuel left: " + this.fuel + "\n"
                   + "Doors: " + this.doors + "\n"
                   + "Seats: " + this.seats + "\n");
        }
        public void updateCar()
        {
            Console.WriteLine("Please update doors:");
            doors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please update seats:");
            seats = Convert.ToInt32(Console.ReadLine());


        }


    }
}
