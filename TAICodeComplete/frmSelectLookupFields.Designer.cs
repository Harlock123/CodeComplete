namespace TAICodeComplete
{
    partial class frmSelectLookupFields
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTables = new System.Windows.Forms.ListBox();
            this.lstFieldValues = new System.Windows.Forms.ListBox();
            this.lstFieldDescription = new System.Windows.Forms.ListBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTables
            // 
            this.lstTables.FormattingEnabled = true;
            this.lstTables.Location = new System.Drawing.Point(12, 27);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(231, 355);
            this.lstTables.TabIndex = 0;
            this.lstTables.SelectedIndexChanged += new System.EventHandler(this.handleTableSelection);
            // 
            // lstFieldValues
            // 
            this.lstFieldValues.FormattingEnabled = true;
            this.lstFieldValues.Location = new System.Drawing.Point(249, 27);
            this.lstFieldValues.Name = "lstFieldValues";
            this.lstFieldValues.Size = new System.Drawing.Size(231, 355);
            this.lstFieldValues.TabIndex = 1;
            // 
            // lstFieldDescription
            // 
            this.lstFieldDescription.FormattingEnabled = true;
            this.lstFieldDescription.Location = new System.Drawing.Point(486, 27);
            this.lstFieldDescription.Name = "lstFieldDescription";
            this.lstFieldDescription.Size = new System.Drawing.Size(231, 355);
            this.lstFieldDescription.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(723, 27);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(723, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tables Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fields For The Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fields For The Description";
            // 
            // frmSelectLookupFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 396);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lstFieldDescription);
            this.Controls.Add(this.lstFieldValues);
            this.Controls.Add(this.lstTables);
            this.Name = "frmSelectLookupFields";
            this.Text = "Select fields for LOOKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListBox lstFieldValues;
        private System.Windows.Forms.ListBox lstFieldDescription;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}