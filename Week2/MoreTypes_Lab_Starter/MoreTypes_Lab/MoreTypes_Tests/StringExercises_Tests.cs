using NUnit.Framework;
using System;
using MoreTypes_Lib;

namespace MoreTypes_Tests
{
    public class StringExercises_Tests
    {
		[TestCase("  Cathy", 10, "CATHY0123456789")]
        [TestCase("", 4, "0123")]
        [TestCase(" Piano  ", 12, "PIANO01234567891011")]
        public void GivenAString_ManipulateString_ReturnsATransformedString(string original, int num, string expected)
        {
            var result = StringExercises.ManipulateString(original, num);
            Assert.That(result, Is.EqualTo(expected));
        }
		
        [TestCase(5, "Main Street", "Stone", "ST6 2RQ", "5 Main Street, Stone ST6 2RQ.")]
        [TestCase(27, "Town Road", "Hull", "H12 8AA", "27 Town Road, Hull H12 8AA.")]
        public void Address_GivenItsComponents_ReturnsAFormattedAddressString
           (int number, string street, string city, string postcode, string expAddress)
        {
            var result = StringExercises.Address(number, street, city, postcode);
            Assert.That(result, Is.EqualTo(expAddress));
        }
        [TestCase(33, 40, "You got 33 out of 40: 82.5%")]
        [TestCase(18, 65, "You got 18 out of 65: 27.7%")]
        public void GivenATestScore_Scorer_ReturnsAFormattedString(int score, int outOf, string expString)
        {
            var result = StringExercises.Scorer(score, outOf);
            Assert.That(result, Is.EqualTo(expString));
        }
        [Test]
        public void GivenAString_ParseNum_ReturnsTheDoubleRepresentedByTheString()
        {
            Assert.That(StringExercises.ParseNum("3.14159"), Is.EqualTo(3.14159));
        }
        [Test]
        public void GivenAnInvalidDoubleString_ParseNum_ReturnsMinus999()
        {
            Assert.That(StringExercises.ParseNum("twenty-two"), Is.EqualTo(-999));
        }

        [TestCase("BABBDDDBECDCDF", "A:1 B:4 C:2 D:5")]
        [TestCase("", "A:0 B:0 C:0 D:0")]
        [TestCase("NEKISEKMGEZZYK", "A:0 B:0 C:0 D:0")]

        public void CountLettersTest(string input, string expected)
        {
            var result = StringExercises.CountLetters(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}