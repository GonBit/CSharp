using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Spartan
    {        
        //If you use init you eliminate the need to build a construtor
        //public string FirstName { get;  }
        //public string LastName { get; } 
        //public string Stream { get;  }
        //public string Degree { get; }

        //if you want to put these to read only you get right of the set; and create a constructor

        //public Spartan(string firstName, string lastName, string stream, string degree)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Stream = stream;
        //    Degree = degree;
        //}

        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Stream { get; init; }
        public string Degree { get; init; }
    }
}
