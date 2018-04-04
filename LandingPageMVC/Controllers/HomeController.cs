using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.ApplicationInsights;
using System.Threading;

namespace LandingPageMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TelemetryClient telemetry = new TelemetryClient();
            telemetry.TrackTrace("User opened the page");

            return View();
        }

        public ActionResult SlowServerPage()
        {
            for (int i = 0; i < 500; i++)
                Thread.Sleep(10);

            return View();
        }


        public ActionResult SlowClientPage()
        {
            return View();
        }


        public ActionResult ServerBugPage()
        {
            return View();
        }


    }
}