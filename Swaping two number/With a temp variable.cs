static void Main(string[] args)
        {
            // Swap Two Number Wih A Third \ Temporary Variable.

            int a, b, temp;
            Console.Write("Enter the Value for a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Vaule for b= ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swapping a = {a} and b = {b}");

        }
