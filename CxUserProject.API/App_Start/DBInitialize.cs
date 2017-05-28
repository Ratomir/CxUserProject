using CxProject.DB;
using CxUserProject.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CxUserProject.API.App_Start
{
    public static class DBInitialize
    {
        public static void Initialze() => new List<IDbInitialze>()
        {
            new UserContext(),
            new RoleContext(),
            new ProjectContext(),
            new UserProjectContext(),
            new UserRoleContext()
        }.ForEach(context => context.Initialze());
    }
}