using System.Web;
using System.Web.Mvc;

namespace Ch0301FacebookWebExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
