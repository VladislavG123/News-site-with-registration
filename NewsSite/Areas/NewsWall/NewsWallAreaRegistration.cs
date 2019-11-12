using System.Web.Mvc;

namespace NewsSite.Areas.NewsWall
{
    public class NewsWallAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NewsWall";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NewsWall_default",
                "NewsWall/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}