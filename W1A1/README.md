# Week 1 23/2/2022 Wednesday

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

Refactoring is changing the code without changing the behavior. 
It makes it more efficient and bug fixing.

## Creating a Unit test

1. Right click on Solution
2. Add
3. NUnit Test C#

## Unit testing

Doing unit testing makes sure a bug doesn't sneak into higher testing levels. It is important to start testing even when it's very basic program.
By testing part of the code we have confidence in that part of the code and continuing building other parts so unit testing is important to get that confidence.

1 unit test for each class or partition

Exhaustible unit testing is impossible

Return string exception for numbers bellow 0 and over 24 

##### Debugging in Unit testing

Same principles apply with the debugger while in a Unit Test.

### Test Cases

``` csharp
        //Test cases 3 of the possible values for the same method
        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenAtimeBetween5and12Inclusive_Greeting_returnGoodMorning(int time)
        {

            Assert.That("Top of the morning", Is.EqualTo(Program.Greeting(time)));

        }

        //Good afternoon
        [Category("Edge Case")]
        [TestCase(12, "Top of the morning")]
        [TestCase(13, "Good afternoon")]
        public void GivenAtime_Greeting_ReturnsCorrectMessage(int time, string expected)
        {

            Assert.That(expected, Is.EqualTo(Program.Greeting(time)));

        }
```

Test methods shouldn't be dependent of other test methods. They should self validating and timely (fast).

Don't put logic into unit testing, all you're doing is Arrange, Act, Assert.





