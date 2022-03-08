using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    //Abstract classes can have both concrete and abstract methods
    //Abstract methods MUST be implemented in their derived classes
    //Concrete classes cannot have abstract methods
    public abstract class Shape
    {
        //An abtract metho has a method signature
        //but NO method body
        public abstract int CalculateArea();

        public override string ToString()
        {
            return $"{this.GetType()} and the area is {this.CalculateArea()}";
        }

    }
    //Derived classes must implement abstract methods
    //from their base class
    public class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(int height, int width)
        { 
            _height = height;
            _width = width;
        }        
        public override int CalculateArea()
        {
            return _height* _width;
        }
    }

}
