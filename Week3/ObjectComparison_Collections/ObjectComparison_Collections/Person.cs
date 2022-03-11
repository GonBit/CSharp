using System;
using System.Threading.Tasks;
public class Person : IEquatable<Person?> , IComparable<Person>//Quick actions and refactoring , Equals and Hashcode

{
    private string _firstName;
    private string _lastName;
    private int _age;
    public Person() { }
    public Person(string fName, string lName)
    {
        _firstName = fName;
        _lastName = lName;
    }

    public int Age
    {
        get { return _age; }
        set { if (value >= 0) _age = value; }
    }
    //IComparable, use it if you want to sort objects in a list
    public int CompareTo(Person? other)
    {
        //Comparing the objects to sort a list
        if (other == null) return 1;
        if (this._lastName != other._lastName) return this._lastName.CompareTo(other._lastName);
        else if (this._firstName != other._firstName) return this._firstName.CompareTo(other._firstName);
        else return this._age.CompareTo(other._age);
        
    }

    public override bool Equals(object? obj)//takes any object and see if it equals as a Person and then calls Equals
    {
        return Equals(obj as Person);
    }

    public bool Equals(Person? other)//Is the other not null and checks the parameters as the other
    {
        return other != null &&
               _firstName == other._firstName &&
               _lastName == other._lastName &&
               _age == other._age;
    }

    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_firstName, _lastName, _age);
    }

    public static bool operator ==(Person? left, Person? right)
    {
        return EqualityComparer<Person>.Default.Equals(left, right);
    }

    public static bool operator !=(Person? left, Person? right)
    {
        return !(left == right);
    }

    public override string ToString()
    {
        return $"{_firstName} {_lastName} is {_age}";
    }
}