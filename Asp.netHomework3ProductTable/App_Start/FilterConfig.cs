using System.Web;
using System.Web.Mvc;

namespace Asp.netHomework3ProductTable
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
