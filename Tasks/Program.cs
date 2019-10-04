using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1- Write a program to check whether a user's number is positive, negative or zero
            start:
            int userNumber;
            Console.WriteLine("Insert a random number, please.");
            userNumber = int.Parse(Console.ReadLine());

            if(userNumber > 0)
            {
                Console.WriteLine("Your number is positive.");
                goto start;
            }

           else if(userNumber < 0)
            {
                Console.WriteLine("Your number is negative.");
                goto start;
            }
            else
            {
                Console.WriteLine("Your number is 0.");
                goto start;
            }



            Console.ReadLine();



        }
    }
}
