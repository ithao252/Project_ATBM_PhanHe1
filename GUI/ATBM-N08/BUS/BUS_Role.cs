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


        public List<DTO_Role> GetAllRoles()
        {
            //Get all data from DAO Layer
            List<DTO_Role> result = new List<DTO_Role>();
            DataTable data = DAO_Role.Instance.GetAllRoles();

            foreach (DataRow row in data.Rows)
            {
                DTO_Role tmpObject = new DTO_Role();

                tmpObject.Role = row["ROLE"].ToString();
                tmpObject.Role_ID = row["ROLE_ID"].ToString();
                tmpObject.Password_Required = row["PASSWORD_REQUIRED"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }

        public List<DTO_RoleUser> GetRoleUser()
        {
            //Get all data from DAO Layer
            List<DTO_RoleUser> result = new List<DTO_RoleUser>();
            DataTable data = DAO_Role.Instance.GetRoleOfUser();

            foreach (DataRow row in data.Rows)
            {
                DTO_RoleUser tmpObject = new DTO_RoleUser();

                tmpObject.Grantee = row["GRANTEE"].ToString();
                tmpObject.Granted_Role = row["GRANTED_ROLE"].ToString();

                result.Add(tmpObject);
            }

            return result;
        }

        public void RevokeRoleFromUser(String user, String role)
        {
            try
            {
                DAO_Role.Instance.RevokeRoleFromUser(user, role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GrantRoleToUser(String user, String role)
        {
            try
            {
                DAO_Role.Instance.GrantRoleToUser(user, role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteRole(String role)
        {
            try
            {
                DAO_Role.Instance.DeleteRole(role);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateRole(String role, String newpassword, int result)
        {
            try
            {
                DAO_Role.Instance.UpdateRole(role, newpassword, result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CreateRole(String role, String password, int result)
        {
            try
            {
                DAO_Role.Instance.CreateRole(role, password, result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
