using System;

namespace SafariParkApp;

public class SafariPark
{
    public static void Main(string[] agrs)
    {
        //Instatiating objects
        Person james = new Person("James", "Dickson", 12);
        Console.WriteLine(james.FullName);

        Person david = new Person("David", "Cull", 5);
        Console.WriteLine(david.FullName);
        david.Age = -1;

        //Using construtor overloading
        //Person steven = new Person("Steven");
        //Console.WriteLine(steven.FullName);

        //Object Initializers
        var arr = new int[] { 1, 2, 3 };

        //var marian = new Person("Marian", "Dumitriu") { Age = 98 }; //Object Initializer

        //Default construtor in shopping basket
        //C# gives you a "free" construtor if you don't add any
        var shoppingBasket = new ShoppingBasket() { Bread = 2, Eggs = 6, Milk = 2};

        //var nish = new Person("Nish", "Mandal") { Age = 32};
        //var nish = new Person() { _firstName = "Nish", _lastName = "Mandal", Age = 32 };

        //var spartan = new Spartan() { FirstName = "Nish", LastName = "Mandal", Stream = "Yes" }; 
        //With init keyword - init turns it readonly
        var spartan2 = new Spartan() { FirstName = "Ned", LastName="Nedson", Degree= "Yes" , Stream= "Okay" };        
    }
}