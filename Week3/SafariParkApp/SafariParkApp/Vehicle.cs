using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        private int _capacity;
        private int _numPassengers;       

        public int Position
        {
            get;
            private set;
        }
        public int Speed
        {
            get;
            init;
        } = 10; // I can do that without putting in the construtor
        public int NumPassengers
        {
            get
            {
                return _numPassengers;
            }
            set
            {
                if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Invalid number of Passengers");
                }
                else _numPassengers = value;
            }
        }

        public Vehicle()
        {
            //Redundant code because the set values are 0
            //NumPassengers = _capacity;
            //Speed = 10;            
        }
        public Vehicle(int capacity, int speed = 10)
        {
            NumPassengers = capacity;            
            Speed = speed;
        }

        public string Move()
        {
            Position = Speed;
            return $"Moving along";
        }

        public string Move(int times)
        {
            Position = times * Speed;
            return $"Moving along {times} times";
        }

        
    }
}
