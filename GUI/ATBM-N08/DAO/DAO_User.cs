using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_N08.DAO
{
    public class DAO_User : DatabaseConnect
    {
        private static DAO_User _instance = null;
        public static DAO_User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DAO_User();
                }
                return _instance;
            }
        }
    }

    }
