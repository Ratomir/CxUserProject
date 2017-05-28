using CxUserProject.ReferenceEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Model
{
    public class ProjectModel : ModifiedModel
    {
        public string Title { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public UserModel CreatedUser { get; set; }

        public ProjectStatusEnum ProjectStatus { get; set; }
    }
}
