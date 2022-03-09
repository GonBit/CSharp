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

        /*
        Airplane a = new Airplane(200, 100, "JetsRUs"){NumPassengers = 150};
        a.Ascend(500); 
        Console.WriteLine(a.Move(3));
        Console.WriteLine(a); 
        a.Descend(200); 
        Console.WriteLine(a.Move()); 
        a.Move(); 
        Console.WriteLine(a);*/
        #endregion
        #region Polymorphism
        /*
        List<Object> gameObjects = new List<Object>()
        {
            new Person ("Nish" , "Mandal") { Age = 32},
            new Airplane (400, 200, "Boeing"),
            new Vehicle (12,43),
            new Hunter ("Hunter", "McHunty" , "Hunter")
        };

        foreach (var gameObj in gameObjects)
        {
            //Console.WriteLine(gameObj);
        }*/

        //Yolanda is a person, an object is an object, yolanda is specialized than a stardant object
        //Passing by reference
        //Run time polymorphism(override) . Method overloading is type of compile rime polymorphism
        //Person yolanda = new Person("Yolanda", "Young") { Age = 32};
        //SpartaWrite(yolanda);
        /*
        var a = new Person("Nish", "Mandal") { Age = 32 };

        var b = new Hunter("Hunter", "McHunty", "Hunter");
        SpartaWrite(a);               
        var c = (Person)b;
        SpartaWrite(c);

        var d = a as Hunter;//You can't cast this
        SpartaWrite(d);
        */
        /*
        List<IMoveable> moveables = new List<IMoveable>()
        {
            new Person("Hue", "HueHue"){ Age =42},
            new Vehicle(51,45),
        };

        foreach (var num in moveables)
        { 
            Console.WriteLine(num.Move());
        }*/

        #endregion

        IShootable laser = new LaserGun("Laser Premium");
        IShootable waterPistol = new WaterPistol("H2Wow");
        IShootable hunter = new Hunter("Gaurav", "Dogra", laser);
        IShootable hunter2 = new Hunter("Goncalo", "Nunes", waterPistol);
        IShootable camera = new Camera("Samsung");

        List<IShootable> weapons = new List<IShootable>()
        {
            laser,
            waterPistol,
            hunter,
            hunter2,
            camera            
        };

        foreach (var weapon in weapons)
        {
            Console.WriteLine(weapon.Shoot());
        }
        
    }
    /*
    public static void SpartaWrite(Object obj)
    { 
        Console.Write(obj.ToString());
        if (obj is Hunter)//obj is a hunter cast it to hunter type
        {
            var hunterObj = (Hunter)obj;
            Console.WriteLine(hunterObj.Shoot);
        }
    }*/

    static void DemoMethod(Person p, Point3D pt)//From Point3D
    {
        pt.y = 1000;
        p.Age = 92;
    }
}