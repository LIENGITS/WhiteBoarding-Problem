
        static void Main(string[] args)
        {
            int[] coins = { 25, 10, 5, 1 };
            int amount, count, i;
            Console.Write("Enter the amount you want to change: ");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________________");
            for (i = 0; i < coins.Length; i++)
            {
                count = amount / coins[i];
                if (count != 0)
                    Console.WriteLine("Count of {0} cent(s) :{1}", coins[i], count);
                amount %= coins[i];
            }
            Console.ReadLine();
        }

 

