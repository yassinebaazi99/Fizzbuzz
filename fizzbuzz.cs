using System;

public class Program
{
    public static void FizzBuzz(int x) 
    {
        if (x % 3 == 0 && x % 5 == 0) 
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (x % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (x % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else 
        {
            Console.WriteLine("this number is not fizzbuzzable");
        }
    }

    public static void Main(string[] args)
    {
        string y; 
        int z;
        
        Console.WriteLine("Write a number");
        
        y = Console.ReadLine(); 

        if (int.TryParse(y, out z))
        {
            FizzBuzz(z); 
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
