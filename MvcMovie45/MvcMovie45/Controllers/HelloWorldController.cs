﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie45.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "this is my <b>default</b> action";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode($"Hello {name}, number of times is {numTimes}.");
        }
    }
}