using System.Web;
using System.Web.Mvc;

namespace PrevencionSalud.Welcome
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
