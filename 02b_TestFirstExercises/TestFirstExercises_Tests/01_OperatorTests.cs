using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class OperatorTests
    {
        [TestCase(5, 2, true)]
        [TestCase(2, 5, false)]
        [TestCase(5, 5, true)]
        public void GivenTwoNumbersXY_GreaterEqual_ReturnsWhetherXIsGreatorOrEqualToY(int x, int y, bool expResult)
        {
            Assert.That(Methods.GreaterEqual(x, y), Is.EqualTo(expResult));
        }

        [TestCase(0, 10.429)]
        [TestCase(10, 24.714)]
        public void GivenNumber_BODMAS_ReturnsTheExpectedResult(int num, double expResult)
        {
            Assert.That(Methods.BODMAS(num), Is.EqualTo(expResult));
        }

        [TestCase(-2)]
        [TestCase(0)]
        [TestCase(2)]
        [TestCase(348)]
        public void WhenTheArgumentIsEven_EvenOdd_ReturnsTrue(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsTrue(result);
        }

        [TestCase(-3)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(347)]
        public void WhenTheArgumentIsOdd_EvenOdd_ReturnsFalse(int x)
        {
            var result = Methods.EvenOdd(x);
            Assert.IsFalse(result);
        }
    }
}
