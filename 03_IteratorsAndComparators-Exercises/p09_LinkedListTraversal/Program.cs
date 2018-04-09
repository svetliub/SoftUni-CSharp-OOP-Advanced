using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfCommands = int.Parse(Console.ReadLine());
        MyLinkedList<int> myLinkedList = new MyLinkedList<int>();

        for (int i = 0; i < numberOfCommands; i++)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string command = input[0];
            int element = int.Parse(input[1]);

            switch (command)
            {
                case "Add":
                    myLinkedList.Add(element);
                    break;
                case "Remove":
                    myLinkedList.Remove(element);
                    break;
            }
        }

        Console.WriteLine(myLinkedList.Count);
        Console.WriteLine(string.Join(" ", myLinkedList));
    }
}