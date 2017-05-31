using CxUserProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxUserProject.Model;
using CxUserProject.DB.Context;

namespace CxUserProject.BLL
{
    public class ProjectService : IProjectService
    {
        public ProjectModel Create(ProjectModel entity)
        {
            DbContext dbContext = new DbContext();
            dbContext.Projects.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            DbContext dbContext = new DbContext();
            ProjectModel project = dbContext.Projects.First(u => u.Id == id);
            return dbContext.Projects.Remove(project);
        }

        public List<ProjectModel> GetAll()
        {
            DbContext dbContext = new DbContext();
            return dbContext.Projects;
        }

        public ProjectModel GetById(int id)
        {
            DbContext dbContext = new DbContext();
            return dbContext.Projects.First(t => t.Id == id);
        }

        public bool Update(int id, ProjectModel entity)
        {
            DbContext dbContext = new DbContext();
            int indexOfProject = dbContext.Projects.FindIndex(t => t.Id == id);

            if (indexOfProject != -1)
            {
                dbContext.Projects[indexOfProject] = entity;
                return true;
            }

            return false;
        }
    }
}
