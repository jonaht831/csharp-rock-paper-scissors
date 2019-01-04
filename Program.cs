using System;

namespace hwapp
{
  class Program
  {
    static void Main(string[] args)
    {
      int computerChoice;
      bool won = false;
      Console.WriteLine("Lets play Rock Paper Scissors");
      Random rng = new Random();
      computerChoice = rng.Next(0, 3);
      Console.WriteLine("Make your Choice");
      string playerChoice = Console.ReadLine();
      while (!won)
      {
        if (computerChoice == 0)
        {
          if (playerChoice == "rock")
          {
            Console.WriteLine("Tie Game!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
          else if (playerChoice == "paper")
          {
            Console.WriteLine("The computer chose rock");
            Console.WriteLine("You Win!");
            won = true;
          }
          else if (playerChoice == "scissors")
          {
            Console.WriteLine("You Loose!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
        }
        if (computerChoice == 1)
        {
          if (playerChoice == "rock")
          {
            Console.WriteLine("You Lose!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
          else if (playerChoice == "paper")
          {
            Console.WriteLine("Tie Game!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
          else if (playerChoice == "scissors")
          {
            Console.WriteLine("The computer chose paper");
            Console.WriteLine("You Win!");
            won = true;
          }
        }
        if (computerChoice == 2)
        {
          if (playerChoice == "rock")
          {
            Console.WriteLine("The computer chose scissors");
            Console.WriteLine("You Win!");
            won = true;
          }
          else if (playerChoice == "paper")
          {
            Console.WriteLine("You Lose!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
          else if (playerChoice == "scissors")
          {
            Console.WriteLine("Tie Game!");
            Console.WriteLine("Try Again!");
            playerChoice = Console.ReadLine();
          }
        }
      }
    }
  }
}