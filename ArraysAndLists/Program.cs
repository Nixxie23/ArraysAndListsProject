﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numOneToTen = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens= new List<int>();
            List<int> odds= new List<int>();

            foreach (int num in numOneToTen)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                { 
                    odds.Add(num);
            }
            }
            foreach (int evenNum in evens)
            {
                Console.WriteLine($"{evenNum} is an even number!");
            }
            foreach (int oddNum in odds)    
            {
                Console.WriteLine($"{oddNum} can't even! That means it must be odd!");
            }
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
