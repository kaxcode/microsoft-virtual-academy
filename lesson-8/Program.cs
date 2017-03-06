using System;

namespace ForIteration
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine();
                if (i == 7 )
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
