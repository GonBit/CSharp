using System;
using System.Collections;
using System.Collections.Generic;

namespace ObjectComparison_Collections;

public class Program
{
    public static void Main(string[] agrs)
    {
        #region Comparing objects
        /*
        var bobOne = new Person("Bob", "Builder") { Age = 25 };
        var bobTwo = bobOne;
        //The object reference of bobone and bobtwo are the same so it returns true
        var areSame = bobOne.Equals(bobTwo);

        //The object reference isnt the same but the values are but it still returns false
        var bobThree = new Person("Bob", "Builder") { Age = 25 };
        var areSameOneThree = bobOne.Equals(bobThree);

        List<Person> personList = new List<Person>
        {
            new Person("Cath", "Cookson"),
            new Person("Bob", "Builder"){ Age = 24},
            new Person("Dan", "Dare"),
            new Person("Amy", "Andrew"){ Age = 32},
            new Person("Bob", "Andrew"){ Age = 32},
        };

        //This will return false because their not the same reference
        //We are going to define our way of Equals
        var hasBob = personList.Contains(bobOne);
        //After the own definition of Equals it returns true

        personList.ForEach(x => Console.WriteLine(x));
        
        Console.WriteLine();
        //Indicate that is implementing the IComparable interface
        personList.Sort();

        personList.ForEach(x => Console.WriteLine(x));*/
        #endregion
        #region Collections

        var helen = new Person("Helen", "Tryp") { Age = 22};
        var will = new Person("William", "Shakespeare") { Age = 457};

        List<Person> thePeople = new List<Person> { helen,will };
        thePeople.Add(new Person("Nish", "Mandal"));

        Person[] arr = thePeople.ToArray();

        /*
                var numList = new List<int> { 5, 4, 9, 8 };
                numList.Add(8);
                numList.Sort();    
                numList.RemoveRange(1, 2);
                numList.Insert(2, 1);
                numList.Remove(9);
                numList.Reverse();

                foreach (var n in numList)
                {
                    Console.WriteLine(n);
                }
        */
        /*
                LinkedList<Person> list = new LinkedList<Person>();
                list.AddFirst(helen);
                list.AddLast(will);
                list.AddLast(new Person("Nish", "Mandal"));
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }*/
        /*
                
        //Queue
                var myQueue = new Queue<Person>();
                myQueue.Enqueue(helen);
                myQueue.Enqueue(will);
                myQueue.Enqueue( new Person("Jab", "Khan"));

                foreach (var item in myQueue)
                {
                    Console.WriteLine(item);
                }

                var first = myQueue.Peek();
                var server = myQueue.Dequeue();

                foreach (var item in myQueue)
                {
                    Console.WriteLine(item);
                }
        */
        /*
        //Stacks
        int[] original = new int[] { 1, 2, 3, 4, 5 };
        int[] reversed = new int[] { original.Length };
        var stack = new Stack<int>();

        foreach (var item in original)
        {
            stack.Push(item);
            Console.WriteLine(item);
        }

        //pop off the stack the top cahir, wichi will be fine and continue until our array is full
        for (int i = 0; i < original.Length; i++)
        {
            reversed[i] = stack.Pop();
        }*/

        //Hashset
        /*
        var peopleSet = new HashSet<Person> { helen, new Person("Jasmin", "Mandal"), new Person("Andrew", "Aggassi")};

        var successMartin = peopleSet.Add(new Person("Martin", "Beard"));
        var successHelen = peopleSet.Add(new Person("Helen", "Troy"));

        var sorePeople = new HashSet<Person> { new Person("Cathy", "French"), new Person("Jasmin", "Mandal")};
        peopleSet.IntersectWith(sorePeople);//Gives Jasmin because its the only one common

        foreach (var person in peopleSet)
        {
            Console.WriteLine(person);
        }
        */


        /*
        //Dictionaries
        var personDictionary = new Dictionary<string, Person>
        {
            { "helen", helen},
            { "sherlock", new Person("Sherlock", "Holmes"){ Age = 40} }
        };

        Person p = personDictionary["Sherlock"];


        string input = "The cat in the hat comes back";
        input = input.Trim().ToLower();

        var countDict = new Dictionary<char, int>();

        foreach (var count in input)
        {
            if (countDict.ContainsKey(count))
            {
                countDict[count]++;
            }
            else
            { 
                countDict.Add(count, 1);
            }
        }*/

        var theBeatles = new Dictionary<int, string>() { { 1, "John" }, { 2, "Paul", { 3, "Ringo" }, { 4, "George" } };
        theBeatles.TryAdd(3, "Nish");
        var beatleslist = theBeatles.Values.ToList();
        var c = theBeatles.Remove(1);
        var d = theBeatles.Keys.Where(x => x % 2 == 0).Sum();



    }
        #endregion

    }

}