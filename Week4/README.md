# Week 4

sql questions (3 questions)

 correct naming conventions in select statement 

c# questions

big O notation   

 comparing sort methods, which time complexity are they?

efficiency of algorithms, is it O(n) O(n^2)? 

multiple choice which one will return a sum of numbers, from code snippets  

codesmells 

definition of refactoring 

data clumps

 choose examples of dead code

 when should you refactor your code

design patterns (2 questions)

 streams

# Monday 14/3/2022

## Refactoring

### Objectives

1. Define Refactoring - what, why, when

2. Look at some code smells

3. Refactor smelly code with Visual Studio support.

Refactoring is the process of improving the structure of the code

* not debugging.

### Why is it done

To improve your design

Without refactoring, the design of the program will decay.

As people modify code, the code loses its structure.

### Before refactoring

1. Cover you code with unit tests
2. Make sure they all pass
3. Commit your code
4. Now you can confidently change your code knowing that you can go back to a previous version

### Refactoring and testing

Refactoring is easy if your code is well covered by automated unit tests

You know the code works

### When to Refactor

When a program is hard to read

When duplication exists

Before adding new functionality

When adding new behavior is not possible without making major changes to the existing

On code reviews

When your code smells

### When to not Refactor

Close to a deadline

* Unfinished refactoring can be catastrophic

Need a complete rewrite

* Code should work (mostly) before refactoring
* Sometimes it is better to throw the existing code out and start again

## Code smells

Term refers to recognizable bad code traits

If it smells bad, change it

### Inappropriate names

Method names should say what the method does

Field, property, parameter and variable names should be meaningful

Ditto class names

Your code will be easier to understand and require less commenting.

### Duplicate Code

* Same code in different places

* Refactor!

* Find a way to unify them.

- If you have several classes with similar code, can you extract a superclass?

* Most important smell to eliminate

* Duplicate code is easy to write but hard to maintain

### Long Methods

* Favor shorter methods

* Is the method doing more than one thing?

* Use meaningful method names

* Less need for comments if method names are self-explanatory

### Large classes

* When a class does too much

* Single Responsibility Principle

* Should it be split into two associated classes?

### Long Method Parameters Lists

![image-20220314144745749](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220314144745749.png)

### Feature Envy

When you keep calling on a particular class several times.

A sign the functionality might belong to the other class

## Conclusion

![image-20220314145659240](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220314145659240.png)



# Tuesday 15/3/2022

## Design patterns

### What are Design Patterns?

Design patterns describe solutions to commonly encountered problems

Patterns capture good design principles and communicate them to others.

Based on architectural patterns.

### MVC Architecture

An architectural pattern

Enables Separation of Concerns

![image-20220315120855202](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315120855202.png)

### Factory Method



### Singleton

Ensures a class haas only one instance, while providing global access to that instance

The problem;

* an application needs to have only one instance of a particular class
* but many classes/objcets need to be able to access it
* potentially lots of coupling
  * lots of objects referencing the same object
  * needed a global point of access to the single instance
* Often, the instance should not be constructed before it is first needed
  * lazy instantiation

**How does it work?**

![image-20220315121556041](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315121556041.png)

![image-20220315121629285](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315121629285.png)

![image-20220315121822160](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315121822160.png)

![image-20220315121902217](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315121902217.png)





![image-20220315122350225](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315122350225.png)

![image-20220315122543044](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315122543044.png)

![image-20220315122550261](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315122550261.png)

![image-20220315122612889](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315122612889.png)

![image-20220315122717368](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220315122717368.png)

#  Wednesday 16/3/2022

## Decorator design pattern

Attach additional responsibilites to an object dynamically by placing them inside wrapper objects that contain the behaviors.

Structural behavior C something

3 coding SQL questions

# Thursday 17/3/2022

# Friday 17/3/2022

**Group By**

``` sql
SELECT  SUM(o.Freight) AS 'Freight sum', c.CustomerId
FROM Customers c
LEFT JOIN Orders o ON c.CustomerId = o.CustomerId
GROUP BY c.CustomerId
```

## XML & JSON

XML is Extensible Markup Language and JSON is JavaScript Object Notation are used to store and transfer data.

They are both human readable easily parsed hierarchal

Though the use is the same in regards to data storage and exchange there are many changes.

## XML

![image-20220318102431505](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318102431505.png)



![image-20220318102938120](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318102938120.png)

![image-20220318103022496](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318103022496.png)

![image-20220318103132158](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318103132158.png)

![image-20220318103249586](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318103249586.png)

# JSON

![image-20220318110449959](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318110449959.png)

![image-20220318110521765](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318110521765.png)

# SQL

![image-20220318134046873](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318134046873.png)



![image-20220318134215695](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318134215695.png)

![image-20220318134449045](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318134449045.png)

![image-20220318140726234](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318140726234.png)

![image-20220318140741361](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318140741361.png)

![image-20220318141338461](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318141338461.png)

![image-20220318141355691](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318141355691.png)

![image-20220318142930739](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318142930739.png)

![image-20220318143131329](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318143131329.png)

![image-20220318143333771](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318143333771.png)

![image-20220318151657679](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318151657679.png)

![image-20220318154435677](C:\Users\BlkBird\AppData\Roaming\Typora\typora-user-images\image-20220318154435677.png)

