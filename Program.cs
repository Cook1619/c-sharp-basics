using System;

namespace CSharpBasics
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            int c = 3;
            if (a + b > 10 && c > 2) Console.WriteLine("The answer is greater than 10");
            else Console.WriteLine("The answer is less then 10");

            int counter = 0;
            // Checks the condition, then executes
            while(counter <= 10)
            {
                Console.WriteLine($"Counter is {counter}");
                counter++;
            }

            int counter2 = 0;

            // This is execute before checking the condition
            do
            {
                Console.WriteLine($"Counter 2 is {counter2}");
                    counter2++;
            } while (counter2 <= 10);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"The index is {i}");
            }

            // Find the sum of all the integers 1-20 that are divisible by 3
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine($"This number is divisble by 20: {i}");
                    sum += i;
                }
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}