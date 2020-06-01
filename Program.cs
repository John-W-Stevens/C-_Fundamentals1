using System;

namespace Fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            for (int i=1; i<=255; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //Create a new loop that prints all values from 1 - 100 that are divisible by 3 or 5, but not both
            for (int i=1; i<=100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            Console.WriteLine();
            // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for (int i=1; i<=100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }

            // (Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!

            // first one:
            int k = 1;
            int limit1 = 100;
            while( k <= limit1)
            {
                if (k % 3 == 0 || k % 5 == 0)
                {
                    if (k % 3 == 0 && k % 5 == 0)
                    {
                        k += 1;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(k);
                    }
                }
                k += 1;
            }

            // second one
            int j = 1;
            int limit2 = 100;
            while (j <= limit2)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                j += 1;
            }
            Console.WriteLine("All done");
        }
    }
}
