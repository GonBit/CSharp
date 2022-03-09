namespace SafariParkApp
{
    public class LaserGun : Weapon 
    {
        public LaserGun(string brand) : base(brand)
        { 
        
        }

        public override string Shoot() 
        {
            return "Lasergun shooting";
        }
    }
}
