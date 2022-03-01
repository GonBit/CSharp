using NUnit.Framework;
using DataTypes_Lib;
using System;

namespace DataTypes_Test
{
    public class TypeConversionTests
    {
        [TestCase(88u, 88)]
        [TestCase(0u, 0)]
        [TestCase(32_767u, 32_767)]
        public void WhenGivenAValidUInt_UIntToShort_ReturnsAShort(uint before, short expAfter)
        {
            var after = TypeConversion.UIntToShort(before);
            Assert.That(after, Is.InstanceOf<short>());
            Assert.That(after, Is.EqualTo(expAfter));
        }

        [Test]
        public void WhenGivenAnInvalidUInt_UIntToShort_ThrowsAnException()
        {
            uint before = short.MaxValue + 1;
            Assert.That(() => TypeConversion.UIntToShort(before), Throws.InstanceOf<OverflowException>()); 
        }

        [TestCase(0f, 0L)]
        [TestCase(-100_000f, -100_000L)]
        [TestCase(100_000f, 100_000L)]
        public void WhenGivenAnIntegralFloat_FloatToLong_ReturnsALong(float before, long expAfter)
        {
            var after = TypeConversion.FloatToLong(before);
            Assert.That(after, Is.InstanceOf<long>());
            Assert.That(after, Is.EqualTo(expAfter));
        }

        [TestCase(-100_000.678f, -100_001L)]
        [TestCase(100_000.678f, 100_001L)]
        public void WhenGivenANonItegralFloat_FloatToLong_ReturnsARoundedLong(float before, long expAfter)
        {
            var after = TypeConversion.FloatToLong(before);
            Assert.That(after, Is.InstanceOf<long>());
            Assert.That(after, Is.EqualTo(expAfter));
        }
    } 
}
