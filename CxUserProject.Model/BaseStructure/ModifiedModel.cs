using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Model
{
    public class ModifiedModel : BaseModel
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public UserModel CreateUser { get; set; }
        public UserModel UpdateUser { get; set; }

    }
}
