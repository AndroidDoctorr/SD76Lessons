using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Airplane, Boat, Segway }
    public class Vehicle
    {
        // 1 - Access modifier
        // 2 - Type
        // 3 - Name
        // 4 - Getters and Setters

        // 1     2     3        4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType Type { get; set; }

        public bool IsRunning { get; private set; }

        // Method (class method or instance method)

        // 1 - access modifier
        // 2 - return type
        // 3 - Method signature
        //    a - Name
        //    b - Parameters
        // 4 - Body (the part that runs)

        // 1    2     3a  3b
        public void TurnOn()
        // 4
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turn the vechicle off");
        }
    }
}
