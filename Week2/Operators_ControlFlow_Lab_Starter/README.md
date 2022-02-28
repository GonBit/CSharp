<img src="https://boolerang.co.uk/wp-content/uploads/job-manager-uploads/company_logo/2018/04/SG-Logo-Black.png" alt="Sparta Logo" width="200"/>

---
# Lab - Operators and Control Flow

## Setup
Download and unzip the starter code Operators_ControlFlow_Lab_Starter, save it in your lesson repo, and open it in Visual Studio.

## Lab
1. Look at the `static` method `Exercises.MyMethod` in the project `Op_ControlFlow_Lib`.  What does it do?  Write unit tests in `Op_CtrlFlow_Tests.Exercises_Tests` that verify your answer.

2. Implement the `static` method `Exercises.Average` so that it returns the average of the numbers in the list `nums`.  It must pass the unit tests written for it:
  - `Op_CtrlFlow_Tests.Exercises_Tests.Average_ReturnsCorrectAverage()`
  - `Op_CtrlFlow_Tests.Exercises_Tests.WhenListIsEmpty_Average_ReturnsZero()`

3. Implement the static method `Exercises.TicketType` so that it passes the all the test cases of  `Op_CtrlFlow_Tests.Exercises_Tests.TicketTypeTest()`

4.  A University wants to you to write a `static` method called `Grade` which fulfils the following criteria:

Mark      |  Return value
----------|------------------------
75 to 100 | "Pass with Distinction"
60 to 74  | "Pass with Merit"
40 to 59  | "Pass"
0 to 39   | "Fail"

Write unit tests in `Op_CtrlFlow_Tests.Exercises_Tests` corresponding to these criteria.

Then write a `static` method in the `Exercises` class to pass the tests.  
The client has stipulated that you must use a *nested* `if` statement - see https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/if-else if you're not sure what a *nested* `if` is.

5. Create and unit test a `static` method which returns the maximum number of attendees at a Scottish wedding given the current Covid alert level as shown in the table below.  You method must use a `switch` statement.

Level | Max attendees
------|--------------
4 | 20
3 | 50
2 | 50
1 | 100
0 | 200
