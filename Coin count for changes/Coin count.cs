
        static void Main(string[] args)
        {
            CoinCount(12.33);

        }
        public static void CoinCount(double input)
        {
            int centAmount = Convert.ToInt32(input * 100);
            int quarters = centAmount / 25;
            centAmount %= 25;

            int dimes = centAmount / 10;
            centAmount %= 10;

            int nickles = centAmount / 5;
            centAmount %= 5;

            int pennies = centAmount / 1;

            Console.WriteLine($"Quarters: {quarters}\nDimes: {dimes}\nNick: {nickles}\nPennies: {pennies}");
 
           
