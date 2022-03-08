using NUnit.Framework;
using SafariParkApp;

namespace SafariParkTests
{   
    //testing classes
    public class PersonTests
    {
        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullName(string fName, string lName, string expected)
        {
            var subject = new Person(fName, lName);
            var results = subject.GetFullName();
            Assert.AreEqual(expected, results);
        }

        [Test]
        public void GetAge()
        {
            var subject = new Person("A","B");
            subject.Age = 35;
            Assert.AreEqual(35, subject.Age);
        }
    }
}