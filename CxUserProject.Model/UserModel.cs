using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CxUserProject.Model
{
    public class UserModel : ModifiedModel
    {
        private string _password;

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Password
        {
            get { return _password; }
            set { _password = value.GetPasswordHash(); }
        }
    }

    public static class StringExtensions
    {
        public static string GetPasswordHash(this string input)
        {
            HashAlgorithm hashAlgoritham = new SHA256CryptoServiceProvider();

            byte[] byteValue = Encoding.UTF8.GetBytes(input);

            byte[] byteHash = hashAlgoritham.ComputeHash(byteValue);

            return Convert.ToBase64String(byteHash);
        }
    }
}
