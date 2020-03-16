﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ExpressoApi
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

            //how to get the data in Json format
            //only get the data in json format both in web browser as well as postman
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            //  config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/Html"));(appears in json format but not well indented)
            // formatting the data so that it appears well indented
            config.Formatters.JsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

        }
    }
}
