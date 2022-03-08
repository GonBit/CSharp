using System;

namespace SafariParkApp;

public class SafariPark
{
    public static void Main(string[] agrs)
    {
        #region Creating objects
        //Instatiating objects
        //Person james = new Person("James", "Dickson", 12);
        //Console.WriteLine(james.FullName);

        //Person david = new Person("David", "Cull", 5);
        //Console.WriteLine(david.FullName);
        //david.Age = -1;

        //Using construtor overloading
        //Person steven = new Person("Steven");
        //Console.WriteLine(steven.FullName);

        //Object Initializers
        //var arr = new int[] { 1, 2, 3 };

        //var marian = new Person("Marian", "Dumitriu") { Age = 98 }; //Object Initializer

        //Default construtor in shopping basket
        //C# gives you a "free" construtor if you don't add any
        //var shoppingBasket = new ShoppingBasket() { Bread = 2, Eggs = 6, Milk = 2};

        //var nish = new Person("Nish", "Mandal") { Age = 32};
        //var nish = new Person() { _firstName = "Nish", _lastName = "Mandal", Age = 32 };

        //var spartan = new Spartan() { FirstName = "Nish", LastName = "Mandal", Stream = "Yes" }; 
        //With init keyword - init turns it readonly
        //var spartan2 = new Spartan() { FirstName = "Ned", LastName="Nedson", Degree= "Yes" , Stream= "Okay" };
        //var person = new Person() {  _firstName = "Jay",_lastName = "Z", Age = 50};
        //var pt3d = new Point3D(1, 2, 3);
        //DemoMethod(person, pt3d);
        //Console.WriteLine($"{pt3d.y}. Jay Z's age: {person.Age}");//From DemoMethod so y is 2 and Age is 92
        #endregion
        #region Inheritance
        //Hunter h = new Hunter("Gaurav", "Dogra", "Nikon") { Age = 22};
        //Hunter h1 = new Hunter("Goncalo", "Nunes", " Leica") { Age = 28};
        //Console.WriteLine(h.Age);
        //Console.WriteLine(h.Shoot());

        //Just worry about the inheritance aspect of this
        //Console.WriteLine(h1.GetHashCode());
        //Console.WriteLine(h1.GetType());        
        //Console.WriteLine(h1.Equals(h));
        //Console.WriteLine(h1.ToString());

        //Different ways of calling 
        /*var rec1 = new Rectangle(10,10);
        Rectangle rec2 = new Rectangle(11, 2);
        Shape rec3 = new Rectangle(10, 102);
        rec3.CalculateArea();//when i declare it this way i only get access to object methods

        var arrRecs = new Shape[] { rec1, rec2, rec3 };
        foreach (var n in arrRecs)
        {
            Console.WriteLine(n.CalculateArea());
        }
        */
        #endregion

        Airplane a = new Airplane(200, 100, "JetsRUs"){NumPassengers = 150};
        a.Ascend(500); 
        Console.WriteLine(a.Move(3));
        Console.WriteLine(a); 
        a.Descend(200); 
        Console.WriteLine(a.Move()); 
        a.Move(); 
        Console.WriteLine(a);
    }

    static void DemoMethod(Person p, Point3D pt)//From Point3D
    {
        pt.y = 1000;
        p.Age = 92;
    }
}