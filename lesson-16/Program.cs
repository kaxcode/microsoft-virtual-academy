using System;

namespace UnderstandingScope
{
    public class Program
    {
        // private field. Sort of like a property that is private but available to all the member's of the class.
        private static string k = "";

        public static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10 ; i++)       
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);
            Console.ReadLine();
        }
    }
}
