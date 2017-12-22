
using AutoMapper;
using Ninject;
using Ninject.Web.Mvc;
using Project.Model;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebAPI.Views;

namespace WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.Initialize(config: cfg => {

                cfg.CreateMap<VehicleMake, IVehicleMake>();   
                cfg.CreateMap<VehicleMakes, IVehicleMake>();
                cfg.CreateMap<VehicleModel, IVehicleModel>();

            });
        }
        
    }
}
