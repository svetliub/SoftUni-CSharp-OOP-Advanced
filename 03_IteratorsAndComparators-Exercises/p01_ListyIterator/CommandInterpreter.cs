using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CommandInterpreter
{
    private List<string> myList;
    private ListyIterator<string> listyIterator;

    public void Run()
    {
        try
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] arguments = input.Split().ToArray();
                string command = arguments[0];
                string[] methodArgs = arguments.Skip(1).ToArray();

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "Create":
                        Create(methodArgs);
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                    //default:
                    //    throw new InvalidOperationException("Invalid Operation!");
                }
            }
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public void Create(params string[] args)
    {
        if (args.Length == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }

        this.myList = new List<string>(args);
        this.listyIterator = new ListyIterator<string>(myList);
    }
}