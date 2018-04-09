using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> persons = new List<Person>();
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] arguments = input.Split().ToArray();
            string name = arguments[0];
            int age = int.Parse(arguments[1]);
            string town = arguments[2];

            Person newPerson = new Person(name, age, town);

            persons.Add(newPerson);
        }

        int personIndex = int.Parse(Console.ReadLine());
        Person personToCheck = persons[personIndex - 1];
        int equalPeople = 1;

        for (int i = 0; i < persons.Count; i++)
        {
            int result = personToCheck.CompareTo(persons[i]);
            if (result == 0)
            {
                if (personIndex - 1 != i)
                {
                    equalPeople++;
                }
            }
        }

        if (equalPeople == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalPeople} {persons.Count - equalPeople} {persons.Count}");
        }
    }
}