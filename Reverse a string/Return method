using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reversed = ReverseString("Hello");
            Console.WriteLine(Reversed);
        }
        public static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            return new string(charArray);
        }
    }
}
            
