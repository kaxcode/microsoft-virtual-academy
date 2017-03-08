using System;

namespace UnderstandingScope
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10 ; i++)       
            {
                j = i.ToString();
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
