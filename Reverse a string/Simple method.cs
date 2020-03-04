  public static string ReverseString()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            string reverse = "";
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse = reverse + charArray[i];
           }
            return reverse;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string, return the string that is reverse of the given string\n");
            Console.WriteLine($"The reverse word is {ReverseString()}");

        }
    }
}
   
