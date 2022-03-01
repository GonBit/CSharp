using NUnit.Framework;
using ExceptionsApp;
using System;

namespace ExceptionTests
{
    public class GradeTests
    {
        [TestCase(-43)]
        [TestCase(-1)]
        public void WhenTheMarkIsLessThanZero_Grade_ThrowsAnException(int mark)
        {

            //Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<>() //
                .With.Message.Contain("Invalid data"));

        }

        [TestCase(123)]
        public void WhenTheMarkIsMoreThanHundred_Grade_ThrowsAnException(int mark) {

            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>()
                .With.Message.Contain("is above 100"));
        
        }
    }
}