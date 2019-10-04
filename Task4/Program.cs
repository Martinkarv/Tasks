using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task4- Write a program to check if a user's input is a vowel(täishäälik) or something else

            string randomLetter;
            Console.WriteLine("Insert a random letter, please.");

            randomLetter = Console.ReadLine();
            switch(randomLetter)
            {
                case "a":
                    Console.WriteLine("It is a vowel!");
                    break;
                case "e":
                    Console.WriteLine("It is a vowel");
                    break;
                case "i":
                    Console.WriteLine("It is a vowel");
                    break;
                case "o":
                    Console.WriteLine("It is a vowel!");
                    break;
                case "u":
                    Console.WriteLine("It is a vowel");
                    break;
                case "õ":
                    Console.WriteLine("It is a vowel");
                    break;
                case "ä":
                    Console.WriteLine("It is a vowel!");
                    break;
                case "ö":
                    Console.WriteLine("It is a vowel");
                    break;
                case "ü":
                    Console.WriteLine("It is a vowel");
                    break;
                default:
                    Console.WriteLine("It is not a vowel!");
                    break;
            }

           

            Console.ReadLine();


        }
    }
}
