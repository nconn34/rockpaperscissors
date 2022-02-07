using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RockPaperScissor.Logic;
using System;

namespace RockPaperScissor.Tests
{
    [TestClass]
    public class ItemTests
    {

      [TestMethod]
      public void RockPaperScissor_GivesADrawResult()
      {
        //Arrange
        string user1 = "scissors";
        string user2 = "scissors";

        //Act
        string result = "draw";
        RockPaperScissorGame newGame = new RockPaperScissorGame();

        //Assert
        Assert.AreEqual(newGame.DecideWhoWins(user1, user2), result);
      }
      [TestMethod]
      public void RockPaperScissor_RockBeatsScissors()
      {
        //Arrange
        string user1 = "scissors";
        string user2 = "rock";

        //Act
        string result = "user2 wins!";
        RockPaperScissorGame newGame = new RockPaperScissorGame();

        //Assert
        Assert.AreEqual(newGame.DecideWhoWins(user1, user2), result);
      }
    }
}