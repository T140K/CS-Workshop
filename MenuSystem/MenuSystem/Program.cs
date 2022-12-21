namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            mainMenu();
        }

        static void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my menu app");
            Console.WriteLine();
            Console.WriteLine("(1) about this app");
            Console.WriteLine("(2) guess this riddle for a prize!");
            Console.WriteLine("(3) play a game");
            Console.WriteLine("(e) exit");

            string options = Console.ReadLine();
            switch (options)
            {
                case "1":
                    about();
                    break;
                case "2":
                    riddle();
                    break;
                case "3":
                    game();
                    break;
                case "e":
                    exit();
                    break;
            }
            mainMenu();
        }
        static void about()
        {
            Console.WriteLine("this app was possible due to some dedication");
            Console.Write("press space to continiue");
            Console.ReadLine();
        }

        static void riddle()
        {
            Console.WriteLine("The riddle is on its way");
            Console.Write("press space to continiue");
            Console.ReadLine();
        }

        static void game()
        {
            Console.WriteLine("The game is in progress");
            Console.Write("press space to continiue");
            Console.ReadLine();
        }
        
        static void exit()
        {
            Console.WriteLine("Im killing myself");
            System.Environment.Exit(1);
        }
    }
}