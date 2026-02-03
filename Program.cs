namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User 1 enter a number between 0 - 100");
            int secretNumber = int.Parse(Console.ReadLine());

            Console.Clear();

            int guess = 0;

            while (guess != secretNumber)
            {
                Console.WriteLine("User 2 guess a number between 0 - 100");
                guess = int.Parse(Console.ReadLine());

                if (guess > secretNumber)
                {
                    Console.WriteLine("Your number is too high, guess again");
                }
                
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Your number is too low, guess again");
                }
                else
                {
                    Console.WriteLine("Correct! You guessed the number");
                }
            }

        }
    }
    
}