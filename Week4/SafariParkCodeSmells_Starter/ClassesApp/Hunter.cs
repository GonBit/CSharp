using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesApp
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter { get; set; }
        public Hunter() { }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            var msg = GetFullName();
            if (Shooter == null)
            {
                msg += " doesn't have a shooter";
            }
            else
            {
                msg += $": { Shooter.Shoot()}";
            }
            return msg;
        }

        public override string ToString()
        {
            var msg = base.ToString();
            if (Shooter != null)
            {
                msg += $" Shooter: {Shooter}";
            }
            return msg;
        }
    }
}
