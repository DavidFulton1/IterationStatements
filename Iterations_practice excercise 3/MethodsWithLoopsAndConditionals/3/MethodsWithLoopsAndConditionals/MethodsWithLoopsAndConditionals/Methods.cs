using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Methods
    {
        public static void Printnumbers1000()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }

        }
        public static void Printnumbers999()
        {
            for (int n = 3; n <= 999; n += 3)
            {
                Console.WriteLine(n);
            }
        }


        public static void CheckifEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("these are equal");
            }
            else Console.WriteLine("the are not equal");
        }


        public static void CheckifOdd(int x)
        {
            if (x % 2 = 0)
            {
                Console.WriteLine("this number is even");
            }


            else Console.WriteLine("this number is odd");
        }
        public static void CheckifPositive(int x)
        {
            if (x < 0)
            {
                Console.WriteLine("This number is negative.");
            }
            else if (x = 0)
            {
                Console.WriteLine("This number is 0");
            }
            else Console.WriteLine("This number is positve");
        }
        public static void VotingAge()
        {
            Console.WriteLine("Please enter your age");
            var age = ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You can vote in this election! ");
            }
            else Console.WriteLine("You cannot vote");
        }
        public static void Checkrange()
        {
            Console.WriteLine("please enter a number from -10 to 10");
            var num = ToInt32(Console.ReadLine());
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine("Good Job!");
            }
            else Console.WriteLine("That number is not in that range");
        }
        public static void Multiplicationx12(int x)
        {
            int y = 2;
            do
            {
                answer = x * y++;
                Console.WriteLine(answer);

            } while (y <= 12);




        }
    }

}
    

