using System;
using System.Collections.Generic;

namespace RoShamBo.Objects
{
  public class Game
  {
    // Choices and random for AI player
    private List<string> _computerChoices = new List<string> { "rock", "paper", "scissors" };
    private Random _rng = new Random();
    private string _p1Choice;
    private string _p2Choice;
    private List<string> _choices = new List<string> { };
    private Dictionary<string, string> _results = new Dictionary<string, string> {};

    public Game(string p1Choice)
    {
      _p1Choice = p1Choice;
      _p2Choice = _computerChoices[_rng.Next(0, 3)];
      _choices.Add(_p1Choice);
      _choices.Add(_p2Choice);
    }

    public Dictionary<string, string> CheckWin()
    {
      if (_choices.Contains("rock") && _choices.Contains("paper"))
      {
        _results.Add("choice","paper");
        _results.Add("index", _choices.IndexOf("paper").ToString());
        return _results;
      }
      else if (_choices.Contains("rock") && _choices.Contains("scissors"))
      {
        _results.Add("choice", "rock");
        _results.Add("index", _choices.IndexOf("rock").ToString());
        return _results;
      }
      else if (_choices.Contains("scissors") && _choices.Contains("paper"))
      {
        _results.Add("choice", "scissors");
        _results.Add("index", _choices.IndexOf("scissors").ToString());
        return _results;
      }
      else if (_choices[0] == _choices[1])
      {
        _results.Add("index", "3");
        _results.Add("choice", "Draw");
        return _results;
      }
      else
      {
        _results.Add("index", "4");
        _results.Add("choice", "Error");
        return _results;
      }
    }

    public string OutputString(string winningIndex, string winningChoice)
    {
      int winner = int.Parse(winningIndex);
      if (winner <= 1)
      {
        int winningPlayer = winner + 1;
        return "Player "+winningPlayer+" chose "+winningChoice+" and wins!";
      }
      else if (winner == 3)
      {
        return "Draw!";
      }
      else
      {
        return "ERROR!";
      }
    }
  }
}
