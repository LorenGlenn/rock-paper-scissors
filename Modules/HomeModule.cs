using Nancy;
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
        Game newGame = new Game(p1Choice, "rock");
        int resultNumber = newGame.CheckWin();
        string resultString = newGame.OutputString(resultNumber);
        return View["index.cshtml", resultString];
      };

    }
  }
}
