# Week 4

Test will have SQL questions

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

