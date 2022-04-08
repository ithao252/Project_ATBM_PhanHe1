using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATBM_N08.DTO
{
    public class DTO_PrivilegeUser
    {
        public String Username { get; set; }
        public String Privilege { get; set; }
        public String Admin_option { get; set; }
        public String Common { get; set; }
        public String Inherited { get; set; }
    }
}
