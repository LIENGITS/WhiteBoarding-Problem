static void Main(string[] args)
        {
            // Swap Two Number Without A Third \ Temporary Variable.

            int a, b;
            Console.Write("Enter the Value for a = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the Vaule for b= ");
            b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After Swapping a = {a} and b = {b}");

        }
