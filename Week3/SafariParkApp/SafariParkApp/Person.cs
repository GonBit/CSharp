using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person
    {
        //public so can be accessed outside
        //prop tab tab
        //public int Age { get; set; } 

        // This is the full body of a property
        private int _age;

        public int Age
        {
            get 
            { 
                return _age;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Age cannot be less than 0");
                else
                    _age = value; 
            }
        }

        //they can't be accessed outside of the class
        private string _firstName { get; init; } 
        private string _lastName { get; init; }
                

        //Create a constructor     
        public Person(string firstName, string lastName, int age = 0)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        //only the first name
        public Person(int age)
        { 
            Age = age;
        }

        public Person(string firstName)
        {
            _firstName = firstName;
        }

        public string FullName => $"{_firstName} {_lastName}"; //this is the same as the method but a property

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        

    }
}
