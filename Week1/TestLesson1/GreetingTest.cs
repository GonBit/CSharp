using CodeToTest;
using NUnit.Framework;
using System;

namespace TestLesson1
{
    public class Tests
    {
        [Category("Exceptions")]
        [TestCase(25)]
        [TestCase(-1)]        
        public void WhenTimeIsAbove25_ThrowsException(int time)
        {
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>());
        
        }



        //Good morning
        //Test cases 3 of the possible values for the same method
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenAtimeBetween5and12Inclusive_Greeting_returnGoodMorning(int time)
        {

            Assert.That("Top of the morning", Is.EqualTo(Program.Greeting(time)));

        }

        //Good afternoon
        [Category("Edge Case")]
        [TestCase(12, "Top of the morning")]
        [TestCase(13, "Good afternoon")]
        public void GivenAtime_Greeting_ReturnsCorrectMessage(int time, string expected)
        {

            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));

        }

        //Good evening
        [TestCase(18, "Good afternoon")]
        [TestCase(4, "Good evening")]
        public void GivenAtimeBetween18and5(int time, string expected)
        {

            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));

        }
        /* 
        //Invalid Input
        [TestCase(-12)]
        [TestCase(25)]        
        [TestCase(24)]
        public void GivenAtimeInvalid(int time)
        {

            Assert.That("Invalid Input", Is.EqualTo(Program.Greeting(time)));

        }

               
        [Test]
        public void GivenATimeOf21_Greeting_ReturnGoodEvening()
        {
            //Arrange
            var time = 21;
            var expected = "Good evening";
            //Act
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void GivenAtTimeOf12_ReturnGoodMorning() 
        { 
            //Arrange
            var time = 12;
            var expected = "Top of the morning";
            //Act
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expected));


        }*/

    }

    public class LabTests
    {

        [Category("Classic Tests")]
        [TestCase(-1, "Invalid age.")]
        [TestCase(1, "U, PG films are available.")]
        [TestCase(11, "U, PG films are available.")]
        [TestCase(12, "U, PG , 12 & 12A films are available.")]
        [TestCase(14, "U, PG , 12 & 12A films are available.")]
        [TestCase(15, "U, PG, 12, 12A & 15 films are available.")]
        [TestCase(16, "U, PG, 12, 12A & 15 films are available.")]
        [TestCase(18, "All films are available.")]
        [TestCase(50, "All films are available.")]
        public void CorrectClassification(int age, string expected)
        {

            Assert.That(expected, Is.EqualTo(Program.AvailableClassifications(age)));

        }

    }
}