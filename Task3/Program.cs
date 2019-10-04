using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3- write a program to check whether a user's number is even or odd
            start:
            int userNumber;
            Console.WriteLine("Insert a random number, please.");
            userNumber = int.Parse(Console.ReadLine());

            if(userNumber % 2 == 0)
            {
                Console.WriteLine("Your number is even.");
                goto start;
            }
            else
            {
                Console.WriteLine("Your number is odd.");
                goto start;
            }
            Console.ReadLine();
        }
    }
}
