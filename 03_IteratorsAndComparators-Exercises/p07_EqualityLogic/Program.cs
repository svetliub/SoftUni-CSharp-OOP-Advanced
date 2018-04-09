using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPersons = int.Parse(Console.ReadLine());

        SortedSet<Person> sortedSetPersons = new SortedSet<Person>();
        HashSet<Person> hashSetPersons = new HashSet<Person>();

        for (int i = 0; i < numberOfPersons; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person newPerson = new Person(name, age);
            sortedSetPersons.Add(newPerson);
            hashSetPersons.Add(newPerson);
        }
        
        Console.WriteLine(sortedSetPersons.Count + Environment.NewLine + hashSetPersons.Count);
    }
}