using FizzBuzzApp;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class FizzBuzzShould
    {        
        [TestCase(1 , "1")]
        [TestCase(2 , "2")]
        public void GivenNumberNotDivisible_Return_NumberString(int input, string expected)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo(expected));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(12)]        
        public void GivenANumberDivisibleByThree_ReturnFizz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Fizz"));
        }
        
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        [TestCase(25)]        
        public void GivenANumberDivisibleByFive_ReturnBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]        
        public void GivenANumberDivisibleByFifteen_Return_FizzBuzz(int input)
        {
            Assert.That(Program.FizzBuzz(input), Is.EqualTo("FizzBuzz"));
        }
    }
}