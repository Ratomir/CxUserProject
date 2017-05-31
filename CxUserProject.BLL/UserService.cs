using CxUserProject.DB.Context;
using CxUserProject.Interface;
using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.BLL
{
    public class UserService : IUserService
    {
        public UserModel Create(UserModel entity)
        {
            DbContext dbContext = new DbContext();
            dbContext.Users.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            DbContext dbContext = new DbContext();
            UserModel user = dbContext.Users.First(u => u.Id == id);
            return dbContext.Users.Remove(user);
        }

        public List<UserModel> GetAll()
        {
            DbContext dbContext = new DbContext();
            return dbContext.Users;
        }

        public UserModel GetById(int id)
        {
            DbContext dbContext = new DbContext();
            return dbContext.Users.First(t => t.Id == id);
        }

        public bool Update(int id, UserModel entity)
        {
            DbContext dbContext = new DbContext();
            int indexOfUser = dbContext.Users.FindIndex(t => t.Id == id);

            if (indexOfUser != -1)
            {
                dbContext.Users[indexOfUser] = entity;
                return true;
            }

            return false;
        }
    }
}
