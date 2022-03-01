<img src="https://boolerang.co.uk/wp-content/uploads/job-manager-uploads/company_logo/2018/04/SG-Logo-Black.png" alt="Sparta Logo" width="200"/>

---   
# Lab - Data Types

## Setup
Download the starter code `DataTypes_Lab_Starter`, unzip it, save it in your local repo folder for this lesson, and open it in Visual Studio.

## Lab

1.  Implement the method `Methods.Factorial` so that it returns the product of all numbers from 1 to `n` inclusive.

In `DataTypes_Test.MethodTests.cs`, write test cases for the following input and expected output.  The first one has been done for you.

Input | Expected Output
------|----------------
1     | 1
10    | 3_628_800 
12    | 479_001_600
13    | 6_227_020_800
20    | 2_432_902_008_176_640_000

2. The method `Methods.Mult` returns the product of two `float`s.  

    Run the test `MethodTests.Mult_ReturnsTheCorrectProductOfFloats()`.  Does it pass?  If not, what has gone wrong?

    Look at the NUnit documentation [Comparing Floating Point Values](https://docs.nunit.org/articles/nunit/writing-tests/constraints/EqualConstraint.html#comparing-numerics).  Rewrite the test so that it passes.

3.  Look at the two static methods of the `TypeConversion` class.  Each method uses a *cast* to convert from one type to another.

    Run the tests in `TypeConversionTests`.  Do they pass?

    Modify the `TypeConversion` methods so that they pass all the tests.

4.  Implement the methods of the static class `IntegerCalc` so that they pass the unit tests in `CalculatorTests`.
