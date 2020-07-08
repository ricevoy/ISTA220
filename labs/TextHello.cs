using System;

namespace TextHello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name;
            System.Console.Write("Enter Your Name:");
            name = System.Console.ReadLine();
            System.Console.WriteLine($"Hello, {name}");
        }
    }
}
