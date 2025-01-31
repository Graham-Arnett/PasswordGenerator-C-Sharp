﻿using System.Linq.Expressions;

namespace PasswordGenApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Password Generator App!");
            Random random = new Random();
            string choice;
            char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9','0'};
            char[] specialSyms = {'!','@','#','$','%','^','&','*','(',')','_','-','+','='};
            bool validInput = false;
            do
            {

                while (!validInput)
                {
                    Console.Write("\nPlease enter a number for how long you want your password: ");

                    //int passSize = int.TryParse(Console.ReadLine());
                    string passlength = Console.ReadLine();
                    if (int.TryParse(passlength, out int passSize))
                    {

                        for (int i = passSize - 1; i >= 0; i--)//originally it was i=passSize and the last i was an increment but that filled the page.
                        {
                            int symbolType = random.Next(0, 3);
                            int letterChoice = random.Next(0, 26);
                            int numChoice = random.Next(0, 10);
                            int symChoice = random.Next(0, 14);
                            //might come back to this with a switch statement version
                            //if (symbolType == 1)
                            //{
                            //    Console.Write(letters[letterChoice]);
                            //}
                            //else if (symbolType == 2)
                            //{
                            //    Console.Write(numbers[numChoice]);
                            //}
                            //else
                            //{
                            //    Console.Write(specialSyms[symChoice]);
                            //}
                            switch (symbolType)
                            {
                                case 0:
                                    Console.Write(letters[letterChoice]);
                                    break;
                                case 1:
                                    Console.Write(numbers[numChoice]);
                                    break;
                                case 2:
                                    Console.Write(specialSyms[symChoice]);
                                    break;
                            }
                            validInput = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was invalid. Please enter an integer.");

                    }
                }

            Console.Write("\nWould you like to generate a new password? (y/n): ");
            choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
