using ATBM_N08.DAO;
using ATBM_N08.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_N08.BUS
{
    public class BUS_User
    {
        private static BUS_User _instance = null;
        public static BUS_User Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_User();
                }
                return _instance;
            }
        }

        public void Login(String username, String password)
        {
            try
            {
                DatabaseConnect.InitConnection(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
