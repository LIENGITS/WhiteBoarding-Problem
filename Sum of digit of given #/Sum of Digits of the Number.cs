static void Main(string[] args)
        {
            //Sum of Digits of the Number(146 = 1+4+6)
            //Logic is to use the Number to % by 10 to get the reminder and then / 10 to move 
            //to the next left index to get the reminder and sum them together with sum start with 
            //the vaule of "0".

            int n, k, sum = 0;
            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                sum = sum + k;
            }
            Console.WriteLine($"The sum of the digits are {sum}!");

        }
       
       
       
       */   n(number)     sum(total)     k(reminder)
        146/10=14 integer   0+6=6         146%10=6
         14/10=10           6+4=14         14%10=4
             0              14+1=15       10%10=1
             

               
  public static void SumofDigits(int n)
        {
            int k, sum = 0;

            while (n != 0)
            {
                k = n % 10;
                n = n / 10;
                sum = sum + k;
            }
            Console.WriteLine($"The sum of the digits are {sum}!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a digit!");
            SumofDigits(int.Parse(Console.ReadLine()));
        }
    }
}             
               
               
               
               
               
