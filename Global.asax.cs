using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MCISBCWebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_BeginRequest(Object sender, EventArgs e)
        {
            var lang = Request.QueryString["lang"];
            if (!string.IsNullOrEmpty(lang))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);
            }
        }
        protected void Application_Start()
        {


            //string directoryPath = @"E:\WORKKKKKKKK\Repos\MCI new\SBC Case web app\MCISBCWebApp\Connected Services\MCIGateWayServiceNSP"; // Specify your directory path here


            //// Get all files in the directory
            //string[] files = Directory.GetFiles(directoryPath);

            //foreach (string filePath in files)
            //{
            //    // Get the file name and directory
            //    string directory = Path.GetDirectoryName(filePath);
            //    string fileName = Path.GetFileName(filePath);

            //    string newFileName = fileName;
            //    if (fileName.Split('.')[0].Trim().Equals("TestCommercialRegisterationAPI"))
            //    {
            //        newFileName = "MCISBCWebApp." + string.Join(".", fileName.Split('.').Skip(1));
            //    }


            //    // Combine the directory with the new file name
            //    string newFilePath = Path.Combine(directory, newFileName);

            //    // Rename the file
            //    File.Move(filePath, newFilePath);

            //    Console.WriteLine($"Renamed {fileName} to {newFileName}");
            //}

            //Console.WriteLine("All files have been renamed successfully.");



            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}