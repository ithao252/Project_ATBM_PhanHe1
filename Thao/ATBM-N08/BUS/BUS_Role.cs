using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM_N08.DAO;
using ATBM_N08.DTO;
using System.Data;



namespace ATBM_N08.BUS
{
    public class BUS_Role
    {
        private static BUS_Role _instance = null;
        public static BUS_Role Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Role();
                }
                return _instance;
            }
        }

        public List<DTO_Role> GetRolesOfUser(String username)
        {

            List<DTO_Role> result = new List<DTO_Role>();
            DataTable data;
            try
            {
                data = DAO_Role.Instance.GetRolesOfUser(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            foreach (DataRow row in data.Rows)
            {
                DTO_Role tmpObject = new DTO_Role();

                tmpObject.RoleName = row["GRANTED_ROLE"].ToString();
                tmpObject.Admin_Option = row["ADMIN_OPTION"].ToString();

                result.Add(tmpObject);
            }

            return result;

        }
    }
}
