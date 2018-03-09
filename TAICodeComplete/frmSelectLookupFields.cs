using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TAICodeComplete
{
    public partial class frmSelectLookupFields : Form
    {

        string DSN = "";

        public string TABLENAME = "";
        public string VALUEFIELD = "";
        public string DESCCRIPTIONFIELD = "";


        public frmSelectLookupFields()
        {
            InitializeComponent();

        }

        public frmSelectLookupFields(string connectionstring)
        {
            InitializeComponent();

            DSN = connectionstring;

            string sql = "select NAME from sys.tables ORDER BY NAME";

            SqlConnection cn = new SqlConnection(DSN);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);

            SqlDataReader r = cmd.ExecuteReader();

            lstTables.Items.Clear();

            while (r.Read())
            {
                lstTables.Items.Add(r[0] + "");
            }
            r.Close();
            cmd.Dispose();
            cn.Close();
            cn.Dispose();


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (lstTables.SelectedItem != null)
                TABLENAME = (string)lstTables.SelectedItem;
            else
                TABLENAME = "";

            if (lstFieldValues.SelectedItem != null)
                VALUEFIELD = (string)lstFieldValues.SelectedItem;
            else
                VALUEFIELD = "";

            if (lstFieldDescription.SelectedItem != null)
                DESCCRIPTIONFIELD  = (string)lstFieldDescription.SelectedItem;
            else
                DESCCRIPTIONFIELD = "";

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TABLENAME = "";
            VALUEFIELD = "";
            DESCCRIPTIONFIELD = "";

            this.Close();
        }
    
        private List<string> GetFieldsInTable(string tablename)
        {
            List<string> result = new List<string>();

            string obid = GetObjectIdFor(tablename);

            string sql = "SELECT A.NAME FROM SYS.columns A " +
                        "where A.object_id = " + obid + " ORDER BY A.COLUMN_ID";

            SqlConnection cn = new SqlConnection(DSN);
            cn.Open();
            SqlCommand cmd = new SqlCommand(sql, cn);

            SqlDataReader r = cmd.ExecuteReader();

            while(r.Read())
            {
               
                result.Add(r[0] + "");

            }
            r.Close();
            cmd.Dispose();
            cn.Close();
            cn.Dispose();

            return result;
        }

        private string GetObjectIdFor(string tname)
        {
            string result = "";

            try
            {
                string sql = "select OBJECT_ID from sys.tables WHERE NAME = @NAME";

                SqlConnection cn = new SqlConnection(DSN);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@NAME", SqlDbType.VarChar).Value = tname;

                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    result = r[0] + "";
                }
                r.Close();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();

            }
            catch //(Exception ex)
            {
                result = "-1";
            }

            return result;
        }

        private void handleTableSelection(object sender, EventArgs e)
        {
            if (lstTables.SelectedItem != null)
            {
                string TBL = (string)lstTables.SelectedItem;

                List<string> flds = GetFieldsInTable(TBL);

                lstFieldDescription.Items.Clear();
                lstFieldValues.Items.Clear();

                foreach(string s in flds)
                {
                    lstFieldValues.Items.Add(s);
                    lstFieldDescription.Items.Add(s);
                }

            }
        }

    
    }
}
