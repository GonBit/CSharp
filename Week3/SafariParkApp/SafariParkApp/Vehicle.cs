using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Vehicle
    {
        protected int _capacity;
        protected int _position; 
        private int _numPassengers;
        
        

        public int Position
        {
            get { return _position; }
            private set { _position = value; }
        }
        public int Speed
        {
            get;
            init;
        } // I can do that without putting in the construtor
        public int NumPassengers
        {
            get
            {
                return _numPassengers;                
            }
            set
            {
                /*if (value > 10 || value < 0)
                {
                    throw new ArgumentException("Invalid number of Passengers");
                }
                else _numPassengers = value;*/
                _numPassengers = value <= _capacity ? _numPassengers = value : _numPassengers = 0;                                    
            }
        }
        //public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public Vehicle()
        {
            //Redundant code because the set values are 0
            //NumPassengers = _capacity;
            //Speed = 10;            
        }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;            
            Speed = speed;
        }

        public virtual string Move()
        {
            Position += Speed;
            return $"Moving along";
        }

        public virtual string Move(int times)
        {
            Position = times * Speed;
            return $"Moving along {times} times";
        }      
        
    }
}
