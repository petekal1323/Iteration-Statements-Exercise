﻿namespace IterationStatements
{
    public class Program
    {
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.

        public static void AreNumbersEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.

        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"even");
            }
            else
            {
                Console.WriteLine($"odd");
            }
        }
        //    - Method Signature: bool IsEven(int number)
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        
        public static void IsPositive(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"{number} is positive.");
            }
            else
            {
                Console.WriteLine($"{number} is negative.");
            }
        }
        
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        
        public static void CanVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        
        public static void IsInRange(int number)
        {
            if (number >= -10 && number <= 10)
            {
                Console.WriteLine($"{number} is within the range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"{number} is not within the range of -10 to 10.");
            }
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"
        
        public static void DisplayMultiplicationTable(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {number} = {i * number}");
            }
        }

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.        
        static void Main(string[] args)
        {
            //PrintNumbers();
           //PrintEveryThirdNumber();
           //AreNumbersEqual(2, 2);
           //EvenOrOdd(2);
           //IsPositive(2);
           //CanVote(17);
           //IsInRange(4);
           //DisplayMultiplicationTable(4);
        }
    }
}
