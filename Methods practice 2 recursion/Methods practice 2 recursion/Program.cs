using System;
using System.Collections.Generic;

namespace Methods_practice_2_recursion
{
    class Program
    {

        //1. Write a method Power that accepts two integers (a, b) and returns a to the power of b by multiplying a with a to the power of b - 1.
        static int Power(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * Power(a, b - 1);
            }
        }

        //2. Write a method Factorial that accepts an integer n and returns its factorial by multiplying n with Factorial of n - 1.
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //3. Write a method Fibonacci that accepts an integer n and returns the n-th Fibonacci number (Fibonacci(n - 1) + Fibonacci(n - 2)).
        static int Fibonacci(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            int previousNumber = Fibonacci(n - 1);
            int secondPrevious = Fibonacci(n - 2);

            return previousNumber + secondPrevious;

        }





        static void Main(string[] args)
        {
            // 1.
            Console.WriteLine(Power(4, 6));
            Console.WriteLine();

            // 2.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Factorial(1 + i));
            }
            Console.WriteLine();

            // 3.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fibonacci(i));

            }







            Console.ReadKey(true);
        }
    }
}
