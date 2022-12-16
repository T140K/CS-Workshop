namespace fuzzbuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fuzzbuzz();
        }

        public static void fuzzbuzz()
        {
            Console.WriteLine("Write a number\n");
                        
            string? a = Console.ReadLine();

            int p;
            if (Int32.TryParse(a, out p))
            { 
                for (int i = 1; i <= p; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("fuzzbuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("fuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("you have to write a number!");
                fuzzbuzz();
            }
        }
    }
}