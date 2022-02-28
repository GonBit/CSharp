using System;
using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    class SumEvenFiveTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(9, 25)]
        [TestCase(10, 35)]
        [TestCase(22, 152 )]
        public void SumEvenFive_ReturnsExpectedResult(int n, int expectedSum)
        {
            var result = Methods.SumEvenFive(n);
            Assert.That(result, Is.EqualTo(expectedSum));
        }
        [Test]
        public void GivenAParameterOfZero_SumEvenFive_ReturnsZero()
        {
            var result = Methods.SumEvenFive(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GivenANegativeParameter_SumEvenFive_ReturnsZero()
        {
            var result = Methods.SumEvenFive(-3);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
