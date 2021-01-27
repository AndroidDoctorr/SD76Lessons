using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class VehicleTests
    {
        [TestMethod]
        public void Properties()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Honda";

            Console.WriteLine(firstVehicle.Make);
            firstVehicle.Make = "CEC";
            firstVehicle.Model = "YT-1300f";
            firstVehicle.Mileage = 24000000;
            firstVehicle.Type = VehicleType.Spaceship;
        }

        [TestMethod]
        public void Methods()
        {
            Vehicle myCar = new Vehicle();
            Console.WriteLine(myCar.IsRunning);
            myCar.TurnOn();
            // myCar.IsRunning = false; <- gives an error because the setter is private
            Console.WriteLine(myCar.IsRunning);
        }
    }
}
