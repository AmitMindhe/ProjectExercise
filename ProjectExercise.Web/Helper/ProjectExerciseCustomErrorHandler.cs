using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectExercise.Web.Helper
{
    public class ProjectExerciseCustomErrorHandler : HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            var model = new HandleErrorInfo(filterContext.Exception, "Home", "Error");

            filterContext.Result = new ViewResult()
            {
                ViewName = "Error",
                ViewData = new ViewDataDictionary(model)
            };

            //log error
            if (exception != null)
            {
                    //Maintain User Log in File
                    string folderPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/ErrorLogs/");
                    string fileName = "ErrorLog_" + DateTime.UtcNow.ToLocalTime().Day + "-" + DateTime.UtcNow.ToLocalTime().Month + "-" + DateTime.UtcNow.ToLocalTime().Year + ".txt";
                    string fullPath = Path.Combine(folderPath, fileName);
                    if (!System.IO.File.Exists(fullPath))
                    {
                        using (FileStream fs = System.IO.File.Create(fullPath)) { }
                    }
                    if (System.IO.File.Exists(fullPath))
                    {
                        System.IO.StreamWriter file = new System.IO.StreamWriter(fullPath, true);
                        file.WriteLine("Date & Time - " + DateTime.UtcNow.ToLocalTime().ToString("dd/MM/yyyy h:mm:ss tt"));
                        file.WriteLine("Message - " + exception.Message);
                        file.WriteLine("Details - ");
                        file.WriteLine(exception.StackTrace);
                        file.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");
                        file.Close();
                    }
            }
        }
    }
}