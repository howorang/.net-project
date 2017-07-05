using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Libretto
{
    class AuthManager
    {

        public static String sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Concat(hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        }

        private static AuthManager instance;

        private AuthManager() { }

        public Model.Entity.User CurrentUser { get; set; }

        public static AuthManager Instance {
            get
            {
                if (instance == null)
                {
                    instance = new AuthManager();
                }
                return instance;
            }
        }

    }
}
