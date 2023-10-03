// See https://aka.ms/new-console-template for more information

using Inheritance_Task;
using System;
using System.Data;
using System.Drawing;

int choice;

Console.WriteLine("Please Create a Car\n");
Car vehicle1 = new Car();
Console.Clear();
Console.WriteLine("Please Create a Motorbike\n");
Motorbike vehicle2 = new Motorbike();
Console.Clear();
Console.WriteLine("Please Create a Truck\n");
Truck vehicle3 = new Truck();
Console.Clear();

while (true)
{
    Console.WriteLine("Vehicle Simulator\n");
    Console.WriteLine("1. Create Vehicle\n");
    Console.WriteLine("2. Display Vehicle\n");
    Console.WriteLine("3. Edit Vehicle\n");
    Console.WriteLine("4. Delete Vehicle\n");
    Console.WriteLine("5. Drive Vehicle\n");
    Console.WriteLine("6. Exit\n");
    Console.WriteLine("\nEnter Your Choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
           
            Console.Clear();
            createVehicle();

            break;

        case 2:

            Console.Clear();
            display();
            



            break;

        case 3:

            Console.Clear();
            updateVehicle();

            break;

        case 4:

            Console.Clear();
            delete();

            break;

        case 5:

            Console.Clear();
            drive();

            break;

        case 6:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }

    

   
}
void createVehicle()
{
    Console.WriteLine("What vehicle do you want to create?\n");
    Console.WriteLine("1. Car\n");
    Console.WriteLine("2. Motorbike\n");
    Console.WriteLine("3. Truck\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            if (vehicle1 == null)
            {
                
                Car vehicle1 = new Car();
                
            }
            else
            {
                Console.WriteLine("You already have a car\n");
            }

            break;

        case 2:

            if (vehicle2 == null)
            {
                Motorbike vehicle1 = new Motorbike();
            }
            else
            {
                Console.WriteLine("You already have a motorbike\n");
            }

            break;

        case 3:

            if (vehicle3 == null)
            {
                Truck vehicle1 = new Truck();
            }
            else
            {
                Console.WriteLine("You already have a Truck\n");
            }

            break;


        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    
}

void display()
{
    Console.WriteLine("What vehicle do you want to Display?\n");
    Console.WriteLine("1. Car\n");
    Console.WriteLine("2. Motorbike\n");
    Console.WriteLine("3. Truck\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            if (vehicle1 == null)
            {
                Console.WriteLine("You do not have a car\n");
            }
            else
            {
                vehicle1.display();
            }

            break;

        case 2:

            if (vehicle2 == null)
            {
                Console.WriteLine("You do not have a motorbike\n");
            }
            else
            {
                vehicle2.display();
            }

            break;

        case 3:

            if (vehicle3 == null)
            {
                Console.WriteLine("You do not have a Truck\n");
            }
            else
            {
                vehicle3.display();
            }

            break;


        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    
    
    
}

void updateVehicle()
{
    Console.WriteLine("What vehicle do you want to update?\n");
    Console.WriteLine("1. Car\n");
    Console.WriteLine("2. Motorbike\n");
    Console.WriteLine("3. Truck\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            if (vehicle1 == null)
            {
                Console.WriteLine("You do not have a car\n");
            }
            else
            {
                Console.WriteLine("Please enter new car details\n");
                vehicle1.updateVehicle();
                vehicle1.updateCar();
                Console.Clear();
            }
            break;

        case 2:

            if (vehicle2 == null)
            {
                Console.WriteLine("You do not have a motorbike\n");
            }
            else
            {
                Console.WriteLine("Please enter new motorbike details\n");
                vehicle2.updateVehicle();
                vehicle2.updateMotorbike();
                Console.Clear();
            }

            break;

        case 3:

            if (vehicle3 == null)
            {
                Console.WriteLine("You do not have a Truck\n");
            }
            else
            {
                Console.WriteLine("Please enter new truck details\n");
                vehicle3.updateVehicle();
                vehicle3.updateTruck();
                Console.Clear();
            }

            break;


        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    
    
    
}

void drive()
{
    Console.WriteLine("Select a vehicle to drive\n");
    Console.WriteLine("1. Car\n");
    Console.WriteLine("2. Motorbike\n");
    Console.WriteLine("3. Truck\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            if (vehicle1 == null)
            {
                Console.WriteLine("You do not have a car\n");
            }
            else
            {
                vehicle1.drive();
            }

            break;

        case 2:

            if (vehicle2 == null)
            {
                Console.WriteLine("You do not have a motorbike\n");
            }
            else
            {
                vehicle2.drive();
            }

            break;

        case 3:

            if (vehicle3 == null)
            {
                Console.WriteLine("You do not have a Truck\n");
            }
            else
            {
                vehicle3.drive();
            }

            break;


        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    
   
   
}

void delete()
{
    Console.WriteLine("Select Vehicle to delete\n");
    Console.WriteLine("1. Car\n");
    Console.WriteLine("2. Motorbike\n");
    Console.WriteLine("3. Truck\n");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:

            if (vehicle1 == null)
            {
                Console.WriteLine("Car is already deleted\n");
            }
            else
            {
                vehicle1 = null;
                Console.WriteLine("Car Deleted\n");
            }

            break;

        case 2:

            if (vehicle2 == null)
            {
                Console.WriteLine("Motorbike is already deleted\n");
            }
            else
            {
                vehicle2 = null;
                Console.WriteLine("Motorbike Deleted\n");
            }

            break;

        case 3:

            if (vehicle3 == null)
            {
                Console.WriteLine("Truck is already deleted\n");
            }
            else
            {
                vehicle3 = null;
                Console.WriteLine("Truck Deleted\n");
            }

            break;


        default:
            Console.WriteLine("Invalid Option");
            break;
    }
    
    
    
}





