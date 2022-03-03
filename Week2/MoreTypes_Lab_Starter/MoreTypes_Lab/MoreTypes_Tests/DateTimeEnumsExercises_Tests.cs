using System;
using NUnit.Framework;
using MoreTypes_Lib;

namespace MoreTypes_Tests
{
    class DateTimeEnumsExercises_Tests
    {
        [Test]
        public void GivenValidDate_AgeAt_ReturnsCorrectAge()
        {
            var birthDate = new DateTime(1992, 4, 21);
            var date = new DateTime(2020, 5, 27);
            var result = DateTimeEnumsExercises.AgeAt(birthDate, date);
            Assert.That(result, Is.EqualTo(28));
        }

        [Test]
        public void GivenHaventHadBirthdayYet_AgeAt_ReturnsCorrectAge()
        {
            var birthDate = new DateTime(1992, 8, 21);
            var date = new DateTime(2020, 5, 27);
            var result = DateTimeEnumsExercises.AgeAt(birthDate, date);
            Assert.That(result, Is.EqualTo(27));
        }

        [Test]
        public void IfDateIsAfterBirthdate_AgeAt_ThrowsException()
        {
            var birthDate = new DateTime(1992, 8, 21);
            var date = new DateTime(1992, 5, 27);
            Assert.That(() => DateTimeEnumsExercises.AgeAt(birthDate, date), Throws.TypeOf<ArgumentException>()
        .With.Message.EqualTo("Error - birthDate is in the future"));
        }

        [Test]
        public void GivenADateTimeObject_FormatDate_ReturnsAFormattedString()
        {
            var date = new DateTime(2020, 11, 16);
            var result = DateTimeEnumsExercises.FormatDate(date);
            Assert.That(result, Is.EqualTo("20/16/Nov"));
        }

        [Test]
        public void GivenADateTimeObject_GetMonthString_ReturnsTheCorrectMonth()
        {
            var date = new DateTime(2020, 11, 16);
            var result = DateTimeEnumsExercises.GetMonthString(date);
            Assert.That(result, Is.EqualTo("November"));
        }

        [TestCase(Suit.CLUBS, "And the seventh rule is if this is your first night at fight club, you have to fight.")]
        [TestCase(Suit.DIAMONDS, "Diamonds are a girls best friend")]
        [TestCase(Suit.HEARTS, "You've broken my heart")]
        [TestCase(Suit.SPADES, "Bucket and spade")]
        public void GivenASuit_Fortune_ReturnsAnAppropriateMessage(Suit suit, string expectedMessage)
        {
            var result = DateTimeEnumsExercises.Fortune(suit);
            Assert.That(result, Is.EqualTo(expectedMessage));
        }
    }
}
