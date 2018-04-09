using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        int numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string name = input[0];
            int age = int.Parse(input[1]);

            Person newPerson = new Person(name, age);
            persons.Add(newPerson);
        }

        SortedSet<Person> firstSortedSet = new SortedSet<Person>(persons, new LengthComparator());
        SortedSet<Person> secondSortedSet = new SortedSet<Person>(persons, new AgeComparator());

        Console.WriteLine(string.Join(Environment.NewLine, firstSortedSet));
        Console.WriteLine(string.Join(Environment.NewLine, secondSortedSet));
    }
}