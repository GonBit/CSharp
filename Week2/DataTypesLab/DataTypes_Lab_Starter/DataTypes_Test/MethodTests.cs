using NUnit.Framework;
using DataTypes_Lib;

namespace DataTypes_Test
{
    public class MethodTests
    {
        [TestCase(1, 1)]
        [TestCase(10, 3628800)]
        [TestCase(12, 479001600)]
        [TestCase(13, 6227020800)]
        [TestCase(20, 2432902008176640000)]
        public void Factorial_Returns_CorrectInteger(int n, long expResult)
        {
            var result = Methods.Factorial(n);
            Assert.That(result, Is.EqualTo(expResult));
        }

        [Test]
        public void Mult_ReturnsCorrectProductOfFloats()
        {
            var result = Methods.Mult(2.1f, 3.0f);
            Assert.That(result, Is.EqualTo(6.30000f).Within(2).Ulps); //Units in the Last Place            

        }
    }
}