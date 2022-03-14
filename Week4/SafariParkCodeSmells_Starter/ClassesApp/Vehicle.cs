using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    // model answer for Inheritance exercise
    public class Vehicle 
    {
        private int _speed = 10;
        private int _numPassengers;
        private int _capacity = 4;

        public int Position { get; private set; }

        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (value < 0) _numPassengers = 0;
                else if (value > _capacity) _numPassengers = _capacity;
                else _numPassengers = value;
            }
        }
        public Vehicle() { }
        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;
        }
        public virtual string Move()
        {
            Position += _speed;
            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times";
        }

        public override string ToString()
        {
            return base.ToString() + $" capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: { Position}";
        }
    }
}
