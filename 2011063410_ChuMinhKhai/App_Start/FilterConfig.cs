using System.Web;
using System.Web.Mvc;

namespace _2011063410_ChuMinhKhai
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
