﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab30NMH
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //http://domain-name/San-Pham/Danh-Sach-San-Pham
            routes.MapRoute(
            name: "Show Product",
            url: "San-Pham/Danh-Sach-San-Pham",
            defaults: new { controller = "Product", action = "ShowProduct" }
            );
            //http://domain-name/San-Pham
            routes.MapRoute(
            name: "Product",
            url: "San-Pham",
            defaults: new { controller = "Product", action = "ShowProduct" }
            );

            //http://domain-name/San-Pham/Sua/productId
            routes.MapRoute(
            name: "Edit Product",
            url: "San-Pham/Sua/{productId}", defaults: new
            {
                controller = "Product",
                action = "EditProduct",
                productId = @"\d{1,4}"
            });
        }
    }
}