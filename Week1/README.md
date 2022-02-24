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

**Don't put logic into unit testing, all you're doing is Arrange, Act, Assert.**

# 24/2/2022 Thursday

## Agile and Scrum

Software developers in the 80s and 90s experiences high levels of failed project and noticed common traits:

* Too much analysis upfront

* Restrictive change control

* Too much uncertainty

## The Agile Manifesto

**Individual & interactions** over processes & tools

**Working software** over comprehensive documentation

**Customer collaboration **over contract negotiation

**Responding to change** over following a plan

## SCRUM Framework

SCRUM is an agile methodology

![](https://scrumorg-website-prod.s3.amazonaws.com/drupal/inline-images/2021-01/screen_shot_2021-01-10_at_9.14.17_am.png)

## Three Pillars of Scrum

* Transparency

Everyone present the facts as is & collectively collaborates for the common organizational objective.

* Inspection

Not done by an inspector but by everyone on the Scrum team.

* Adaptation

Adaptation is about continuous improvement.

## Scrum Team

* Co-located
* Engaged with the customer

* Self-Organizing

* Accountable & Empowered

* Cross Functional

## Scrum Roles

* **Product Owner**

Key stakeholder who should have deep understanding of the product and communicate with both the team and other stakeholders

* **Scrum Master**

Ensures the team keeps to the values of Scrum, facilitates meetings and removes impediments

* **Development Team**

Effectively 3-9 people

Decide how the work will be done

Everyone is accountable for the team's productivity

**SMART Criteria**

- **S**pecific (simple, sensible, significant).

  Your goal should be clear and specific, otherwise you won't be able  to focus your efforts or feel truly motivated to achieve it. When  drafting your goal, try to answer the five "W" questions:

  - **What** do I want to accomplish?

  - **Why** is this goal important?

  - **Who** is involved?

  - **Where** is it located?

  - **Which** resources or limits are involved?

    

- **M**easurable (meaningful, motivating).

  It's important to have measurable goals, so that you can track your  progress and stay motivated. Assessing progress helps you to stay  focused, meet your deadlines, and feel the excitement of getting closer  to achieving your goal.

  A measurable goal should address questions such as:

  - How much?
  - How many?
  - How will I know when it is accomplished?

- **A**chievable (agreed, attainable).

  Your goal also needs to be realistic and attainable to be successful. In other words, it should stretch your abilities but still remain  possible. When you set an achievable goal, you may be able to identify  previously overlooked opportunities or resources that can bring you  closer to it.

  An achievable goal will usually answer questions such as:

  - How can I accomplish this goal?
  - How realistic is the goal, based on other constraints, such as financial factors?

- **R**elevant (reasonable, realistic and resourced, results-based).

  This step is about ensuring that your goal matters to you, and that  it also aligns with other relevant goals. We all need support and  assistance in achieving our goals, but it's important to retain control  over them. So, make sure that your plans drive everyone forward, but  that you're still responsible for achieving your own goal.

  A relevant goal can answer "yes" to these questions:

  - Does this seem worthwhile?
  - Is this the right time?
  - Does this match our other efforts/needs?
  - Am I the right person to reach this goal?
  - Is it applicable in the current socio-economic environment?

- **T**ime bound (time-based, time limited, time/cost limited, timely, time-sensitive).

  Every goal needs a target date, so that you have a deadline to focus  on and something to work toward. This part of the SMART goal criteria  helps to prevent everyday tasks from taking priority over your  longer-term goals.

  A time-bound goal will usually answer these questions:

  - When?
  - What can I do six months from now?
  - What can I do six weeks from now?
  - What can I do today?

  ## User Stories

**Events**
As a customer, I want to be able to view upcoming events so that i can attend them

As a salesperson, I want to be able to showcase upcoming events so that i can sell tickets

**Sales**

As a customer, I want to be able to showcase current sales so that i can attend them at a lower cost

As a salesperson, I want to be able to showcase current sales so that i can sell tickets

**Competitions**

As a customer, I want to be able to view future competitions so that I can compete in them

As a salesperson, I want to be able to highlight future competitions so that I sell tickets 

**Open Days**

As a customer, I want to be able to view future open days so I can attend them

As a salesperson, I want to be able to add 

**Lesson**

As a customer, I want to be able to view future lessons so that I can attend them

As a salesperson , I want to be able to sell tickets to lessons and change/update the time of the lessons

As a manager, I want to be able to view how many people are attending to get the correct amount of equipment and book the teacher.

## Acceptance Criteria

How do we know when a user story is completed

**Gherkin Scenario**

Given						

​	And					

When

​	And

Then

​	And

## Introduction to BDD Behavior-Driven Development

### What is BDD

* It's a software development process that puts features behaviors first.

* Allows for non technical members of the project team to have a better understanding of how the product will function.

* The BDD process is a collaborative one which includes the whole project team (Business Analysts/Product Owners/ Testers)



## Estimation and Prioritizing

Critical Functionality



Ask about market share for tomorrow's discussion

## Retrospectives

This is done at the end of every sprint

Set the stage 

Gather Data

Generate Insights

Decide what to do

Close the retro

*Emotional seismograph* for Retrospective



Refactor

