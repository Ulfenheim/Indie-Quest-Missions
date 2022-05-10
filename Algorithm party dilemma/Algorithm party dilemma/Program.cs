using System;

namespace Algorithm_party_dilemma
{
    class Program
    {

        /*
        function factorial is:

        input: integer n such that n >= 0

        output: [n × (n-1) × (n-2) × ... × 1]


            1. if n is 0, return 1
            2. otherwise, return [ n × factorial(n-1) ]


        end factorial          
         */


        static double Factorial(int n)
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


        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(Factorial(1+i));
            }
            */

            Console.WriteLine(Factorial(2));





            Console.ReadKey(true);
        }
    }
}
