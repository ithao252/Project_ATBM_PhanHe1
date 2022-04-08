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
    public class BUS_Table
    {
        private static BUS_Table _instance = null;
        public static BUS_Table Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Table();
                }
                return _instance;
            }
        }

        public List<DTO_Table> GetAllTables()
        {
            //Get all data from DAO Layer
            List<DTO_Table> result = new List<DTO_Table>();
            DataTable data = DAO_Table.Instance.GetAllTables();

            foreach (DataRow row in data.Rows)
            {
                DTO_Table tmpObject = new DTO_Table();

                tmpObject.Owner = row["OWNER"].ToString();
                tmpObject.Table_name = row["TABLE_NAME"].ToString();
                tmpObject.Tablespace_name = row["TABLESPACE_NAME"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }


        public void DeleteTable(String table_name)
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
