using System;

namespace Quiz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PART 1");
            Console.WriteLine("MM        MM SSSSSSS  SSSSSSS   AAAAAA");
            Console.WriteLine("MMM     MMMM SSSSSSS  SSSSSSS   AA  AA");
            Console.WriteLine("MMMM   MMMMM SS       SS       AA    AA");
            Console.WriteLine("MM MM  MM MM SS       SS       AA    AA");
            Console.WriteLine("MM MM MM  MM SSSSSSS  SSSSSSS AAAAAAAAAA");
            Console.WriteLine("MM   MM   MM SSSSSSS  SSSSSSS AAAAAAAAAAA");
            Console.WriteLine("MM        MM      SS       SS AA       AA");
            Console.WriteLine("MM        MM      SS       SS AA       AA");
            Console.WriteLine("MM        MM SSSSSSS  SSSSSSS AA       AA");
            Console.WriteLine("MM        MM SSSSSSS  SSSSSSS AA       AA");
            Console.WriteLine("PART 2");
            double phi = (1 + Math.Sqrt(5)) / 2;
            Console.WriteLine($"phi is {phi}");

        }
    }
}
