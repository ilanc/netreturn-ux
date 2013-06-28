using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class App1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public static string SS_GridDataTemplate = "{ company = \"{0}\", price = {1}, change = {2:0.##}, pctChange = {3:0.##}, lastChange = \"{4}\" }";
        public static string SS_ChartDataTemplate = "{ ID = {0}, Month = \"{1}\", Sample1 = {2} }";

        public ActionResult Data()
        {
            Api.App1Controller.SerialiseGridData(HttpContext.Response);
            Api.App1Controller.SerialiseChartData(HttpContext.Response);

            HttpContext.ApplicationInstance.CompleteRequest();
            return new JavaScriptResult();
        }
    }
}
