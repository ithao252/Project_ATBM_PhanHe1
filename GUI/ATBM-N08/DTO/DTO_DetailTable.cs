using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATBM_N08.DTO
{
    public class DTO_DetailTable
    {
        public String Owner_table { get; set; }
        public String Table_name { get; set; }
        public String Column_ID { get; set; }
        public String Column_name { get; set; }
        public String Data_type { get; set; }
        public String Nullable { get; set; }
    }
}
