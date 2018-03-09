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
    public partial class tblDocDefTemplateUI : Form
    {

        private tbldocDefTemplate TheThing = null;

        public tblDocDefTemplateUI(tbldocDefTemplate thing)
        {
            InitializeComponent();

            TheThing = thing;

            Unpack(TheThing);
            
        }
        
        private tbldocDefTemplate Pack()
        {
            tbldocDefTemplate thing = new tbldocDefTemplate(TheThing.classDatabaseConnectionString);
            thing.Initialize();
            
            thing.DocDefTemplateID = GetAsInteger(txtDocDefTemplateID.Text);
            thing.DocDefTypeId = GetAsInteger(txtDocDefTypeId.Text);
            thing.DocDefTypeSubId = GetAsInteger(txtDocDefTypeSubId.Text);
            thing.DocDefTemplateParID = GetAsInteger(txtDocDefTemplateParID.Text);
            thing.DocDefSecId = GetAsInteger(txtDocDefSecId.Text);
            thing.TType = txtTType.Text + "";
            thing.TLabel = txtTLabel.Text + "";
            thing.TLabelPosition = txtTLabelPosition.Text + "";
            thing.TLabelFontWeight = txtTLabelFontWeight.Text + "";
            thing.TableName = txtTableName.Text + "";
            thing.TableColumnName = txtTableColumnName.Text + "";
            thing.ValidationType = txtValidationType.Text + "";
            thing.CustomParameters = txtCustomParameters.Text + "";
            thing.TOrder = GetAsInteger(txtTOrder.Text);
            thing.LookupTypeId = GetAsInteger(txtLookupTypeId.Text);
            thing.Indent = GetAsInteger(txtIndent.Text);
            thing.TemplateCode = txtTemplateCode.Text + "";
            thing.COPY = txtCOPY.Text + "";

            return thing;
        }

        private void Unpack(tbldocDefTemplate thing)
        {
            txtDocDefTemplateID.Text = thing.DocDefTemplateID.ToString() + "";
            txtDocDefTypeId.Text = thing.DocDefTypeId.ToString() + "";
            txtDocDefTypeSubId.Text = thing.DocDefTypeSubId.ToString() + "";
            txtDocDefTemplateParID.Text = thing.DocDefTemplateParID.ToString() + "";
            txtDocDefSecId.Text = thing.DocDefSecId.ToString() + "";
            txtTType.Text = thing.TType + "";
            txtTLabel.Text = thing.TLabel + "";
            txtTLabelPosition.Text = thing.TLabelPosition + "";
            txtTLabelFontWeight.Text = thing.TLabelFontWeight + "";
            txtTableName.Text = thing.TableName + "";
            txtTableColumnName.Text = thing.TableColumnName + "";
            txtValidationType.Text = thing.ValidationType + "";
            txtCustomParameters.Text = thing.CustomParameters + "";
            txtTOrder.Text = thing.TOrder.ToString() + "";
            txtLookupTypeId.Text = thing.LookupTypeId.ToString() + "";
            txtIndent.Text = thing.Indent.ToString() + "";
            txtTemplateCode.Text = thing.TemplateCode + "";
            txtCOPY.Text = thing.COPY + "";
            RefreshLOOKUPValues();
        }

        private void RefreshLOOKUPValues()
        {
            string sql = "SELECT [LookupId],[LookupType],[LongDesc],[ShortDesc],[Active],[SortOrder]," +
                "[CoverageType],[LookupTypeId],[LookupTypeId_Sub],[Parm] " +
                "FROM [tblLookup] where LookupTypeId = " + txtLookupTypeId.Text + " ORDER BY SortOrder";

            taigLOOKUPS.PopulateGridWithData(TheThing.classDatabaseConnectionString, sql);

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
