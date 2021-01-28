using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void Volume()
        {
            Room closet = new Room(1, 1, 3);
            Console.WriteLine("closet volume: " + closet.Volume);
            Console.WriteLine("closet SA: " + closet.SurfaceArea);

            Room bobsRoom = new Room(12.75, 15.5, 9.5);
            Console.WriteLine("Bob's room volume: " + bobsRoom.Volume);
            Console.WriteLine("Bob's room SA: " + bobsRoom.SurfaceArea);
        }
    }
}
