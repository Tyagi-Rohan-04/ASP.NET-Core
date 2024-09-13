using System;

class Person
{
    // Private Fields
    private string name;
    private int age;

    // Constructor
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    // Method to display person details
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects of the Person class using the constructor
        Person person1 = new Person("Alice", 30);
        Person person2 = new Person("Bob", 25);

        // Displaying person details
        person1.DisplayPersonInfo();
        person2.DisplayPersonInfo();

        Console.ReadKey();
    }
}
