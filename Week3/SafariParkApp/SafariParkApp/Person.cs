using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        
        //public so can be accessed outside
        //prop tab tab
        //public int Age { get; set; } 

        // This is the full body of a property
        //they can't be accessed outside of the class
        public string FirstName { get; init; }
        public string LastName { get; init; }
        //private int _age;

        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be less than 0");
                else
                    Age = value; 
            }
        }

        public Person()
        {

        }
        ////Create a constructor     
        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }        

        //only the first name
        public Person(int age)
        {
            Age = age;
        }
        //Overriding my parent classes implementation of ToString()
        public override string ToString()
        {
            return $"{base.ToString()} Name: {FirstName} {LastName} Age: {Age}";
        }

        //public Person(string firstName)
        //{
        //    _firstName = firstName;
        //}

        //public string FullName => $"{_firstName} {_lastName}"; //this is the same as the method but a property

        public string GetFullName()
        {
            
            return $"{FirstName} {LastName}";
        }

        public string Move()
        {
            return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
