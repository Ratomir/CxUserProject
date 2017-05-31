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
    public class ProjectController : BaseApiController<ProjectModel>
    {
        public IProjectService _projectService { get; set; }

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpPost]
        public override ProjectModel Create([FromBody] ProjectModel model)
        {
            ProjectModel createdProjectModel = _projectService.Create(model);
            return createdProjectModel;
        }

        [HttpDelete]
        public override bool Delete(int id)
        {
            bool isDeleted = _projectService.Delete(id);
            return isDeleted;
        }

        [HttpGet]
        public override List<ProjectModel> Get()
        {
            var roles = _projectService.GetAll();
            return roles;
        }

        [HttpGet]
        public override ProjectModel GetById(int id)
        {
            ProjectModel role = _projectService.GetById(id);
            return role;
        }

        [HttpPut]
        public override bool Put(int id, [FromBody] ProjectModel model)
        {
            bool isUpdated = _projectService.Update(id, model);
            return isUpdated;
        }
    }
}
