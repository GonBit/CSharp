using System;

namespace Classes_Struct;

public class Vehicle
{

    public int NumPassengers { get; init;}

    public int Position { get; init;}

    public int Speed { get; init; }

    public Vehicle(int nPassengers, int pos, int speed)
    { 
        NumPassengers = nPassengers;
        Position = pos; 
        Speed = speed;    
    }


}



