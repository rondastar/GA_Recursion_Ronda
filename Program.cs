namespace GA_Recursion_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tests
            PrintNumbersFrom1To10(1);
            CountDownAndUp(5);
        }

        // PrintNumbersFrom1To10 - Step by Step
        static void PrintNumbersFrom1To10(int currentNumber)
        {
            // Check if the current number is less than or equal to 10
            // If true, proceed with the following steps.
            if (currentNumber <= 10) // Base case ensures we don't continue indefinitely
            {
                // Print the current number
                Console.WriteLine(currentNumber);

                // Increase the current number by 1
                int nextNumber = currentNumber + 1;

                // Recursively call the function with the next number
                PrintNumbersFrom1To10(nextNumber);

                // When the recursion passes 10, it stops automatically. (Base case exit)
            }
        }

        // CountDownAndUp - Call Stack
        static void CountDownAndUp(int currentNumber)
        {
            // Base Case Check for Counting Down: Ensure we don't continue indefinitely while counting down
            if (currentNumber >= 1)
            {
                Console.WriteLine($"Before Recursive Call: {currentNumber}");

                // Recursive Call: Recursively count down
                CountDownAndUp(currentNumber - 1);

                Console.WriteLine($"After Recursive Call: {currentNumber}");
                // Print the same number while counting up

                // Because the code after the recursive call is not reached until after all of the recursive calls, 
                // each number is printed in reverse order of how they were called, effectively counting up.
                // If too many recursive calls are made, it can cause a stack overflow
            }
        }

        // CalculateSum - working with arrays

        // Fibonacci
    }
}
