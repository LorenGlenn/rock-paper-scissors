// using Xunit;
// using RoShamBo.Objects;
//
// namespace RoShamBo.Tests
// {
//   public class GameTests
//   {
//     [Fact]
//     public void CheckWin_P1RockP2Scissors_P1Wins()
//     {
//       string p1Choice = "rock";
//       string p2Choice = "scissors";
//       Game testGame = new Game(p1Choice, "scissors");
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Player 1 wins!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P2RockP1Paper_P1Wins()
//     {
//       string p1Choice = "paper";
//       string p2Choice = "rock";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Player 1 wins!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P1PaperP2Scissors_P2Wins()
//     {
//       string p1Choice = "paper";
//       string p2Choice = "scissors";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Player 2 wins!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P1PaperP2Paper_Draw()
//     {
//       string p1Choice = "paper";
//       string p2Choice = "paper";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Draw!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P1RockP2Rock_Draw()
//     {
//       string p1Choice = "rock";
//       string p2Choice = "rock";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Draw!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P1ScissorsP2Scissors_Draw()
//     {
//       string p1Choice = "scissors";
//       string p2Choice = "scissors";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("Draw!", resultString);
//     }
//
//     [Fact]
//     public void CheckWin_P1ScissorsP2Blargh_Error()
//     {
//       string p1Choice = "scissors";
//       string p2Choice = "blargh";
//       Game testGame = new Game(p1Choice, p2Choice);
//       int resultNumber = testGame.CheckWin();
//       string resultString = testGame.OutputString(resultNumber);
//       Assert.Equal("ERROR!", resultString);
//     }
//   }
// }
