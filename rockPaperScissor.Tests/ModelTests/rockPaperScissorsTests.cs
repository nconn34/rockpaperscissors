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
        //string methodReturnValue = RockPaperScissorGame.DecideWhoWins();

        //Assert
        Assert.AreEqual("true", result);
      }
    }
}