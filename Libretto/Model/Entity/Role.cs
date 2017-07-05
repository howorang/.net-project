using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libretto.Model.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }


        public Role Self {
            get
            {
                return this;
            }
        }


    }
}
