using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task
{
    public class Truck : Vehicle
    {
        public string cargoLimit;
        public string towingLimit;

        public Truck()
        {
            this.getCargoLimit();
            this.getTowingLimit();
        }

        public Truck(string cargoLimit, string towingLimit)
        {
            this.cargoLimit = cargoLimit;
            this.towingLimit = towingLimit;
        }

        private void getCargoLimit()
        {
            Console.WriteLine("Cargo Limit:");
            cargoLimit = Console.ReadLine();
        }

        private void getTowingLimit()
        {
            Console.WriteLine("Towing Limit:");
            towingLimit = Console.ReadLine();
        }

        public void display()
        {

            Console.WriteLine("Make: " + this.make + "\n"
                   + "Model: " + this.model + "\n"
                   + "Build Year: " + this.year + "\n"
                   + "Fuel left: " + this.fuel + "\n"
                   + "Cargo Limit: " + this.cargoLimit + "\n"
                   + "Towing Limit: " + this.towingLimit + "\n");
        }

        public void updateTruck()
        {
            Console.WriteLine("Please update cargo limit:");
            cargoLimit = Console.ReadLine();
            Console.WriteLine("Please update towing limit:");
            towingLimit = Console.ReadLine();
           

        }



    }
}
