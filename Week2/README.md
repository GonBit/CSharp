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

