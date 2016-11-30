using Nancy;
using System.Collections.Generic;
using RoShamBo.Objects;


namespace RoShamBo
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=> View["index.cshtml"];

      Post["/result"]=_=> {
        string p1Choice = Request.Form["p1Choice"];
        Game newGame = new Game(p1Choice);
        Dictionary<string, string> results = newGame.CheckWin();
        string resultString = newGame.OutputString(results["index"], results["choice"]);
        return View["index.cshtml", resultString];
      };

    }
  }
}
