using NUnit.Framework;
using Operators;

namespace TestsOperators
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5 , false)]
        [TestCase(8 , true)]
        [TestCase(12 , true)]
        public void EvenOddTest(int number, bool expected)
        {

            Assert.That(number.Equals(Program.EvenOdd));

        }
    }
}