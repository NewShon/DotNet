using System.Web.Http;
using Swagger.Net.Application;

namespace DotNet.WEB
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "swagger_root",
				routeTemplate: "",
				defaults: null,
				constraints: null,
				handler: new RedirectHandler((message => message.RequestUri.ToString()), "swagger"));

			GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
        }
    }
}
