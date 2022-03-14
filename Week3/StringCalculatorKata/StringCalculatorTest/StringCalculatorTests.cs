using NUnit.Framework;
using StringCalculator;
using System;

namespace StringCalculatorTest
{
    public class StringCalculatorTest
    {

        [TestCase("1,3,4", 8)]
        [TestCase("0,500,15", 515)]
        [TestCase("95,5,23", 123)]
        [TestCase("5,10,20,41", 76)]
        public void GivenAStringOfDigits_Add_ReturnsTheirSum(string input, int expected)
        {
            Assert.That(expected, Is.EqualTo(Program.Add(input)));
        }

        [Test]
        public void GivenEmptyString_Return_Zero()
        {
            Assert.That(0, Is.EqualTo(Program.Add("")));
        }

        [Test]
        public void GivenAStringOfDigitsSeparatedByCommasAndNewLines_Add_ReturnsSum()
        { 
            // Arrange
            var input = "1\n2,3";
            var expected = 6;
            // Act
            var actual = Program.Add(input);
            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void SetADelimiter()
        {
            var input = "//;\n1;2";
            var expected = 3;
            var actual = Program.Add(input);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase("-1,-3,-6", "Negatives not allowed -1 -3 -6 ")]
        [TestCase("-140,-365,-6309","Negatives not allowed -140 -365 -6309 ")]
        public void GivenAStringWithNegativeNumbersThrowsExceptionWithTheNumbers(string numbers, string expected)
        {
            
            Assert.That(() => Program.Add(numbers), Throws.TypeOf<ArgumentException>()
                .With.Message.Contain(expected));
        }
    }
}