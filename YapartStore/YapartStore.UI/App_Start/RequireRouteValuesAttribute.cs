using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace YapartStore.UI.App_Start
{
    public class RequireRouteValuesAttribute : ActionMethodSelectorAttribute
    {
        public RequireRouteValuesAttribute(string[] valueNames)
        {
            ValueNames = valueNames;
        }

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            StringBuilder currentRoute = new StringBuilder();
            StringBuilder myRoute = new StringBuilder();
            var valuesMyRoute =
                controllerContext.RequestContext.RouteData.Values.Keys.Where(x => x != "controller" && x != "action");
            foreach (var value in valuesMyRoute)
            {
                myRoute.Append(value + "/");
            }

            foreach (var value in ValueNames)
            {
                currentRoute.Append(value + "/");
            }

            if (myRoute.ToString() == currentRoute.ToString())
                return true;

            return false;

        }

        public string[] ValueNames { get; private set; }
    }
}