using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise01_Morton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rawlston Morton");
            Console.WriteLine("Programming Exercise 01");
            Console.WriteLine("July 10 2020");

            Console.WriteLine("Part 1, Circumference and Area of a Circle.");
            Console.Write("Enter an integer for the radius");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = (2 * intradius * Math.PI );
            Console.WriteLine($"The Circumference is {circumference}");
            double area = Math.PI * (Math.Pow(intradius, 2));
            Console.WriteLine($"The Area is {area}");

            Console.WriteLine("Part 2, Volume of a Hemisphere");
            Console.WriteLine("Enter an integer for the Radius");
            string vrad = Console.ReadLine();
            int vradius = int.Parse(vrad);
            double volume = 4 / 3 * Math.PI * Math.Pow(vradius, 3) / 2;
            Console.WriteLine($"The volume of a hemisphere is {volume}");

            Console.WriteLine("Part 3, Area of a triangle, (Heron's Formula");
            Console.WriteLine("Enter a number for side a");
            string strsidea = Console.ReadLine();
            int intsidea = int.Parse(strsidea);
            Console.WriteLine("Enter a number for side b ");
            string strsideb = Console.ReadLine();
            int intsideb = int.Parse(strsideb);
            Console.WriteLine("Enter a number for side c");
            string strsidec = Console.ReadLine();
            int intsidec = int.Parse(strsidec);
            int p = (intsidea + intsideb + intsidec) / 2;
            double areaheron = Math.Sqrt(p * (p - intsidea) * (p - intsideb) * (p - intsidec));
            Console.WriteLine($"The area of a triangle is{areaheron}");

            Console.WriteLine("\nPart 4, Solving a Quadratic Equation");
            Console.WriteLine("Enter a non-negative number for a coeffiecient a:");
            string inta = Console.ReadLine();
            int coeffa = int.Parse(inta);
            Console.WriteLine("Enter a non-negative number for a coefficient b:");
            string intb = Console.ReadLine();
            int coeffb = int.Parse(intb);
            Console.WriteLine("Enter a non-negative number for a coefficient c:");
            string intc = Console.ReadLine();
            int c = int.Parse(intc);
            double denominator = 2 * (coeffa);
            double positive_num = (-coeffb + Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c))/ denominator;
            double negative_num = (-coeffb - Math.Sqrt((Math.Pow(coeffb, 2)) - 4 * coeffa * c))/ denominator;
            Console.WriteLine($"The positive result is {positive_num}");
            Console.WriteLine($"The negative result is {negative_num}");




























            Console.WriteLine("Solving a quadratic equation.");
            
            
            

            
           
        }
    }
}
