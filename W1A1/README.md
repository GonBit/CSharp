# Week 1 23/2/2022

## Intro to C#

### Application 1 - Hello World

```csharp
using System;

namespace W1A1; //filescoped namedspace
public class Program 
{
    public static void Main(string[] args)
    {
            
        Console.WriteLine("Greetings, Earth");            

    }

}
```

### Naming cases

```csharp
// camelCase : Variable names
// _camelCase : private fields
// Pascal Case : Class and Methods names
// kekbab-case : HTML
// name_case : SQL
```

Note: Use the Debugger

## Refactoring

Refactoring is changing the code without changing the behaviour. 
It makes it more efficient and bug fixing.

## Creating a Unit test

1. Right click on Solution
2. Add
3. NUnit Test C#

## Unit testing

Doing unit testing makes sure a bug doesn't sneak into higher testing levels. It is important to start testing even when it's very basic program.
By testing part of the code we have confidence in that part of the code and continuing building other parts so unit testing is important to get that confidence.

##### Debugging in Unit testing

Same principles apply with the debugger while in a Unit Test.
