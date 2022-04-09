using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM_N08.DAO;
using ATBM_N08.DTO;
using System.Collections.ObjectModel;
using System.Data;


namespace ATBM_N08.BUS
{
    public class BUS_Privilege_Column
    {
        private static BUS_Privilege_Column _instance = null;
        public static BUS_Privilege_Column Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Privilege_Column();
                }
                return _instance;
            }
        }
        

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegeOnColumnUpdateInsert(String username)
        {
            //Get all data from DAO Layer
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            DataTable data = DAO_Privilege_Column.Instance.GetPrivilegeOnColumnUpdateInsert(username);

            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmpObject = new DTO_PrivilegeOnColumn();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                tmpObject.Grantor = row["GRANTOR"].ToString();
                tmpObject.ColumnName = row["COLUMN_NAME"].ToString();
                tmpObject.Privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();
                if (tmpObject.Privilege.Equals("UPDATE"))
                {
                    tmpObject.IsUpdate = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsUpdateGrantable = true;
                    }
                }
                if (tmpObject.Privilege.Equals("INSERT"))
                {
                    tmpObject.IsInsert = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsInsertGrantable = true;
                    }
                }

                result.Add(tmpObject);
            }

            return result;
        }


        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegesOnColumnSelect(String username)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            DataTable data = DAO_Privilege_Column.Instance.GetPrivilegeOnView(username);

            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmpObject = new DTO_PrivilegeOnColumn();
                String tableName = "", columnName = "";
                GetNameFromViewName(ref tableName, ref columnName, row["TABLE_NAME"].ToString());

                if (tableName == null || columnName == null)
                {
                    continue;
                }

                tmpObject.TableName = tableName;
                tmpObject.Grantor = row["GRANTOR"].ToString();
                tmpObject.ColumnName = columnName;
                tmpObject.Privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();
                if (tmpObject.Privilege.Equals("SELECT"))
                {
                    tmpObject.IsSelect = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsSelectGrantable = true;
                    }
                }
                result.Add(tmpObject);
            }

            return result;
        }

        private void GetNameFromViewName(ref String TableName, ref String ColumnName, String ViewName)
        {
            int index0 = ViewName.IndexOf('_');
            if (index0 < 0)
            {
                TableName = null;
                ColumnName = null;
                return;
            }
            TableName = ViewName.Substring(0, index0);
            ViewName = ViewName.Substring(index0 + 1);
            index0 = ViewName.IndexOf('_');
            if (index0 < 0)
            {
                TableName = null;
                ColumnName = null;
                return;
            }
            ColumnName = ViewName.Substring(0, index0);

        }

        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegeOnColumns(String username)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> result = GetPrivilegesOnColumnSelect(username);

            ObservableCollection<DTO_PrivilegeOnColumn> temp = GetPrivilegeOnColumnUpdateInsert(username);

            int len = result.Count;

            for (int i = 0; i < len; i++)
            {
                DTO_PrivilegeOnColumn objResult = result[i];
                for (int j = 0; j < temp.Count; j++)
                {
                    DTO_PrivilegeOnColumn objTemp = temp[j];
                    if (objResult.TableName.Equals(objTemp.TableName) &&
                        objResult.ColumnName.Equals(objTemp.ColumnName))
                    {
                        objResult.IsUpdate = objTemp.IsUpdate ? true : objResult.IsUpdate;
                        objResult.IsUpdateGrantable = objTemp.IsUpdateGrantable ? true : objResult.IsUpdateGrantable;
                        objResult.IsInsert = objTemp.IsInsert ? true : objResult.IsInsert;
                        objResult.IsInsertGrantable = objTemp.IsInsertGrantable ? true : objResult.IsInsertGrantable;
                        temp.Remove(objTemp);
                        j--;
                    }
                }
            }
            for (int i = 0; i < temp.Count; i++)
            {
                result.Add(temp[i]);
            }

            return result;
        }


        public ObservableCollection<DTO_PrivilegeOnColumn> GetPrivilegesAllColumns(String username, String tableName)
        {
            ObservableCollection<DTO_PrivilegeOnColumn> privilegeOnColumns = GetPrivilegeOnColumns(username);
            ObservableCollection<DTO_PrivilegeOnColumn> result = new ObservableCollection<DTO_PrivilegeOnColumn>();
            for (int i = 0; i < privilegeOnColumns.Count; i++)
            {
                if (privilegeOnColumns[i].TableName.Equals(tableName))
                {
                    result.Add(privilegeOnColumns[i]);
                }
            }

            DataTable data = DAO_Table.Instance.GetAllColumnFromTable(tableName);
            foreach (DataRow row in data.Rows)
            {
                DTO_PrivilegeOnColumn tmp = new DTO_PrivilegeOnColumn();
                tmp.TableName = tableName;
                tmp.ColumnName = row["column_name"].ToString();
                bool flag = false;

                for (int i = 0; i < result.Count; i++)
                {
                    if (tmp.ColumnName.Equals(result[i].ColumnName))
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    result.Add(tmp);
                }
            }
            return result;

        }


        public void ExecPrivilegeOnColumn(List<ObservableCollection<DTO_PrivilegeOnColumn>> privilegeOnColumns, String username)
        {   
            

            RevokeAllPrivilegesColumn(privilegeOnColumns, username);
            for (int i = 0; i < privilegeOnColumns.Count; i++)
            {
                for (int j = 0; j < privilegeOnColumns[i].Count; j++)
                {
                    DTO_PrivilegeOnColumn privilege = privilegeOnColumns[i][j];
                    if (privilege.IsUpdate)
                    {
                        DAO_Privilege_Column.Instance.GrantPrivilegeUpdateOnColumn
                           (username, privilege.TableName, privilege.ColumnName, privilege.IsUpdateGrantable);
                    }
                    if (privilege.IsSelect)
                    {
                        DAO_Privilege_Column.Instance.GrantPrivilegeSelectOnColumn
                           (username, privilege.TableName, privilege.ColumnName, privilege.IsSelectGrantable);
                    }

                }
            }
        }



      public void RevokeAllPrivilegesColumn(List<ObservableCollection<DTO_PrivilegeOnColumn>> privilegeOnColumns, String username)
      {
           for (int i = 0; i < privilegeOnColumns.Count; i++)
           {
                for (int j = 0; j < privilegeOnColumns[i].Count; j++)
                {
                    DTO_PrivilegeOnColumn privilege = privilegeOnColumns[i][j];
                   DAO_Privilege_Column.Instance.RevokePrivilegeUpdateOnColumn(username, privilege.TableName, privilege.ColumnName);

                  DAO_Privilege_Column.Instance.RevokePrivilegeSelectOnColumn(username, privilege.TableName, privilege.ColumnName);
                }
            }
        }


    }
}
