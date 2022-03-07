# Monday 7/3/2022
## OOP Introduction

### The Four Pillar of Object-Oriented Programming
Its based on the concept of objects and it mimics real life. Allows you to create robust code that is easy to troubleshoot.
The code written is modular. You don't have to rewrite methods because of Inheritance. We can reuse same code instead of writing again.
Flexibility because of Polymorphism.

## The four pillars

### Abstraction
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
A constructor doesn't return anything
'''csharp
//Create a constructor     
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }
'''
