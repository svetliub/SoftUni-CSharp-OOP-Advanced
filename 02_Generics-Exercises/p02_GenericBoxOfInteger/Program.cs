using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfInts = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfInts; i++)
        {
            int item = int.Parse(Console.ReadLine());
            Box<int> strBox = new Box<int>(item);
            Console.WriteLine(strBox);
        }
    }
}