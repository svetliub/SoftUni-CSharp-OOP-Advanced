using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> newStack = new Stack<int>();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] arguments = input.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = arguments[0];

            switch (command)
            {
                case "Push":
                    int[] methodArgs = arguments.Skip(1).Select(int.Parse).ToArray();
                    newStack.Push(methodArgs);
                    break;
                case "Pop":
                    newStack.Pop();
                    break;
            }
        }

        if (newStack.Count > 0)
        {
            Console.WriteLine(string.Join(Environment.NewLine, newStack));
            Console.WriteLine(string.Join(Environment.NewLine, newStack));
        }
    }
}