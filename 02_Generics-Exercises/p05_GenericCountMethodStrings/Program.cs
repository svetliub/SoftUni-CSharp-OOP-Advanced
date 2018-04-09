using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());
        List<string> boxList = new List<string>();

        for (int i = 0; i < numberOfStrings; i++)
        {
            string item = Console.ReadLine();
            boxList.Add(item);
        }

        string element = Console.ReadLine();
        Box<string> box = new Box<string>(boxList);

        Console.WriteLine(box.CompareCount(element));
    }
}