using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Model
{
    public class UserProjectModel : BaseModel
    {
        public int UserId { get; set; }
        public int ProjectId { get; set; }

        public UserModel User { get; set; }
        public ProjectModel Project { get; set; }
    }
}
