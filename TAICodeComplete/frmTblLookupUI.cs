using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAICodeComplete
{
    public partial class frmTblLookupUI : Form
    {
        private tblLookup TheThing = null;

        public frmTblLookupUI(tblLookup thing)
        {
            InitializeComponent();

            TheThing = thing;

            Unpack(TheThing);

        }

        public frmTblLookupUI(tblLookup thing,bool foradd)
        {
            InitializeComponent();

            TheThing = thing;

            Unpack(TheThing);

            if (foradd)
            {
                txtLookupType.ReadOnly = true;
                txtSortOrder.ReadOnly = true;

            }

        }

        private tblLookup Pack()
        {
            tblLookup thing = new tblLookup(TheThing.classDatabaseConnectionString);

            thing.LookupId = GetAsInteger(txtLookupId.Text);
            thing.LookupType = txtLookupType.Text + "";
            thing.LongDesc = txtLongDesc.Text + "";
            thing.ShortDesc = txtShortDesc.Text + "";
            thing.Active = txtActive.Text + "";
            thing.SortOrder = GetAsInteger(txtSortOrder.Text);
            thing.CoverageType = txtCoverageType.Text + "";
            thing.LookupTypeId = GetAsInteger(txtLookupTypeId.Text);
            thing.LookupTypeId_Sub = GetAsInteger(txtLookupTypeId_Sub.Text);
            thing.Parm = txtParm.Text + "";

            return thing;
        }

        private void Unpack(tblLookup thing)
        {
            txtLookupId.Text = thing.LookupId.ToString() + "";
            txtLookupType.Text = thing.LookupType + "";
            txtLongDesc.Text = thing.LongDesc + "";
            txtShortDesc.Text = thing.ShortDesc + "";
            txtActive.Text = thing.Active + "";
            txtSortOrder.Text = thing.SortOrder.ToString() + "";
            txtCoverageType.Text = thing.CoverageType + "";
            txtLookupTypeId.Text = thing.LookupTypeId.ToString() + "";
            txtLookupTypeId_Sub.Text = thing.LookupTypeId_Sub.ToString() + "";
            txtParm.Text = thing.Parm + "";
        }

        private int GetAsInteger(string input)
        {
            int result = 0;
            bool diditwork = int.TryParse(input, out result);
            return result;
        }

        private long GetAsLong(string input)
        {
            long result = 0;
            bool diditwork = long.TryParse(input, out result);
            return result;
        }

        private double GetAsDouble(string input)
        {
            double result = 0;
            bool diditwork = double.TryParse(input, out result);
            return result;
        }

        private DateTime GetAsDateTime(string input)
        {
            DateTime result = Convert.ToDateTime(null);
            bool diditwork = DateTime.TryParse(input, out result);
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TheThing = Pack();
            TheThing.Add();
            this.Close();
        }




    }
}
