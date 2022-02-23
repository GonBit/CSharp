using CodeToTest;
using NUnit.Framework;

namespace TestLesson1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

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

        //Invalid Input
        [TestCase(-12)]
        [TestCase(25)]        
        [TestCase(24)]
        public void GivenAtimeInvalid(int time)
        {

            Assert.That("Invalid Input", Is.EqualTo(Program.Greeting(time)));

        }

        /*        
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
}