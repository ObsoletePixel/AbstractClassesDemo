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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles
            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var car1 = new Car() {
                HasTrunk = true,
                Year = 2021,
                Make = "BMW",
                Model = "330i"
            };
            var moto1 = new Motorcycle() {
                HasSideCar =  false,
                Year = 2025,
                Make = "Ducati",
                Model = "Desmo"
            };
            Vehicle vehicle1 = new Car() {
                HasTrunk = true,
                Year = 2016,
                Make =  "Jeep",
                Model = "Liberty"
            };
            Vehicle vehicle2 = new Motorcycle() {
                HasSideCar = true,
                Year = 2011,
                Make = "Harley Davidson",
                Model = "Nightster"
            };
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.AddRange(car1,moto1,vehicle1,vehicle2);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year: {vehicle.Year}\n");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("");

            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
