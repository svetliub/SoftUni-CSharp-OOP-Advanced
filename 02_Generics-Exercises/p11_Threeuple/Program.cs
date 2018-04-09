using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var input = ReadFromConsole();
        var firstItem = input[0] + " " + input[1];
        var secondItem = input[2];
        var town = input[3];
        Threeuple<string, string, string> firstLine = new Threeuple<string, string, string>(firstItem, secondItem, town);

        input = ReadFromConsole();
        var name = input[0];
        var beerLitres = int.Parse(input[1]);
        var drunk = input[2];
        bool isDrunk = drunk == "drunk";
        Threeuple<string, int, bool> secondLine = new Threeuple<string, int, bool>(name, beerLitres, isDrunk);

        input = ReadFromConsole();
        var userName = input[0];
        var doubleNumber = double.Parse(input[1]);
        var bankName = input[2];
        Threeuple<string, double, string> thirdLine = new Threeuple<string, double, string>(userName, doubleNumber, bankName);

        Console.WriteLine(firstLine);
        Console.WriteLine(secondLine);
        Console.WriteLine(thirdLine);
    }

    private static string[] ReadFromConsole()
    {
        return Console.ReadLine().Split().ToArray();
    }
}