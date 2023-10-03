using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task
{
    public class Motorbike : Vehicle
    {
        public bool storage;
        public string storageCapacity;

        public Motorbike()
        {
            this.storageCheck();
            this.getStorageCapacity();
        }

        public Motorbike(bool storage, string storageCapacity)
        {
            this.storage = storage;
            this.storageCapacity = storageCapacity;
        }

        private void storageCheck()
        {
            int storageChoice;
            Console.WriteLine("Do you have storage bags?\n");
            Console.WriteLine("1. Yes\n");
            Console.WriteLine("2. No\n");
            storageChoice = Convert.ToInt32(Console.ReadLine());

            if (storageChoice == 1) 
            {
                storage = true;
            }
            else if (storageChoice == 2)
            {
                storage = false;
            }
        }

        private void getStorageCapacity()
        {
            if (storage == true)
            {
                Console.WriteLine("Storage Capacity:");
                storageCapacity = Console.ReadLine();
            }
            else if (storage == false) 
            {
                Console.WriteLine("There is no storage bag");
            }

        }

        public void display()
        {
            if (storage == true)
            {
                Console.WriteLine("Make: " + this.make + "\n"
                   + "Model: " + this.model + "\n"
                   + "Build Year: " + this.year + "\n"
                   + "Fuel left: " + this.fuel + "\n"
                   + "Storage Bags: " + this.storage + "\n"
                   + "storage Capacity: " + this.storageCapacity + "\n");
            }
            else if (storage == false)
            {
                Console.WriteLine("Make: " + this.make + "\n"
                  + "Model: " + this.model + "\n"
                  + "Build Year: " + this.year + "\n"
                  + "Fuel left: " + this.fuel + "\n"
                  + "Storage Bags: " + this.storage + "\n");
            }
            
        }

        public void updateMotorbike()
        {
            getStorageCapacity();
            storageCheck();


        }
    }
}
