using CxUserProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.DB
{
    public class UserContext : IDbInitialze
    {
        public static List<UserModel> UserContextList = new List<UserModel>();

        public void Initialze()
        {
            var lstUserModel = new List<UserModel> { new UserModel
            {
                Age = 18,
                Email = "ratomir@live.com",
                FirstName = "Ratomir",
                Id = 1,
                LastName = "Vukadin",
                Password = "ratomir1992"
            }, new UserModel
            {
                Age = 18,
                Email = "marko.stijak@codaxy.com",
                FirstName = "Marko",
                Id = 2,
                LastName = "Stijak",
                Password = "marko1992"
            },new UserModel
            {
                Age = 18,
                Email = "igor.timarac@codaxy.com",
                FirstName = "Igor",
                Id = 3,
                LastName = "Timarac",
                Password = "igor992"
            } };

            UserContextList.AddRange(lstUserModel);
        }
    }
}
