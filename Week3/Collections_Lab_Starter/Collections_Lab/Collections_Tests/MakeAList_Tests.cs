using NUnit.Framework;
using Collections_Lib;
using System.Collections.Generic;

namespace CollectionsExercisesTests
{
    public class MakeAList_Tests
    {
        [Test]
        public void IfTheListIsEmptyAnEmptyListIsReturned()
        {
            var argList = new List<string>();
            var result = ListExercises.MakeAList(argList);
            Assert.That(result, Is.Empty);
        }
        [Test]
        public void IfTheListHasNoWordsStartingWithAAnEmptyListIsReturned()
        {
            var argList = new List<string> { "Cat", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void IfTheListHasTwoWordsStartingWithAListOfSize2IsReturned()
        {
            var argList = new List<string> { "Cat", "Aarvaark", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.That(result.Count, Is.EqualTo(2));
        }
        [Test]
        public void IfTheListHasTwoWordsStartingWithATheCorrectWordsAreReturned()
        {
            var argList = new List<string> { "Cat", "Aardvark", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.That(result, Does.Contain("Aardvark"));
            Assert.That(result, Does.Contain("ant"));
        }
        [Test]
        public void IfTheListHasaWordsStartingWithaTheWordIsReturned()
        {
            var argList = new List<string> { "Cat", "ant", "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Does.Contain("ant"));
        }
        [Test]
        public void IfTheListHasaWordsStartingWithATheWordIsReturned()
        {
            var argList = new List<string> { "Cat", "Aardvark",  "Dog", "Budgie" };
            var result = ListExercises.MakeAList(argList);
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result, Does.Contain("Aardvark"));
        }
    }
}
