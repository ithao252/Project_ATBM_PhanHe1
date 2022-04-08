using ATBM_N08.DAO;
using ATBM_N08.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ATBM_N08.BUS
{
    public class BUS_Privilege
    {
        private static BUS_Privilege _instance = null;
        public static BUS_Privilege Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Privilege();
                }
                return _instance;
            }
        }

        public List<DTO_Privilege> GetAllPrivileges()
        {
            //Get all data from DAO Layer
            List<DTO_Privilege> result = new List<DTO_Privilege>();
            DataTable data = DAO_Privilege.Instance.GetAllPrivileges();

            foreach (DataRow row in data.Rows)
            {
                DTO_Privilege tmpObject = new DTO_Privilege();

                tmpObject.Role = row["ROLE"].ToString();
                tmpObject.Privilege = row["PRIVILEGE"].ToString();
                tmpObject.Admin_option = row["ADMIN_OPTION"].ToString();
                tmpObject.Common = row["COMMON"].ToString();
                tmpObject.Inherited = row["INHERITED"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }


/*        public void DeleteTable(String table_name)
        {
            try
            {
                DAO_Table.Instance.DeleteTable(table_name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
*/
/*        public void CreateUser(String table_name)
        {
            try
            {
                DAO_User.Instance.CreateUser(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
*/
    }
}
