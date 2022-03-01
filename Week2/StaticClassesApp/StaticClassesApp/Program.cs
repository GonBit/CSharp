using System;

namespace StaticClassesApp;

public class StaticClassesProgram {

    public static void Main(string[] args) {

        var nishMan = new Trainee()
        {
            Course = "C# Dev",
            Name = "Nish Mandal",
            Age = 30

        };

        var nishKumar = new Trainee()
        {
            Course = "Java Dev",
            Name = "Nish Kumar",
            Age = 35

        };

        Console.WriteLine(nishMan.Name + "  " + nishMan.Age + "  " + nishMan.Course + " ");
        Console.WriteLine(nishKumar.Name + "  " + nishKumar.Age + "  " + nishKumar.Course + " ");
    }

}

public class Trainee { 

    public string Course { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    private static int _noOfTrainees = 0;

    public Trainee() { 
    
        _noOfTrainees++;
    }

    public static int GetNumberOfTrainees() { 
    
        return _noOfTrainees;

    }
}

public static class Calculator {

    public static int Add(int a, int b) { 
    
        return a + b;
    
    }

}