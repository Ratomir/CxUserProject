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
    public class UserController : BaseApiController
    {
        public IUserService _userService { get; set; }

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        public IEnumerable<UserModel> Get()
        {
            var users = _userService.GetAll();
            return users;
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
