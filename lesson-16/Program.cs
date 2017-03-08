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

                // In this case the l is not accessible because it's inside of an if/else statement
                // if (i == 9)
                // {
                //     string l = i.ToString();
                // }

                // Console.WriteLine(l);
            }
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            Car myCar = new Car();
            myCar.DoSomething();

            HelperMethod();
            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World!";
        }
    }
}
