using System.Web;
using System.Web.Mvc;

namespace RajvinderYogi_Assignment2_COMP2084
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            // add SSL
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
