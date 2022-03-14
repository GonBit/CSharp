using System;
using System.Collections.Generic;

namespace ClassesApp
{
    class Program
    {
        static void SpartaWrite(Object obj)
        {
            Console.WriteLine(obj.ToString());
            if (obj is Hunter)
            {
                var hunterObj = (Hunter)obj;
                Console.WriteLine(hunterObj.Shoot());
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person("Katie", "King");
            Hunter h = new Hunter("Marion", "Jones", new Camera("Leica")) { Age = 32 };
            //Console.WriteLine(h.Age);
            //Console.WriteLine(h.Shoot());
            //Hunter h2 = new Hunter();
            //Console.WriteLine(h2.Shoot());
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");

            //Airplane a = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //List<Object> gameObjects = new List<Object>()
            //{
            //    new Person("Cathy", "French"),
            //    new Airplane(400,200,"Booing"),
            //    new Vehicle(12, 20),
            //    new Hunter("Henry", "Hodgkins", new Camera("Pentax"))
            // };
            //Console.WriteLine();
            //Console.WriteLine("The game objects:");
            //foreach (var gameObj in gameObjects)
            //{
            //    Console.WriteLine(gameObj);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Using the Write method:");
            //Person yolanda = new Person("Yolanda", "Young");
            //Hunter zog = new Hunter("Zog", "Zeldane", new Camera("Fischer Price"));
            //SpartaWrite(yolanda);
            //SpartaWrite(zog);

            //List<IMovable> moveableObjects = new List<IMovable>()
            //{
            //    new Person("John", "Smith"),
            //    new Airplane(400,200,"FrightAir"),
            //    new Vehicle(6, 10),
            //    new Hunter("Jack", "Jameson", new Camera("Minolta"))
            // };

            //Console.WriteLine();
            //Console.WriteLine("Moving the objects:");
            //foreach (var movObj in moveableObjects)
            //{
            //    Console.WriteLine(movObj.Move(3));
            //}

            Console.WriteLine();
            var theWeapons = new List<IShootable>();
            theWeapons.Add(new Weapon(WeaponType.LaserGun, "ToysRUs"));
            theWeapons.Add(new Weapon(WeaponType.Waterpistol, "Supersoaker"));
            theWeapons.Add(new Weapon(WeaponType.LaserGun, "ZippaZap"));
            theWeapons.Add(new Hunter("Cathy", "French", new Camera("Minolta")));
            theWeapons.Add(new Camera("Pentax"));
            foreach (var w in theWeapons)
            {
                Console.WriteLine(w.Shoot());
            }
            Console.WriteLine();
            Console.WriteLine("Polymorphic shootout");
            Camera pentax = new Camera("Pentax");
            var pistol = new Weapon(WeaponType.Waterpistol, "Supersoaker");
            var laserGun = new Weapon(WeaponType.LaserGun, "ZippaZap");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());

        }

    }
}
