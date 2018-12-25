using System;
using System.Text;

namespace ImmutableStrings
{
    class Program
    {
        static void Main(string[] args)
        {
//            int x = 5;
//            int y = x;
//            Console.WriteLine($"x = {x}, y = {y}");
//            Console.WriteLine($"x is the same as y: {object.ReferenceEquals(x, y)}");
//
//            string first = "This is a string";
//            string second = first;
//
//            Console.WriteLine($"first:  {first}");
//            Console.WriteLine($"second: {second}");
//
//            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
            
            StringBuilder first = new StringBuilder("This is a string");
            StringBuilder second = new StringBuilder("This is a string");
            
            Console.WriteLine($"first:  {first}");
//            Console.WriteLine($"second: {second}");
//            Console.WriteLine($"first is the same as second: {object.ReferenceEquals(first, second)}");
//            Console.WriteLine($"first == second: {first == second}");
//            Console.WriteLine($"first .Equals second: {first.Equals(second)}");
            Console.WriteLine("Clearing first....");
//            first.Length = 0;
//            Console.WriteLine($"first: *{first}*");
//            first.Append("Another string");
            first.Clear();
            first.Append("Another string");
            first.Clear().Append("Another string").Append(" ").Append(second);
            Console.WriteLine($"first: *{first}*");

            if (first.Clear() == first)
            {
                Console.WriteLine("The references are the same.");
            }
            
            StringBuilder third = new StringBuilder("The values are");
            int a = 12;
            int b = 34;
            int c = 56;
            third.AppendLine(":");
            third.AppendFormat("a = {0}, b = {1}, c = {2}", a, b, c);
//            Console.WriteLine(third);

            third.Append(12);
            third.Append(' ');
            third.Append(3.45);
            third.Append(' ');
            third.Append(a == 12);
            third.Append(' ');
            third.Append(b > c);

            third.AppendLine().Append('*', 40);
            Console.WriteLine(third);
        }
    }
}