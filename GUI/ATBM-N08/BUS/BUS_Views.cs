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
    public class BUS_Views
    {
        private static BUS_Views _instance = null;
        public static BUS_Views Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Views();
                }
                return _instance;
            }
        }

        public List<DTO_Views> GetAllViews()
        {
            //Get all data from DAO Layer
            List<DTO_Views> result = new List<DTO_Views>();
            DataTable data = DAO_Views.Instance.GetAllViews();

            foreach (DataRow row in data.Rows)
            {
                DTO_Views tmpObject = new DTO_Views();

                tmpObject.Owner = row["OWNER"].ToString();
                tmpObject.View_name = row["VIEW_NAME"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }
        
        public List<DTO_Views> GetOwnerViews(String owner_view)
        {
            //Get all data from DAO Layer
            List<DTO_Views> result = new List<DTO_Views>();
            DataTable data = DAO_Views.Instance.GetOwnerViews(owner_view);

            foreach (DataRow row in data.Rows)
            {
                DTO_Views tmpObject = new DTO_Views();

                tmpObject.Owner = row["OWNER"].ToString();
                tmpObject.View_name = row["VIEW_NAME"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }


        //public List<DTO_DetailTable> GetDetailTable(String table_name)
        //{
        //    //Get all data from DAO Layer
        //    List<DTO_DetailTable> result = new List<DTO_DetailTable>();
        //    DataTable data = DAO_Table.Instance.GetDetailTable(table_name);

        //    foreach (DataRow row in data.Rows)
        //    {
        //        DTO_DetailTable tmpObject = new DTO_DetailTable();

        //        tmpObject.Owner_table = row["OWNER"].ToString();
        //        tmpObject.Table_name = row["TABLE_NAME"].ToString();
        //        tmpObject.Column_ID = row["COLUMN_ID"].ToString();
        //        tmpObject.Column_name = row["COLUMN_NAME"].ToString();
        //        tmpObject.Data_type = row["DATA_TYPE"].ToString();
        //        tmpObject.Nullable = row["NULLABLE"].ToString();

        //        result.Add(tmpObject);
        //    }

        //    return result;
        //}

        //public void DeleteTable(String table_name)
        //{
        //    try
        //    {
        //        DAO_Table.Instance.DeleteTable(table_name);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

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
