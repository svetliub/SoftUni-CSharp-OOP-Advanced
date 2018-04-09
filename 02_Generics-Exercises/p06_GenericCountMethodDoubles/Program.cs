using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());
        List<double> boxList = new List<double>();

        for (int i = 0; i < numberOfStrings; i++)
        {
            double item = double.Parse(Console.ReadLine());
            boxList.Add(item);
        }

        double element = double.Parse(Console.ReadLine());
        Box<double> box = new Box<double>(boxList);

        Console.WriteLine(box.CompareCount(element));
    }
}