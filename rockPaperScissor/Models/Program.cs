using System;
using System.Collections.Generic;
using RockPaperScissor.Logic;

namespace RockPaperScissor 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Let's play Rock, Paper, Scissors!");
      {
      Console.WriteLine("User 1 enter rock paper or scissors");
      string user1Choice = Console.ReadLine();
      Console.WriteLine("User 2 enter rock paper or scissors");
      string user2Choice = Console.ReadLine();
      if (user1Choice == "rock" && user2Choice == "paper")
      {
        Console.WriteLine("user2 wins!");
      }
      else if (user1Choice == "rock" && user2Choice == "scissors")
      {
        Console.WriteLine("user1 wins!");
      }
      else if (user1Choice == "rock" && user2Choice == "rock")
      {
        Console.WriteLine("You tied...yourself?!");
      }
      else if (user1Choice == "paper" && user2Choice == "scissors")
      {
        Console.WriteLine("user2 wins!");
      }
      else if (user1Choice == "paper" && user2Choice == "rock")
      {
        Console.WriteLine("user1 wins!");
      }
      else if (user1Choice == "paper" && user2Choice == "paper")
      {
        Console.WriteLine("You tied...yourself?!");
      }
      else if (user1Choice == "scissors" && user2Choice == "rock")
      {
        Console.WriteLine("user2 wins!");
      }
      else if (user1Choice == "scissors" && user2Choice == "paper")
      {
        Console.WriteLine("user1 wins!");
      }
      else if (user1Choice == "scissors" && user2Choice == "scissors")
      {
        Console.WriteLine("You tied...yourself?!");
      }
      else
      {
        Console.WriteLine("I think you should learn the rules better...");
      }
      } 
    }
  }
}