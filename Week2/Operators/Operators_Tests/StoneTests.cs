using NUnit.Framework;
using Operators;
using ControlFlowApp;

namespace Operators_Tests
{
    public class Tests
    {


        [Category("Total Stones")]
        [TestCase(156, 11)]
        [TestCase(302 , 21)]
        [TestCase(1500 , 107)]
        public void TotalStones(int totalPounds, int expectedStones)
        {
            var result = Method.GetStones(totalPounds);
            Assert.That(result, Is.EqualTo(expectedStones));

        }

        [Category("Total Pounds")]
        [TestCase(156, 2)]
        [TestCase(302, 8)]
        [TestCase(1500, 2)]
        public void TotalPounds(int poundsLeft, int expectedLeft)
        {
            var result = Method.GetPounds(poundsLeft);
            Assert.That(result, Is.EqualTo(expectedLeft));

        }

        //edge cases
    }
}