using CxUserProject.DB;
using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxProject.DB
{
    public class RoleContext : IDbInitialze
    {
        public static List<RoleModel> RoleContextList = new List<RoleModel>();

        public void Initialze()
        {
            var lstRole = new List<RoleModel>()
            {
                new RoleModel()
                {
                    CreateDate = DateTime.Now,
                    CreateUser = UserContext.UserContextList.Single(t => t.Id == 1),
                    Id = 1,
                    Name = "Admin",
                    UpdateDate = DateTime.Now,
                    UpdateUser = UserContext.UserContextList.Single(t => t.Id == 1)
                },
                new RoleModel()
                {
                    CreateDate = DateTime.Now,
                    CreateUser = UserContext.UserContextList.Single(t => t.Id == 1),
                    Id = 2,
                    Name = "Manager",
                    UpdateDate = DateTime.Now,
                    UpdateUser = UserContext.UserContextList.Single(t => t.Id == 2)
                }
            };

            RoleContextList.AddRange(lstRole);
        }
    }
}
