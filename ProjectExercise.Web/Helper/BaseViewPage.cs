using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjectExercise.Web.Helper
{
    public static class RequestExtensions
    {
        public static bool IsCurrentRoute(this RequestContext context, params string[] routenames)
        {
            var routeData = context.RouteData;
            var current = false;

            if (routeData.Route != null)
            {
                var route = ((System.Web.Routing.Route)(routeData.Route)).Url;
                if (routenames.Contains(route))
                    current = true;
            }

            return current;
        }
    }

    public static class UrlExtensions
    {
        public static bool IsCurrent(this UrlHelper urlHelper, params string[] routenames)
        {
            return urlHelper.RequestContext.IsCurrentRoute(routenames);
        }

        public static string Selected(this UrlHelper urlHelper, params string[] routenames)
        {
            return urlHelper.IsCurrent(routenames)
                ? "active" : String.Empty;
        }
    }

}