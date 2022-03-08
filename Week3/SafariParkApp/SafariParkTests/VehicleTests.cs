using NUnit.Framework;
using SafariParkApp;
using System;

namespace SafariParkTests
{
    //testing classes
    public class VehicleTests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.AreEqual(20, v.Position);
            Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();
            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }

        [TestCase (-5)]
        [TestCase (15)]
        public void WhenTheVehicleGetsInvalidValuesforThePassengers(int n)
        {
            var pass = new Vehicle();                      
            Assert.That(() => pass.NumPassengers = n, Throws.TypeOf<ArgumentException>().With.Message.Contain("Invalid number of Passengers"));
        }

        ////First test
        //[Test]
        //public void GetPassengers()
        //{
        //    var pass = new Vehicle();
        //    Assert.That(() => pass.NumPassengers = -5, Throws.TypeOf<ArgumentException>().With.Message.Contain("Invalid number of Passengers"));
        //}

    }
}
