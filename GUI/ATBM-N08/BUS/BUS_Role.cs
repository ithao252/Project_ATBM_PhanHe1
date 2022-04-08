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


        //public void DeleteUser(String username, bool cascade)
        //{
        //    try
        //    {
        //        DAO_User.Instance.DeleteUser(username, cascade);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

        //public void UpdateUser(String username, bool isLock, string password)
        //{
        //    try
        //    {
        //        DAO_User.Instance.UpdateUser(username, isLock, password);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}


        //public void CreateUser(String username, String password)
        //{
        //    try
        //    {
        //        DAO_User.Instance.CreateUser(username, password);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}

    }
}
