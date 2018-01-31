using System.Web.Mvc;

namespace HhcTst.Areas.Stockist
{
    public class StockistAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Stockist";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Stockist_default",
                "Stockist/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}