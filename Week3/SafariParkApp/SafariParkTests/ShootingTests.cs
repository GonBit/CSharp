using NUnit.Framework;
using SafariParkApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    public class ShootingTests
    {
 
        [Test]
        public void IShootable_ShootTest()
        {
            IShootable laser = new LaserGun("Laser Premium");
            Assert.That(laser.Shoot(), Is.EqualTo("Lasergun shooting"));
            Assert.That(new WaterPistol("H2Wow").Shoot(), Is.EqualTo("Watergun shooting"));
            Assert.That(new Hunter("Gaurav", "Dogra", laser).Shoot(), Is.EqualTo("Lasergun shooting"));
        }
            
    }
}
