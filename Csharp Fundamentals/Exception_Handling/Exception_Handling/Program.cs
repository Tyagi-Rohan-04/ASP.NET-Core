using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter the numerator: ");
            float num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the denominator: ");
            float denom = Convert.ToInt32(Console.ReadLine());

            float result = num / denom;

            Console.WriteLine($"Result: {result}");
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot be divided by zero.");
        }

        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid Format.");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error occured." + ex.Message);
        }

        finally { Console.WriteLine("The program ends here.");
        }
    }
}