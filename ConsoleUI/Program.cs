using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE
            var vehicles = new List<Vehicle>();
            Car myCar1 = new Car()
            {
                Year = 2022,
                Make = "Ferrari",
                Model = "Spider-x30",
            };
            Motorcylce myBike = new Motorcylce()
            {
                Year = 2003,
                Make = "Kawasaki",
                Model = "Ninja-500",
            };
            Vehicle vehicle1 = new Car()
            {
                Year = 2021,
                Make = "Jeep",
                Model = "Wrangler",
            };
            Vehicle vehicle2 = new Motorcylce()
            {
                Year = 2022,
                Make = "Ducati",
                Model = "AXBZ",
            };
            vehicles.Add(myCar1);
            vehicles.Add(myBike);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Make}-{item.Model}-{item.Year}");
                Console.WriteLine();
            }
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            myCar1.DriveAbstract();
            myBike.DriveVirtual();
            myBike.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
