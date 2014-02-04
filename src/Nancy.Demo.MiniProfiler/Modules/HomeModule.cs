using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using StackExchange.Profiling;

namespace NancyViewStart.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
            : base("/")
        {
            Get["/"] = _ =>
            {
                using (MiniProfiler.StepStatic("Indexing"))
                {
                    return View["index"];
                }
            };
        }
    }
}