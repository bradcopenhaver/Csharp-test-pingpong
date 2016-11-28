using Nancy;
using System;
using System.Collections.Generic;
using Pingpong.Objects;

namespace Pingpong
{
    public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get ["/"] = _ =>{
          return View["index.cshtml"];
        };
        Post ["/result"] = _ =>{
          int userInput = Request.Form["input"];
          PingpongGenerator pingPongObject = new PingpongGenerator(userInput);
          List<string> pingPongList = pingPongObject.CreateList();
          return View["results.cshtml", pingPongList];
        };
      }
    }
}
