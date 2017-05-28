using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.ReferenceEnum
{
    public class ProjectStatusEnum : BaseReferenceEnumModel
    {
        public static ProjectStatusEnum Open = new ProjectStatusEnum(1, "Open");
        public static ProjectStatusEnum Approved = new ProjectStatusEnum(2, "Approved");
        public static ProjectStatusEnum Resolved = new ProjectStatusEnum(3, "Resolved");
        public static ProjectStatusEnum Closed = new ProjectStatusEnum(4, "Closed");
        public static ProjectStatusEnum Rejected = new ProjectStatusEnum(5, "Rejected");

        public ProjectStatusEnum(int id, string code)
        {
            Id = id;
            Code = code;
        }
    }
}
