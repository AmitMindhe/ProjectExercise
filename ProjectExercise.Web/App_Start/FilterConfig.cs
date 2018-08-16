using ProjectExercise.Web.Helper;
using System.Web;
using System.Web.Mvc;

namespace ProjectExercise.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new ProjectExerciseCustomErrorHandler());
        }
    }
}