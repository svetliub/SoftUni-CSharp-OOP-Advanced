using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Box<int>> boxList;
    static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());
        boxList = new List<Box<int>>();

        for (int i = 0; i < numberOfStrings; i++)
        {
            int item = int.Parse(Console.ReadLine());
            Box<int> strBox = new Box<int>(item);
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

        Box<int> firstBox = boxList[firstIndex];
        Box<int> secondBox = boxList[secondIndex];

        boxList[firstIndex] = secondBox;
        boxList[secondIndex] = firstBox;
    }
}