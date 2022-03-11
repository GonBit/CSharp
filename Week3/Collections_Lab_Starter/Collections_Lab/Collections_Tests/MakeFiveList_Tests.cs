using NUnit.Framework;
using Collections_Lib;

namespace CollectionsExercisesTests
{
    public class MakeFiveList_Tests
    {
        [TestCase(0)]
        public void WhenNis0TheListisEmpty(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.AreEqual(0, result.Count);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void WhenNis1to4TheListisEmpty(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.That(result, Is.Empty);
        }

        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        public void WhenNis5to9TheListHasOneElement(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.That(result.Count, Is.EqualTo(1));
        }

        [TestCase(5)]
        [TestCase(7)]
        [TestCase(9)]
        public void WhenNis5to9TheListContains5(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.That(result[0], Is.EqualTo(5));
        }

        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void WhenNis95to99TheListHas19Elements(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            Assert.That(result.Count, Is.EqualTo(19));
        }

        [TestCase(95)]
        [TestCase(97)]
        [TestCase(99)]
        public void WhenNis95to99TheLastElementIs95(int n)
        {
            var result = ListExercises.MakeFiveList(n);
            var lastPos = result.Count - 1;
            Assert.That(result[lastPos], Is.EqualTo(95));
        }
    }
}