using System.Security.Cryptography;
using System.Text;

namespace TM_backend.Models
{
    public class User
    {
        public string Login { get; set; }
        private byte[] password;
        public string Password
        {
            get { return Encoding.UTF8.GetString(new MD5CryptoServiceProvider().ComputeHash(password)); }
            set { password = Encoding.UTF8.GetBytes(value); }
        }
        public bool IsAdmin => Login == "admin";

        public bool CheckPassword(string password) => password == Password;
    }
}
