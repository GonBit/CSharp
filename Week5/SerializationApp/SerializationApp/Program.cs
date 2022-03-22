using System;

namespace SerializationApp;

public class Program
{
    private static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //Serialization and ending up in MyDocuments
    private static ISerialise _serialiser;
    public static void Main(string[] args)
    {
        #region Binary Serialisation
        
        Trainee trainee = new Trainee { FirstName = "Jab", LastName = "Khan", SpartaNo = 100 };
        //Create a binary serializer
        _serialiser = new SerialiserBinary();
        _serialiser.SerialiseToFile($"{_path}/BinaryTrainee.bin",trainee);

        var deserialisedTrainee = _serialiser.DeseraliseFromFile<Trainee>($"{_path}/BinaryTrainee.bin");
        
        #endregion

        #region XML Serialisation

        _serialiser = new SerialiserXML();
        _serialiser.SerialiseToFile($"{_path}/XMLTrainee.xml", trainee);
        var deserialisedXMLTrainee = _serialiser.DeseraliseFromFile<Trainee>($"{_path}/XMLTrainee.xml")

        Course eng104 = new Course { Title = "Engineering 104", Subject = "C# Dev", StartDate = new DateTime(2022, 2, 21) };
        eng104.AddTrainee(trainee);
        eng104.AddTrainee(new Trainee { FirstName = "Stanni", LastName = "Lewis", SpartaNo = 101 });
        _serialiser.SerialiseToFile($"{_path}/XMLCourse.xml", eng104);
        #endregion
    }

}
