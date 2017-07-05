using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libretto.Model;

namespace Libretto
{
    public class DbManager
    {

        private static DbManager _instance;

        private DbManager()
        {
            Context = new LibrettoContext();
        }

        public static DbManager Instance {
            get
            {
                if(_instance == null)
                {
                    _instance = new DbManager();
                }

                return _instance;
            }
        }

        public LibrettoContext Context { get; }


    }
}
