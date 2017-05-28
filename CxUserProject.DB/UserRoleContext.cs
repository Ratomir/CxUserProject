using CxProject.DB;
using CxUserProject.DB.Context;
using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.DB
{
    public class UserRoleContext : IDbInitialze
    {
        public static List<UserRoleModel> UserRoleContextList = new List<UserRoleModel>();

        public void Initialze()
        {
            var lstUserRole = new List<UserRoleModel>()
            {
                new UserRoleModel()
                {
                    Id = 1,
                    RoleId = 1,
                    Role = RoleContext.RoleContextList.Single(t => t.Id == 1),
                    UserId = 1,
                    User = UserContext.UserContextList.Single(t => t.Id == 1)
                },
                new UserRoleModel()
                {
                    Id = 2,
                    RoleId = 1,
                    Role = RoleContext.RoleContextList.Single(t => t.Id == 1),
                    UserId = 2,
                    User = UserContext.UserContextList.Single(t => t.Id == 2)

                },
                new UserRoleModel()
                {
                    Id = 3,
                    RoleId = 2,
                    Role = RoleContext.RoleContextList.Single(t => t.Id == 2),
                    UserId = 1,
                    User = UserContext.UserContextList.Single(t => t.Id == 1)
                }
            };

            UserRoleContextList.AddRange(lstUserRole);
        }
    }
}
