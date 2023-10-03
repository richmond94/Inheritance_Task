using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task
{
    public class Vehicle
    {
        public string make;
        public string model;
        public string year;
        public int fuel;

        public Vehicle()
        {
            this.GetMake();
            this.getModel();
            this.getYear();
            this.getFuel();
        }

        public Vehicle(string make, string model, string year, int fuel)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.fuel = fuel;

        }



        public void GetMake()
        {
            Console.WriteLine("Enter Make:");
            make = Console.ReadLine();
        }

        private void getModel()
        {
            Console.WriteLine("Enter Model:");
            model = Console.ReadLine();
        }

        private void getYear()
        {
            Console.WriteLine("Enter Year:");
            year = Console.ReadLine();
        }

        private void getFuel()
        {
            Console.WriteLine("How Much Fuel:");
            fuel = Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {

            Console.WriteLine("Make: " + this.make + "\n "
                   + "Model: " + this.model + "\n "
                   + "Build Year: " + this.year + "\n "
                   + "Fuel left: " + this.fuel + "\n ");
        }

        public void updateVehicle()
        {
            Console.WriteLine("Please update make:");
            make = Console.ReadLine();
            Console.WriteLine("Please update model:");
            model = Console.ReadLine();
            Console.WriteLine("Please update year:");
            year = Console.ReadLine();
            Console.WriteLine("Please update Fuel:");
            fuel = Convert.ToInt32(Console.ReadLine());

        }
        
        public void drive()
        {
            if (fuel > 0)
            {
                int miles;
                Console.WriteLine("How many miles will you drive:");
                miles = Convert.ToInt32(Console.ReadLine());
                if (miles > fuel)
                {
                    Console.WriteLine("You do not have enough fuel to make the trip");
                }
                else 
                {
                    fuel = fuel - miles;
                    Console.WriteLine("Fuel left: " + this.fuel + "\n ");
                }
                
            }
            else
            {
                Console.WriteLine("You are out of fuel");
            }
        }

       
    }
}



