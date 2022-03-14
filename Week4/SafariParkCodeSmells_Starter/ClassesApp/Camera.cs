using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Camera : IShootable
    {
        private string _brand;
        public Camera(string brand)
        {
            _brand = brand;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - {_brand}";
        }

        public virtual string Shoot()
        {
            return $"Shooting a {ToString()}";
        }
    }
}
