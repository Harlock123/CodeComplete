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
    public partial class frmFieldSelect : Form
    {

        public string SELECTEDFIELD = "";

        public frmFieldSelect(List<string> fnames)
        {
            InitializeComponent();

            chkLBfields.Items.Clear();

            foreach (string s in fnames)
            {
                chkLBfields.Items.Add(s);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (chkLBfields.CheckedItems.Count > 0)
            {
                SELECTEDFIELD = chkLBfields.CheckedItems[0].ToString();
            }
            else
            {
                SELECTEDFIELD = "";
            }
            
            
            this.Hide();
        }
    }
}
