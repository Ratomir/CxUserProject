using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Model
{
    public class UserRoleModel : BaseModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public UserModel User { get; set; }
        public RoleModel Role { get; set; }
    }
}
