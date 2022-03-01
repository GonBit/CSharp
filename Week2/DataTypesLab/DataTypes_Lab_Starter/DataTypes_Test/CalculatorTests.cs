using NUnit.Framework;
using DataTypes_Lib;
using System;

namespace DataTypes_Test
{
    public class CalculatorTests
    {
        [Test]
        public void WhenGivenTwoIntegers_Add_ReturnsCorrectAnswer()
        {
            Assert.That(IntegerCalc.Add(3, 7), Is.EqualTo(10));
        }

        [Test]
        public void WhenGivenTwoVeryLargeIntegers_Add_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Add(int.MaxValue, 3), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void WhenGivenTwoVeryNegativeIntegers_Add_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Add(int.MinValue, -3), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void WhenGivenTwoIntegers_Subtract_ReturnsCorrectAnswer()
        {
            Assert.That(IntegerCalc.Subtract(3, 7), Is.EqualTo(-4));
        }

        [Test]
        public void WhenGivingLargeOperands_Subtract_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Subtract(int.MaxValue, -3), Throws.TypeOf<OverflowException>());
        }

        [Test]
        public void WhenGivingMoreLargeOperands_Subtract_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Subtract(int.MinValue, 3), Throws.TypeOf<OverflowException>());
        }

        [TestCase(9, 3, 3)]
        [TestCase(9, 2, 4)]
        [TestCase(9, -2, -4)]
        public void WhenGivenTwoInts_Divide_ReturnsCorrectAnswer(int num1, int num2, int expAnswer)
        {
            Assert.That(IntegerCalc.Divide(num1, num2), Is.EqualTo(expAnswer));
        }

        [Test]
        public void WhenGivenTwoInts_WhereTheSecondIntIsZero_Divide_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Divide(8, 0), Throws.InstanceOf<ArgumentException>().With.Message.Contains("Can't divide by zero"));
        }

        [TestCase(9, 3, 0)]
        [TestCase(9, 2, 1)]
        [TestCase(9, -2, 1)]
        public void WhenGivenTwoInts_Modulus_ReturnsCorrectAnswer(int num1, int num2, int expAnswer)
        {
            Assert.That(IntegerCalc.Modulus(num1, num2), Is.EqualTo(expAnswer));
        }

        [Test]
        public void WhenGivenTwoInts_WhereTheSecondIntIsZero_Modulus_ThrowsAnException()
        {
            Assert.That(() => IntegerCalc.Modulus(8, 0), Throws.InstanceOf<ArgumentException>().With.Message.Contains("Can't modulo by zero"));
        }
    }
}
