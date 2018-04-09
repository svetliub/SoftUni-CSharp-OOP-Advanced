using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CommandInterpreter
{
    private CustomList<string> customList;

    public CommandInterpreter()
    {
        this.customList = new CustomList<string>();
    }

    public void Run()
    {
        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            string[] args = input.Split().ToArray();
            string command = args[0];

            switch (command)
            {
                case "Add":
                    this.customList.Add(args[1]);
                    break;
                case "Remove":
                    this.customList.Remove(int.Parse(args[1]));
                    break;
                case "Contains":
                    Console.WriteLine(this.customList.Contains(args[1]));
                    break;
                case "Swap":
                    this.customList.SwapString(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Greater":
                    Console.WriteLine(this.customList.CountGreaterThan(args[1]));
                    break;
                case "Max":
                    Console.WriteLine(this.customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(this.customList.Min());
                    break;
                case "Sort":
                    this.customList.Sort();
                    break;
                case "Print":
                    this.customList.Print();
                    break;
                    default:
                        throw new InvalidOperationException("Invalid command!");
            }
        }
    }
}