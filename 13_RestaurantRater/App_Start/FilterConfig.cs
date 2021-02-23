using System.Web;
using System.Web.Mvc;

namespace _13_RestaurantRater
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
