using System;

namespace MultiplicationChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            bool run = true;
            while (run)
            {
                Console.Write("Number 1: ");
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    run = false;
                }
                catch { Console.WriteLine("Invalid number, please try again."); }
            }
            run = true;
            while (run)
            {
                Console.Write("Number 2: ");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    run = false;
                }
                catch { Console.WriteLine("Invalid number, please try again."); }
            }

            NumberResults(num1, num2);
            Console.ReadKey();
        }

        /*
         * Your function will be given 2 numbers.
         * It should print out every possible order of the resulting combinations.
         * 
         * For example: For 5 and 6:
         * 
         * 5 * 6 = 30
         * 
         * it will print out this:
         * 
         * 30
         * 03 (30 backwards)
         * 
         * for 20 and 12:
         * 
         * 20 * 12 = 240
         * 
         * it will print out this:
         * 
         * 240
         * 420
         * 042
         * 402
         * 204
         * 024
         * 
         * SHES A DINNER PLATE DINNER PLATE SHES A DINNER PLATE
         *
         */

        static void NumberResults(int number1, int number2)
        {
            int x = number1 * number2;
            Console.WriteLine(x);
            char[] myArray = x.ToString().ToCharArray();
            int[] arr = new int[myArray.Length];
            for(int i = 0; i < myArray.Length; i++) { arr[i] = Convert.ToInt32(myArray[i].ToString()); }
            foreach(int value in arr)
            {
                Console.WriteLine(value + " ");
            }
        }
    }
}
