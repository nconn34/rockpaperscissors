using System;
using System.Collections.Generic;

namespace RockPaperScissor.Logic {

  public class RockPaperScissorGame
  {
    public string DecideWhoWins(string user1, string user2)
    {
      if (user1 == user2)
      {
         return "draw";
      }
      //scissors and rock
      else if (user1 == "scissors" && user2 == "rock")
      {
        return "user2 wins!";
      }
      else if (user1 == "rock" && user2 == "scissors")
      {
        return "user1 wins!";
      }

      //scissors and paper
      else if (user1 == "scissors" && user2 == "paper")
      {
        return "user1 wins!";
      }
      else if (user1 == "paper" && user2 == "scissors")
      {
        return "user2 wins!";
      }

      //rock and paper
      else if (user1 == "rock" && user2 == "paper")
      {
        return "user2 wins!";
      }
      else if (user1 == "paper" && user2 == "rock")
      {
        return "user1 wins!";
      }

      else
      {
        return ("Invalid input");
      }

  }
}
}