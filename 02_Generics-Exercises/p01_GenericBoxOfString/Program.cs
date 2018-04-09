using System;

class Program
{
    static void Main(string[] args)
    {
        int numberOfStrings = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStrings; i++)
        {
            string item = Console.ReadLine();
            Box<string> strBox = new Box<string>(item);
            Console.WriteLine(strBox);
        }
    }
}
