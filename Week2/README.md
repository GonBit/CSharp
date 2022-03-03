# Monday 28/2/2022

## C# Operators

**primary** | x++ x-- a[] x.y new typeof

**unary** | +x -x !x ++x --x (T)x

**multiplicative** | x*y x/y x%y

**additive** | x+y x-y

**relational and type-testing** | x<y x>y x<=y x>=y is as

**equality** | == !=

**logical** | x&y x^y x|y x&&y x||y

**conditional** | x ? y : z

**assignment** | x=y x+=y x-=y x*=y x/=y x%=y

```csharp
        int x = 5;
        int y = 5;
        int a = x++; //post fix operation
        int b = ++y; //the timing of increment is first than the x++ pre fix operation
```

## 

Unit test and refactoring

.NET and C#

Static methods aren't initialized and they exists at the top level

A static class can only contain static members

Static classes cannot be used by object only by the method it is originated

# Tuesday 1/3/2022

Exceptions

We know C# is a strongly typed language

What does strongly typed language - You have to specify what type of data you're storing

C# is like Java that means that is statically typed so a variable must be assigned a data type when its declared and that type can never change 

```csharp
int a = 1;
a = 2;
a = "string"; //It can't be
```

Type-safe means cannot change the type after it's declared

Memory-safe means that the memory assigned cannot grow. Ex array[4] will always have 4 indexes.

C# is a strongly typed language because it is statically typed, type safe and memory safe.

## Var keyword

We can use var to make a variable if the type is assigned by compile typed.

```csharp
var name = "Stanni" //string
var isClean = true; //boolean
var letter = "M" //char
var uLongNum =  52uL; //long
```

### Disadvantages

Var can assign more memory, it's type is not explicit and more error prone

## Integral types

```csharp
byte b = 8; // 8bits unsigned byte can store value from 0 to 255
short s = 16 // int16 0 to 65535
int i = 32 ; // int32 
long l = 64; // int64
```

unsigned means it can't be negative

signed vs unsigned hold the same amount of memory/numbers with an unsigned max being double a signed ints max value

```csharp
Examples
    short n1 = -65;
	ushort n2 = 64;
	int n3 = -100_000;
	uint n4 = 100_000;
	uint n5 = 4_000_000_000; //its on the range of an integer but not of an unsigned integer
	long n6 = -5_000_000_000;
	ulong n7 = 5_000_000_000;
```

## Floating types

float - 4 bytes

double - 8 bytes - Double is more precise than a float and you use a float over an integer for precision

decimal - 16 bytes

Anything that requires more accuracy a float is used. It's used for sensor readings.

Unlike integers floating point numbers cannot be precisely represented in binary forms

```csharp
float sum = 0;
for (int i = 0; i < 100_000; i++){    
    sum += 2 / 5.0f;
}

Console.WriteLine("2/5 added 100,000 times " + sum);
Console.WriteLine("2/5 multiplied by 100,000 " + (2 / 5.0f * 100,000));

Answer ADDED 39994.227
    MULTIPLIED 40000
```

The slight inaccuracy of float in binary forms adds up when doing multiple calculations like the example.

If it was a decimal it would return 40000 because decimal is more precise.

## Safe type conversion

``` csharp
var result = 5.0f /5;
```

Within this division 5 (int) has been promoted to a float type number and we get a double from the operations so the result is a double

```csharp
var myInt = 5;
double myNum = myInt;

double myNum2 = 2.0;
int myNum2 = myNum2; // this is potential for data loss so a fix would be
int myNum2 = 
```

### Implicit and Explicit Casting

https://www.w3schools.com/cs/cs_type_casting.php

## Overflow and underflow

It means when you go over the max or minimum value and it resets to 0

``` csharp
byte num = 255;
num++; // it will give 0 because it went over the max value

byte num = 0;
num--; // it will give 255
```

A good example of this happening is Nuclear Ghandi

```csharp
sbyte sNum = SByte.MaxValue;
sNum++; // it gives -128
```

A negative number as always a 1 in the left side and a positive has a positive on the right side (post picture here)

```csharp
byte c = 255;
sbyte d= (sbyte)c;
string cBinary = Convert.ToString(c , 2);
string dBinary = Convert.ToString (d, 2);

string cBinary returns 11111111
string dBinary returns 11111111
```

## Casting

You have to do casting if there's a potential for data lost

At compile time recognize this *num* with a different **type**

``` csharp
double x = 3.14159265359;
float y =(float)x;

x = 3.14159265359
y = 3.1415927
```

### Incompatible types

```csharp
float pi = 3.14f;
bool boolPi = (bool)pi;
```

### Convert Class

```csharp
 	var theint = 5;
//no conversion
	var anotherInt = Convert.ToInt32(theInt);
//safe - widening
	var myDouble = Convert.ToDouble(theInt);
//Narrowing (unsafe)
	var myShort = Convert.ToInt16(theInt);
//InvalidCastException
	var pi = 3.142;
DateTime piDay = Convert.ToDateTime(pi);
```

Convert methods throw and exception if there's something wrong.

If we attempt an invalid convert it only detects until runtime.

### Dealing with int over and underflow

```csharp
byte num = Byte.MaxValue;
Console.WriteLine("Byte max: " + num);
num++;
Console.WriteLine(num);
```

Because the num value is declared before the incrementation it doesn't detect an exception.

If you did byte num = 900; it gets picked up by the compiler with and exception.

### Dealing with it

```csharp
checked {    
    byte num = Byte.MaxValue;
	Console.WriteLine("Byte max: " + num);
	num++;
	Console.WriteLine(num);    
}
```

Method overloading is when there's multiple calls on the method with different parameters

# Wednesday 2/3/2022

## More types

## Strings

Strings are objects. 

Lower case string is an alias for the string class.

```csharp
string steven = "Steven Maddox";
steven = "Steven Mandal";
// We've created 2 strings, the first string is not longer being references

//Another way of creating a string
String nish = "Nish Kumar";
String nish2 = new String("Nish Kumar");
string nish3 = "Nish Kumar";
// We can use the equality operator (==) in strings
```

### Using Split

```csharp
string names = "Jab,James,Gaurav,Goncalo";
string[] namesToArray = names.Split(',');

foreach (var name in namesToArray){    
    Console.WriteLine(name);
}
```

![image-20220302104258537](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220302104258537.png)



We’re not changing the string value; these methods are returning a new string. Strings are immutable

Continuous memory blocks

Strings are super important because they display text



### String Builder

Is a reference type. Means that data is being stored in the object, and they are mutable

```csharp
	Console.WriteLine(StringBuilderExercise(myString));

privae static string StringBuilderExercise(string myString){
    
    var trimmedUpString = myString.Trim().ToUpper();
    StringBuilder() sb = new StringBuilder(trimmedUpperString);
    
    return null;
    
}
```

## String Concatenation

```csharp
// Use of Concat Function
var spartaString = String.Concat("This", " is ", "Sparta");
// Returns This is Sparta
```

## String Interpolation

```csharp
var num1 = 2;
var num2 = 3;

var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
Console.WriteLine(fString);

var fString2 = $"That will be {num1 / 3.0:C}, please"; //C formats to currency
var fString3 = $"You've recieved {1 / 10.0:P} in your test"; //P formats it to percentage
Console.WriteLine(fString2);
Console.WriteLine(fString3);
```

### Comparation

```csharp
Console.WriteLine("My name is : " + str + " using ");// concatenation
Console.WriteLine($"My name is {str} using interpolation"); // the $ indicates interpolation
```

## String Parsing

```csharp
bool isSuccess;
do
{

Console.WriteLine("How many apples");
string input = Console.ReadLine();
isSuccess = Int32.TryParse(input ,out int numApples);//TryParse super useful for applications that take inputs
Console.WriteLine($"{numApples} apples");

} while (isSuccess);

Console.WriteLine("Invalid Number");
```

What else is immutable in C#?

Arrays.

## Arrays

### One Dimensional

Different types you can declare an array

```csharp
int[] myIntArray = {12,34,23,45,56}; //declared and initialised
var traineesArray = new string[]{" bla", "bla"}; //declared and initialised using var
var traineesArray2 = new string[3];

//replace the values of the traineesArray with new values
traineesArray[0] = "Jab";
traineesArray[1] = "ble";
```

When you are declaring an array you need to specify it's size either by filling with { 0 , 1 , 2 } or by new array[2]

Iterate through an array using for, foreach etc..

GetUpperBound

GetLowerBound for exercise

### Two Dimensional

```csharp
//0  1
//[ ][ ] 0
//[ ][ ] 1
//[ ][ ] 2 
//[ ][ ] 3
int[,] grid = new int[2, 4];  //2 col 4 rows 2by4
grid[0,0] = 6;
grid[1,1] = 8;
grid[1,3] = 10;

//[6][ ]
//[ ][8]
//[ ][ ]
//[ ][10]
```

```csharp
 //2D array
        char[,] gridTwo =
        {
            { 'a','b'},
            { 'c','d'},
            { 'e','f'},
            { 'g','h'},

        };
        foreach (char c in gridTwo)
        { 
            Console.WriteLine(c);//itterate in column instead of line
        }
        //research upperbound and lowerbound //nested for loop
        //loads of sort algorithms
```

### Jagged Arrays

```csharp
 public static void JaggedArray()
    {
        int[][] intJArray = new int[2][];
        intJArray[0] = new int[4];
        intJArray[1] = new int[2];

        //[][][3][]
        //[5][]
        intJArray[0][2] = 3;
        intJArray[1][0] = 5;

    }
```

Its nice to think of md arrays as coordinates when looking up the index at where your value is stored (xyz)

for Jagged arrays you can think of it more of a nested array where finding the array that you find your value in is the first index and the second index contains the actual array your value is inside.

## Time in C#

DateTime

Timespan



## Enums

It's useful to represent a fixed set of constants. They give type safety like the days of the week By defining an enum we are limiting the value. Each member of a enum has a value, could be int or any other type

They are assigned starting with 50

HEARTS  //0 , CLUBS = 50 , DIAMONDS // 51 , SPADES //52



# Thursday 3/3/2022

Random uses computer ticks to generate the number

```csharp
//Seeding with the current time in ticks
        var rng = new Random();
        var rngSeeded = new Random(42);
        var between1And10 = rngSeeded.Next(1,11);
        Console.WriteLine(between1And10); //result 7

        var rollDice1 = rng.Next(1, 7);
        var rollDice2 = rng.Next(1, 7);
        var rollDice3 = rng.Next(1, 7);       

        Console.WriteLine($"{rollDice1} {rollDice2} {rollDice3} {rollDice1 + rollDice2 + rollDice3}");
```

## Methods

![image-20220303104425822](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303104425822.png)

## Method overloading

C# method overloading **allows a class to declare multiple methods with the same name, separated by their signatures**.
**Method overloading can be achieved by the following:**

1. By changing number of parameters in a method.
2. By changing the order of parameters in a method.
3. By using different data types for parameters.

In C# is not possible to return more than 1 value of a method

You can designate 1 or more parameters to return but it would be together

Value type and reference type

```csharp 
int x = 1; // this holds the values

var arr = new int []{1,2,3} //this points the where the value is
```

![image-20220303105325450](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303105325450.png)



```csharp
//main function 	    
		int y = 10;
        int [] arr = new int[] { 1 , 2 , 3};//it changes the value of the array
        var result = DoThis(y, "Sad", arr); //y is assigned to x from the DoThis method - y holds its value while x doesn't
    
        Array.ForEach(arr, x => Console.WriteLine(x));//so the 1,2,3 returns 30,2,3 we passed a copy of y to x =10;
        //x only exists in the DoThis method and return the x*x;
        //we passed a reference with the array
        //anything we do with our array it finds the address and changes its value in the heap
        Console.WriteLine(y);

    public static int DoThis(int x, string y, int[] arr)
    { 
    
        Console.WriteLine($"I am feeling {y}");
        //If i change the first element
        arr[0] = 30;
        x = 3;
        return x * x;
    
    }
```

To clean a heap after the values have been used and manipulated we use a garbage collector to clean and compact the heap

### Ref keyword

```csharp
	public static void Add(int num)
    {
        num++;
    }
    public static void Add(ref int num)
    {
        num++;
    }
//Main method
int y = 10;
int z = 10;
Add(y); //incremented the copy of Y and increments - the value of Y doesn't change - prints out 10
Add(ref z); //passing reference and increments - the value of Y does change - prints out 11
```



### Out keyword

```csharp
 //main function
bool isLarge;
var result = DoThis(10/*int x*/, "Here's a string"/*string y*/, out isLarge/*bool z*/); //out passes by reference
Console.WriteLine(isLarge);

public static int DoThis(int x, string y, out bool z) 
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    
    }
```

The out is a keyword in C# which is **used for the passing the arguments to methods as a reference type**. It is generally used when a method returns multiple values. ... The ref is a keyword in C# which is used for the passing the arguments by a reference.

 A **tuple** is a list of different things

```csharp
  var myTuple = ( "Liam", "Gallangher", 49 );
        Console.WriteLine(myTuple);
        Console.WriteLine(myTuple.Item2);

var myTuple = ( fName:"Liam", lName:"Gallangher", age:49 );
        Console.WriteLine(myTuple);
        Console.WriteLine(myTuple.lName);

(string fName, string lName, int age) myTuple2 = ("Noel","Gallangher", 55);// another way of initialising

var noel = myTuple.fName;
var myTuple3 = ("Bon", noel); // add elements from a tuple to another
```

How to return a tuple?

```csharp
public static (int,int)/* a method tha returns a tuple */ ConvertPoundsToStones(int pounds)
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lb = pounds % poundsInAStone;
        
        return (st,lb);
    
    //or return as a variable
    var result = (st,lb);
    return result;
    }


//main method
var result = ConvertPoundsToStones(98);
Console.WriteLine(result);
```

An array is reference type

## Memory model

### Stack

The stack is an area of fast-access memory where variables are stores as they are declared. Last In First Out .Variables in the stack - values OR references to the heap. Local variables are POPPED off the stack when they go out of scope.

### Heap

The heap is a larger memory area and it hold what is being references when a new ref type is created the system finds space for it on the heap. The reference variable stores the ADDRESS NOT THE DATA

```csharp
int stanni = 4; //stack
string james = "James"; // heap with reference in stack
int[] laura = { 6, 7, 2 }; // heap with reference in stack
for (var gaurav = 0; gaurav < laura.Length; gaurav++)
{ Console.WriteLine(laura[gaurav]); }
double jab = 3.14159;
var steven = stanni;
stanni++;
string[] seb = { "cat", "dog" };
{
var marian = laura;
marian[2] = 42;
string[] goncalo = { "perch", "cod", "eel" };
seb = goncalo;
seb[1] = "bass";
var ned = james;
james = goncalo[0];
}
jab = laura[2];
```

![image-20220303145710284](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303145710284.png)

## Garbage Collector

![image-20220303150543130](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303150543130.png)

## References to references 

![image-20220303150708434](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303150708434.png)

## Garbage collection

![image-20220303151001564](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303151001564.png)

Find, Destroy. Compact

## Why the difference

![image-20220303151049805](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303151049805.png)

## Advantage of reference types

![image-20220303151152551](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303151152551.png)

## Beware!!

![image-20220303151218022](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220303151218022.png)
