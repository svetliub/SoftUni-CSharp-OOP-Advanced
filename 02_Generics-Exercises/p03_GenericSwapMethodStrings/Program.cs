using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Box<string>> boxList;
    static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());
        boxList = new List<Box<string>>();

        for (int i = 0; i < numberOfStrings; i++)
        {
            string item = Console.ReadLine();
            Box<string> strBox = new Box<string>(item);
            boxList.Add(strBox);
        }

        int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        SwapString(indexes);
        PrintBoxes();
    }

    private static void PrintBoxes()
    {
        foreach (var box in boxList)
        {
            Console.WriteLine(box);
        }
    }

    private static void SwapString(int[] indexes)
    {
        int firstIndex = indexes[0];
        int secondIndex = indexes[1];

        Box<string> firstBox = boxList[firstIndex];
        Box<string> secondBox = boxList[secondIndex];

        boxList[firstIndex] = secondBox;
        boxList[secondIndex] = firstBox;
    }
}