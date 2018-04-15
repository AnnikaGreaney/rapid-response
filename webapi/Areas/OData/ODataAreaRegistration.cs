using System.Web.Mvc;

namespace RapidResponse.webapi.Areas.OData
{
    public class ODataAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "OData";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "OData_default",
                "OData/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}