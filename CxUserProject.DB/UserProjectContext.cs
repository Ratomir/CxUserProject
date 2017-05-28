using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.DB
{
    public class UserProjectContext : IDbInitialze
    {
        public static List<UserProjectModel> UserProjectContextList = new List<UserProjectModel>();

        public void Initialze()
        {
            var lstUserProjectModel = new List<UserProjectModel>()
            {
                new UserProjectModel()
                {
                    Id = 1,
                    Project = ProjectContext.ProjectContextList.Single(t => t.Id == 1),
                    ProjectId = 1,
                    User = UserContext.UserContextList.Single(t => t.Id == 1),
                    UserId = 1
                },
                new UserProjectModel()
                {
                    Id = 2,
                    Project = ProjectContext.ProjectContextList.Single(t => t.Id == 1),
                    ProjectId = 1,
                    User = UserContext.UserContextList.Single(t => t.Id == 2),
                    UserId = 2
                },
                new UserProjectModel()
                {
                    Id = 3,
                    Project = ProjectContext.ProjectContextList.Single(t => t.Id == 2),
                    ProjectId = 2,
                    User = UserContext.UserContextList.Single(t => t.Id == 1),
                    UserId = 1
                }
            };

            UserProjectContextList.AddRange(lstUserProjectModel);
        }
    }
}
