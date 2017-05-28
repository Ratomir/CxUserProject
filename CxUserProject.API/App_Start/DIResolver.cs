using CxUserProject.API.Resolver;
using CxUserProject.BLL;
using CxUserProject.Interface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CxUserProject.API.App_Start
{
    public static class DIResolver
    {
        public static void Configure(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());
            container.RegisterType<IRoleService, RoleService>(new HierarchicalLifetimeManager());
            container.RegisterType<IProjectService, ProjectService>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}