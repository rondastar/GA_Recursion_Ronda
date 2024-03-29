﻿namespace GA_Recursion_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test PrintNumbersFrom1To10
            PrintNumbersFrom1To10(1);

            // Test CountDownAndUp
            CountDownAndUp(5);

            // Test CalculateSum
            int[] numbers = { 12, 45, 7, 23, 9 }; // Adding 5 hardcoded numbers to the array

            Console.WriteLine("Array elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            int sum = CalculateSum(numbers, 0);
            Console.WriteLine($"\nSum of the array elements: {sum}");

            // Test Fibonacci
            int n = 9; // Change n to the desired Fibonacci sequence length
            Console.WriteLine($"Fibonacci sequence of length {n}:");
            for (int i = 0; i < n; i++)
            {
                int result = Fibonacci(i);
                Console.Write(result + " ");
            }

        }

        // PrintNumbersFrom1To10 - Step by Step
        static void PrintNumbersFrom1To10(int currentNumber)
        {
            // Check if the current number is less than or equal to 10
            // This is the base case - ensures we don't continue indefinitely
            // If true, proceed with the following steps.
            if (currentNumber <= 10) 
            {
                // Print the current number
                Console.WriteLine(currentNumber);

                // Increase the current number by 1 to determine the next number
                int nextNumber = currentNumber + 1;

                // Recursively call the function with the next number
                PrintNumbersFrom1To10(nextNumber);
            } // When the recursion passes 10, it stops automatically. (Base case)
        }

        // CountDownAndUp - Call Stack
        static void CountDownAndUp(int currentNumber)
        {
            // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
            if (currentNumber >= 1)
            {
                Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Recursive Call: Recursively count down - calls the method with the next lower number
                CountDownAndUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");
                // Print the same number while counting up
                // Because the code after the recursive call is not reached until after all of the recursive calls, 
                // each number is printed in reverse order of how they were called, effectively counting up.

                // Note: If too many recursive calls are made, it can cause a stack overflow
            } // if: only runs if current number is 1 or greater (base case)
        }

        // CalculateSum - working with arrays
        static int CalculateSum(int[] arr, int index)
        {
            // Base Case: If the index is equal to the array length, return 0 (no elements to add)
            if (index == arr.Length)
            {
                return 0;
            }
            else
            {
                // Recursive Case:
                // Add the current element (at the current index) to the sum of the rest of the elements
                int currentElement = arr[index];
                int restOfTheSum = CalculateSum(arr, index + 1);
                
                // The sum is returned after all recursive calls.
                return currentElement + restOfTheSum;
            }
        }

        // Fibonacci - Each number is the sum of the two that precede it
        // returns the first n digits of the Fibonacci sequence
        // 
        static int Fibonacci(int n)
        {
            // base case - returns n if n is 1 or 0 (the first two numbers in the Fibonacci sequence)
            if (n <= 1)
            {
                return n;
            }
            else
            {
                // Calculates the Fibonacci number by adding the previous two numbers in the sequence
                // The recursive call breaks the problem down into smaller sub-problems
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            // Note: This code takes exponentially more processing power
            // depending on how many numbers in the sequence are requested!
        }
    }
}
