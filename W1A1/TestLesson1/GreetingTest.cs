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


        }
    }
}