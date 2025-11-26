using System;

namespace reverseword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to reverse:");
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversed = new string(charArray);

                Console.WriteLine("Reversed word: " + reversed);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-empty word.");
            }
        }
    }
}