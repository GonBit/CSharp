using NUnit.Framework;
using Op_CtrlFlow;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [Test]        
        public void MyMethod_ReturnsCorrectAverage(int average)
        {
                    
            Assert.That(true, Is.EqualTo(average));

        }


        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_Average_ReturnsZero()
        {
            var myList = new List<int>() {};
            Assert.That(Exercises.Average(myList), Is.EqualTo(0));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }


        [TestCase(39, "Fail")]
        [TestCase(-1, "Invalid mark")]
        [TestCase(40, "Pass")]
        [TestCase(60, "Pass with Merit")]
        [TestCase(75, "Pass with Distinction")]
        [TestCase(102, "Invalid mark")]
        public void CheckIfGradeReturnsExpectedValue(int grade, string expectedMark)
        {
            var result = Exercises.Grade(grade);
            Assert.That(result, Is.EqualTo(expectedMark));
        }

        
        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 75)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void CheckIfSwitchReturnsProperAttendees(int covidLevel, int expectedAttendees)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(result, Is.EqualTo(expectedAttendees));
        }
    }
}
