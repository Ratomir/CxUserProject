using CxUserProject.ReferenceEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserRole.Enum
{
    public class RoleEnum : BaseReferenceEnumModel
    {
        public static RoleEnum Admin = new RoleEnum(1, "Admin");
        public static RoleEnum Manager = new RoleEnum(2, "Manager");

        public RoleEnum(int id, string code)
        {
            Id = id;
            Code = code;
        }
    }
}
