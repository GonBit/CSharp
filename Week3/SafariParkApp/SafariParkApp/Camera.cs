namespace SafariParkApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return _brand + " shooting";
        }

        public string ToString()
        { 
            return "Camera: " + _brand;
        }

    }
}
