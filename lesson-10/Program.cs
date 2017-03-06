﻿using System;

namespace HelperMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("The Name Game");

          Console.Write("What's your first name? ");
          string firstName = Console.ReadLine();

          Console.Write("What's your last name? ");
          string lastName = Console.ReadLine();

          Console.Write("What city were you born? ");
          string city = Console.ReadLine();

          DisplayResult(ReverseString(firstName), 
                ReverseString(lastName), 
                ReverseString(city));

          Console.ReadLine();
        }
         

        // Method to Reverse the String 

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
    }
}
