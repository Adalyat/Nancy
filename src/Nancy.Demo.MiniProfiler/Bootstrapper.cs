using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.TinyIoc;
using Nancy.Bootstrapper;
using StackExchange.Profiling;

namespace NancyViewStart
{
    public class Bootstrapper:DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);
            pipelines.BeforeRequest += PreRequest;
            pipelines.AfterRequest += PostRequest;
        }

        private static Response PreRequest(NancyContext ctx)
        {
            MiniProfiler.Start();
            return null;
        }

        private static void PostRequest(NancyContext ctx)
        {
            MiniProfiler.Stop();
        }
    }
}