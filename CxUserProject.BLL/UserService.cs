﻿using CxUserProject.DB.Context;
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
        public IList<UserModel> GetAll()
        {
            DbContext dbContext = new DbContext();
            return dbContext.Users;
        }

        public UserModel GetById(int id)
        {
            DbContext dbContext = new DbContext();
            return dbContext.Users.First(t => t.Id == id);
        }
    }
}
