using CxProject.DB;
using CxUserProject.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.DB.Context
{
    public class DbContext
    {
        public List<ProjectModel> Projects { get { return ProjectContext.ProjectContextList; } }
        public List<RoleModel> Roles { get { return RoleContext.RoleContextList; } }
        public List<UserModel> Users { get { return UserContext.UserContextList; } }
        public List<UserProjectModel> UserProjects { get { return UserProjectContext.UserProjectContextList; } }
        public List<UserRoleModel> UserRoles { get { return UserRoleContext.UserRoleContextList; } }
    }
}
