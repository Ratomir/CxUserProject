using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CxUserProject.API.Controllers
{
    /// <summary>
    /// Base Api controller for base methods for all derived api controllers.
    /// </summary>
    public abstract class BaseApiController<T> : ApiController
    {
        public abstract List<T> Get();
        public abstract T GetById(int id);
        public abstract T Create([FromBody]T model);
        public abstract bool Put(int id, [FromBody]T model);
        public abstract bool Delete(int id);
    }
}
