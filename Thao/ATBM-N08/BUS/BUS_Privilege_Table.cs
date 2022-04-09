using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATBM_N08.DTO;
using ATBM_N08.DAO;
using System.Collections.ObjectModel;
using System.Data;

namespace ATBM_N08.BUS
{

    public class BUS_Privilege_Table
    {
        private static BUS_Privilege_Table _instance = null;
        public static BUS_Privilege_Table Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BUS_Privilege_Table();
                }
                return _instance;
            }
        }

        public ObservableCollection<DTO_Privilege_Table> GetPrivilegesOnTable(String username)
        {
            //Get all data from DAO Layer
            ObservableCollection<DTO_Privilege_Table> result = new ObservableCollection<DTO_Privilege_Table>();
            DataTable data = DAO_Privilege_Table.Instance.GetPrivilegeOnTable(username);

            foreach (DataRow row in data.Rows)
            {
                bool flag = false;
                DTO_Privilege_Table tmpObject = new DTO_Privilege_Table();

                tmpObject.TableName = row["TABLE_NAME"].ToString();
                tmpObject.Grantor = row["GRANTOR"].ToString();
                if (result.Count > 0 && result[result.Count - 1].TableName.Equals(tmpObject.TableName))
                {
                    tmpObject = result[result.Count - 1];
                    flag = true;
                }

                String privilege = row["PRIVILEGE"].ToString();
                String grantable = row["GRANTABLE"].ToString();

                //All default values were false
                if (privilege.Equals("SELECT"))
                {
                    tmpObject.IsSelect = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsSelectGrantable = true;
                    }
                }
                else if (privilege.Equals("INSERT"))
                {
                    tmpObject.IsInsert = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsInsertGrantable = true;
                    }
                }
                else if (privilege.Equals("UPDATE"))
                {
                    tmpObject.IsUpdate = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsUpdateGrantable = true;
                    }
                }
                else
                {
                    tmpObject.IsDelete = true;
                    if (grantable.Equals("YES"))
                    {
                        tmpObject.IsDeleteGrantable = true;
                    }
                }

                if (!flag)
                {
                    result.Add(tmpObject);
                }

            }

            return result;
        }

        
        

        

        public ObservableCollection<DTO_Privilege_Table> GetPrivilegesAllTables(String username)
        {
            ObservableCollection<DTO_Privilege_Table> result = GetPrivilegesOnTable(username);
            DataTable data = DAO_Table.Instance.GetAllTables();
            bool flag = false;

            foreach (DataRow row in data.Rows)
            {
                DTO_Privilege_Table tmpObject = new DTO_Privilege_Table();
                tmpObject.TableName = row["OBJECT_NAME"].ToString();
                flag = false;

                for (int i = 0; i < result.Count; i++)
                {
                    if (result[i].TableName.Equals(tmpObject.TableName))
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    result.Add(tmpObject);
                }
            }

            return result;
        }

        


        

        public void ExecPrivilegeOnTable(ObservableCollection<DTO_Privilege_Table> privilegesOnTable,
                                         String username)
        {
            RevokeAllPrivilegesTable(username);

            for (int i = 0; i < privilegesOnTable.Count; i++)
            {
                DTO_Privilege_Table tmp = privilegesOnTable[i];

                String privileges = "";
                if (tmp.IsSelect)
                {
                    privileges = "SELECT";
                    DAO_Privilege_Table.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsSelectGrantable);
                }
                if (tmp.IsUpdate)
                {
                    privileges = "UPDATE";
                    DAO_Privilege_Table.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsUpdateGrantable);
                }
                if (tmp.IsInsert)
                {
                    privileges = "INSERT";
                    DAO_Privilege_Table.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsInsertGrantable);
                }
                if (tmp.IsDelete)
                {
                    privileges = "DELETE";
                    DAO_Privilege_Table.Instance.GrantPrivilegesOnTable(username, privileges, tmp.TableName, tmp.IsDeleteGrantable);
                }
            }
        }

       

        public void RevokeAllPrivilegesTable(String username)
        {
            DataTable data = DAO_Table.Instance.GetAllTableGranted(username);
            foreach (DataRow row in data.Rows)
            {
                DAO_Privilege_Table.Instance.RevokeAllPrivilegesOnTable(username, row["TABLE_NAME"].ToString());
            }
        }

        




    }
}

