# Monday 7/3/2022
## Exam

PRACTICE THINGS LIKE ADDING UP NUMBERS MULTIPLE OF 2 OR DIVISIBLE BY SOMETHING
BE CAREFUL IN THE WAY THAT STRING NAME, MAKE SURE THE STRING MATCHES THE RETURN IN THE QUESTIONS
FINDING THE LARGEST, OR SMALLEST
THE GARBAGE COLLECTOR
THE TYPES OF DATA STORED AT THE HEAP
OVERFLOW
find lowest number in array and include negative NUMBERS

## Next Exam Monday 14/03

For next exam. 2 questions with a definition of the solids principles

Coding exercise will be building collections and classes, and implement interface. Putting some logic in the setter(Person Example age can't be less than 0)

2 question about dictionaries

This week OOP

What makes a good unit test, best practices, advantages of Unit testing, classes, structs, which will be a good constructor for this type of class,overloading, abstract, concrete methods.

virtual, override and sealed keywords

## OOP Introduction

### The Four Pillar of Object-Oriented Programming
Its based on the concept of objects and it mimics real life. Allows you to create robust code that is easy to troubleshoot.
The code written is modular. You don't have to rewrite methods because of Inheritance. We can reuse same code instead of writing again.
Flexibility because of Polymorphism.

## The four pillars

### Abstraction
Is a general concept which you can find in the real world as well as in OOP languages
A way of managing complexity
Model the real world
Things contain data and methods that interact with that data.
Think of it as the blueprint of the code

The unit of Abstraction is the class - blueprint
In our program we make objects - instances of that class
Think of the problem in term of things - objects
That can interact with each other by calling their methods
And be combined together to make more things

Abstraction is the concept of a class.

### Encapsulation
Encapsulation in object oriented programming is a mechanism of restricting direct access to some components of an object, so users cannot access
Hiding how it works with private and using get and set
We are not interested in how it works
We are only interested in how we can interact with it
Black box - Only expose the interface(public methods), not what's inside
          - information hiding - don't know how the data is stored.
We're not interested in the details of how each thing works
We just need to know what it does and how other things can interact with it


**Encapsulation Guidelines**
Information hiding- data exposed only on a need to know basis
Tell, don't ask
The thing that has the information does the works - pass the buck whenever you can
Single responsibility
Cohesion good, coupling bad

### Inheritance
Is a mechanism where you can to derive a class from another class for a hierarchy of classes that share a set of attributes and methods.
A way to avoid writing the same code to describe similar things
A base class encapsulates the common data and functionality
Derived classes add new functionality and/ or data to deal with specialisms
B extends A

Goncalo is a human which is a mammal which is an animal. Species to subspecies

**Inheritance Guidelines**
base classes should be closed to change but open to extension
don't go wild - avoid deep levels of Inheritance
make use of abstract classes and interfaces

## Polymorphism
Same thing different way
Many forms - diamond, graphite, graphene
A way for things to flexibly interact
Same interface, different behavior
  -Ibex, Fish, Eagle, Jeep all implement IMoveable interfaces
  -Can call same method on all IMoveable objects
  -and they have different response depending on their class

**What does Polymorphism allows us to do?**
Customized behavior, same interfaces
  Move methods
Closed to modification, open to extension
  Can add more classes which implement the same interface without changing existing classes
Single responsibility
High cohesion, low coupling
  Separate a game object from the way it is rendered
  can change each independently

## Constructor
A constructor is used instantiate new objects.
A constructor doesn't have a return type. The constructor returns the reference to the new object
A constructor must also have the same name as the class

## Property
public int Age { get; set; }

Property are private variables with get and set.

## Structs
Structs are value types(stack) and classes are reference types(heap)
Used to hold simpliesh data

# Tuesday 8/3/2022
Classes have Fields, Properties and Methods

## Inheritance
A way to avoid writing the same code to describe similar Things
Parent class encapsulates the common data and functionality
Sub-classes add new functionality and / or data to deal with specialisms
B extends A
It's a relationship

Thins to another
When the derived class constructor is called, it immediately calls the base class Constructor
Once the base class constructor

What is a virtual keyword
Its a word that would be used in a method in a base class that can be override in a derived class.

The use of base in the class
In the context of class is inheriting the Fields
In the context of Constructor - its expecting parameters

What does the protected keyword do
In the base class we use it to let our drive class use it but it makes it inaccessible by other methods

### Abstract methods and Classes
Both concrete and abstract classes can have a mixture of concrete and abstract methods\

The sealed keyword doesn't allow Inheritance of that class

Abstract classes can have both concrete and abstract methods
Abstract methods MUST be implemented in their derived classes
Concrete classes cannot have abstract methods

abstract class vs method
Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).

method overloading vs method overriding
In method overloading, methods must have the same name and different signatures. In method overriding, methods must have the same name and same signature.

difference between interface and abstract class
The short answer: An abstract class allows you to create functionality that subclasses can implement or override. An interface only allows you to define functionality, not implement it. And whereas a class can extend only one abstract class, it can take advantage of multiple interfaces.

# Wednesday 9/3/2022
## Polymorphism
Review of Polymorphism as a Pillar
Polymorphism - ToString methods
Polymorphism method arguments
Casting between Classes

## Polymorphism - 4th Pillar
Many forms
A way for things to flexibly interact
Same interface, different behavior

**Many forms of the ToString() methods**
All classes derive from the Object classes
Which defines a virtual ToString() method

Method override is a type of runtime Polymorphism

## Solid Principles
What are SOLID Principles?
They are a list of good practices when using OOP languages

### Solid responsibility Principles
The 5 principles of SOLID are:

- **S**ingle-responsibility principle
- **O**pen-closed principle
- **L**iskov substitution principle
- **I**nterface segregation principle
- **D**ependency inversion principle

Make the code as readable and as small as possible.

Single responsibility
--
Software module should only represent just one thing
	-ONE resposibility
Class members should be cohesive
	- fields and properties should hold information about the thing
	- the methods should manipulate or return this informaiton
The class should have only one reason to change.
(High cohesion means that the class is focused on what it should be doing as it contains only methods relation to the intention of the class)

It is easier for other devs to read and debug.

Open/closed
--
Software entities(methods and classes) should be open for extension but closed for modification
New functionality can be added by creating a derived class

A lot of devs may be using your base class, you don't want it to have problems later down the line when they're implementing different methods.

Liskov substituion
--
Subtypes must be substitutable for their base types without breaking the application 
Expect for any class which implemented an interface to implement the methods correctly.

If exists a method which isn't needed from a class that has implemented an interface, code must be written to make sure it has higher cohesion.

Interface segregation 
--
Many small, specific interfaces are better than one large, general purpose one.
Interface, in this context, means the public methods & Properties of a code module
Having smaller interfaces that describe only one type of behavior, helps enforce the Liskov Substitution principle.
This invites high cohesion along with singular responsibility. 

Good for readability, other devs understanding and your code and debugging. 

## Dependency Inversion

Depend on abstractions rather than concrete instances

**High level modules should not depend on low level code**

​	Both should depend on abstractions

**High level**

​	Business rules, processes, guts of the application

​	Calculator class, Radio class

**Low-level**

​	Plumbing code

The **dependency inversion principle** (DIP) has two parts:

1. High-level modules should not depend on low-level modules. Instead, both should depend on abstractions (interfaces)
2. Abstractions should not depend on details. Details (like concrete implementations) should depend on abstractions.
   ![image-20220310100619062](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310100619062.png)

new is glue - Hunter is tighly coupled to the camera glass

Violates SRP and DIP

Hard to test Hunter and Camera separately

Dependency is hidden

At compile time, Hunter references Camera

At run time, hunter calls a Camera method.

### Safari example using DIP

![image-20220310101010050](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310101010050.png)



Dependency is transparent via the constructor signature.

![image-20220310101448119](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310101448119.png)

Now it's not coupled. Making more cohesive

Now both Hunter and Camera reference the IShootable interface (compile time)

At runtime, Hunter calls a method of the IShootable interface

Hunter and Camera know nothing about each other

Easy to test Hunter - provide it a specific IShootable object or a mock

**Another DIP example - GUI Calculator**

The GUI code-behind classes are low-level

​	Handle user interactions with the GUI

​	Depends on the Calculator class

​	Ideally we would refactor this so it depends on an ICalculator interface

The Calculator class is high-level

​	Knows nothing about the GUI

![image-20220310102157852](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310102157852.png)

## Object Equality and Comparison

Object equality - overriding Equals() and Hashcode()

That will allows us to sort objects

A **hash code** is a numeric value which is used **to insert and identify an object in a hash-based collection**. The GetHashCode method provides this hash code for algorithms that need quick checks of object equality

**IComparable**

![image-20220310110359628](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310110359628.png)

Collections are used to hold objects of the same type.

**Linked List**

They are list, but they are not next to each other in memory. It doesn't have the IList interface.

Lists are better to access stuff by its index. You use it where its rare.



## Queues

![image-20220310122305128](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220310122305128.png)

Represents a first-in, first-out collection of objects.

Queues are fast acess, allow queue operations,



## Stacks

Represents a simple last-in-first-out (LIFO) non-generic collection of objects.

## Hashset

Represents a set of values.

they have mathematical operations

## Dictionary

Generally used to store key/value pairs**. The working of Dictionary is quite similar to the non-generic  hashtable. The advantage of Dictionary is, it is generic type.  Dictionary is defined under System. Collection
