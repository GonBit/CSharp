using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Airplane : Vehicle
    {
        public string _airline;        
        public int Altitude { get; private set; }

        public Airplane(int capacity) : base(capacity) 
        {
           
        }
        public Airplane(int capacity , int speed, string airline): base(capacity,speed) 
        {                       
            _airline = airline;   
        }
        public void Ascend(int distance)
        {
            Altitude += distance; 
        }
        public void Descend(int distance)
        {
            Altitude -= distance;
        }
        public override string Move()
        {           
            return $"{base.Move()} altitude of {Altitude} meters.";
        }
        public override string Move(int times)
        {            
            return $"{base.Move(times)} at an altitude of {Altitude} meters.";
        }
        public override string ToString()
        {            
            return $"Thank you for flying {_airline}.{base.ToString()} capacity: {_capacity}: passengers {NumPassengers}: speed: {Speed} position: {_position} altitude : {Altitude}";
        }

    }
}
