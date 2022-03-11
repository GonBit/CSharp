using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person, IShootable //Inherite from person
    {
        public IShootable Shooter { get; init; }
        public Hunter()
        {

        }

        public Hunter(string fName, string lName, IShootable shooter) 
        {
            FirstName = fName;
            LastName = lName;
            Shooter = shooter;            
        }
        
        public string Shoot()
        {
            return Shooter.Shoot();
        }

        public /*sealed doesn't allow */ override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter}";//Ensure the ToString method does what the method do.            
            
        }
    }

}
