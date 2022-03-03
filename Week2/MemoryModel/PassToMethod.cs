using System;

namespace MemoryModel
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    class PassToMethod
    {
        public static void Main()
        {
            Person seb = new Person { FirstName = "Seb", LastName = "Mo", Age = 25 };
            double gaurav = 4.2;
            string jab = DemoMethod(seb, gaurav);
            int james;
            var success = Int32.TryParse("632", out james);
            int marian = 42;
            PassByReference(marian, out int david);
            Console.WriteLine(david);
        }
        public static string DemoMethod(Person steven, double laura)
        {
            steven.LastName = "Sawyer";
            steven.Age = 26;
            laura *= 2;
            return steven.FirstName;
        }

        public static void PassByReference(in int goncalo, out int steven)
        {
            steven = 2 * goncalo;
        }
    }
}
