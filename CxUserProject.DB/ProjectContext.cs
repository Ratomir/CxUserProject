using CxUserProject.Model;
using CxUserProject.ReferenceEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.DB
{
    public class ProjectContext : IDbInitialze
    {
        public static List<ProjectModel> ProjectContextList = new List<ProjectModel>();

        public void Initialze()
        {
            var lstProjectModel = new List<ProjectModel>()
            {
                new ProjectModel()
                {
                    CreateDate = DateTime.Now,
                    CreatedUser = UserContext.UserContextList.Single(t => t.Id == 1),
                    CreateUser = UserContext.UserContextList.Single(t => t.Id == 1),
                    EndDateTime = DateTime.Now,
                    Id = 1,
                    ProjectStatus = ProjectStatusEnum.Open,
                    StartDateTime = DateTime.Now,
                    Title = "Title of project",
                    UpdateDate = DateTime.Now,
                    UpdateUser = UserContext.UserContextList.Single(t => t.Id == 2)
                },
                new ProjectModel()
                {
                    CreateDate = DateTime.Now,
                    CreatedUser = UserContext.UserContextList.Single(t => t.Id == 2),
                    CreateUser = UserContext.UserContextList.Single(t => t.Id == 2),
                    EndDateTime = DateTime.Now.AddDays(-5),
                    Id = 2,
                    ProjectStatus = ProjectStatusEnum.Open,
                    StartDateTime = DateTime.Now.AddDays(-5),
                    Title = "Title of project 2",
                    UpdateDate = DateTime.Now,
                    UpdateUser = UserContext.UserContextList.Single(t => t.Id == 1)
                },
                new ProjectModel()
                {
                    CreateDate = DateTime.Now,
                    CreatedUser = UserContext.UserContextList.Single(t => t.Id == 2),
                    CreateUser = UserContext.UserContextList.Single(t => t.Id == 2),
                    EndDateTime = DateTime.Now.AddDays(-10),
                    Id = 3,
                    ProjectStatus = ProjectStatusEnum.Open,
                    StartDateTime = DateTime.Now.AddDays(-10),
                    Title = "Title of project 3",
                    UpdateDate = DateTime.Now,
                    UpdateUser = UserContext.UserContextList.Single(t => t.Id == 3)
                }
            };

            ProjectContextList.AddRange(lstProjectModel);
        }
    }
}
