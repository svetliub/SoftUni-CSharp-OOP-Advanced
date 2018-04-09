using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = ReadFromConsole();
        var firstItem = input[0] + " " + input[1];
        var secondItem = input[2];
        
        Tuple<string, string> firstLine = new Tuple<string, string>(firstItem, secondItem);

        input = ReadFromConsole();
        var name = input[0];
        var beerLitres = int.Parse(input[1]);
        Tuple<string, int> secondLine = new Tuple<string, int>(name, beerLitres);

        input = ReadFromConsole();
        var intNumber = int.Parse(input[0]);
        var doubleNumber = double.Parse(input[1]);
        Tuple<int, double> thirdLine = new Tuple<int, double>(intNumber, doubleNumber);

        Console.WriteLine(firstLine);
        Console.WriteLine(secondLine);
        Console.WriteLine(thirdLine);
    }

    private static string[] ReadFromConsole()
    {
        return Console.ReadLine().Split().ToArray();
    }
}