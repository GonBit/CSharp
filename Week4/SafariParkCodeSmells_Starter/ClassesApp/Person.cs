using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    // A Class to represent a Person
    public class Person 
    {
        private string _firstName;
        private string _lastName;
        private int _age;       
        private int _houseNo;
        private string _street;
        private string _town;
        public Person() { }
        public Person(string fName, string lName, int hNo = 0, string street = "", string town = "")
        {
            _firstName = fName;
            _lastName = lName;
            _houseNo = hNo;
            _street = street;
            _town = town;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

        public string Move()
        {
            return "Walking along";            
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        public override string ToString()
        {            
            return $"{base.ToString()} Name: {_firstName}  { _lastName} Age: {Age}. {GetAddress()}";
        }

        private string GetAddress()
        {
            return $"Address: {_houseNo} {_street}, {_town}";
        }
    }
}
