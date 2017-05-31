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
    public class RoleService : IRoleService
    {
        public RoleModel Create(RoleModel entity)
        {
            DbContext dbContext = new DbContext();
            dbContext.Roles.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            DbContext dbContext = new DbContext();
            RoleModel project = dbContext.Roles.First(u => u.Id == id);
            return dbContext.Roles.Remove(project);
        }

        public List<RoleModel> GetAll()
        {
            DbContext dbContext = new DbContext();
            return dbContext.Roles;
        }

        public RoleModel GetById(int id)
        {
            DbContext dbContext = new DbContext();
            return dbContext.Roles.First(t => t.Id == id);
        }

        public bool Update(int id, RoleModel entity)
        {
            DbContext dbContext = new DbContext();
            int indexOfRole = dbContext.Roles.FindIndex(t => t.Id == id);

            if (indexOfRole != -1)
            {
                dbContext.Roles[indexOfRole] = entity;
                return true;
            }

            return false;
        }
    }
}
