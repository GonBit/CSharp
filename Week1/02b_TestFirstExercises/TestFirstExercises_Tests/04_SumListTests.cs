using NUnit.Framework;
using System.Collections.Generic;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class SumListTests
    {
        [Test]
        public void GivenAList_SumList_ReturnsItsSum()
        {
            var myList = new List<int> { 7, 2, 4, 1, 9 };
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void GivenAnEmptyList_SumList_ReturnsZero()
        {
            var myList = new List<int>();
            var result = Methods.SumList(myList);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
