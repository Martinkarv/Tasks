using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2- Write a program to check whether a user's number is divisible by 5 and 11 or not

            int userNumber;
            Console.WriteLine("Insert a random rumber please.");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 5 == 0)
            {
                Console.WriteLine($"{userNumber} divides by 5.");
            }

            else if (userNumber % 11 == 0)
            {
                Console.WriteLine($"{userNumber} divides by 11.");
            }

            else if (userNumber % 11 == 0 && userNumber % 5 == 0) ;
            {
                Console.WriteLine($"{userNumber} divides by 11 and by 5.");
            }

            else
            {
                Console.WriteLine("Your number does not divide by 5 or by 11.");
            }

            Console.ReadLine();
          





        }
    }
}
