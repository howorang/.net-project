using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto.Model.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual Role UserRole { get; set; }
        public virtual byte[] Avatar{ get; set; }

        public override string ToString()
        {
            return Username;
        }

        public User Self {
            get
            {
                return this;
            }
        }
    }
}
