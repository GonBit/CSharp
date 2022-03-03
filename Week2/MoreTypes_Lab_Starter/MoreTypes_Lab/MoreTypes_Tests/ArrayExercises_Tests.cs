using MoreTypes_Lib;
using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace MoreTypes_Tests
{
    class ArrayExercises_Tests
    {
        private List<string> _list = new List<string>{ "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta"}; 
        [Test]
        public void GivenAListOfStrings_Make1DArray_ReturnsAnArrayOfTheSameStrings()
        {
            string[] result = ArraysExercises.Make1DArray(_list);
            Assert.That(result.Length, Is.EqualTo(6), "Length incorrect");
            Assert.That(result[0], Is.EqualTo("Alpha"), "First element incorrect");
            Assert.That(result[1], Is.EqualTo("Beta"), "Second element incorrect");
            Assert.That(result[2], Is.EqualTo("Gamma"), "Third element incorrect");
            Assert.That(result[3], Is.EqualTo("Delta"), "Fourth element incorrect");
            Assert.That(result[4], Is.EqualTo("Epsilon"), "Fifth element incorrect");
            Assert.That(result[5], Is.EqualTo("Zeta"), "Last element incorrect");
        }

        [Test]
        public void GivenAListOfStrings_Make3DArray_ReturnsA3DArrayOfTheSameStrings()
        {
            string[,,] result = ArraysExercises.Make3DArray(2, 1, 3, _list);
            Assert.That(result.Length, Is.EqualTo(6), "Length incorrect");
            Assert.That(result[0, 0, 0], Is.EqualTo("Alpha"), "First element incorrect");
            Assert.That(result[0, 0, 1], Is.EqualTo("Beta"), "Second element incorrect");
            Assert.That(result[0, 0, 2], Is.EqualTo("Gamma"), "Third element incorrect");
            Assert.That(result[1, 0, 0], Is.EqualTo("Delta"), "Fourth element incorrect");
            Assert.That(result[1, 0, 1], Is.EqualTo("Epsilon"), "Fifth element incorrect");
            Assert.That(result[1, 0, 2], Is.EqualTo("Zeta"), "Last element incorrect");
        }

        [Test]
        public void GivenLengthsThatDontFitTheListOfStrings_Make3DArray_ThrowAnArgumentException()
        {
            Assert.That(() => ArraysExercises.Make3DArray(2, 2, 3, _list),
                Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo("Number of elements in list must match array size")); ;
        }

        [Test]
        public void GivenAListOfStrings_MakeJagged2DArray_ReturnsAJaggedArrayOfTheSameStrings()
        {
            string[][] result = ArraysExercises.MakeJagged2DArray(2, 4, _list);
            Assert.That(result.Length, Is.EqualTo(2), "Length incorrect");
            Assert.That(result[0][0], Is.EqualTo("Alpha"), "First element incorrect");
            Assert.That(result[0][1], Is.EqualTo("Beta"), "Second element incorrect");
            Assert.That(result[1][0], Is.EqualTo("Gamma"), "Third element incorrect");
            Assert.That(result[1][1], Is.EqualTo("Delta"), "Fourth element incorrect");
            Assert.That(result[1][2], Is.EqualTo("Epsilon"), "Fifth element incorrect");
            Assert.That(result[1][3], Is.EqualTo("Zeta"), "Last element incorrect");
        }

        [Test]
        public void GivenRowSizesThatDontFitTheListOfStrings_MakeJagged2DArray_ThrowAnArgumentException()
        {
            Assert.That(() => ArraysExercises.MakeJagged2DArray(3, 4, _list),
                Throws.TypeOf<ArgumentException>()
                .With.Message.EqualTo("Number of elements in list must match array size")); ;
        }
    }
}
