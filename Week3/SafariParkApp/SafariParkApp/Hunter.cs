using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person //Inherite from person
    {
        private string _camera;
        public Hunter()
        {

        }

        public Hunter(string fName, string lName, string camera = "") /* : base(fName , lName)*/
        { 
            _camera = camera;            
        }
        
        public string Shoot()
        {
            var fullname = $"{base._firstName} {base._lastName}";
            return $"{fullname} has taken a photo with the {_camera}";
        }

        public /*sealed doesn't allow */ override string ToString()
        {
            return $"{base.ToString()} Camera: {_camera}";//Ensure the ToString method does what the method do.            
            
        }
    }

    public class MonsterHunter : Hunter
    {
        public override string ToString()
        {
            return "I am a Monster Hunter";
            

        }
    }
}
