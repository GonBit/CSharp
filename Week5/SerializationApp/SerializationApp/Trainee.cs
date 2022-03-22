using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationApp
{
    [Serializable]
    public class Trainee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Nullable<int> SpartaNo { get; set; }
        public string? FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{SpartaNo} - {FullName}";
        }
    }
}
