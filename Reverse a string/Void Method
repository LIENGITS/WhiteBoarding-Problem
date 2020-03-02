using System;

namespace ReverseString 
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString();
        }
        public static void ReverseString()
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            char[] charArray = input.ToCharArray();
            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                charArray[i] = input[j];
                charArray[j] = input[i];
            }
            string Reversed = new string(charArray);
            Console.WriteLine(Reversed);
        }
    }                       
}






