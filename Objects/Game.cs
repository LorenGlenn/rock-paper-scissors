using System;
using System.Collections.Generic;

namespace RoShamBo.Objects
{
  public class Game
  {
    private string _p1Choice;
    private string _p2Choice;
    private List<string> _choices = new List<string> { };

    public Game(string p1Choice, string p2Choice)
    {
      _p2Choice = p2Choice;
      _p1Choice = p1Choice;
      _choices.Add(_p1Choice);
      _choices.Add(_p2Choice);
    }

    public int CheckWin()
    {
      if (_choices.Contains("rock") && _choices.Contains("paper"))
      {
        int result = _choices.IndexOf("paper");
        return result;
      }
      else if (_choices.Contains("rock") && _choices.Contains("scissors"))
      {
        int result = _choices.IndexOf("rock");
        return result;
      }
      else if (_choices.Contains("scissors") && _choices.Contains("paper"))
      {
        int result = _choices.IndexOf("scissors");
        return result;
      }
      else if (_choices[0] == _choices[1])
      {
        return 3;
      }
      else
      {
        return 4;
      }
    }

    public string OutputString(int result)
    {
      if (result <= 1)
      {
      result+=1;
      return "Player "+result+" wins!";
      }
      else if (result == 3)
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
