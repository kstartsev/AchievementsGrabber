﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AchievementsGrabber
{
	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			GlobalFilters.Filters.Add(new HandleErrorAttribute());

			RouteTable.Routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			RouteTable.Routes.MapRoute("Default", "{controller}/{action}/{id}", new {controller = "Home", action = "Index", id = UrlParameter.Optional});
		}
	}
}