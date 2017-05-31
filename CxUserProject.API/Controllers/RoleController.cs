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
    public class RoleController : BaseApiController<RoleModel>
    {
        public IRoleService _roleService { get; set; }

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        public override RoleModel Create([FromBody] RoleModel model)
        {
            RoleModel createdRoleModel = _roleService.Create(model);
            return createdRoleModel;
        }

        [HttpDelete]
        public override bool Delete(int id)
        {
            bool isDeleted = _roleService.Delete(id);
            return isDeleted;
        }

        [HttpGet]
        public override List<RoleModel> Get()
        {
            var roles = _roleService.GetAll();
            return roles;
        }

        [HttpGet]
        public override RoleModel GetById(int id)
        {
            RoleModel role = _roleService.GetById(id);
            return role;
        }

        [HttpPut]
        public override bool Put(int id, [FromBody] RoleModel model)
        {
            bool isUpdated = _roleService.Update(id, model);
            return isUpdated;
        }
    }
}
