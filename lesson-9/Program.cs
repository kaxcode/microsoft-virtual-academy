using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // int[] numbers = new int[5];

            // numbers[0] = 4;
            // numbers[1] = 8;
            // numbers[2] = 15;
            // numbers[3] = 16;
            // numbers[4] = 23;

            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers.Length);
            // Console.ReadLine();

            // OR

            // int[] numbers = new int[] {4, 8, 15, 16, 23, 42};
            // Console.WriteLine(numbers[1]);
            // Console.WriteLine(numbers.Length);
            // Console.ReadLine();

            // OR

            // string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee"};

            // for (int i=0; i < names.Length; i++)
            // {
            //     Console.WriteLine(names[i]);
            // }
            // Console.ReadLine();

            // OR

            // string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee"};

            // foreach (string name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // Console.ReadLine();

            // Reversing an array's chars

            string zig = "You can get what you want out of life if you help enough people get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.Write(zigChar);
            }

            Console.ReadLine();
        }
    }
}
