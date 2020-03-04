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


      */ Logic if a = 3, b = 4;
         Make a new vaule for a, and then make a new vaule for b, and then a - b;
       a = 3+4 = 7; Now new a = 7;
       b = new a - old b = 3; New new b = 3; 
       a = new a - new b = 4
