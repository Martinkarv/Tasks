using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task5- write a program that asks user to input a number(1-7) and print the corresponding day of week(Monday-Sunday)
            Start:
            int userAnswer;
            Console.WriteLine("Write a number from 1-7, please.Then I will tell you which day it is in the week.");
            userAnswer = int.Parse(Console.ReadLine());

            if(userAnswer == 1)
            {
                Console.WriteLine("It is Monday!");
            }
            else if(userAnswer == 2)
            {
                Console.WriteLine("It is Tuesday!");
            }
            else if(userAnswer == 3)
            {
                Console.WriteLine("It is Wednesday!");
            }
            else if(userAnswer == 4)
            {
                Console.WriteLine("It is Thursday!");
            }
            else if(userAnswer == 5)
            {
                Console.WriteLine("It is Friday!");
            }
            else if(userAnswer == 6)
            {
                Console.WriteLine("It is Saturday!");
            }
            else if(userAnswer == 7)
            {
                Console.WriteLine("It is Sunday!");
            }
            else
            {
                Console.WriteLine("Your number must be in the scale of 1-7.");
                goto Start;
            }

            Console.ReadLine();
        }

    }
}
