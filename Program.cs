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
                // Console.WriteLine($"Counter is {counter}");
                counter++;
            }

            int counter2 = 0;

            // This is execute before checking the condition
            do
            {
                // Console.WriteLine($"Counter 2 is {counter2}");
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
                    // Console.WriteLine($"This number is divisble by 20: {i}");
                    sum += i;
                }
            }
            Console.WriteLine($"The total sum is: {sum}");

            var names = new List<string> { "Danelle", "Flynn", "Matt", "Juliette", "Lilly" };
            var nums = new List<int> { 1, 10, 23, 2, 56, 3, 45, 34 };
            nums.Sort();
            foreach(int num in nums)
            {
                Console.WriteLine($"Nums are: {num}");
            }
            names.Add("Kali");
            names.Remove("Matt");
            var flynn = names.IndexOf("Flynn");
            Console.WriteLine(flynn);
            names.Sort();
            foreach (string name in names)
            {
                Console.WriteLine($"Name is: {name.ToUpper()}");
            }
        }
    }
}