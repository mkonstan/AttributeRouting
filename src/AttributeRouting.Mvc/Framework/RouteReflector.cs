﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AttributeRouting.Framework;

namespace AttributeRouting.Mvc.Framework {
    public class RouteReflector : RouteReflector<IRouteConstraint, IController, AttributeRoute, UrlParameter, HttpContextBase, RouteData>
    {
        public RouteReflector(AttributeRoutingConfiguration configuration) : base(configuration) {}
    }
}
