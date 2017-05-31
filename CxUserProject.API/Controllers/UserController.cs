using CxUserProject.Interface;
using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CxUserProject.API.Controllers
{
    public class UserController : BaseApiController<UserModel>
    {
        public IUserService _userService { get; set; }

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public override List<UserModel> Get()
        {
            var users = _userService.GetAll();
            return users;
        }

        [HttpGet]
        public override UserModel GetById(int id)
        {
            UserModel user = _userService.GetById(id);
            return user;
        }

        [HttpPost]
        public override UserModel Create([FromBody] UserModel model)
        {
            UserModel createdUserModel = _userService.Create(model);
            return createdUserModel;
        }

        [HttpPut]
        public override bool Put(int id, [FromBody] UserModel model)
        {
            bool isUpdated = _userService.Update(id, model);
            return isUpdated;
        }

        [HttpDelete]
        public override bool Delete(int id)
        {
            bool isDeleted = _userService.Delete(id);
            return isDeleted;
        }
    }
}
