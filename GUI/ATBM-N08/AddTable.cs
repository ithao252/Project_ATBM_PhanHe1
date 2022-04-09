using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBM_N08.BUS;

namespace ATBM_N08
{
    public partial class AddTable : Form
    {
        public class ColProperty
        {
            public String column_name;
            public String data_type;
            public String data_size;
            public Boolean nullable;
            public Boolean primary_key;
        }
        List<ColProperty> colsProperties;
        String table_name;
        public AddTable()
        {
            InitializeComponent();
        }
        private void getInput()
        {
            table_name = table_name_textbox.Text;

            colsProperties = new List<ColProperty>();
            foreach (DataGridViewRow dr in dtgv_table.Rows)
            {
                if (dr.IsNewRow)
                    continue;

                ColProperty item = new ColProperty();

                item.column_name = dr.Cells["Column_name"].Value.ToString();
                item.data_type = dr.Cells["Data_type"].Value.ToString().ToUpper();

                if (dr.Cells["Data_size"].Value != null)
                    item.data_size = dr.Cells["Data_size"].Value.ToString();
                else
                    item.data_size = null;

                item.nullable = Convert.ToBoolean(dr.Cells["Nullable"].Value);
                item.primary_key = Convert.ToBoolean(dr.Cells["Primary_key"].Value);

                colsProperties.Add(item);
            }

        }

        private String CreateTable()
        {
            table_name = table_name_textbox.Text.ToString();
            String oracleCmd = $"CREATE TABLE {table_name.ToUpper()} (";
            for (int i = 0; i < colsProperties.Count; i++)
            {
                oracleCmd += ":col" + i.ToString() + "name ";
                oracleCmd += ":col" + i.ToString() + "type ";
                if (colsProperties[i].data_size != null)
                    oracleCmd += "(:col" + i.ToString() + "size) ";

                if (colsProperties[i].nullable)
                    oracleCmd += ":col" + i.ToString() + "notnull";

                oracleCmd += " ,";
            }

            for (int i = 0; i < colsProperties.Count; i++)
            {
                oracleCmd = oracleCmd.Replace(":col" + i.ToString() + "name", colsProperties[i].column_name);
                oracleCmd = oracleCmd.Replace(":col" + i.ToString() + "type", colsProperties[i].data_type);

                if (colsProperties[i].data_size != null)
                {
                    oracleCmd = oracleCmd.Replace(":col" + i.ToString() + "size", colsProperties[i].data_size);
                }
                if (colsProperties[i].nullable)
                {
                    oracleCmd = oracleCmd.Replace(":col" + i.ToString() + "notnull", "NOT NULL");
                }
            }
            oracleCmd += $"CONSTRAINT {table_name}_PK PRIMARY KEY(";
            bool needComma = false;
            for (int i = 0; i < colsProperties.Count; i++)
            {
                if (colsProperties[i].primary_key)
                {
                    if (needComma)
                    {
                        oracleCmd += ",";
                    }
                    oracleCmd += colsProperties[i].column_name;
                    needComma = true;
                }
            }
            oracleCmd += "))";

            return oracleCmd;
        }
        private void ListTableOwner_Load(object sender, EventArgs e)
        {
            try
            {
                getInput();
                BUS_Table.Instance.CreateTable(CreateTable());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_create_table_Click(object sender, EventArgs e)
        {
            this.ListTableOwner_Load(sender, e);
            table_name_textbox.Text = "";

        }

        private void dtgv_table_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
