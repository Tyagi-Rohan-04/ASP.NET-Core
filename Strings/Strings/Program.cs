// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    public static void Main(string[] args)
    {
        string greeting = "Hello World!";
        Console.WriteLine(greeting);
        Console.WriteLine("How many names you want to enter ?");
        int size = int.Parse(Console.ReadLine());
        string[] names = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter Name {i + 1}: ");
            names[i] = Console.ReadLine();
        }
        Console.WriteLine("\n The names in the upper case are: ");
        foreach(string name in names)
        {
            Console.WriteLine(name.ToUpper());
        }

        string allNames = string.Join(", ", names);
        Console.WriteLine($"\n All names concatenated: {allNames}");
        char[] allNamesarray = allNames.ToCharArray();
        Array.Reverse(allNamesarray);
        string reversedallNames = new string(allNamesarray);
        Console.WriteLine($"\n Reversed concatenated names: {reversedallNames}");
    }
}