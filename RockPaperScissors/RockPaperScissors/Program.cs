namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome");

            while (playerScore != 3 && enemyScore != 3) 
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter (r) for rock, (p) for paper and (s) for scissors");
                string? playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("enemy choice is rock");
                    
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("tie");
                            break;
                        case "p":
                            Console.WriteLine("player wins this round");
                            playerScore++;
                            break;
                        case "s":
                            Console.WriteLine("enemy wins this round");
                            enemyScore++;
                            break;
                    }
                } 
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("enemy choice is paper");
                    
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("enemy wins this round");
                            enemyScore++; 
                            break;
                        case "p":
                            Console.WriteLine("tie");
                            break;
                        case "s":
                            Console.WriteLine("player wins this round");
                            playerScore++;
                            break;
                    }
                } 
                else
                {
                    Console.WriteLine("enemy choice is scissors");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("player wins this round");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("enemy wins this round");
                            enemyScore++;
                            break;
                        case "s":
                            Console.WriteLine("tie");
                            break;
                    }
                }
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You WIN!");
            }
            else
            {
                Console.WriteLine("YOU LOSE!");
            }
        }
    }
}