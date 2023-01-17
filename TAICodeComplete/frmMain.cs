using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using ScintillaNET;
using SQL_Formatter;


namespace TAICodeComplete
{
    public partial class frmMain : Form
    {

        private BindingSource bsource = new BindingSource();
        private string DBSERVERNAME = "";
        private string DSN = "";
        private string DSNTYPE = "";
        private string IDFIELDNAME = "";
        private string IDFIELDTYPE = "";
        private string TableName = "";
        private List<Field> TheFields = null;

        private string INTERFACEFIELD = "";
        private string INTERFACEFIELDTYPE = "";

        private bool AUTONUMBER = true;

        public frmMain()
        {

            InitializeComponent();

            lblOneMoment.Visible = true;
            cmboServers.Enabled = false;

            lblOneMoment.Visible = false;

            //backgroundworkerThread.RunWorkerAsync();

            this.Text += " ver " + ApplicationInfo.Version.ToString();

            //LocateSqlInstances();


            // Remove the DOCDEF stuff

            //tabControl1.TabPages.Remove(tabPage6);
            //tabControl1.TabPages.Remove(tabPage7);


            // Setup Scintillas

            ConfigureScintillaControlForCPP(sciBaseTableCode);
            ConfigureScintillaControlForCPP(sciStringify);
            ConfigureScintillaControlForCPP(sciBaseTableTSCode);
            ConfigureScintillaControlForCPP(scintillaJSCode);
            ConfigureScintillaControlForCPP(scintillaWebMethodCode);
            ConfigureScintillaControlForCPP(scintillaWEBAPICode);
            ConfigureScintillaControlForCPP(scintillaRestCode);
            ConfigureScintillaControlForCPP(scintillaWFCode);


            // Reset the styles
            sciSQLCode.StyleResetDefault();
            sciSQLCode.Styles[Style.Default].Font = "Courier New";
            sciSQLCode.Styles[Style.Default].Size = 12;
            sciSQLCode.StyleClearAll();

            SQLCODEPRETTY.StyleResetDefault();
            SQLCODEPRETTY.Styles[Style.Default].Font = "Courier New";
            SQLCODEPRETTY.Styles[Style.Default].Size = 12;
            SQLCODEPRETTY.StyleClearAll();

            

            // Set the SQL Lexer
            sciSQLCode.Lexer = Lexer.Sql;

            SQLCODEPRETTY.Lexer = Lexer.Sql;

            // Show line numbers
            sciSQLCode.Margins[0].Width = 20;

            SQLCODEPRETTY.Margins[0].Width = 20;

            // Set the Styles
            sciSQLCode.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            sciSQLCode.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 190, 190, 190);  //Light Gray
            sciSQLCode.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            sciSQLCode.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            sciSQLCode.Styles[Style.Sql.Word2].ForeColor = Color.Fuchsia;
            sciSQLCode.Styles[Style.Sql.User1].ForeColor = Color.DarkGray;
            sciSQLCode.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192);    //Medium Blue-Green
            sciSQLCode.Styles[Style.Sql.String].ForeColor = Color.Red;
            sciSQLCode.Styles[Style.Sql.Character].ForeColor = Color.Red;
            sciSQLCode.Styles[Style.Sql.Operator].ForeColor = Color.Black;
            sciSQLCode.Styles[Style.Sql.Identifier].ForeColor = Color.Purple;
            sciSQLCode.Styles[Style.Sql.CommentDoc].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.User3].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.User4].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.Operator].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.Operator].Bold = true; // = Color.Green;
            sciSQLCode.Styles[Style.Sql.QOperator].ForeColor = Color.Green;
            sciSQLCode.Styles[Style.Sql.QOperator].Bold = true; // = Color.Green;
            sciSQLCode.Styles[Style.Sql.SqlPlus].ForeColor = Color.Green;



            SQLCODEPRETTY.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            SQLCODEPRETTY.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 190, 190, 190);  //Light Gray
            SQLCODEPRETTY.Styles[Style.Sql.Comment].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.CommentLine].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.CommentLineDoc].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.Number].ForeColor = Color.Maroon;
            SQLCODEPRETTY.Styles[Style.Sql.Word].ForeColor = Color.Blue;
            SQLCODEPRETTY.Styles[Style.Sql.Word].Bold = true;// = Color.Blue;

            SQLCODEPRETTY.Styles[Style.Sql.Word2].ForeColor = Color.Plum;
            SQLCODEPRETTY.Styles[Style.Sql.User1].ForeColor = Color.DarkGray;
            SQLCODEPRETTY.Styles[Style.Sql.User1].Bold = true; // = Color.DarkGray;
            SQLCODEPRETTY.Styles[Style.Sql.User2].ForeColor = Color.FromArgb(255, 00, 128, 192);    //Medium Blue-Green
            SQLCODEPRETTY.Styles[Style.Sql.String].ForeColor = Color.Red;
            SQLCODEPRETTY.Styles[Style.Sql.Character].ForeColor = Color.Red;
            SQLCODEPRETTY.Styles[Style.Sql.Operator].ForeColor = Color.Black;
            SQLCODEPRETTY.Styles[Style.Sql.Identifier].ForeColor = Color.Purple;
            SQLCODEPRETTY.Styles[Style.Sql.CommentDoc].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.User3].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.User4].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.Operator].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.Operator].Bold = true; // = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.QOperator].ForeColor = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.QOperator].Bold = true; // = Color.Green;
            SQLCODEPRETTY.Styles[Style.Sql.SqlPlus].ForeColor = Color.Green;




            // Set keyword lists
            // Word = 0
            sciSQLCode.SetKeywords(0, @"add alter as authorization backup begin bigint binary bit break browse bulk by cascade case catch check checkpoint close clustered column commit compute constraint containstable continue create current cursor cursor database date datetime datetime2 datetimeoffset dbcc deallocate decimal declare default delete deny desc disk distinct distributed double drop dump else end errlvl escape except exec execute exit external fetch file fillfactor float for foreign freetext freetexttable from full function goto grant group having hierarchyid holdlock identity identity_insert identitycol if image index insert int intersect into key kill lineno load merge money national nchar nocheck nocount nolock nonclustered ntext numeric nvarchar of off offsets on open opendatasource openquery openrowset openxml option order over percent plan precision primary print proc procedure public raiserror read readtext real reconfigure references replication restore restrict return revert revoke rollback rowcount rowguidcol rule save schema securityaudit select set setuser shutdown smalldatetime smallint smallmoney sql_variant statistics table table tablesample text textsize then time timestamp tinyint to top tran transaction trigger truncate try union unique uniqueidentifier update updatetext use user values varbinary varchar varying view waitfor when where while with writetext xml go ");
            // Word2 = 1
            sciSQLCode.SetKeywords(1, @"ascii cast char charindex ceiling coalesce collate contains convert current_date current_time current_timestamp current_user floor isnull max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            sciSQLCode.SetKeywords(4, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");
            // User2 = 5
            sciSQLCode.SetKeywords(5, @"sys objects sysobjects ");

            sciSQLCode.SetKeywords(3, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");



            // Word = 0
            SQLCODEPRETTY.SetKeywords(0, @"add alter as authorization backup begin bigint binary bit break browse bulk by cascade case catch check checkpoint close clustered column commit compute constraint containstable continue create current cursor cursor database date datetime datetime2 datetimeoffset dbcc deallocate decimal declare default delete deny desc disk distinct distributed double drop dump else end errlvl escape except exec execute exit external fetch file fillfactor float for foreign freetext freetexttable from full function goto grant group having hierarchyid holdlock identity identity_insert identitycol if image index insert int intersect into key kill lineno load merge money national nchar nocheck nocount nolock nonclustered ntext numeric nvarchar of off offsets on open opendatasource openquery openrowset openxml option order over percent plan precision primary print proc procedure public raiserror read readtext real reconfigure references replication restore restrict return revert revoke rollback rowcount rowguidcol rule save schema securityaudit select set setuser shutdown smalldatetime smallint smallmoney sql_variant statistics table table tablesample text textsize then time timestamp tinyint to top tran transaction trigger truncate try union unique uniqueidentifier update updatetext use user values varbinary varchar varying view waitfor when where while with writetext xml go ");
            // Word2 = 1
            SQLCODEPRETTY.SetKeywords(1, @"ascii cast char charindex ceiling coalesce collate contains convert current_date current_time current_timestamp current_user floor isnull max min nullif object_id session_user substring system_user tsequal ");
            // User1 = 4
            SQLCODEPRETTY.SetKeywords(4, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");
            // User2 = 5
            SQLCODEPRETTY.SetKeywords(5, @"sys objects sysobjects ");

            SQLCODEPRETTY.SetKeywords(3, @"all and any between cross exists in inner is join left like not null or outer pivot right some unpivot ( ) * ");



            scintillaXAML.StyleResetDefault();
            scintillaXAML.Styles[Style.Default].Font = "Consolas";
            scintillaXAML.Styles[Style.Default].Size = 10;
            scintillaXAML.StyleClearAll();

            // Set the XML Lexer
            scintillaXAML.Lexer = Lexer.Xml;

            // Show line numbers
            scintillaXAML.Margins[0].Width = 20;

            // Enable folding
            scintillaXAML.SetProperty("fold", "1");
            scintillaXAML.SetProperty("fold.compact", "1");
            scintillaXAML.SetProperty("fold.html", "1");

            // Use Margin 2 for fold markers
            scintillaXAML.Margins[2].Type = MarginType.Symbol;
            scintillaXAML.Margins[2].Mask = Marker.MaskFolders;
            scintillaXAML.Margins[2].Sensitive = true;
            scintillaXAML.Margins[2].Width = 20;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintillaXAML.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintillaXAML.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            scintillaXAML.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintillaXAML.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            scintillaXAML.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintillaXAML.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintillaXAML.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            scintillaXAML.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintillaXAML.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintillaXAML.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintillaXAML.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintillaXAML.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            scintillaXAML.StyleResetDefault();
            // I like fixed font for XML
            scintillaXAML.Styles[Style.Default].Font = "Courier";
            scintillaXAML.Styles[Style.Default].Size = 10;
            scintillaXAML.StyleClearAll();
            scintillaXAML.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            scintillaXAML.Styles[Style.Xml.Entity].ForeColor = Color.Red;
            scintillaXAML.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            scintillaXAML.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintillaXAML.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            scintillaXAML.Styles[Style.Xml.DoubleString].ForeColor = Color.DeepPink;
            scintillaXAML.Styles[Style.Xml.SingleString].ForeColor = Color.DeepPink;
            
            // Reset the styles
            scintillaHTMLCode.StyleResetDefault();
            scintillaHTMLCode.Styles[Style.Default].Font = "Courier New";
            scintillaHTMLCode.Styles[Style.Default].Size = 10;
            scintillaHTMLCode.StyleClearAll();

            // Set the SQL Lexer
            scintillaHTMLCode.Lexer = Lexer.Html;

            // Show line numbers
            scintillaHTMLCode.Margins[0].Width = 20;

            // Set the Styles
            scintillaHTMLCode.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            scintillaHTMLCode.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228);  //Light Gray
            scintillaHTMLCode.Styles[Style.Html.Comment].ForeColor = Color.Green;
            scintillaHTMLCode.Styles[Style.Html.Number].ForeColor = Color.Maroon;

            //scintillaHTMLCode.Styles[Style.Default].Font = "Courier";
            //scintillaHTMLCode.Styles[Style.Default].Size = 10;
            //scintillaHTMLCode.StyleClearAll();
            scintillaHTMLCode.Styles[Style.Html.Attribute].ForeColor = Color.Red;
            scintillaHTMLCode.Styles[Style.Html.Entity].ForeColor = Color.Red;
            scintillaHTMLCode.Styles[Style.Html.Comment].ForeColor = Color.Green;
            scintillaHTMLCode.Styles[Style.Html.Tag].ForeColor = Color.Blue;
            scintillaHTMLCode.Styles[Style.Html.TagEnd].ForeColor = Color.Blue;
            scintillaHTMLCode.Styles[Style.Html.DoubleString].ForeColor = Color.DeepPink;
            scintillaHTMLCode.Styles[Style.Html.SingleString].ForeColor = Color.DeepPink;

            scintillaHTMLCode.Styles[Style.Html.Script].ForeColor = Color.DarkGreen;
            scintillaHTMLCode.Styles[Style.Html.Script].ForeColor = Color.DarkGreen;

            scintillaHTMLCode.Styles[Style.Html.XmlStart].ForeColor = Color.LavenderBlush;
            scintillaHTMLCode.Styles[Style.Html.XmlEnd].ForeColor = Color.LavenderBlush;


            // Reset the styles
            scintillaCSSCode.StyleResetDefault();
            scintillaCSSCode.Styles[Style.Default].Font = "Courier New";
            scintillaCSSCode.Styles[Style.Default].Size = 10;
            scintillaCSSCode.StyleClearAll();

            scintillaCSSCode.Lexer = Lexer.Css;

            scintillaCSSCode.Margins[0].Width = 20;
            scintillaCSSCode.Styles[Style.LineNumber].ForeColor = Color.FromArgb(255, 128, 128, 128);  //Dark Gray
            scintillaCSSCode.Styles[Style.LineNumber].BackColor = Color.FromArgb(255, 228, 228, 228);  //Light Gray

            scintillaCSSCode.Styles[Style.Css.Attribute].ForeColor = Color.Red;
            scintillaCSSCode.Styles[Style.Css.Class].ForeColor = Color.Blue;
            scintillaCSSCode.Styles[Style.Css.Comment].ForeColor = Color.Green;
            scintillaCSSCode.Styles[Style.Css.Directive].ForeColor = Color.Purple;
            scintillaCSSCode.Styles[Style.Css.DoubleString].ForeColor = Color.Pink;
            scintillaCSSCode.Styles[Style.Css.ExtendedIdentifier].ForeColor = Color.HotPink;
            scintillaCSSCode.Styles[Style.Css.ExtendedPseudoClass].ForeColor = Color.Magenta;
            scintillaCSSCode.Styles[Style.Css.ExtendedPseudoElement].ForeColor = Color.Brown;
            scintillaCSSCode.Styles[Style.Css.Id].ForeColor = Color.LightBlue;
            scintillaCSSCode.Styles[Style.Css.Identifier].ForeColor = Color.Cyan;
            scintillaCSSCode.Styles[Style.Css.Identifier2].ForeColor = Color.DarkCyan;
            scintillaCSSCode.Styles[Style.Css.Identifier3].ForeColor = Color.DarkKhaki;
            scintillaCSSCode.Styles[Style.Css.Important].ForeColor = Color.DarkOrange;
            scintillaCSSCode.Styles[Style.Css.Media].ForeColor = Color.Azure;
            scintillaCSSCode.Styles[Style.Css.Operator].ForeColor = Color.DeepPink;
            scintillaCSSCode.Styles[Style.Css.PseudoClass].ForeColor = Color.Magenta;
            scintillaCSSCode.Styles[Style.Css.PseudoElement].ForeColor = Color.Brown;
            scintillaCSSCode.Styles[Style.Css.SingleString].ForeColor = Color.Pink;
            scintillaCSSCode.Styles[Style.Css.Tag].ForeColor = Color.CadetBlue;
            scintillaCSSCode.Styles[Style.Css.Value].ForeColor = Color.Green;
            scintillaCSSCode.Styles[Style.Css.Variable].ForeColor = Color.DarkGray;
                     

        }

        private DataTable GetData(string sqlCommand)
        {

            DataTable table = new DataTable();

            try
            {

                IDFIELDNAME = ""; // Initialize Identity fields to empty
                IDFIELDTYPE = "";
                AUTONUMBER = true;

                SqlConnection cn = new SqlConnection(DSN);

                SqlCommand command = new SqlCommand(sqlCommand, cn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                //DataTable table = new DataTable();
                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);

                TheFields = new List<Field>();

                // unpack the field specifiers from the resulting datataable

                for (int row = 0; row < table.Rows.Count; ++row)
                {

                    string n = table.Rows[row][0].ToString();
                    string t = table.Rows[row][1].ToString().ToUpper();

                    int w = 0;

                    int.TryParse(table.Rows[row][2].ToString(), out w);

                    if (t.ToUpper().Trim() == "TEXT" || t.ToUpper().Trim() == "IMAGE")
                    {
                        w = 2147483647;
                    }

                    if (t.ToUpper().Trim() == "NTEXT")
                    {
                        w = 1073741823;
                    }

                    bool nul = false;

                    bool.TryParse(table.Rows[row][3].ToString(), out nul);

                    bool id = false;

                    bool.TryParse(table.Rows[row][4].ToString(), out id);

                    int p = 0;
                    int s = 0;

                    int.TryParse(table.Rows[row][7].ToString(), out p);
                    int.TryParse(table.Rows[row][8].ToString(), out s);

                    if (id)
                    {
                        IDFIELDNAME = n;
                        IDFIELDTYPE = t;
                    }

                    if (t.ToUpper() == "UNIQUEIDENTIFIER" || t.ToUpper() == "GUID")
                    {
                        w = 50;
                    }

                    Field f = new Field(n, t, w, nul, id,p,s);

                    TheFields.Add(f);

                }

                if (IDFIELDNAME == "")
                {
                    // we do not have an ID so lets assume one perhaps

                    AUTONUMBER = false;

                    Field FF = TheFields[0];

                    IDFIELDNAME = FF.FieldName;
                    IDFIELDTYPE = FF.FieldType;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return table;
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

        
        #region JavaScript stuff

        private string GenerateJavaScriptClass()
        {
            string s = "";

            s += "var " + TableName.ToUpper() + " = {\n";
            
            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "" + f.FieldNameConverted + ": \"\",\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "" + f.FieldNameConverted + ": 0,\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "" + f.FieldNameConverted + ": 0,\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "" + f.FieldNameConverted + ": 0.0,\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "" + f.FieldNameConverted + ": new Date(),\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "" + f.FieldNameConverted + ": false,\n";
                }
            }

            s = s.Substring(0, s.Length - ",\n".Length);

            s += "\n}\n\n";

            return s;
        }

        #endregion

        #region TypeScript Stuff

        private string GenerateTSCode()
        {
            string s = "";

            s += "class " + TableName.ToUpper() + " {\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "" + f.FieldNameConverted + ": string = \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT" || f.FieldType == "BIGINT" ||
                    f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || 
                    f.FieldType == "FLOAT")
                {
                    s += "" + f.FieldNameConverted + ": number = 0;\n";
                }
                                
                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "" + f.FieldNameConverted + ": Date = new Date();\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "" + f.FieldNameConverted + ": boolean = false;\n";
                }
            }

            s += "\n";

            //s += "constructor() {\n\n";
            //s += "// The initialization code can go here\n\n";
            //s += "}\n\n";

            s += "constructor(jsonString?: string) {\n\n";
            s += "// The initialization code can go here\n\n";
            s += "if (jsonString) {\n";
            s += "this.fillFromJSON(jsonString);\n";
            s += "}\n";
            s += "}\n\n";
            
            s += "fillFromJSON(json?: string) {\n\n";
            s += "var jsonObj = JSON.parse(json);\n";
            s += "for (var propName in jsonObj) {\n";
            s += "this[propName] = jsonObj[propName];\n";
            s += "}\n";
            s += "}\n";
                        
            s += "\n}\n\n";
            
            return s;
        }

        #endregion

        #region UI Stuff

        private void HandleDatabaseSelection(object sender, EventArgs e)
        {
            if (cmboDatabases.SelectedItem != null && cmboDatabases.SelectedItem.ToString() != "")
            {
                if (DSN == "")
                    DSN = "Data Source=" + DBSERVERNAME + ";Integrated Security=SSPI;Initial Catalog=" + cmboDatabases.SelectedItem.ToString();
                else
                {
                    DSN = GenerateDSN();
                }

                try
                {
                    string sql = "select NAME from sys.tables ORDER BY NAME";

                    SqlConnection cn = new SqlConnection(DSN);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    SqlDataReader r = cmd.ExecuteReader();

                    cmboTables.Items.Clear();

                    while (r.Read())
                    {
                        cmboTables.Items.Add(r[0] + "");
                    }
                    r.Close();
                    cmd.Dispose();
                    cn.Close();
                    cn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmboTables.Items.Clear();
                }


            }
        }

        private void HandleServerSelection(object sender, EventArgs e)
        {
            if (cmboServers.SelectedItem.ToString() != "")
            {
                DSNTYPE = "";
                DSN = "Data Source=" + cmboServers.SelectedItem.ToString() + ";Integrated Security=SSPI;Initial Catalog=MASTER;";

                DBSERVERNAME = cmboServers.SelectedItem.ToString();

                try
                {

                    SqlConnection cn = new SqlConnection(DSN);
                    cn.Open();

                    string sql = "select NAME from sys.databases ORDER BY NAME";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    SqlDataReader r = cmd.ExecuteReader();

                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();

                    while (r.Read())
                    {
                        cmboDatabases.Items.Add(r[0] + "");
                        //cmboDatabasedForDocDefForms.Items.Add(r[0] + "");
                        //cmboDATABASEFORLOOKUPS.Items.Add(r[0] + "");
                    }
                    r.Close();
                    cmd.Dispose();
                    cn.Close();
                    cn.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();
                }

            }
        }

        private void HandleTableSelection(object sender, EventArgs e)
        {
            try
            {
                if (cmboTables.SelectedItem.ToString() != "")
                {
                    TableName = cmboTables.SelectedItem.ToString();
                    IDFIELDNAME = "";
                    AUTONUMBER = true;

                    string obid = GetObjectIdFor(TableName);

                    string sql = "SELECT A.NAME,(SELECT TOP 1 B.NAME FROM SYS.types B WHERE A.SYSTEM_TYPE_ID = B.system_type_id AND B.is_user_defined = 0) as 'COLUMNTYPE'," +
                                "A.max_length as 'LENGTH',A.is_nullable as 'ALLOWNULLS',A.is_identity as 'IDENTITY'," +
                                "A.is_computed as 'COMPUTED',COALESCE(a.collation_name,'') as 'COLLATIONTYPE',A.PRECISION,A.SCALE " +
                                "FROM SYS.columns A " +
                                "where A.object_id = " + obid + " ORDER BY A.COLUMN_ID";

                    bsource.DataSource = GetData(sql);
                    dgrid.DataSource = bsource;

                    dgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                    dgrid.BorderStyle = BorderStyle.Fixed3D;

                    dgrid.EditMode = DataGridViewEditMode.EditProgrammatically;

                    if (!AUTONUMBER)
                    {
                        MessageBox.Show("We do not have a true AUTONUMBERING ID Field in the selected Table\n" +
                            "This is likely going be a problem for some of the\n" +
                            "Auto Code Generation stuff but an Assumption will\n" +
                            "be made on the first field in the table...", "Big Trouble in little china");
                    }




                    if (IDFIELDNAME != "")
                    {

                        //sciBaseTableCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaWFCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaWebMethodCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaXAML.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //sciSQLCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaJSCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaHTMLCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaCSSCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //sciBaseTableTSCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;



                        sciBaseTableCode.Text = "";
                        sciBaseTableTSCode.Text = "";
                        scintillaWFCode.Text = "";
                        scintillaWebMethodCode.Text = "";
                        scintillaWEBAPICode.Text = "";
                        scintillaXAML.Text = "";
                        sciSQLCode.Text = "";
                        scintillaRestCode.Text = "";
                        scintillaJSCode.Text = "";
                        scintillaHTMLCode.Text = "";
                        scintillaCSSCode.Text = "";


                        sciSQLCode.InsertText(0,
                            GenerateDropTableStatement() +
                            GenerateCreateTableStatement() +
                            GenerateInsertStatement());

                        scintillaJSCode.InsertText(0,
                            DoTheIndentation(GenerateJavaScriptClass()
                            ));

                        sciBaseTableTSCode.InsertText(0,
                            DoTheIndentation(GenerateTSCode()
                            ));

                        scintillaWFCode.InsertText(0,
                            DoTheIndentation(
                            GenerateWinFormsInitializeComponent() +
                            GeneratePacker() +
                            GenerateUnPacker() +
                            GenerateButtonHandlers() +
                            GenerateSupportRoutines()
                            ));

                        scintillaXAML.InsertText(0,
                            GenerateXAMLCode());

                        sciBaseTableCode.InsertText(0,
                            DoTheIndentation(GenerateUsingBlock() +
                            GenerateClassHeader() +
                            GenerateConstructor() +

                            "#region Public Methods\n\n" +

                            GenerateInitializeMethod() +
                            GenerateCopyFieldsMethod() +
                            GenerateRecExistsMethod() +
                            GenerateAddMethod() +
                            GenerateFastAddMethod() +
                            GenerateUpdateMethod() +
                            GenerateDeleteMethod() +
                            GenerateReadMethod() +
                            GenerateReadAsDataSetMethod() +

                            "#endregion\n\n" +

                            GeneratePrivateMethods() +
                            GenerateClasssTrailer()));



                        scintillaHTMLCode.InsertText(0, GenerateHTMLCode());

                        scintillaCSSCode.InsertText(0, GenerateCSSCode());


                        if (chkGenerateWebMethods.Checked)
                        {

                            scintillaWebMethodCode.InsertText(0,
                                DoTheIndentation(GenerateLDObject() +
                                GenerateDBCON() +
                                GenerateGETLISTOFX() +
                                GenerateWRITEx() +
                                GenerateGETx() +
                                GeneratePostProcessX()));

                            scintillaRestCode.InsertText(0,
                                DoTheIndentation(GenerateRESTFULPage_Load()));

                            scintillaWEBAPICode.InsertText(0,
                                DoTheIndentation(GenerateLDObject() + 
                                GenerateWEBApiGet()));


                        }
                    }
                    else
                    {
                        //MessageBox.Show("The selected table contains no Identity field and thus\n" +
                        //    "is unsuitable for the automated code generation used\n" +
                        //    "within this tool.... \n" +
                        //    "Please select a different table.");

                        //sciBaseTableCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaWFCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaWebMethodCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //scintillaXAML.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;
                        //sciSQLCode.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP2;

                        sciBaseTableCode.Text = "";
                        scintillaWFCode.Text = "";
                        scintillaWebMethodCode.Text = "";
                        scintillaXAML.Text = "";
                        sciSQLCode.Text = "";

                        sciSQLCode.InsertText(0,
                            GenerateDropTableStatement() +
                            GenerateCreateTableStatement() +
                            GenerateInsertStatement());

                    }

                }
            }
            catch //(Exception ex)
            {
                // Something went horribly wrong
            }

        }

        private string GenerateDSN()
        {
            string result = "";

            if (DSNTYPE == "MANUALDSN")
            {

                result = DSN; // just return the existing dsn

            }
            else
            {
                // Make a new DSN based on the other settings

                result = "Data Source=";

                if (cmboServers.SelectedItem == null)
                {
                    if (txtUSER.Text.Trim() == "")
                    {
                        if (cmboDatabases.SelectedItem == null)
                            result = "Data Source=" + txtManualServerName.Text + ";Integrated Security=SSPI;Initial Catalog=MASTER;";
                        else
                            result = "Data Source=" + txtManualServerName.Text + ";Integrated Security=SSPI;Initial Catalog=" + cmboDatabases.SelectedItem.ToString() + ";";
                    }
                    else
                    {
                        if (cmboDatabases.SelectedItem == null)
                            result = "Data Source=" + txtManualServerName.Text + ";USER=" + txtUSER.Text.Trim() + ";PASSWORD=" + txtPASSWORD.Text.Trim() + ";Initial Catalog=MASTER;";
                        else
                            result = "Data Source=" + txtManualServerName.Text + ";USER=" + txtUSER.Text.Trim() + ";PASSWORD=" + txtPASSWORD.Text.Trim() + ";Initial Catalog=" + cmboDatabases.SelectedItem.ToString() + ";";
                    }
                }
                else
                {
                    if (cmboDatabases.SelectedItem == null)
                        result = "Data Source=" + cmboServers.SelectedItem.ToString() + ";Integrated Security=SSPI;Initial Catalog=MASTER;";
                    else
                        result = "Data Source=" + cmboServers.SelectedItem.ToString() + ";Integrated Security=SSPI;Initial Catalog=" + cmboDatabases.SelectedItem.ToString() + ";";
                }
            }

            return result;
        }

        private void HandleBaseTableCodeFoldingChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkBaseTableCodeFolding.Checked)
            {
                marginwidth = 20;
                //sciBaseTableCode.SetProperty("fold", "1");
                //sciBaseTableCode.SetProperty("fold.compact", "1");

            }
            else
            {
                marginwidth = 0;
                //sciBaseTableCode.SetProperty("fold", "0");
                //sciBaseTableCode.SetProperty("fold.compact", "0");
            }

            sciBaseTableCode.Margins[2].Width = marginwidth;

            

        }

        private void HandleBaseTableLineNumberChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkBaseTableLineNumbers.Checked)
            {
                marginwidth = 40;
            }
            else
            {
                marginwidth = 0;
            }

            sciBaseTableCode.Margins[0].Width = marginwidth;
        }

        private void HandletxtManualServerNameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                DSNTYPE = "";

                if (txtUSER.Text.Trim() == "" && txtPASSWORD.Text.Trim() == "")
                    DSN = "Data Source=" + txtManualServerName.Text + ";Integrated Security=SSPI;Initial Catalog=MASTER;";
                else
                    DSN = "Data Source=" + txtManualServerName.Text + ";USER=" + txtUSER.Text.Trim() + ";PASSWORD=" + txtPASSWORD.Text.Trim() + ";Initial Catalog=MASTER;";

                DBSERVERNAME = txtManualServerName.Text;

                try
                {

                    SqlConnection cn = new SqlConnection(DSN);
                    cn.Open();

                    string sql = "select NAME from sys.databases ORDER BY NAME";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    SqlDataReader r = cmd.ExecuteReader();

                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();

                    while (r.Read())
                    {
                        cmboDatabases.Items.Add(r[0] + "");
                        //cmboDatabasedForDocDefForms.Items.Add(r[0] + "");
                        //cmboDATABASEFORLOOKUPS.Items.Add(r[0] + "");
                    }
                    r.Close();
                    cmd.Dispose();
                    cn.Close();
                    cn.Dispose();

                    cmboDatabases.Focus();

                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();
                }

            }
        }

        private void HandleWebMethodCodeFoldingCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkWebMethodCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaWebMethodCode.Margins[2].Width = marginwidth;
        }

        private void HandleWinformsUICodeFoldingChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkWFCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaWFCode.Margins[2].Width = marginwidth;
        }

        private void HandleXAMLCodeFoldingChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkXAMLCodeFoldingXaml.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaXAML.Margins[2].Width = marginwidth;
        }

        private void HandleWebMethodLineNumberCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkWebMethodLineNumbers.Checked)
            {
                marginwidth = 40;
            }
            else
            {
                marginwidth = 0;
            }

            //SqlDbType.UniqueIdentifier 


            scintillaWebMethodCode.Margins[0].Width = marginwidth;
        }

        private void HandleXamlLineNumberCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkLineNumbersXAML.Checked)
            {
                marginwidth = 40;
            }
            else
            {
                marginwidth = 0;
            }

            //SqlDbType.UniqueIdentifier 


            scintillaXAML.Margins[0].Width = marginwidth;
        }

        private void HandleWinformsLineNumberCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkWFLineNumbers.Checked)
            {
                marginwidth = 40;
            }
            else
            {
                marginwidth = 0;
            }

            //SqlDbType.UniqueIdentifier 


            scintillaWFCode.Margins[0].Width = marginwidth;
        }

        //private void btnReadDocDefForms_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnAddNewDocDefForm_Click(object sender, EventArgs e)
        //{

        //}

        //private void HandleSelectingDatabaseForLOOKUPMGMT(object sender, EventArgs e)
        //{
        //    if (cmboDATABASEFORLOOKUPS.SelectedItem.ToString() != "")
        //    {
        //        if (DSN.EndsWith("Initial Catalog=MASTER;"))
        //            DSN = DSN.Replace("Initial Catalog=MASTER;", "Initial Catalog=" + cmboDATABASEFORLOOKUPS.SelectedItem.ToString() + ";");

        //        try
        //        {
        //            string sql = "Select distinct LOOKUPTYPE from tblLookup ORDER BY LOOKUPTYPE";

        //            cmboSpecificLookupList.Items.Clear();

        //            SqlConnection cn = new SqlConnection(DSN);
        //            cn.Open();
        //            SqlCommand cmd = new SqlCommand(sql, cn);

        //            SqlDataReader r = cmd.ExecuteReader();

        //            while (r.Read())
        //            {
        //                cmboSpecificLookupList.Items.Add(r[0] + "");
        //            }
        //            r.Close();
        //            cmd.Dispose();
        //            cn.Close();
        //            cn.Dispose();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            cmboSpecificLookupList.Items.Clear();
        //        }
        //    }
        //}

        //private void HandleSelectionADatabaseforDocDef(object sender, EventArgs e)
        //{
        //    if (cmboDatabasedForDocDefForms.SelectedItem.ToString() != "")
        //    {
        //        if (DSN.EndsWith("Initial Catalog=MASTER;"))
        //            DSN = DSN.Replace("Initial Catalog=MASTER;", "Initial Catalog=" + cmboDatabasedForDocDefForms.SelectedItem.ToString() + ";");


        //        cmboDocDefForms.Items.Clear();
        //        cmboDocDefSubForms.Items.Clear();
        //        cmboDocDefSubSubForms.Items.Clear();
        //        cmboDocDefForms.SelectedItem = null;
        //        cmboDocDefSubForms.SelectedItem = null;
        //        cmboDocDefSubSubForms.SelectedItem = null;

        //        try
        //        {
        //            string sql = "SELECT [DocDefCat_Id],[DocDefCatCode],[DocDefCatDesc],[isActive]  FROM [tblDocDefCat]";

        //            SqlConnection cn = new SqlConnection(DSN);
        //            cn.Open();
        //            SqlCommand cmd = new SqlCommand(sql, cn);

        //            SqlDataReader r = cmd.ExecuteReader();

        //            cmboDocDefForms.Items.Clear();

        //            while (r.Read())
        //            {
        //                DOCDEFCAT thefrm = new DOCDEFCAT();

        //                thefrm.DocDefCat_Id = r[0] + "";
        //                thefrm.DocDefCatCode = r[1] + "";
        //                thefrm.DocDefCatDesc = r[2] + "";
        //                thefrm.isActive = r[3] + "";

        //                cmboDocDefForms.Items.Add(thefrm);
        //            }
        //            r.Close();
        //            cmd.Dispose();
        //            cn.Close();
        //            cn.Dispose();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            cmboDocDefForms.Items.Clear();
        //            cmboDocDefSubForms.Items.Clear();
        //            cmboDocDefSubSubForms.Items.Clear();
        //            cmboDocDefForms.SelectedItem = null;
        //            cmboDocDefSubForms.SelectedItem = null;
        //            cmboDocDefSubSubForms.SelectedItem = null;
        //        }


        //    }
        //}

        //private void HandelSelectionOfAFormInTheDatabase(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmboDocDefForms.SelectedItem != null)
        //        {

        //            string sql = "SELECT [DocDefType_Id],[DocDefCat_Id],[DocDefTypeCode],[DocDefTypeDesc],[isActive],[Forms] FROM [tblDocDefType] WHERE DocDefCat_Id = " + ((DOCDEFCAT)cmboDocDefForms.SelectedItem).DocDefCat_Id;

        //            SqlConnection cn = new SqlConnection(DSN);
        //            cn.Open();
        //            SqlCommand cmd = new SqlCommand(sql, cn);

        //            SqlDataReader r = cmd.ExecuteReader();

        //            cmboDocDefSubForms.Items.Clear();
        //            cmboDocDefSubSubForms.Items.Clear();
        //            cmboDocDefSubForms.SelectedItem = null;
        //            cmboDocDefSubSubForms.SelectedItem = null;

        //            while (r.Read())
        //            {
        //                DOCDEFTYPE thefrm = new DOCDEFTYPE();

        //                thefrm.DocDefType_Id = r[0] + "";
        //                thefrm.DocDefCat_Id = r[1] + "";
        //                thefrm.DocDefTypeCode = r[2] + "";
        //                thefrm.DocDefTypeDesc = r[3] + "";
        //                thefrm.isActive = r[4] + "";
        //                thefrm.Forms = r[5] + "";

        //                cmboDocDefSubForms.Items.Add(thefrm);
        //            }
        //            r.Close();
        //            cmd.Dispose();
        //            cn.Close();
        //            cn.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        cmboDocDefSubForms.Items.Clear();
        //        cmboDocDefSubSubForms.Items.Clear();
        //        cmboDocDefSubForms.SelectedItem = null;
        //        cmboDocDefSubSubForms.SelectedItem = null;
        //    }
        //}

        //private void HandleSelectionOfAformForTHatCatgory(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmboDocDefSubForms.SelectedItem != null)
        //        {

        //            string sql = "SELECT [DocDefTypeSub_Id],[DocDefType_Id],[DocDefTypeSubCode],[DocDefTypeSubDesc],[DocDefTypeSubOrder],[isActive] FROM [tblDocDefTypeSub] WHERE DocDefType_Id = " + ((DOCDEFTYPE)cmboDocDefSubForms.SelectedItem).DocDefType_Id;

        //            SqlConnection cn = new SqlConnection(DSN);
        //            cn.Open();
        //            SqlCommand cmd = new SqlCommand(sql, cn);

        //            SqlDataReader r = cmd.ExecuteReader();

        //            cmboDocDefSubSubForms.Items.Clear();
        //            cmboDocDefSubSubForms.SelectedItem = null;

        //            while (r.Read())
        //            {
        //                DOCDEFSUBTYPE thefrm = new DOCDEFSUBTYPE();

        //                thefrm.DocDefTypeSub_Id = r[0] + "";
        //                thefrm.DocDefType_Id = r[1] + "";
        //                thefrm.DocDefTypeSubCode = r[2] + "";
        //                thefrm.DocDefTypeSubDesc = r[3] + "";
        //                thefrm.DocDefTypeSubOrder = r[4] + "";
        //                thefrm.isActive = r[5] + "";

        //                cmboDocDefSubSubForms.Items.Add(thefrm);
        //            }
        //            r.Close();
        //            cmd.Dispose();
        //            cn.Close();
        //            cn.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        cmboDocDefSubSubForms.Items.Clear();
        //        cmboDocDefSubSubForms.SelectedItem = null;

        //    }
        //}

        //private void HandelSelectionOfASpecificFormFinally(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        PopulateDocDefinitionsTable();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void HandleMouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    int row = ((TAIGridControl2.TAIGridControl)sender).SelectedRow;

        //    string ID = ((TAIGridControl2.TAIGridControl)sender).get_item(row, "DocDefTemplateID");

        //    tbldocDefTemplate template = new tbldocDefTemplate(DSN);

        //    template.Read(Convert.ToInt32(ID));

        //    tblDocDefTemplateUI thefrm = new tblDocDefTemplateUI(template);

        //    thefrm.FormClosed += thefrm_FormClosed;

        //    thefrm.Show();

        //}

        //private void HandleDoubleClickingOnALookup(object sender, MouseEventArgs e)
        //{
        //    int row = ((TAIGridControl2.TAIGridControl)sender).SelectedRow;

        //    string ID = ((TAIGridControl2.TAIGridControl)sender).get_item(row, "LookupId");

        //    tblLookup lkp = new tblLookup(DSN);

        //    lkp.Read(Convert.ToInt32(ID));

        //    frmTblLookupUI thelkpfrm = new frmTblLookupUI(lkp);

        //    thelkpfrm.FormClosed += thelkpfrm_FormClosed;

        //    thelkpfrm.Show();

        //}
                
        //private void HandleSelectionOfASpecificLookupList(object sender, EventArgs e)
        //{
        //    if (cmboSpecificLookupList.SelectedItem.ToString() != "")
        //    {

        //        string sql = "select * from tbllookup where LOOKUPTYPE = '" + cmboSpecificLookupList.SelectedItem.ToString() + "' ORDER BY SORTORDER; ";

        //        taigLookupListGrid.PopulateGridWithData(DSN, sql);
        //    }
        //}
        
        private void chkSQLLineNumber_CheckedChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkSQLLineNumber.Checked)
            {
                marginwidth = 60;
            }
            else
            {
                marginwidth = 0;
            }

            sciSQLCode.Margins[0].Width = marginwidth;
        }

        private void chkSQLCodeFolding_CheckedChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkSQLCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            sciSQLCode.Margins[2].Width = marginwidth;
        }

        private void dtnSaveSQLToFile_Click(object sender, EventArgs e)
        {
            if (sciSQLCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, sciSQLCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some SQL code first");
            }
        }
        
        //private void btnAddNewLookup_Click(object sender, EventArgs e)
        //{
        //    int sorder = 0;

        //    int lookuptypeid = 0;

        //    string lookuptype = "";

        //    for (int i = 0; i < taigLookupListGrid.Rows; i++)
        //    {
        //        sorder = Convert.ToInt32(taigLookupListGrid.get_item(i, "SortOrder"));
        //        lookuptypeid = Convert.ToInt32(taigLookupListGrid.get_item(i, "LookupTypeId"));

        //        lookuptype = taigLookupListGrid.get_item(i, "LookupType");

        //    }

        //    tblLookup lkp = new tblLookup(DSN);

        //    lkp.Initialize();

        //    lkp.SortOrder = sorder + 1;
        //    lkp.LookupTypeId = lookuptypeid;
        //    lkp.LookupType = lookuptype;

        //    frmTblLookupUI thelkpfrm = new frmTblLookupUI(lkp, true);

        //    thelkpfrm.FormClosed += thelkpfrm_FormClosed;

        //    thelkpfrm.Show();

        //}

        //private void btnRemoveSelectedLookup_Click(object sender, EventArgs e)
        //{
        //    if (taigLookupListGrid.SelectedRow < 0)
        //    {
        //        MessageBox.Show("You have to select a row to remove");
        //    }
        //    else
        //    {
        //        int ID = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow, "LookupId"));

        //        string sql = "DELETE FROM TBLLOOKUP WHERE LOOKUPID = " + ID.ToString();

        //        SqlConnection cn = new SqlConnection(DSN);
        //        cn.Open();
        //        SqlCommand cmd = new SqlCommand(sql, cn);

        //        cmd.ExecuteNonQuery();

        //        cmd.Dispose();
        //        cn.Close();
        //        cn.Dispose();

        //        PopulateTheLookupGrid();

        //    }
        //}

        //private void btnDeactivateSelectedLookup_Click(object sender, EventArgs e)
        //{
        //    if (taigLookupListGrid.SelectedRow < 0)
        //    {
        //        MessageBox.Show("You have to select a row to Toggle Activation On");
        //    }
        //    else
        //    {
        //        int ID = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow, "LookupId"));

        //        tblLookup lkp = new tblLookup(DSN);
        //        lkp.Read(ID);

        //        if (lkp.Active.ToUpper() == "Y")
        //        {
        //            lkp.Active = "N";
        //        }
        //        else
        //        {
        //            lkp.Active = "Y";
        //        }

        //        lkp.Update();

        //        PopulateTheLookupGrid();
        //    }
        //}

        //private void btnMOVELOOKUPUP_Click(object sender, EventArgs e)
        //{
        //    if (taigLookupListGrid.SelectedRow < 0)
        //    {
        //        MessageBox.Show("You have to select a row to Move");
        //    }
        //    else
        //    {
        //        if (taigLookupListGrid.SelectedRow == 0)
        //        {
        //            // we are already at the top

        //            MessageBox.Show("The Row select is already at the top");
        //        }
        //        else
        //        {
        //            int IDtoMove = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow, "LookupId"));
        //            int IDtoMoveTo = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow - 1, "LookupId"));

        //            int RowToSelectAfterWards = taigLookupListGrid.SelectedRow - 1;

        //            tblLookup lkptoMove = new tblLookup(DSN);
        //            tblLookup lkptoMoveTo = new tblLookup(DSN);

        //            lkptoMove.Read(IDtoMove);
        //            lkptoMoveTo.Read(IDtoMoveTo);

        //            int sorder = lkptoMoveTo.SortOrder;

        //            lkptoMoveTo.SortOrder = lkptoMove.SortOrder;
        //            lkptoMove.SortOrder = sorder;

        //            lkptoMove.Update();
        //            lkptoMoveTo.Update();

        //            PopulateTheLookupGrid();

        //            taigLookupListGrid.SelectedRow = RowToSelectAfterWards;
        //        }
        //    }
        //}

        //private void btnMOVELOOKUPDOWN_Click(object sender, EventArgs e)
        //{
        //    if (taigLookupListGrid.SelectedRow < 0)
        //    {
        //        MessageBox.Show("You have to select a row to Move");
        //    }
        //    else
        //    {
        //        if (taigLookupListGrid.SelectedRow == taigLookupListGrid.Rows - 1)
        //        {
        //            // we are already at the top

        //            MessageBox.Show("The Row select is already at the top");
        //        }
        //        else
        //        {
        //            int IDtoMove = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow, "LookupId"));
        //            int IDtoMoveTo = Convert.ToInt32(taigLookupListGrid.get_item(taigLookupListGrid.SelectedRow + 1, "LookupId"));

        //            int RowToSelectAfterWards = taigLookupListGrid.SelectedRow + 1;

        //            tblLookup lkptoMove = new tblLookup(DSN);
        //            tblLookup lkptoMoveTo = new tblLookup(DSN);

        //            lkptoMove.Read(IDtoMove);
        //            lkptoMoveTo.Read(IDtoMoveTo);

        //            int sorder = lkptoMoveTo.SortOrder;

        //            lkptoMoveTo.SortOrder = lkptoMove.SortOrder;
        //            lkptoMove.SortOrder = sorder;

        //            lkptoMove.Update();
        //            lkptoMoveTo.Update();

        //            PopulateTheLookupGrid();

        //            taigLookupListGrid.SelectedRow = RowToSelectAfterWards;
        //        }
        //    }
        //}

        private void btnSaveXaml_Click(object sender, EventArgs e)
        {
            if (scintillaXAML.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaXAML.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private void btnWFSaveToFile_Click(object sender, EventArgs e)
        {
            if (scintillaWFCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaWFCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private void btnSaveBaseCodeTableToFile_Click(object sender, EventArgs e)
        {
            if (sciBaseTableCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, sciBaseTableCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private void btnSaveHTML_Click(object sender, EventArgs e)
        {
            if (scintillaHTMLCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaHTMLCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }
        
        private void HandlechkRestLineNumbersCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkRestLineNumbers.Checked)
            {
                marginwidth = 60;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaRestCode.Margins[0].Width = marginwidth;
        }

        private void HandlechkRestCodeFoldingCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkRestCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaRestCode.Margins[2].Width = marginwidth;
        }

        private void HandleHTMLLineNumbersChecked(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkHTMLLineNumbers.Checked)
            {
                marginwidth = 60;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaHTMLCode.Margins[0].Width = marginwidth;
        }

        private void HandleHTMLCodeFoldingChecked(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkHTMLCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaHTMLCode.Margins[2].Width = marginwidth;
        }

        private void HandleCSSLineNumbersChecked(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkCSSLineNumbers.Checked)
            {
                marginwidth = 60;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaCSSCode.Margins[0].Width = marginwidth;
        }

        private void HandleCSSCodeFoldingChecked(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkCSSCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            scintillaCSSCode.Margins[2].Width = marginwidth;
        }

        private void btnsaveCSS_Click(object sender, EventArgs e)
        {
            if (scintillaCSSCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaCSSCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }
        
        private void btnRestSaveToFile_Click(object sender, EventArgs e)
        {
            if (scintillaRestCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaRestCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private void chkBaseTableTSLineNumbers_CheckedChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkBaseTableTSLineNumbers.Checked)
            {
                marginwidth = 40;
            }
            else
            {
                marginwidth = 0;
            }

            sciBaseTableTSCode.Margins[0].Width = marginwidth;
        }

        private void chkBaseTableTSCodeFolding_CheckedChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkBaseTableTSCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            sciBaseTableTSCode.Margins[2].Width = marginwidth;



        }

        private void btnSaveTSCode_Click(object sender, EventArgs e)
        {
            if (sciBaseTableTSCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, sciBaseTableTSCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private void ConfigureScintillaControlForCPP(ScintillaNET.Scintilla theSCI)
        {
            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            theSCI.StyleResetDefault();
            theSCI.Styles[Style.Default].Font = "Consolas";
            theSCI.Styles[Style.Default].Size = 10;
            theSCI.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            theSCI.Styles[Style.Cpp.Default].ForeColor = Color.Silver;
            theSCI.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            theSCI.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
            theSCI.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
            theSCI.Styles[Style.Cpp.Number].ForeColor = Color.Olive;
            theSCI.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            theSCI.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
            theSCI.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            theSCI.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
            theSCI.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
            theSCI.Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
            theSCI.Styles[Style.Cpp.Operator].ForeColor = Color.Purple;
            theSCI.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            theSCI.Lexer = Lexer.Cpp;

            ConfigScintillaControlForFolding(theSCI);

            // Set the keywords
            theSCI.SetKeywords(0, "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using virtual while");
            theSCI.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");

        }

        private void ConfigScintillaControlForFolding(ScintillaNET.Scintilla TheSCI)
        {
            // Instruct the lexer to calculate folding
            TheSCI.SetProperty("fold", "1");
            TheSCI.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            TheSCI.Margins[2].Type = MarginType.Symbol;
            TheSCI.Margins[2].Mask = Marker.MaskFolders;
            TheSCI.Margins[2].Sensitive = true;
            TheSCI.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                TheSCI.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                TheSCI.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            TheSCI.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            TheSCI.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            TheSCI.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            TheSCI.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            TheSCI.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            TheSCI.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            TheSCI.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            TheSCI.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
        }

        private void btnFiddleIt_Click(object sender, EventArgs e)
        {

            // Not yet

            if (scintillaHTMLCode.Text.Trim() != "")
            {
                //string URL = "http://jsfiddle.net/api/post/library/pure/";
                //string param = "";

                string url = "FILE://" + Application.StartupPath + "/TEMP.HTML";

                if (System.IO.File.Exists("TEMP.HTML"))
                {
                    System.IO.File.Delete("TEMP.HTML");
                    System.IO.File.Delete("STYLE.CSS");
                }

                System.IO.File.WriteAllText("TEMP.HTML", scintillaHTMLCode.Text.Trim());
                System.IO.File.WriteAllText("STYLE.CSS", scintillaCSSCode.Text.Trim());

                System.Diagnostics.Process.Start(url);

            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        public static string PostMessageToURL(string url, string parameters)
        {
            using (System.Net.WebClient wc = new System.Net.WebClient())
            {
                wc.Headers[System.Net.HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(url, "POST", parameters);
                return HtmlResult;
            }
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        private void dgrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSelectLookupFields frm = new frmSelectLookupFields(DSN);
            frm.ShowDialog();

            if (frm.TABLENAME != "")
            {
                TheFields[e.RowIndex].CROSSWALKTABLE = frm.TABLENAME;
                TheFields[e.RowIndex].CROSSWALKVALUE = frm.VALUEFIELD;
                TheFields[e.RowIndex].CROSSWALKDISPLAY = frm.DESCCRIPTIONFIELD;
            }

            scintillaHTMLCode.Text = "";
            scintillaHTMLCode.InsertText(0, GenerateHTMLCode());


            //MessageBox.Show(TheFields[e.RowIndex].FieldName);
        }

        private void btnSSPI_Click(object sender, EventArgs e)
        {
            txtUSER.Text = "";
            txtPASSWORD.Text = "";
        }

        private void HandleManualConnectionStringKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                DSNTYPE = "MANUALDSN";

                DSN = txtManualConnectionString.Text.Trim();

                var eles = DSN.Split(";".ToCharArray()); // split the DSN on the ; characters so we can determine the server component

                foreach (string s in eles)
                {
                    if (s.ToUpper().Trim().StartsWith("DATA SOURCE="))
                    {
                        DBSERVERNAME = s.Substring(11); // Remove the DATA SOURCE= and set servername
                        break;
                    }

                    if (s.ToUpper().Trim().StartsWith("SERVER="))
                    {
                        DBSERVERNAME = s.Substring(6); // Remove the SERVER= and set servername
                        break;
                    }
                }

                //if (txtUSER.Text.Trim() == "" && txtPASSWORD.Text.Trim() == "")
                //    DSN = "Data Source=" + txtManualServerName.Text + ";Integrated Security=SSPI;Initial Catalog=MASTER;";
                //else
                //    DSN = "Data Source=" + txtManualServerName.Text + ";USER=" + txtUSER.Text.Trim() + ";PASSWORD=" + txtPASSWORD.Text.Trim() + ";Initial Catalog=MASTER;";

                //DBSERVERNAME = txtManualServerName.Text;

                try
                {

                    SqlConnection cn = new SqlConnection(DSN);
                    cn.Open();

                    string sql = "select NAME from sys.databases ORDER BY NAME";

                    SqlCommand cmd = new SqlCommand(sql, cn);

                    SqlDataReader r = cmd.ExecuteReader();

                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();

                    while (r.Read())
                    {
                        cmboDatabases.Items.Add(r[0] + "");
                        //cmboDatabasedForDocDefForms.Items.Add(r[0] + "");
                        //cmboDATABASEFORLOOKUPS.Items.Add(r[0] + "");
                    }
                    r.Close();
                    cmd.Dispose();
                    cn.Close();
                    cn.Dispose();

                    cmboDatabases.Focus();

                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cmboDatabases.Items.Clear();
                    //cmboDatabasedForDocDefForms.Items.Clear();
                    //cmboDATABASEFORLOOKUPS.Items.Clear();
                }

            }
        }

        private void btnStringify_Click(object sender, EventArgs e)
        {
            string[] arr = txtStringIfy.Text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            StringBuilder s = new StringBuilder();

            s.Append("var thestring = \"\";\n");

            foreach (string ss in arr)
            {
                if (chkPad.Checked)
                { s.Append("\tthestring += \"" + ss + " \";\n"); }
                else
                { s.Append("\tthestring += \"" + ss + "\";\n");  }
                
            }

            sciStringify.Text = s.ToString();

        }

        private void handlechkStringifyLineNumberCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkStringifyLineNumbers.Checked)
            {
                marginwidth = 60;
            }
            else
            {
                marginwidth = 0;
            }

            sciStringify.Margins[0].Width = marginwidth;
        }

        private void handlechkStringifyCodeFoldingCheckChanged(object sender, EventArgs e)
        {
            int marginwidth = 0;

            if (chkStringifyCodeFolding.Checked)
            {
                marginwidth = 20;
            }
            else
            {
                marginwidth = 0;
            }

            sciStringify.Margins[2].Width = marginwidth;
        }

        #endregion

        #region Code generation Bits
        private void btnSaveWebMethodsToFile_Click(object sender, EventArgs e)
        {
            if (scintillaWebMethodCode.Text != "")
            {
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(sfd.FileName, scintillaWebMethodCode.Text);
                }
            }
            else
            {
                MessageBox.Show("Generate some code first");
            }
        }

        private string DoTheIndentation(string code)
        {
            StringBuilder sb = new StringBuilder();

            string[] lines = code.Split("\n".ToCharArray());

            int indent = 0;

            foreach (string s in lines)
            {
                string[] OPENBRAKS = s.Split("{".ToCharArray());
                string[] CLOSEBRAKS = s.Split("}".ToCharArray());

                // if line starts with the # character don't do the indent

                if (s.StartsWith("#region") || s.StartsWith("#endregion"))
                {
                    sb.Append(INDENT(indent) + s + "\n");

                    // handle indentation after appending code line
                    //indent += OPENBRAKS.GetUpperBound(0);
                    //indent -= CLOSEBRAKS.GetUpperBound(0);
                }
                else
                {

                    if (s == "}")
                    {
                        // handle indentation before the code line as the line is a trailing } 
                        indent += OPENBRAKS.GetUpperBound(0);
                        indent -= CLOSEBRAKS.GetUpperBound(0);

                        sb.Append(INDENT(indent) + s + "\n");
                    }
                    else
                    {
                        sb.Append(INDENT(indent) + s + "\n");

                        // handle indentation after appending code line
                        indent += OPENBRAKS.GetUpperBound(0);
                        indent -= CLOSEBRAKS.GetUpperBound(0);
                    }
                }
            }
            return sb.ToString();
        }

        private string GenerateAddMethod()
        {
            string s = "";

            s += "public void Add()\n";

            s += "{\n";
            s += "try\n";
            s += "{\n";

            if (!AUTONUMBER)
            {
                s += "if (RecExists(this." + IDFIELDNAME + "))\n" +
                    "{\n" +
                    "Update();\n" +
                    "}\n" +
                    "else\n" +
                    "{\n";
            }


            if (AUTONUMBER)
                s += "string sql = GetParameterSQL();\n";
            else
                s += "string sql = GetParameterSQLForAdd();\n";

            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldName != IDFIELDNAME || (!AUTONUMBER && f.FieldName == IDFIELDNAME))
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "SYSNAME")
                    {
                        if (f.AllowNulls) // also add the UI check here
                        {
                            s += "if (this._" + f.FieldNameConverted + " == null || this._" + f.FieldNameConverted + " == \"\" || this._" + f.FieldNameConverted + " == string.Empty)\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = DBNull.Value;\n" +
                                 "}\n" +
                                 "else\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n" +
                                 "}\n"; 
                        }
                        else
                        {
                            s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n";
                        }
                    }

                    if (f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.UniqueIdentifier).Value = System.Guid.Parse(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "INT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Int).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "SMALLINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.SmallInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "TINYINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.TinyInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIGINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.BigInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Money).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DECIMAL" )
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Decimal).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "BOOL")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bool).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bit).Value = this._" + f.FieldNameConverted + ";\n";
                    }


                    //System.Guid.Parse()
                }
            }

            s += "cmd.ExecuteNonQuery();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";

            
            if (AUTONUMBER)
            {

                s += "if(" + IDFIELDNAME + " < 1)\n";
                s += "{\n";
                s += "SqlCommand cmd2 = new SqlCommand(\"SELECT @@IDENTITY\",cn);\n";

                if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
                {
                    s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
                }
                else
                {
                    if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                    {
                        s += "System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());\n";
                    }
                    else
                    {
                        // this should never happen
                        if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                        {
                            s += "System.Double ii = Convert.ToDouble(cmd2.ExecuteScalar());\n";
                        }
                        else
                        {
                            // default to a long
                            s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
                        }
                    }
                }
                s += "cmd2.Cancel();\n";
                s += "cmd2.Dispose();\n";
                s += "_" + IDFIELDNAME + " = ii;\n";
                s += "}\n";

            }

            s += "cn.Close();\n";
            s += "cn.Dispose();\n";

            if (!AUTONUMBER)
            {
                s += "}\n";
            }

            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".Add \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";



            return s;
        }

        private string GenerateFastAddMethod()
        {
            string s = "";

            s += "public void FastAdd()\n";

            s += "{\n";
            s += "try\n";
            s += "{\n";

            if (!AUTONUMBER)
            {
                s += "if (RecExists(this." + IDFIELDNAME + "))\n" +
                    "{\n" +
                    "Update();\n" +
                    "}\n" +
                    "else\n" +
                    "{\n";
            }


            if (AUTONUMBER)
                s += "string sql = GetParameterSQL();\n";
            else
                s += "string sql = GetParameterSQLForAdd();\n";

            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldName != IDFIELDNAME || (!AUTONUMBER && f.FieldName == IDFIELDNAME))
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "SYSNAME")
                    {
                        if (f.AllowNulls) // also add the UI check here
                        {
                            s += "if (this._" + f.FieldNameConverted + " == null || this._" + f.FieldNameConverted + " == \"\" || this._" + f.FieldNameConverted + " == string.Empty)\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = DBNull.Value;\n" +
                                 "}\n" +
                                 "else\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n" +
                                 "}\n";
                        }
                        else
                        {
                            s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n";
                        }
                    }

                    if (f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.UniqueIdentifier).Value = System.Guid.Parse(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "INT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Int).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "SMALLINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.SmallInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "TINYINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.TinyInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIGINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.BigInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Money).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DECIMAL")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Decimal).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "BOOL")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bool).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bit).Value = this._" + f.FieldNameConverted + ";\n";
                    }


                    //System.Guid.Parse()
                }
            }

            s += "cmd.ExecuteNonQuery();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";


            //if (AUTONUMBER)
            //{

            //    s += "if(" + IDFIELDNAME + " < 1)\n";
            //    s += "{\n";
            //    s += "SqlCommand cmd2 = new SqlCommand(\"SELECT @@IDENTITY\",cn);\n";

            //    if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            //    {
            //        s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
            //    }
            //    else
            //    {
            //        if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
            //        {
            //            s += "System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());\n";
            //        }
            //        else
            //        {
            //            // this should never happen
            //            if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
            //            {
            //                s += "System.Double ii = Convert.ToDouble(cmd2.ExecuteScalar());\n";
            //            }
            //            else
            //            {
            //                // default to a long
            //                s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
            //            }
            //        }
            //    }
            //    s += "cmd2.Cancel();\n";
            //    s += "cmd2.Dispose();\n";
            //    s += "_" + IDFIELDNAME + " = ii;\n";
            //    s += "}\n";

            //}

            s += "cn.Close();\n";
            s += "cn.Dispose();\n";

            if (!AUTONUMBER)
            {
                s += "}\n";
            }

            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".Add \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";



            return s;
        }

        private string GenerateRecExistsMethod()
        {
            string s = "";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "public bool RecExists(System.Int64 idx)\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "public bool RecExists(System.Int32 idx)\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DECIMAL" || IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "public bool RecExists(System.Double idx)\n";
                    }
                    else
                    {
                        // default to a long
                        s += "public bool RecExists(string idx)\n";
                    }
                }
            }

            s += "{\n";
            s += "bool Result = false;\n";
            s += "try\n";
            s += "{\n";

            s += "string sql =\"Select count(*) from " + TableName + " WHERE " + IDFIELDNAME + " = @ID\";\n";
            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.BigInt).Value = idx;\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Int).Value = idx;\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Money).Value = idx;\n";
                    }
                    else
                    {
                        // default to a long
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.VarChar).Value = idx;\n";
                    }
                }
            }

            s += "SqlDataReader r = cmd.ExecuteReader();\n";
            s += "while (r.Read())\n";
            s += "{\n";
            s += "if (r.GetInt32(0) > 0)\n" +
                    "{ \n" +
                        "Result = true;\n" +
                    "}\n";
            s += "}\n";
            s += "r.Close();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";

            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".RecExists \" +  ex.ToString()));\n";
            s += "}\n\n";
            s += "return Result;\n";
            s += "}\n\n";


            return s;
        }

        private string GenerateClassHeader()
        {
            string s = "";

            if (chkINotifyCrap.Checked)
            {

                s = "public partial class " + TableName + " : INotifyPropertyChanged\n" +
                    "{\n\n" +
                    "#region Declarations\n" +
                    "string _classDatabaseConnectionString = \"\";\n" +
                    "string _bulkinsertPath = \"\";\n\n" +
                    "SqlConnection _cn = new SqlConnection();\n" +
                    "SqlCommand _cmd = new SqlCommand();\n\n" +
                    "// Backing Variables for Properties\n";
            }
            else
            {
                s = "public partial class " + TableName + "\n" +
                   "{\n\n" +
                   "#region Declarations\n" +
                   "string _classDatabaseConnectionString = \"\";\n" +
                   "string _bulkinsertPath = \"\";\n\n" +
                   "SqlConnection _cn = new SqlConnection();\n" +
                   "SqlCommand _cmd = new SqlCommand();\n\n" +
                   "// Backing Variables for Properties\n";

            }

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "string _" + f.FieldNameConverted + " = \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "int _" + f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "long _" + f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "double _" + f.FieldNameConverted + " = 0.0;\n";
                }

                if (f.FieldType == "DECIMAL")
                {
                    s += "double _" + f.FieldNameConverted + " = 0.0;\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "DateTime _" + f.FieldNameConverted + " = Convert.ToDateTime(null);\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "bool _" + f.FieldNameConverted + " = false;\n";
                }
            }

            s += "\n" +
                "#endregion\n\n" +
                "#region Properties\n\n" +
                "public string classDatabaseConnectionString\n" +
                "{\n";



            s += "get{return _classDatabaseConnectionString;}\n";

            s += "set{_classDatabaseConnectionString = value;}\n}\n\n";



            s += "public string bulkinsertPath\n{\n";



            s += "get{return _bulkinsertPath;} \n";
            s += "set{_bulkinsertPath = value;} \n}\n\n";


            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {

                    if (chkINotifyCrap.Checked)
                    {

                        // here we look for -1 length of fields meaning vaarchar maxes and if so set them REALLY High

                        if (f.MaxLength < 0)
                        {
                            s += "public string " + f.FieldNameConverted + "\n{\n" +
                           "get{ return _" + f.FieldNameConverted + ";}\n" +
                           "set{ \n" +
                           "if (value != null && value.Length > " + int.MaxValue.ToString() + ")\n" +
                           "{ _" + f.FieldNameConverted + " = value.Substring(0," + int.MaxValue.ToString() + ");}\n" +
                           "else { _" + f.FieldNameConverted + " = value;\n" +
                           "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n}\n\n";
                        }
                        else
                        {
                            s += "public string " + f.FieldNameConverted + "\n{\n" +
                           "get{ return _" + f.FieldNameConverted + ";}\n" +
                           "set{ \n" +
                           "if (value != null && value.Length > " + f.MaxLength.ToString() + ")\n" +
                           "{ _" + f.FieldNameConverted + " = value.Substring(0," + f.MaxLength.ToString() + ");}\n" +
                           "else { _" + f.FieldNameConverted + " = value;\n" +
                           "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n}\n\n";
                        }
                    }
                    else
                    {
                        // here we look for -1 length of fields meaning vaarchar maxes and if so set them REALLY High

                        if (f.MaxLength < 0)
                        {
                            s += "public string " + f.FieldNameConverted + "\n{\n" +
                           "get{ return _" + f.FieldNameConverted + ";}\n" +
                           "set{ \n" +
                           "if (value != null && value.Length > " + int.MaxValue.ToString() + ")\n" +
                           "{ _" + f.FieldNameConverted + " = value.Substring(0," + int.MaxValue.ToString() + ");}\n" +
                           "else { _" + f.FieldNameConverted + " = value;}\n}\n}\n\n";
                        }
                        else
                        {
                            s += "public string " + f.FieldNameConverted + "\n{\n" +
                           "get{ return _" + f.FieldNameConverted + ";}\n" +
                           "set{ \n" +
                           "if (value != null && value.Length > " + f.MaxLength.ToString() + ")\n" +
                           "{ _" + f.FieldNameConverted + " = value.Substring(0," + f.MaxLength.ToString() + ");}\n" +
                           "else { _" + f.FieldNameConverted + " = value;}\n}\n}\n\n";
                        }
                    }


                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    if (chkINotifyCrap.Checked)
                    {

                        s += "public int " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;\n" +
                            "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n\n";
                    }
                    else
                    {
                        s += "public int " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;}\n}\n\n";
                    }
                }

                if (f.FieldType == "BIGINT")
                {

                    if (chkINotifyCrap.Checked)
                    {

                        s += "public long " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;\n" +
                            "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n\n";
                    }
                    else
                    {
                        s += "public long " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;}\n}\n\n";
                    }
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    if (chkINotifyCrap.Checked)
                    {

                        s += "public double " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;\n" +
                            "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n\n";
                    }
                    else
                    {
                        s += "public double " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;}\n}\n\n";
                    }
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {

                    if (chkINotifyCrap.Checked)
                    {
                        s += "public DateTime " + f.FieldNameConverted + "\n{\n" +
                             "get{ return _" + f.FieldNameConverted + ";}\n" +
                             "set{ _" + f.FieldNameConverted + " = value;\n" +
                            "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n\n";
                    }
                    else
                    {
                        s += "public DateTime " + f.FieldNameConverted + "\n{\n" +
                             "get{ return _" + f.FieldNameConverted + ";}\n" +
                             "set{ _" + f.FieldNameConverted + " = value;}\n}\n\n";
                    }
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    if (chkINotifyCrap.Checked)
                    {

                        s += "public bool " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;\n" +
                            "RaisePropertyChanged(\"" + f.FieldNameConverted + "\");}\n}\n\n";
                    }
                    else
                    {
                        s += "public bool " + f.FieldNameConverted + "\n{\n" +
                            "get{ return _" + f.FieldNameConverted + ";}\n" +
                            "set{ _" + f.FieldNameConverted + " = value;}\n}\n\n";
                    }
                }
            }


            if (chkINotifyCrap.Checked)
            {

                s += "\n" +
                    "#endregion\n\n" +
                    "#region Implement INotifyPropertyChanged \n\n" +
                    "public event PropertyChangedEventHandler PropertyChanged;\n" +
                    "public void RaisePropertyChanged(string propertyName)\n" +
                    "{\n" +
                    "PropertyChangedEventHandler handler = PropertyChanged;\n" +
                    "if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));\n" +
                    "}\n" +
                    "#endregion\n\n";
            }
            else
            {
                s += "\n" +
                    "#endregion\n\n";

            }

            return s;
        }

        private string GenerateClasssTrailer()
        {
            string s = "}\n";

            return s;
        }

        private string GenerateConstructor()
        {
            string s = "";

            s = "#region Constructor\n\n" +
                "public " + TableName + "()\n" +
                "{\n" +
                "// Constructor code goes here.\n" +
                "Initialize();\n" +
                "}\n\n" +
                "public " + TableName + "(string DSN)\n" +
                "{\n" +
                "// Constructor code goes here.\n" +
                "Initialize();\n" +
                "classDatabaseConnectionString = DSN;\n" +
                "}\n\n" +
                "#endregion\n\n";

            return s;
        }

        private string GenerateCopyFieldsMethod()
        {
            string s = "";

            s += "public void CopyFields(SqlDataReader r)\n";
            s += "{\n";
            s += "try\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = r[\"" + f.FieldName + "\"] + \"\";\n";
                    s += "}\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = Convert.ToInt32(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = Convert.ToInt64(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = Convert.ToDouble(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = Convert.ToDateTime(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "_" + f.FieldNameConverted + " = Convert.ToBoolean(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                }
            }

            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".CopyFields \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";

            return s;
        }

        private string GenerateDeleteMethod()
        {
            string s = "";

            s += "public void Delete()\n";
            s += "{\n";
            s += "try\n";
            s += "{\n";

            s += "string sql =\"Delete from " + TableName + " WHERE " + IDFIELDNAME + " = @ID\";\n";
            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.BigInt).Value = this._" + IDFIELDNAME + ";\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Int).Value = this._" + IDFIELDNAME + ";\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Money).Value = this._" + IDFIELDNAME + ";\n";
                    }
                    else if (IDFIELDTYPE == "DECIMAL")
                    {
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Decimal).Value = this._" + IDFIELDNAME + ";\n";
                    }
                    else
                    {
                        // default to a long
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.VarChar).Value = this._" + IDFIELDNAME + ";\n";
                    }
                }
            }

            s += "cmd.ExecuteNonQuery();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".Delete \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";

            return s;
        }

        private string GenerateInitializeMethod()
        {
            string s = "";

            s += "public void Initialize()\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "_" + f.FieldNameConverted + " = \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "_" + f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "_" + f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "_" + f.FieldNameConverted + " = 0.0;\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "_" + f.FieldNameConverted + " = Convert.ToDateTime(null);\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "_" + f.FieldNameConverted + " = false;\n";
                }
            }

            s += "}\n\n";

            return s;
        }

        private string GeneratePrivateMethods()
        {
            string s = "";

            if (AUTONUMBER)
            {
                #region AUTONUMBER STUFF

                s = "#region Private Methods\n\n" +
                    "private string GetParameterSQL() {\n" +
                    "string sql = \"\";\n";

                s += "if (_" + IDFIELDNAME + " < 1) {\n" +
                     "sql = \"INSERT INTO " + TableName + "\";\n";

                s += "sql += \"(\";\n";

                string temps = "";

                string lastfield = TheFields[TheFields.Count - 1].FieldName;

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += "], [" + f.FieldName;
                        }
                        else
                        {
                            temps += "[" + f.FieldName;
                        }

                        if (temps.Length > 70 && f.FieldName != lastfield) // create a line break but NOT if we are on the LASTFIELD
                        {
                            // we want a new line

                            s += "sql += \"" + temps + "],\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + "])\";\n";
                }
                else
                {

                    if (s.EndsWith(",]\";\n"))
                    {
                        // we inadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",]\";\n".Length;

                        s = s.Substring(0, s.Length - t);
                    }

                    s += "sql += \"]) \";\n";
                }

                s += "sql += \" VALUES (\";\n";

                // Write the Values as Parameters

                temps = "";

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += ",@" + f.FieldNameConverted;
                        }
                        else
                        {
                            temps += "@" + f.FieldNameConverted;
                        }

                        if (temps.Length > 70)
                        {
                            // we want a new line

                            s += "sql += \"" + temps + ",\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + ")\";\n";
                }
                else
                {

                    if (s.EndsWith(",\";\n"))
                    {
                        // we unadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",\";\n".Length;

                        s = s.Substring(0, s.Length - t) + "\";\n";
                    }

                    s += "sql += \") \";\n";
                }

                s += "} else {\n";

                s += "sql = \"UPDATE " + TableName + " SET \";\n";

                temps = "";

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += ", [" + f.FieldName + "] = @" + f.FieldNameConverted;
                        }
                        else
                        {
                            temps += "[" + f.FieldName + "] = @" + f.FieldNameConverted;
                        }

                        if (temps.Length > 70)
                        {
                            // we want a new line

                            s += "sql += \"" + temps + ",\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + "\";\n";
                }
                else
                {
                    if (s.EndsWith(",\";\n"))
                    {
                        // we unadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",\";\n".Length;

                        s = s.Substring(0, s.Length - t) + "\";\n";
                    }

                    s += "sql += \"\";\n";
                }

                s += "sql += \" WHERE " + IDFIELDNAME + " = \" + _" + IDFIELDNAME + ".ToString();\n";
                s += "}\n";
                s += "return sql;\n";
                s += "}\n\n";

                s += "private object getDateOrNull(DateTime d)\n";
                s += "{\n";
                s += "if ( d == Convert.ToDateTime(null)) {\n";
                s += "return DBNull.Value;\n";
                s += "} else {\n";
                s += "return d;\n";
                s += "}\n";
                s += "}\n";
                s += "#endregion\n";


                #endregion

            }
            else
            {

                #region Non AutoNumber stuff

                // We are not autonumbering so we have to do some different things here

                s = "#region Private Methods\n\n" +
                    "private string GetParameterSQLForAdd() {\n" +
                    "string sql = \"\";\n";

                s += "if (1==1) { // A Hack I suppose but it works...\n" +
                     "sql = \"INSERT INTO " + TableName + "\";\n";

                s += "sql += \"(\";\n";

                string temps = "";

                string lastfield = TheFields[TheFields.Count - 1].FieldName;

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += "], [" + f.FieldName;
                        }
                        else
                        {
                            temps += "[" + f.FieldName;
                        }

                        if (temps.Length > 70 && f.FieldName != lastfield) // create a line break but NOT if we are on the LASTFIELD
                        {
                            // we want a new line

                            s += "sql += \"" + temps + "],\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + "])\";\n";
                }
                else
                {

                    if (s.EndsWith(",]\";\n"))
                    {
                        // we inadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",]\";\n".Length;

                        s = s.Substring(0, s.Length - t);
                    }

                    s += "sql += \"]) \";\n";
                }

                s += "sql += \" VALUES (\";\n";

                // Write the Values as Parameters

                temps = "";

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += ",@" + f.FieldNameConverted;
                        }
                        else
                        {
                            temps += "@" + f.FieldNameConverted;
                        }

                        if (temps.Length > 70)
                        {
                            // we want a new line

                            s += "sql += \"" + temps + ",\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + ")\";\n";
                }
                else
                {

                    if (s.EndsWith(",\";\n"))
                    {
                        // we unadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",\";\n".Length;

                        s = s.Substring(0, s.Length - t) + "\";\n";
                    }

                    s += "sql += \") \";\n";
                }

                s += "}\n";

                s += "return sql;\n";
                s += "}\n\n";


                s += "private string GetParameterSQLForUpdate() {\n" +
                   "string sql = \"\";\n";

                s += "sql = \"UPDATE " + TableName + " SET \";\n";

                temps = "";

                foreach (Field f in TheFields)
                {
                    if (!f.IsIdentity)
                    {
                        if (temps != "")
                        {
                            temps += ", [" + f.FieldName + "] = @" + f.FieldNameConverted;
                        }
                        else
                        {
                            temps += "[" + f.FieldName + "] = @" + f.FieldNameConverted;
                        }

                        if (temps.Length > 70)
                        {
                            // we want a new line

                            s += "sql += \"" + temps + ",\";\n";
                            temps = "";
                        }
                    }
                }

                // do we have any hanging fields at the end

                if (temps != "")
                {
                    s += "sql += \"" + temps + "\";\n";
                }
                else
                {
                    if (s.EndsWith(",\";\n"))
                    {
                        // we inadvertantly ended in a mess from the loop above we need to fix it

                        int t = ",\";\n".Length;

                        s = s.Substring(0, s.Length - t) + "\";\n";
                    }

                    s += "sql += \"\";\n";
                }

                // If the field type of the IDFIELD is a number we dont quote it otherwise its quoted
                if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG" || IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT" ||
                    IDFIELDTYPE == "DECIMAL" || IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                {
                    //s += "sql += \" WHERE " + IDFIELDNAME + " = \" + _" + IDFIELDNAME + ".ToString();\n";

                    s += "sql += \" WHERE [" + IDFIELDNAME + "] = @" + IDFIELDNAME + "\";\n";

                }
                else
                {
                    s += "sql += \" WHERE [" + IDFIELDNAME + "] = @" + IDFIELDNAME + "\";\n";
                }
                               
                s += "return sql;\n";
                s += "}\n\n";

                s += "private object getDateOrNull(DateTime d)\n";
                s += "{\n";
                s += "if ( d == Convert.ToDateTime(null)) {\n";
                s += "return DBNull.Value;\n";
                s += "} else {\n";
                s += "return d;\n";
                s += "}\n";
                s += "}\n";
                s += "#endregion\n";

                #endregion

            }
            return s;
        }

        private string GenerateReadAsDataSetMethod()
        {

            string s = "";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "public DataSet ReadAsDataSet(System.Int64 idx)\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "public DataSet ReadAsDataSet(System.Int32 idx)\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DECIMAL" || IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "public DataSet ReadAsDataSet(System.Double idx)\n";
                    }
                    else
                    {
                        // default to a long
                        s += "public DataSet ReadAsDataSet(string idx)\n";
                    }
                }
            }

            s += "{\n";
            s += "try\n";
            s += "{\n";

            s += "string sql =\"Select * from " + TableName + " WHERE " + IDFIELDNAME + " = @ID\";\n";
            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.BigInt).Value = idx;\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Int).Value = idx;\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Money).Value = idx;\n";
                    }
                    else
                    {
                        // default to a long
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.VarChar).Value = idx;\n";
                    }
                }
            }

            s += "SqlDataAdapter da = new SqlDataAdapter(cmd);\n";
            s += "DataSet ds = new DataSet();\n";
            s += "da.Fill(ds, \"" + TableName + "\");\n";
            s += "da.Dispose();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "return ds;\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".ReadAsDataSet \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";


            return s;


        }

        private string GenerateReadMethod()
        {
            string s = "";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "public void Read(System.Int64 idx)\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "public void Read(System.Int32 idx)\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DECIMAL" || IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "public void Read(System.Double idx)\n";
                    }
                    else
                    {
                        // default to a long
                        s += "public void Read(string idx)\n";
                    }
                }
            }

            s += "{\n";
            s += "try\n";
            s += "{\n";

            s += "string sql =\"Select * from " + TableName + " WHERE " + IDFIELDNAME + " = @ID\";\n";
            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.BigInt).Value = idx;\n";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Int).Value = idx;\n";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.Money).Value = idx;\n";
                    }
                    else
                    {
                        // default to a long
                        s += "cmd.Parameters.Add(\"@ID\",System.Data.SqlDbType.VarChar).Value = idx;\n";
                    }
                }
            }

            s += "SqlDataReader r = cmd.ExecuteReader();\n";
            s += "while (r.Read())\n";
            s += "{\n";
            s += "this.CopyFields(r);\n";
            s += "}\n";
            s += "r.Close();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".Read \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";


            return s;
        }

        private string GenerateUpdateMethod()
        {

            string s = "";

            s += "public void Update()\n";

            s += "{\n";
            s += "try\n";
            s += "{\n";

            if (AUTONUMBER)
                s += "string sql = GetParameterSQL();\n";
            else
                s += "string sql = GetParameterSQLForUpdate();\n";

            s += "SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql,cn);\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldName != IDFIELDNAME || (!AUTONUMBER && f.FieldName == IDFIELDNAME))
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "SYSNAME")
                    {
                        if (f.AllowNulls) // also add the UI check here
                        {
                            s += "if (this._" + f.FieldNameConverted + " == null || this._" + f.FieldNameConverted + " == \"\" || this._" + f.FieldNameConverted + " == string.Empty)\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = DBNull.Value;\n" +
                                 "}\n" +
                                 "else\n" +
                                 "{\n " +
                                 "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n" +
                                 "}\n";
                        }
                        else
                        {
                            s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.VarChar).Value = this._" + f.FieldNameConverted + ";\n";
                        }
                    }

                    if (f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.UniqueIdentifier).Value = System.Guid.Parse(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "INT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Int).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "SMALLINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.SmallInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "TINYINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.TinyInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIGINT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.BigInt).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Money).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DECIMAL")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Decimal).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._" + f.FieldNameConverted + ");\n";
                    }

                    if (f.FieldType == "BOOL")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bool).Value = this._" + f.FieldNameConverted + ";\n";
                    }

                    if (f.FieldType == "BIT")
                    {
                        s += "cmd.Parameters.Add(\"@" + f.FieldNameConverted + "\",System.Data.SqlDbType.Bit).Value = this._" + f.FieldNameConverted + ";\n";
                    }


                    //System.Guid.Parse()
                }
            }

            s += "cmd.ExecuteNonQuery();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";

            if (AUTONUMBER)
            {

                s += "if(" + IDFIELDNAME + " < 1)\n";
                s += "{\n";
                s += "SqlCommand cmd2 = new SqlCommand(\"SELECT @@IDENTITY\",cn);\n";

                if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
                {
                    s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
                }
                else
                {
                    if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                    {
                        s += "System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());\n";
                    }
                    else
                    {
                        // this should never happen
                        if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                        {
                            s += "System.Double ii = Convert.ToDouble(cmd2.ExecuteScalar());\n";
                        }
                        else
                        {
                            // default to a long
                            s += "System.Int64 ii = Convert.ToInt64(cmd2.ExecuteScalar());\n";
                        }
                    }
                }
                s += "cmd2.Cancel();\n";
                s += "cmd2.Dispose();\n";
                s += "_" + IDFIELDNAME + " = ii;\n";
                s += "}\n";

            }

            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".Update \" +  ex.ToString()));\n";
            s += "}\n";
            s += "}\n\n";



            return s;


            //string s = "";

            //s += "public void Update()\n";

            //s += "{\n";
            //s += "try\n";
            //s += "{\n";

            //s += "Add();\n";

            //s += "}\n";
            //s += "catch (Exception ex)\n";
            //s += "{\n";
            //s += "throw(new Exception(\"" + TableName + ".Update \" +  ex.ToString()));\n";
            //s += "}\n";
            //s += "}\n\n";

            //return s;
        }

        private string GenerateUsingBlock()
        {

            string s = "using System;\n" +
                        "using System.ComponentModel;\n" +
                        "using System.Data;\n" +
                        "using System.Data.SqlClient;\n\n";

            return s;
        }

        private string INDENT(int indent)
        {
            string s = "";

            for (int t = 0; t < indent; t++)
            {
                s += "\t";
            }

            return s;

        }

        #region Web Interface Generators

        private string GenerateDBCON()
        {
            string s = "";

            s += "//DBCON() goes after the web config and retrieves the configured server\n";
            s += "//connection string\n";
            s += "public string DBCON()\n";
            s += "{\n";
            s += "#if(!DEBUG)\n";
            s += "return System.Configuration.ConfigurationManager.ConnectionStrings[\"PRODUCTION\"].ConnectionString;\n";
            s += "#else\n";
            s += "return System.Configuration.ConfigurationManager.ConnectionStrings[\"DEVELOPMENT\"].ConnectionString;\n";
            s += "#endif\n";
            s += "}\n\n";

            //    public string DBCON()
            //{
            //    #if(!DEBUG)
            //                            return System.Configuration.ConfigurationManager.ConnectionStrings["PRODUCTION"].ConnectionString;
            //    #else
            //                return System.Configuration.ConfigurationManager.ConnectionStrings["DEVELOPMENT"].ConnectionString;
            //    #endif

            //    //return System.Configuration.ConfigurationManager.ConnectionStrings["PRODUCTION"].ConnectionString;
            //}



            return s;
        }

        private string GenerateWEBApiGet()
        {
            string s = "";

            string pfix = txtInterfaceOBJPrefix.Text;

            List<string> flds = new List<string>();

            foreach (Field f in TheFields)
            {
                flds.Add(f.FieldName);
            }

            //frmFieldSelect frm = new frmFieldSelect(flds);

            //frm.ShowDialog();

            //string INTERFACEFIELD = frm.SELECTEDFIELD;
            //string INTERFACEFIELDTYPE = "";


            //frm.Close();

            //frm.Dispose();

            foreach (Field f in TheFields)
            {
                if (f.FieldName == INTERFACEFIELD)
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME")
                    {
                        INTERFACEFIELDTYPE = "string";
                    }

                    if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                    {
                        INTERFACEFIELDTYPE = "int";
                    }

                    if (f.FieldType == "BIGINT")
                    {
                        INTERFACEFIELDTYPE = "long";
                    }

                    if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        INTERFACEFIELDTYPE = "double";
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        INTERFACEFIELDTYPE = "DateTime";
                    }

                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                    {
                        INTERFACEFIELDTYPE = "bool";
                    }

                    break;
                }
            }

            //s += "// This is the exposer for the web service call\n";
            //s += "[HttpGet(Name = " + TableName + ")]\n";
            //s += "public IEnumerable<" + pfix + TableName + "> GetListOf" + TableName + "(" + INTERFACEFIELDTYPE + " " + INTERFACEFIELD + ");\n\n";


            s += "// This is the actual web service call\n";
            s += "[HttpGet(Name = " + TableName + ")]\n";
            s += "public IEnumerable<" + pfix + TableName + "> GetListOf" + TableName + "(" + INTERFACEFIELDTYPE + " " + INTERFACEFIELD + ")\n";
            s += "{\n";
            s += "List<" + pfix + TableName + "> result = new List<" + pfix + TableName + ">();\n";
            s += "try\n";
            s += "{\n";
            s += "string sql = \"SELECT * FROM " + TableName + " WHERE " + INTERFACEFIELD + " = @" + INTERFACEFIELD + "\";\n";
            s += "SqlConnection cn = new SqlConnection(DBCON());\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql, cn);\n";

            //System.Data.SqlDbType.
            switch (INTERFACEFIELDTYPE)
            {
                case "string":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.VarChar).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "int":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Int).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "long":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.BigInt).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "double":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Money).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "DateTime":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.DateTime).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "bool":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Bit).Value = " + INTERFACEFIELD + ";\n";
                    break;
            }


            s += "SqlDataReader r = cmd.ExecuteReader();\n";
            s += "while (r.Read())\n";
            s += "{\n";
            s += pfix + TableName + " a = new " + pfix + TableName + "();\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "a." + f.FieldNameConverted + " = r[\"" + f.FieldName + "\"] + \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToInt32(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToInt64(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDouble(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0.0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDateTime(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDateTime(null);\n";
                    s += "}\n";


                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToBoolean(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = false;\n";
                    s += "}\n";
                }
            }

            if (chkPostProcessWSresultlist.Checked)
            {
                s += "result.Add(PostProcess_" + pfix + TableName + "(a));\n";
            }
            else
            {
                s += "result.Add(a);\n";
            }

            s += "}\n";
            s += "r.Close();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".GetListOf" + TableName + "\" +  ex.ToString()));\n";
            s += "}\n";
            s += "return result;\n";
            s += "}\n\n";

            return s;
        }

        private string GenerateGETLISTOFX()
        {
            string s = "";

            string pfix = txtInterfaceOBJPrefix.Text;

            List<string> flds = new List<string>();

            foreach (Field f in TheFields)
            {
                flds.Add(f.FieldName);
            }

            frmFieldSelect frm = new frmFieldSelect(flds);

            frm.ShowDialog();

            INTERFACEFIELD = frm.SELECTEDFIELD;
            INTERFACEFIELDTYPE = "";

            frm.Close();

            frm.Dispose();

            foreach (Field f in TheFields)
            {
                if (f.FieldName == INTERFACEFIELD)
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME")
                    {
                        INTERFACEFIELDTYPE = "string";
                    }

                    if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                    {
                        INTERFACEFIELDTYPE = "int";
                    }

                    if (f.FieldType == "BIGINT")
                    {
                        INTERFACEFIELDTYPE = "long";
                    }

                    if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        INTERFACEFIELDTYPE = "double";
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        INTERFACEFIELDTYPE = "DateTime";
                    }

                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                    {
                        INTERFACEFIELDTYPE = "bool";
                    }

                    break;
                }
            }

            s += "// This is the exposer for the web service call\n";
            s += "[OperationContract]\n";
            s += "List<" + pfix + TableName + "> GetListOf" + TableName + "(" + INTERFACEFIELDTYPE + " " + INTERFACEFIELD + ");\n\n";


            s += "// This is the actual web service call\n";
            s += "public List<" + pfix + TableName + "> GetListOf" + TableName + "(" + INTERFACEFIELDTYPE + " " + INTERFACEFIELD + ")\n";
            s += "{\n";
            s += "List<" + pfix + TableName + "> result = new List<" + pfix + TableName + ">();\n";
            s += "try\n";
            s += "{\n";
            s += "string sql = \"SELECT * FROM " + TableName + " WHERE " + INTERFACEFIELD + " = @" + INTERFACEFIELD + "\";\n";
            s += "SqlConnection cn = new SqlConnection(DBCON());\n";
            s += "cn.Open();\n";
            s += "SqlCommand cmd = new SqlCommand(sql, cn);\n";

            //System.Data.SqlDbType.
            switch (INTERFACEFIELDTYPE)
            {
                case "string":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.VarChar).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "int":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Int).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "long":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.BigInt).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "double":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Money).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "DateTime":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.DateTime).Value = " + INTERFACEFIELD + ";\n";
                    break;

                case "bool":
                    s += "cmd.Parameters.Add(\"@" + INTERFACEFIELD + "\",System.Data.SqlDbType.Bit).Value = " + INTERFACEFIELD + ";\n";
                    break;
            }


            s += "SqlDataReader r = cmd.ExecuteReader();\n";
            s += "while (r.Read())\n";
            s += "{\n";
            s += pfix + TableName + " a = new " + pfix + TableName + "();\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "a." + f.FieldNameConverted + " = r[\"" + f.FieldName + "\"] + \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToInt32(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToInt64(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDouble(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = 0.0;\n";
                    s += "}\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDateTime(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToDateTime(null);\n";
                    s += "}\n";


                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "if (!Convert.IsDBNull(r[\"" + f.FieldName + "\"]))\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = Convert.ToBoolean(r[\"" + f.FieldName + "\"]);\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "a." + f.FieldNameConverted + " = false;\n";
                    s += "}\n";
                }
            }

            if (chkPostProcessWSresultlist.Checked)
            {
                s += "result.Add(PostProcess_" + pfix + TableName + "(a));\n";
            }
            else
            {
                s += "result.Add(a);\n";
            }

            s += "}\n";
            s += "r.Close();\n";
            s += "cmd.Cancel();\n";
            s += "cmd.Dispose();\n";
            s += "cn.Close();\n";
            s += "cn.Dispose();\n";
            s += "}\n";
            s += "catch (Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"" + TableName + ".GetListOf" + TableName + "\" +  ex.ToString()));\n";
            s += "}\n";
            s += "return result;\n";
            s += "}\n\n";

            return s;
        }

        private string GenerateGETx()
        {
            string s = "";

            string ParamType = "";

            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG")
            {
                ParamType = "System.Int64";
            }
            else
            {
                if (IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
                {
                    ParamType = "System.Int32";
                }
                else
                {
                    // this should never happen
                    if (IDFIELDTYPE == "DECIMAL" || IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                    {
                        ParamType = "System.Double";
                    }
                    else
                    {
                        // default to a string
                        ParamType = "string";
                    }
                }
            }

            string pfix = txtInterfaceOBJPrefix.Text;

            s += "// This is the exposer for the web service call\n";
            s += "[OperationContract]\n";
            s += pfix + TableName + " Get" + pfix + TableName + "(" + ParamType + " param);\n\n";

            s += "public " + pfix + TableName + " Get" + pfix + TableName + "(" + ParamType + " param)\n";
            s += "{\n";
            s += pfix + TableName + " result = new " + pfix + TableName + "();\n\n";
            s += "try\n";
            s += "{\n";
            s += TableName + " TheTableClass = new " + TableName + "(DBCON());\n\n";

            s += "TheTableClass.Read(param);\n\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME")
                {

                    // use a shorthand concationation with emptystring to override nulls
                    s += "result." + f.FieldNameConverted + " = TheTableClass." + f.FieldNameConverted + " + \"\";\n";

                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT" ||
                    f.FieldType == "BIGINT" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "CURRENCY" || f.FieldType == "FLOAT" || f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    // Null Numbers are OK
                    s += "if (TheTableClass." + f.FieldNameConverted + " != null)\n";
                    s += "{\n";
                    s += "result." + f.FieldNameConverted + " = TheTableClass." + f.FieldNameConverted + ";\n";
                    s += "}\n\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    // Null DateTimes need to be treated with care
                    s += "if (TheTableClass." + f.FieldNameConverted + " != null)\n";
                    s += "{\n";
                    s += "result." + f.FieldNameConverted + " = TheTableClass." + f.FieldNameConverted + ";\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "result." + f.FieldNameConverted + " =  Convert.ToDateTime(null);\n";
                    s += "}\n\n";
                }

            }

            s += "TheTableClass = null;\n\n";

            s += "}\n";
            s += "catch( Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\" GET" + pfix + TableName + "\" +  ex.ToString()));\n";

            s += "}\n";

            s += "return result;\n";
            s += "}\n\n";


            return s;
        }

        private string GenerateLDObject()
        {
            string s = "";

            string pfix = txtInterfaceOBJPrefix.Text;

            s += "// This is the public facing class used to encapsulate\n";
            s += "// the base table and its data for serialization over\n";
            s += "// the web.\n";
            s += "public class " + pfix + TableName + "\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "public string " + f.FieldNameConverted + " {get; set;} \n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "public int " + f.FieldNameConverted + " {get; set;} \n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "public long " + f.FieldNameConverted + " {get; set;} \n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "public double " + f.FieldNameConverted + " {get; set;} \n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "public DateTime " + f.FieldNameConverted + " {get; set;} \n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "public bool " + f.FieldNameConverted + " {get; set;} \n";
                }
            }

            s += "\n\n";

            // Generate The Constructor

            s += "public " + pfix + TableName + "()\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += f.FieldNameConverted + " = \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += f.FieldNameConverted + " = 0;\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += f.FieldNameConverted + " = 0.0;\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += f.FieldNameConverted + "= Convert.ToDateTime(null);\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += f.FieldNameConverted + " = false;\n";
                }
            }

            s += "}\n\n";


            s += "}\n\n";

            return s;
        }

        private string GenerateWebPrivateFunctions()
        {
            string s = "";

            s += "// will return the web server defined database connection string\n";
            s += "public string DBCON()\n";
            s += "{\n";
            s += "return System.Configuration.ConfigurationManager.ConnectionStrings[\"DEVELOPMENT\"].ConnectionString;\n";
            s += "}\n";

            return s;
        }

        private string GenerateWRITEx()
        {
            string s = "";

            string pfix = txtInterfaceOBJPrefix.Text;

            s += "// This is the exposer for the web service call\n";
            s += "[OperationContract]\n";
            s += "bool Write" + pfix + TableName + "(" + pfix + TableName + " param);\n\n";

            s += "public bool Write" + pfix + TableName + "(" + pfix + TableName + " param)\n";
            s += "{\n";
            s += "bool result = true;\n\n";
            s += "try\n";
            s += "{\n";
            s += TableName + " TheTableClass = new " + TableName + "(DBCON());\n\n";

            s += "TheTableClass.Initialize();\n\n";

            // code up the read of the old one if its an edit
            if (IDFIELDTYPE == "BIGINT" || IDFIELDTYPE == "LONG" || IDFIELDTYPE == "INT" || IDFIELDTYPE == "SMALLINT" || IDFIELDTYPE == "TINYINT")
            {
                s += "if(param." + IDFIELDNAME + " > 0 )\n";
                s += "{\n";
                s += "TheTableClass.Read(param." + IDFIELDNAME + ");\n";
                s += "}\n\n";
            }
            else
            {

                if (IDFIELDTYPE == "DOUBLE" || IDFIELDTYPE == "MONEY" || IDFIELDTYPE == "CURRENCY" || IDFIELDTYPE == "FLOAT")
                {
                    s += "if(param." + IDFIELDNAME + " > 0.0 )\n";
                    s += "{\n";
                    s += "TheTableClass.Read(param." + IDFIELDNAME + ");\n";
                    s += "}\n\n";
                }
                else
                {
                    // default to a long
                    s += "TheTableClass.Read(param." + IDFIELDNAME + ");\n";
                }
                
            }

            foreach (Field f in TheFields)
            {
                // if the current field is te ID field DONT copy it over as we took care of that with INITIALIZE and READ CHECKS above
                if (f.FieldName != IDFIELDNAME || (!AUTONUMBER && f.FieldName == IDFIELDNAME))
                {

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME")
                    {

                        // use a shorthand concationation with emptystring to override nulls
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + " + \"\";\n";

                        //s += "if (param." + f.FieldName + " != null)\n";
                        //s += "{\n";
                        //s += "TheTableClass." + f.FieldName + " = param." + f.FieldName + ";\n";
                        //s += "}\n";
                        //s += "else\n";
                        //s += "{\n";
                        //s += "TheTableClass." + f.FieldName + " = \"\";\n";
                        //s += "}\n";

                    }

                    if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                    {
                        // Null Numbers are OK
                        s += "if (param." + f.FieldNameConverted + " != null)\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + ";\n";
                        s += "}\n";

                    }

                    if (f.FieldType == "BIGINT")
                    {
                        // Null Numbers are OK
                        s += "if (param." + f.FieldNameConverted + " != null)\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + ";\n";
                        s += "}\n";

                    }

                    if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                    {
                        // Null Numbers are OK
                        s += "if (param." + f.FieldNameConverted + " != null)\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + ";\n";
                        s += "}\n";

                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        // Null DateTimes need to be treated with care
                        s += "if (param." + f.FieldNameConverted + " != null)\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + ";\n";
                        s += "}\n";
                        s += "else\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " =  Convert.ToDateTime(null);\n";
                        s += "}\n";
                    }



                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                    {

                        // Null Bools are Treated as false
                        s += "if (param." + f.FieldNameConverted + " != null)\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = param." + f.FieldNameConverted + ";\n";
                        s += "}\n";
                        s += "else\n";
                        s += "{\n";
                        s += "TheTableClass." + f.FieldNameConverted + " = false;\n";
                        s += "}\n";
                    }
                }
            }

            s += "\n";
            s += "TheTableClass.Add();\n";
            s += "TheTableClass = null;\n";

            s += "}\n";
            s += "catch( Exception ex)\n";
            s += "{\n";
            s += "throw(new Exception(\"Write" + pfix + TableName + "\" +  ex.ToString()));\n";
            s += "result = false;\n";
            s += "}\n";

            s += "return result;\n";
            s += "}\n\n";

            return s;
        }

        private string GeneratePostProcessX()
        {
            string s = "";

            string pfix = txtInterfaceOBJPrefix.Text;

            List<string> flds = new List<string>();

            foreach (Field f in TheFields)
            {
                flds.Add(f.FieldName);
            }

            s += "private " + pfix + TableName + " PostProcess_" + pfix + TableName + "(" + pfix + TableName + " param)\n";
            s += "{\n";

            s += pfix + TableName + " result = param;\n";
            s += "\n";
            s += "// TODO\n";
            s += "// Build any post processing we want to do in here\n";
            s += "\n";
            s += "return result;\n";
            s += "}\n\n";

            return s;
        }

        #endregion

        #region Winforms Stuff

        private string GenerateSupportRoutines()
        {
            string s = "";
            s += "private int GetAsInteger(string input)\n";
            s += "{\n";
            s += "int result = 0;\n";
            s += "bool diditwork = int.TryParse(input, out result);\n";
            s += "return result;\n";
            s += "}\n";
            s += "\n";
            s += "private long GetAsLong(string input)\n";
            s += "{\n";
            s += "long result = 0;\n";
            s += "bool diditwork = long.TryParse(input, out result);\n";
            s += "return result;\n";
            s += "}\n";
            s += "\n";
            s += "private double GetAsDouble(string input)\n";
            s += "{\n";
            s += "double result = 0;\n";
            s += "bool diditwork = double.TryParse(input, out result);\n";
            s += "return result;\n";
            s += "}\n";
            s += "\n";
            s += "private DateTime GetAsDateTime(string input)\n";
            s += "{\n";
            s += "DateTime result = Convert.ToDateTime(null);\n";
            s += "bool diditwork = DateTime.TryParse(input, out result);\n";
            s += "return result;\n";
            s += "}\n";
            s += "\n";

            return s;
        }

        private string GenerateUnPacker()
        {
            string s = "\n";

            s += "private void Unpack(" + TableName + " thing)\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "txt" + f.FieldNameConverted + ".Text = thing." + f.FieldNameConverted + " + \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                   f.FieldType == "TINYINT" || f.FieldType == "BIGINT" ||
                   f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                   f.FieldType == "FLOAT")
                {
                    s += "txt" + f.FieldNameConverted + ".Text = thing." + f.FieldNameConverted + ".ToString() + \"\";\n";
                }


                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "if (thing." + f.FieldNameConverted + " != Convert.ToDateTime(null))\n";
                    s += "{\n";
                    s += "dtp" + f.FieldNameConverted + ".Value = thing." + f.FieldNameConverted + ";\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "dtp" + f.FieldNameConverted + ".Value = Convert.ToDateTime(null);\n";
                    s += "}\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "if (thing." + f.FieldNameConverted + ")\n";
                    s += "{\n";
                    s += "chk" + f.FieldNameConverted + ".Checked = true;\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "chk" + f.FieldNameConverted + ".Checked = false;\n";
                    s += "}\n";
                }
            }

            s += "}\n";

            return s;
        }

        private string GeneratePacker()
        {
            string s = "\n";

            s += "private " + TableName + " Pack()\n";
            s += "{\n";

            s += "" + TableName + " thing = new " + TableName + "();\n\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "thing." + f.FieldNameConverted + " = txt" + f.FieldNameConverted + ".Text + \"\";\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT")
                {
                    s += "thing." + f.FieldNameConverted + " = GetAsInteger(txt" + f.FieldNameConverted + ".Text);\n";
                }

                if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "thing." + f.FieldNameConverted + " = GetAsDouble(txt" + f.FieldNameConverted + ".Text);\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "thing." + f.FieldNameConverted + " = GetAsLong(txt" + f.FieldNameConverted + ".Text);\n";
                }


                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "thing." + f.FieldNameConverted + " = GetAsDateTime(dtp" + f.FieldNameConverted + ".Text);\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "if (chk" + f.FieldNameConverted + ".Checked)\n";
                    s += "{\n";
                    s += "thing." + f.FieldNameConverted + " = true;\n";
                    s += "}\n";
                    s += "else\n";
                    s += "{\n";
                    s += "thing." + f.FieldNameConverted + " = false;\n";
                    s += "}\n";
                }
            }

            s += "\n";
            s += "return thing;\n";

            s += "}\n";

            return s;
        }

        private string GenerateButtonHandlers()
        {
            string s = "";

            s += "private void btnEnableAll_Click(object sender, EventArgs e)\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.txt" + f.FieldNameConverted + ".Enabled = true;\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.dtp" + f.FieldNameConverted + ".Enabled = true;\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.chk" + f.FieldNameConverted + ".Enabled = true;\n";
                }

            }

            s += "}\n\n";
            
            
            s += "private void btnDisableAll_Click(object sender, EventArgs e)\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.txt" + f.FieldNameConverted + ".Enabled = false;\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.dtp" + f.FieldNameConverted + ".Enabled = false;\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.chk" + f.FieldNameConverted + ".Enabled = false;\n";
                }

            }

            s += "}\n\n";

            s += "private void btnHideAll_Click(object sender, EventArgs e)\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.txt" + f.FieldNameConverted + ".Visible = false;\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.dtp" + f.FieldNameConverted + ".Visible = false;\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.chk" + f.FieldNameConverted + ".Visible = false;\n";
                }

                s += "this.lbl" + f.FieldNameConverted + ".Visible = false;\n";

            }

            s += "}\n\n";

            s += "private void btnShowAll_Click(object sender, EventArgs e)\n";
            s += "{\n";

            foreach (Field f in TheFields)
            {

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.txt" + f.FieldNameConverted + ".Visible = true;\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.dtp" + f.FieldNameConverted + ".Visible = true;\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.chk" + f.FieldNameConverted + ".Visible = true;\n";
                }

                s += "this.lbl" + f.FieldNameConverted + ".Visible = true;\n";

            }

            s += "}\n\n";
            
            return s;
        }
 
        private string GenerateWinFormsInitializeComponent()
        {

            string s = "";

            s += "#region Windows Form Designer generated code\n\n";

            s += "private void InitializeComponent()\n";
            s += "{\n";
            s += "this.components = new System.ComponentModel.Container();\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.txt" + f.FieldNameConverted + "  = new System.Windows.Forms.TextBox();\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.dtp" + f.FieldNameConverted + "  = new System.Windows.Forms.DateTimePicker();\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.chk" + f.FieldNameConverted + "  = new System.Windows.Forms.CheckBox();\n";
                }
            }

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.lbl" + f.FieldNameConverted + "  = new System.Windows.Forms.Label();\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.lbl" + f.FieldNameConverted + "  = new System.Windows.Forms.Label();\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.lbl" + f.FieldNameConverted + "  = new System.Windows.Forms.Label();\n";
                }
            }

            s += "this.btnHideAll = new System.Windows.Forms.Button();\n";
            s += "this.btnShowAll = new System.Windows.Forms.Button();\n";
            s += "this.btnDisableAll = new System.Windows.Forms.Button();\n";
            s += "this.btnEnableAll = new System.Windows.Forms.Button();\n";

            s += "this.SuspendLayout();\n";

            int ctlnum = 0;
            int colnum = 0;
            int CTRLnum = 0;
            int ctrlX = 0;


            foreach (Field f in TheFields)
            {

                colnum = ctlnum / (int)20;

                ctrlX = (colnum * 320) + 160;
                
                
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "//\n";
                    s += "// txt" + f.FieldNameConverted + "\n";
                    s += "//\n";

                    s += "this.txt" + f.FieldNameConverted + ".Location = new System.Drawing.Point(" + ctrlX + ", " + ((CTRLnum * 36) + 12).ToString() + ");\n";
                    s += "this.txt" + f.FieldNameConverted + ".Margin = new System.Windows.Forms.Padding(4);\n";
                    s += "this.txt" + f.FieldNameConverted + ".Name = \"txt" + f.FieldNameConverted + "\";\n";
                    s += "this.txt" + f.FieldNameConverted + ".ReadOnly = false;\n";
                    s += "this.txt" + f.FieldNameConverted + ".Size = new System.Drawing.Size(160, 22);\n";
                    s += "this.txt" + f.FieldNameConverted + ".TabIndex = " + ctlnum.ToString() + ";\n";

                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "//\n";
                    s += "// dtp" + f.FieldNameConverted + "\n";
                    s += "//\n";

                    s += "this.dtp" + f.FieldNameConverted + ".Format = System.Windows.Forms.DateTimePickerFormat.Short;\n";


                    s += "this.dtp" + f.FieldNameConverted + ".Location = new System.Drawing.Point(" + ctrlX + ", " + ((CTRLnum * 36) + 12).ToString() + ");\n";
                    s += "this.dtp" + f.FieldNameConverted + ".Name = \"dtp" + f.FieldNameConverted + "\";\n";
                    s += "this.dtp" + f.FieldNameConverted + ".Size = new System.Drawing.Size(120, 22);\n";
                    s += "this.dtp" + f.FieldNameConverted + ".TabIndex = " + ctlnum.ToString() + ";\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "//\n";
                    s += "// chk" + f.FieldNameConverted + "\n";
                    s += "//\n";

                    s += "this.chk" + f.FieldNameConverted + ".Location = new System.Drawing.Point(" + ctrlX + ", " + ((CTRLnum * 36) + 12).ToString() + ");\n";
                    s += "this.chk" + f.FieldNameConverted + ".AutoSize = true;\n";
                    s += "this.chk" + f.FieldNameConverted + ".Name = \"chk" + f.FieldNameConverted + "\";\n";
                    s += "this.chk" + f.FieldNameConverted + ".Text = \"" + f.FieldNameConverted + "\";\n";
                    s += "this.chk" + f.FieldNameConverted + ".Size = new System.Drawing.Size(100, 22);\n";
                    s += "this.chk" + f.FieldNameConverted + ".TabIndex = " + ctlnum.ToString() + ";\n";
                    s += "this.chk" + f.FieldNameConverted + ".UseVisualStyleBackColor = true;\n";

                }

                ctlnum += 1;
                CTRLnum += 1;

                if (CTRLnum == 20)
                {
                    CTRLnum = 0;
                }
            }

           

            ctlnum = 0;
            colnum = 0;
            CTRLnum = 0;
            ctrlX = 0;

            foreach (Field f in TheFields)
            {
                colnum = ctlnum / (int)20;

                ctrlX = (colnum * 320) + 16;

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT" || f.FieldType == "BOOL" || f.FieldType == "BIT" ||
                    f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" ||
                    f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "//\n";
                    s += "// lbl" + f.FieldNameConverted + "\n";
                    s += "//\n";

                    s += "this.lbl" + f.FieldNameConverted + ".Location = new System.Drawing.Point(" + ctrlX + ", " + ((CTRLnum * 36) + 12).ToString() + ");\n";
                    s += "this.lbl" + f.FieldNameConverted + ".Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);\n";
                    s += "this.lbl" + f.FieldNameConverted + ".Name = \"lbl" + f.FieldNameConverted + "\";\n";
                    s += "this.lbl" + f.FieldNameConverted + ".AutoSize = true;\n";
                    s += "this.lbl" + f.FieldNameConverted + ".Size = new System.Drawing.Size(160, 20);\n";
                    s += "this.lbl" + f.FieldNameConverted + ".TabIndex = " + ctlnum.ToString() + ";\n";
                    s += "this.lbl" + f.FieldNameConverted + ".Text = \"" + f.FieldNameConverted + "\";\n";
                }


                ctlnum += 1;
                CTRLnum += 1;

                if (CTRLnum == 20)
                {
                    CTRLnum = 0;
                }
            }

            // Add the 4 Buttons At the Bottom of the Interface

            var thestring = "";
            thestring += "// \n";
            thestring += "// btnHideAll\n";
            thestring += "// \n";
            thestring += "this.btnHideAll.Location = new System.Drawing.Point(14, 770);\n";
            thestring += "this.btnHideAll.Name = \"btnHideAll\";\n";
            thestring += "this.btnHideAll.Size = new System.Drawing.Size(111, 27);\n";
            thestring += "this.btnHideAll.TabIndex = 61;\n";
            thestring += "this.btnHideAll.Text = \"Hide All\";\n";
            thestring += "this.btnHideAll.UseVisualStyleBackColor = true;\n";
            thestring += "// \n";
            thestring += "// btnShowAll\n";
            thestring += "// \n";
            thestring += "this.btnShowAll.Location = new System.Drawing.Point(131, 770);\n";
            thestring += "this.btnShowAll.Name = \"btnShowAll\";\n";
            thestring += "this.btnShowAll.Size = new System.Drawing.Size(111, 27);\n";
            thestring += "this.btnShowAll.TabIndex = 62;\n";
            thestring += "this.btnShowAll.Text = \"Show All\";\n";
            thestring += "this.btnShowAll.UseVisualStyleBackColor = true;\n";
            thestring += "// \n";
            thestring += "// btnDisableAll\n";
            thestring += "// \n";
            thestring += "this.btnDisableAll.Location = new System.Drawing.Point(248, 770);\n";
            thestring += "this.btnDisableAll.Name = \"btnDisableAll\";\n";
            thestring += "this.btnDisableAll.Size = new System.Drawing.Size(111, 27);\n";
            thestring += "this.btnDisableAll.TabIndex = 63;\n";
            thestring += "this.btnDisableAll.Text = \"Disable All\";\n";
            thestring += "this.btnDisableAll.UseVisualStyleBackColor = true;\n";
            thestring += "// \n";
            thestring += "// btnEnableAll\n";
            thestring += "// \n";
            thestring += "this.btnEnableAll.Location = new System.Drawing.Point(365, 770);\n";
            thestring += "this.btnEnableAll.Name = \"btnEnableAll\";\n";
            thestring += "this.btnEnableAll.Size = new System.Drawing.Size(111, 27);\n";
            thestring += "this.btnEnableAll.TabIndex = 64;\n";
            thestring += "this.btnEnableAll.Text = \"Enable All\";\n";
            thestring += "this.btnEnableAll.UseVisualStyleBackColor = true;\n\n";

            s += thestring;


            s += "this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);\n";
            s += "this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;\n";
            s += "this.ClientSize = new System.Drawing.Size(1339, 821);\n\n";


            s += "this.Controls.Add(this.btnEnableAll);\n";
            s += "this.Controls.Add(this.btnDisableAll);\n";
            s += "this.Controls.Add(this.btnShowAll);\n";
            s += "this.Controls.Add(this.btnHideAll);\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.Controls.Add(this.txt" + f.FieldNameConverted + ");\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.Controls.Add(this.dtp" + f.FieldNameConverted + ");\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.Controls.Add(this.chk" + f.FieldNameConverted + ");\n";
                }

            }

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "this.Controls.Add(this.lbl" + f.FieldNameConverted + ");\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "this.Controls.Add(this.lbl" + f.FieldNameConverted + ");\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "this.Controls.Add(this.lbl" + f.FieldNameConverted + ");\n";
                }

            }

            s += "this.Margin = new System.Windows.Forms.Padding(4);\n";
            s += "this.Name = \"frm" + TableName + "UI\";\n";
            s += "this.Text = \"frm" + TableName + "UI\";\n";
            s += "this.ResumeLayout(false);\n";
            s += "this.PerformLayout();\n";

            s += "}\n";

            s += "#endregion \n\n";

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "private System.Windows.Forms.TextBox txt" + f.FieldNameConverted + ";\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "private System.Windows.Forms.DateTimePicker dtp" + f.FieldNameConverted + ";\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "private System.Windows.Forms.CheckBox chk" + f.FieldNameConverted + ";\n";
                }

            }

            foreach (Field f in TheFields)
            {
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                    f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                    f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                    f.FieldType == "FLOAT")
                {
                    s += "private System.Windows.Forms.Label lbl" + f.FieldNameConverted + ";\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "private System.Windows.Forms.Label lbl" + f.FieldNameConverted + ";\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "private System.Windows.Forms.Label lbl" + f.FieldNameConverted + ";\n";
                }

            }

            s += "private System.Windows.Forms.Button btnHideAll;\n";
            s += "private System.Windows.Forms.Button btnShowAll;\n";
            s += "private System.Windows.Forms.Button btnDisableAll;\n";
            s += "private System.Windows.Forms.Button btnEnableAll;\n";
            
            return s;
        }

        #endregion

        #region XAML Code Stuff

        private string GenerateXAMLCode()
        {
            string s = "";

            if (chkXAMLFromOrUserControl.Checked)
            {

                // lets calculate the height to hold aall these things

                int usercontrolheight = 0;


                foreach (Field f in TheFields)
                {
                    // Let calculate the height for this form

                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                        f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                        f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                        f.FieldType == "FLOAT")
                    {
                        if (f.MaxLength > 100)
                        {
                            usercontrolheight += 90;
                        }
                        else
                        {
                            usercontrolheight += 30;
                        }
                    }
                    else
                    {
                        usercontrolheight += 30;
                    }
                }


                s += "<UserControl x:Class=\"" + "UC_" + TableName + "\"\n" +
                    "\t\txmlns:d=\"http://schemas.microsoft.com/expression/blend/2008\"\n" +
                    "\t\txmlns:mc=\"http://schemas.openxmlformats.org/markup-compatibility/2006\"\n" +
                    "\t\txmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\n" +
                    "\t\txmlns:sys=\"clr-namespace:System;assembly=mscorlib\"\n" +
                    "\t\txmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" \n" +
                    "\t\txmlns:sdk=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation/sdk\" \n" +
                    "\t\tmc:Ignorable=\"d\" d:DesignHeight=\"" + usercontrolheight.ToString() + "\" d:DesignWidth=\"600\" >\n" +
                    "\t<Grid Background=\"AntiqueWhite\" >\n" +
                    "\t\t<StackPanel>\n\n";

                foreach (Field f in TheFields)
                {
                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                        f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                        f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                        f.FieldType == "FLOAT")
                    {
                        //s += "this.txt" + f.FieldNameConverted + "  = new System.Windows.Forms.TextBox();\n";

                        if (f.MaxLength > 100)
                        {
                            s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                                 "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\">" + f.FieldNameConverted + "</TextBlock>\n" +
                                 "\t\t\t\t<TextBox Width=\"440\" Height=\"90\" " +
                                 "VerticalScrollBarVisibility=\"Visible\" AcceptsReturn=\"True\" TextWrapping=\"Wrap\" " +
                                 "Name=\"txt" + f.FieldNameConverted + "\"></TextBox>\n" +
                                 "\t\t\t</StackPanel>\n\n";
                        }
                        else
                        {
                            s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                                 "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\">" + f.FieldNameConverted + "</TextBlock>\n" +
                                 "\t\t\t\t<TextBox Width=\"150\" Height=\"30\" Name=\"txt" + f.FieldNameConverted + "\"></TextBox>\n" +
                                 "\t\t\t</StackPanel>\n\n";
                        }
                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        //s += "this.dtp" + f.FieldNameConverted + "  = new System.Windows.Forms.DateTimePicker();\n";

                        s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                             "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\">" + f.FieldNameConverted + "</TextBlock>\n" +
                             "\t\t\t\t<sdk:DatePicker Width=\"150\" Height=\"30\" Name=\"dtp" + f.FieldNameConverted + "\"></sdk:DatePicker>\n" +
                             "\t\t\t</StackPanel>\n\n";


                    }

                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                    {
                        //s += "this.chk" + f.FieldNameConverted + "  = new System.Windows.Forms.CheckBox();\n";

                        s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                             "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\"></TextBlock>\n" +
                             "\t\t\t\t<CheckBox Content=\"" + f.FieldNameConverted + "\" Width=\"150\" Height=\"30\" Name=\"chk" + f.FieldNameConverted + "\"></CheckBox>\n" +
                             "\t\t\t</StackPanel>\n\n";
                        // <CheckBox Content="CheckBox" HorizontalAlignment="Left" Margin="20,110,0,0" VerticalAlignment="Top"/>

                    }
                }

                s += "\t\t</StackPanel>\n" +
                     "\t</Grid>\n" +
                     "</UserControl>\n";
            }
            else
            {
                s += "<Page xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"\n" +
                     "\t\txmlns:sys=\"clr-namespace:System;assembly=mscorlib\"\n" +
                     "\t\txmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" \n" +
                     "\t\txmlns:sdk=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation/sdk\" >\n" +
                     "\t<Grid>\n" +
                     "\t\t<StackPanel>\n\n";

                foreach (Field f in TheFields)
                {
                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                        f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                        f.FieldType == "SYSNAME" || f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                        f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                        f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                        f.FieldType == "FLOAT")
                    {
                        //s += "this.txt" + f.FieldNameConverted + "  = new System.Windows.Forms.TextBox();\n";

                        s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                             "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\">" + f.FieldNameConverted + "</TextBlock>\n" +
                             "\t\t\t\t<TextBox Width=\"150\" Height=\"30\" Name=\"txt" + f.FieldNameConverted + "\"></TextBox>\n" +
                             "\t\t\t</StackPanel>\n\n";

                    }

                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                    {
                        //s += "this.dtp" + f.FieldNameConverted + "  = new System.Windows.Forms.DateTimePicker();\n";

                        s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                             "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\">" + f.FieldNameConverted + "</TextBlock>\n" +
                             "\t\t\t\t<sdk:DatePicker Width=\"150\" Height=\"30\" Name=\"dtp" + f.FieldNameConverted + "\"></sdk:DatePicker>\n" +
                             "\t\t\t</StackPanel>\n\n";


                    }

                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                    {
                        //s += "this.chk" + f.FieldNameConverted + "  = new System.Windows.Forms.CheckBox();\n";

                        s += "\t\t\t<StackPanel Orientation=\"Horizontal\">\n" +
                             "\t\t\t\t<TextBlock Padding=\"5\" Width=\"150\"></TextBlock>\n" +
                             "\t\t\t\t<CheckBox Content=\"" + f.FieldNameConverted + "\" Width=\"150\" Height=\"30\" Name=\"chk" + f.FieldNameConverted + "\"></CheckBox>\n" +
                             "\t\t\t</StackPanel>\n\n";
                        // <CheckBox Content="CheckBox" HorizontalAlignment="Left" Margin="20,110,0,0" VerticalAlignment="Top"/>

                    }
                }

                s += "\t\t</StackPanel>\n" +
                     "\t</Grid>\n" +
                     "</Page>\n";
            }

            return s;
        }

        #endregion

        #region SQL Code Generation

        private string GenerateDropTableStatement()
        {
            string result = "";

            result += "-- Check for and descroy the table object if its already there...\n";
            result += "IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[" + TableName + "]') AND type in (N'U'))\n";
            result += "DROP TABLE [" + TableName + "]\n\nGO\n\n";
            
            return result;
        }

        private string GenerateCreateTableStatement()
        {
            string result = "";

            result += "CREATE TABLE [" + TableName + "] (\n";

            int ord = 1;

            foreach (Field f in TheFields)
            {
                result += "\t[" + f.FieldName + "] [" + f.FieldType + "] ";

                #region Do the Field Decode

                if (f.FieldType == "VARCHAR" || f.FieldType == "NVARCHAR")
                {
                    if (f.MaxLength ==-1)
                    {
                        result += "(MAX) ";
                    }
                    else
                    {
                        result += "(" + f.MaxLength.ToString() + ") ";
                    }

                }

                if (f.FieldType == "BIGINT" || f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT" ||
                    f.FieldType == "FLOAT" || f.FieldType == "MONEY" || f.FieldType == "REAL" || 
                    f.FieldType == "BIT" || f.FieldType == "DATE" || f.FieldType == "DATETIME" || f.FieldType == "SMALLDATETIME" ||
                    f.FieldType == "SMALLMONEY" || f.FieldType == "TEXT" || f.FieldType == "TIMESTAMP" || f.FieldType == "XML")
                {
                    // Do nothing else with the result for these datatypes no size checks
                }


                if (f.FieldType == "CHAR" || f.FieldType == "NCHAR")
                {
                    result += "(" + f.MaxLength.ToString() + ") ";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "NUMERIC")
                {
                    result += "(" + f.Precision.ToString() + "," + f.Scale.ToString() + ") ";
                }

                if (f.FieldType == "TIME")
                {
                    result += "(" + f.Scale.ToString() + ") ";
                }
                
                #endregion

                if (f.IsIdentity)
                {
                    result += "IDENTITY(1,1) ";
                }

                if (f.AllowNulls)
                {
                    result += "NULL";
                }
                else
                {
                    result += "NOT NULL";
                }

                if (ord != TheFields.Count)
                {
                    result += ",\n";
                }
                else
                {
                    result += "\n";
                }

                ord += 1;

            }

            result += ")\n\nGO\n\n";


            return result;
        }
        
        private string GenerateInsertStatement()
        {
            string result = "";

            StringBuilder sb = new StringBuilder();

            if (chkGenerateInsertStatements.Checked)
            {
                
                if (IDFIELDNAME != "")
                {

                    #region Use the CommandBuilder Object to make the Insert

                    SqlConnection cn = new SqlConnection(DSN);
                    cn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + TableName, cn);

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    builder.QuotePrefix = "[";
                    builder.QuoteSuffix = "]";

                    result = builder.GetInsertCommand().CommandText;

                    string InsertCommand = result.Substring(0, result.IndexOf(" VALUES (@p1"));
                    string ValuesCommand = result.Substring(result.IndexOf(" VALUES (@p1"));

                    sb.Append(InsertCommand);
                    sb.Append("\n");

                    builder.Dispose();
                    adapter.Dispose();
                    cn.Close();
                    cn.Dispose();

                    #endregion

                    SqlConnection cn1 = new SqlConnection(DSN);
                    cn1.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM " + TableName + " ORDER BY " + IDFIELDNAME, cn1);

                    SqlDataReader r = cmd.ExecuteReader();

                    int recnum = 0;
                    int UnionNum = 0;
                    int fnum = 0;

                    while (r.Read() && recnum < 10000)
                    {
                        if (UnionNum != 0)
                        {
                            // linefeed onto the end of the prior fields
                            sb.Append(" UNION ALL \n");
                        }

                        fnum = 0;
                        bool AFIELDPRINTED = false;
                        foreach (Field f in TheFields)
                        {
                            if (fnum == 0)
                            {
                                sb.Append("SELECT ");
                            }

                            if (AFIELDPRINTED)
                            {
                                sb.Append(", ");
                            }

                            if (!f.IsIdentity)
                            {
                                AFIELDPRINTED = true;

                                if (r.IsDBNull(fnum))
                                {
                                    sb.Append(" NULL");
                                }
                                else
                                {

                                    #region Do the Field Decode

                                    if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                                            f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                                            f.FieldType == "SYSNAME")
                                    {

                                        string temp = r[fnum].ToString().Replace("'", "''");

                                        sb.Append("N'" + temp + "'");
                                    }

                                    if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT"
                                        || f.FieldType == "BIGINT")
                                    {
                                        sb.Append("" + r[fnum].ToString() + "");
                                    }

                                    if (f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY"
                                        || f.FieldType == "FLOAT" || f.FieldType == "NUMERIC" || f.FieldType == "DECIMAL")
                                    {
                                        sb.Append("" + r[fnum].ToString() + "");
                                    }

                                    if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                                    {
                                        sb.Append("'" + r[fnum].ToString() + "'");
                                    }

                                    if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                                    {
                                        sb.Append("'" + r[fnum].ToString() + "'");
                                    }

                                    #endregion
                                }
                            }

                            fnum += 1;
                        } // END FOREACH
                        recnum += 1;
                        UnionNum += 1;

                        if (recnum % 50 == 0)
                        {

                            UnionNum = 0;

                            sb.Append("\n\nGO\n\n");
                            sb.Append(InsertCommand);
                            sb.Append("\n");

                        }

                    } // ENDWHILE

                    sb.Append(" \n");

                    r.Close();
                    cmd.Dispose();
                    cn1.Close();
                    cn1.Dispose();

                }
                else
                {

                    MessageBox.Show("There is NO AUTONUMBERING Field on the selected Table\n" +
                                    "Most of the functions of this tool Requires this...");

                }
            }
            
            return sb.ToString();
        }

        public static string BuildInsertSQL(DataTable table)
        {
            StringBuilder sql = new StringBuilder("INSERT INTO " + table.TableName + " (");
            StringBuilder values = new StringBuilder("VALUES (");
            bool bFirst = true;
            bool bIdentity = false;
            string identityType = null;

            foreach (DataColumn column in table.Columns)
            {
                if (column.AutoIncrement)
                {
                    bIdentity = true;

                    switch (column.DataType.Name)
                    {
                        case "Int16":
                            identityType = "smallint";
                            break;
                        case "SByte":
                            identityType = "tinyint";
                            break;
                        case "Int64":
                            identityType = "bigint";
                            break;
                        case "Decimal":
                            identityType = "decimal";
                            break;
                        default:
                            identityType = "int";
                            break;
                    }
                }
                else
                {
                    if (bFirst)
                        bFirst = false;
                    else
                    {
                        sql.Append(", ");
                        values.Append(", ");
                    }

                    sql.Append(column.ColumnName);
                    values.Append("@");
                    values.Append(column.ColumnName);
                }
            }
            sql.Append(") ");
            sql.Append(values.ToString());
            sql.Append(")");

            if (bIdentity)
            {
                sql.Append("; SELECT CAST(scope_identity() AS ");
                sql.Append(identityType);
                sql.Append(")");
            }

            return sql.ToString(); ;
        }


        #endregion

        #region HTML and CSS Code

        private string GenerateHTMLCode()
        {
            string s = "";

            string anon = "";

            if (chkDOJAVASCRIPTUI.Checked )
            {
                // Header that references the JAVASCRIPT UI and JQUERY addons

                s = "<!DOCTYPE html>\n" +
               "<html lang=\"en\">\n" +
               "<head>\n" +
               "\t<meta charset=\"utf-8\">\n" +
               "\t<title>title</title>\n" +
               "\t<link rel=\"stylesheet\" href=\"JS\\jquery-ui.min.css\">\n" +
               "\t<link rel=\"stylesheet\" href=\"style.css\">\n" +
               "\t<script language=\"JavaScript\" src=\"JS\\jquery-1.12.0.min.js\" ></script>\n" +
               "\t<script language=\"JavaScript\" src=\"JS\\jquery-ui.min.js\" ></script>\n" +
               "\t<script language=\"JavaScript\">\n"+
               "REPLACETHISWITHANONYMOUSFUNCTION\n" +
               "\t</script>\n" +
               "</head>\n" +
               "<body>\n";
            }
            else
            {
                // Generic Header for the HTML Output

                s = "<!DOCTYPE html>\n" +
                "<html lang=\"en\">\n" +
                "<head>\n" +
                "\t<meta charset=\"utf-8\">\n" +
                "\t<title>title</title>\n" +
                "\t<link rel=\"stylesheet\" href=\"style.css\">\n" +

                "</head>\n" +
                "<body>\n";
            }

            

            s += "\t<div class=\"panel-frame\">\n";

            foreach (Field f in TheFields)
            {

                s += "\t\t<div class=\"panel-container\" id=\"container_" + f.FieldName + "\" >\n";
                
                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {

                    if (f.MaxLength > 200 || f.MaxLength < 0)
                    {
                        // encode this as a large multiline field

                        s += "\t\t\t<nav class=\"panel-left\">\n";
                        s += "\t\t\t\t" + f.FieldName + "\n";
                        s += "\t\t\t</nav>\n\n";

                        s += "\t\t\t<div class=\"panel-splitter\">\n";
                        s += "\t\t\t\t | \n";
                        s += "\t\t\t</div>\n\n";

                        s += "\t\t\t<div class=\"panel-right\">\n";
                        s += "\t\t\t\t<textarea rows=\"4\" cols=\"50\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\"> \n";
                        s += "\t\t\t\t</textarea>\n";
                        s += "\t\t\t</div>\n\n";
                    }
                    else
                    {
                        if (f.CROSSWALKTABLE != "")
                        {
                            // we are coding a crosswalked Item

                            s += "\t\t\t<nav class=\"panel-left\">\n";
                            s += "\t\t\t\t" + f.FieldName + "\n";
                            s += "\t\t\t</nav>\n\n";

                            s += "\t\t\t<div class=\"panel-splitter\">\n";
                            s += "\t\t\t\t | \n";
                            s += "\t\t\t</div>\n\n";

                            s += "\t\t\t<div class=\"panel-right\">\n";
                            s += "\t\t\t\t<input type=\"text\" list=\"data_list_" + f.FieldName + "\" + name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                            s += "\t\t\t</div>\n\n";

                            // Simple dataList

                            SqlConnection cn = new SqlConnection(DSN);
                            cn.Open();
                            string sql = "SELECT DISTINCT " + f.CROSSWALKVALUE + "," + f.CROSSWALKDISPLAY + " from " + f.CROSSWALKTABLE + " ORDER BY " + f.CROSSWALKDISPLAY;

                            SqlCommand cmd = new SqlCommand(sql, cn);

                            SqlDataReader r = cmd.ExecuteReader();

                            s += "\t\t\t<datalist id=\"data_list_" + f.FieldName + "\">\n";

                            while (r.Read())
                            {
                                s += "\t\t\t\t<option value=\"" + r[0] + "\" >" + r[1] + "</option>\n";
                            }
                            r.Close();
                            cmd.Dispose();
                            cn.Close();
                            cn.Dispose();

                            s += "\t\t\t</datalist>\n\n";
                            
                        }
                        else
                        {

                            s += "\t\t\t<nav class=\"panel-left\">\n";
                            s += "\t\t\t\t" + f.FieldName + "\n";
                            s += "\t\t\t</nav>\n\n";

                            s += "\t\t\t<div class=\"panel-splitter\">\n";
                            s += "\t\t\t\t | \n";
                            s += "\t\t\t</div>\n\n";

                            s += "\t\t\t<div class=\"panel-right\">\n";
                            s += "\t\t\t\t<input type=\"text\" maxlength=\"" + f.MaxLength.ToString() + "\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                            s += "\t\t\t</div>\n\n";
                        }
                    }                  
                    //s += "this.txt" + f.FieldNameConverted + "  = new System.Windows.Forms.TextBox();\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" ||
                   f.FieldType == "TINYINT" || f.FieldType == "BIGINT" || f.FieldType == "DECIMAL" ||
                   f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" ||
                   f.FieldType == "FLOAT")
                {
                    s += "\t\t\t<nav class=\"panel-left\">\n";
                    s += "\t\t\t\t" + f.FieldName + "\n";
                    s += "\t\t\t</nav>\n\n";

                    s += "\t\t\t<div class=\"panel-splitter\">\n";
                    s += "\t\t\t\t | \n";
                    s += "\t\t\t</div>\n\n";

                    s += "\t\t\t<div class=\"panel-right\">\n";
                    s += "\t\t\t\t<input type=\"number\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                    s += "\t\t\t</div>\n\n";


                    //s += "this.txt" + f.FieldNameConverted + "  = new System.Windows.Forms.TextBox();\n";
                }


                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    if (chkDOJAVASCRIPTUI.Checked)
                    {
                        // Doing JQUERY UI Date Pickers

                        // is the anon variable empty? if so initialize it

                        if (anon == "")
                        {
                            anon = "\t\t$(document).ready(function() {\n";
                        }

                        s += "\t\t\t<nav class=\"panel-left\">\n";
                        s += "\t\t\t\t" + f.FieldName + "\n";
                        s += "\t\t\t</nav>\n\n";

                        s += "\t\t\t<div class=\"panel-splitter\">\n";
                        s += "\t\t\t\t | \n";
                        s += "\t\t\t</div>\n\n";

                        s += "\t\t\t<div class=\"panel-right\">\n";
                        s += "\t\t\t\t<input type=\"text\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                        s += "\t\t\t</div>\n\n";

                        anon += "\t\t\t$( \"#fld_" + f.FieldName + "\" ).datepicker();\n";
                    }
                    else
                    {
                        // Doing generic Date pickers

                        s += "\t\t\t<nav class=\"panel-left\">\n";
                        s += "\t\t\t\t" + f.FieldName + "\n";
                        s += "\t\t\t</nav>\n\n";

                        s += "\t\t\t<div class=\"panel-splitter\">\n";
                        s += "\t\t\t\t | \n";
                        s += "\t\t\t</div>\n\n";

                        s += "\t\t\t<div class=\"panel-right\">\n";
                        s += "\t\t\t\t<input type=\"date\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                        s += "\t\t\t</div>\n\n";
                    }
                    
                    //s += "this.dtp" + f.FieldNameConverted + "  = new System.Windows.Forms.DateTimePicker();\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {

                    s += "\t\t\t<nav class=\"panel-left\">\n";
                    s += "\t\t\t\t" + f.FieldName + "\n";
                    s += "\t\t\t</nav>\n\n";

                    s += "\t\t\t<div class=\"panel-splitter\">\n";
                    s += "\t\t\t\t | \n";
                    s += "\t\t\t</div>\n\n";

                    s += "\t\t\t<div class=\"panel-right\">\n";
                    s += "\t\t\t\t<input type=\"checkbox\" name=\"fld_" + f.FieldName + "\" id=\"fld_" + f.FieldName + "\" /> \n";
                    s += "\t\t\t</div>\n\n";

                    //s += "this.chk" + f.FieldNameConverted + "  = new System.Windows.Forms.CheckBox();\n";
                }

                s += "\t\t</div>\n";

            }

            s += "\t</div>\n" +
                  "</body>\n" +
                  "</html>\n";

            if (chkDOJAVASCRIPTUI.Checked)
            {
                // do some cleanup and replace the ANON placeholder with the contents of the ANON variable

                anon += "\t\t});\n";

                s = s.Replace("REPLACETHISWITHANONYMOUSFUNCTION", anon);
            }

            return s;
        }

        private string GenerateCSSCode()
        {
            string s = "";

            s = ".panel-container {\n" +
                "\tdisplay: flex;\n" +
                "\tflex-direction: row;\n" +
                "\tjustify-content: space-around;\n" +
                "\tflex-wrap: nowrap;\n" +
                "\talign-items: stretch;\n" +
                "}\n\n" +

                ".panel-left {\n" +
                "\tflex: none;\n" +
                "\twidth: 200px;\n" +
                "}\n\n" +

                ".panel-splitter {\n" +
                "\tflex: none;\n" +
                "\twidth: 20px;\n" +
                "}\n\n" +

                ".panel-right {\n" +
                "\tflex: 1;\n" +
                "}\n\n";

            return s;
        }


        #endregion

        #endregion

        #region Grid Populators

        //void PopulateDocDefinitionsTable()
        //{
        //    if (cmboDocDefSubSubForms.SelectedItem != null)
        //    {

        //        string sql = "SELECT [DocDefTemplateID],[DocDefTypeId],[DocDefTypeSubId],[DocDefTemplateParID],[DocDefSecId],[TType]" +
        //                     ",[TLabel],[TLabelPosition],[TLabelFontWeight],[TableName],[TableColumnName],[ValidationType],[CustomParameters],[TOrder]" +
        //                     ",[LookupTypeId],[Indent],[TemplateCode],[COPY] FROM [tbldocDefTemplate] WHERE DocDefTypeSubId = " +
        //                     ((DOCDEFSUBTYPE)cmboDocDefSubSubForms.SelectedItem).DocDefTypeSub_Id +
        //                     " ORDER BY TORDER ";

        //        TAIGridDocDef.PopulateGridWithData(DSN, sql);

        //        //bsource.DataSource = GetData(sql);
        //        //TheFormGrid.DataSource = bsource;

        //        //TheFormGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        //        //TheFormGrid.BorderStyle = BorderStyle.Fixed3D;

        //        //TheFormGrid.EditMode = DataGridViewEditMode.EditProgrammatically;

        //    }
        //}

        //void PopulateTheLookupGrid()
        //{
        //    if (cmboSpecificLookupList.SelectedItem.ToString() != "")
        //    {

        //        string sql = "select * from tbllookup where LOOKUPTYPE = '" + cmboSpecificLookupList.SelectedItem.ToString() + "' ORDER BY SORTORDER; ";

        //        taigLookupListGrid.PopulateGridWithData(DSN, sql);
        //    }
        //}

        #endregion

        #region Window/Dialog Close Handlers

        //void thefrm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    PopulateDocDefinitionsTable();
        //}

        //void thelkpfrm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    PopulateTheLookupGrid();
        //}

        #endregion

        #region Background Worker Stuff

        private void HandleBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //cmboServers.Enabled = false;
            
            // Retrieve the enumerator instance and then the data.
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();

            table = instance.GetDataSources();

            List<string> RESULT = new List<string>();

            string SNAME = "";

            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    if (col.ColumnName.ToUpper() == "SERVERNAME")
                    {
                        SNAME = row[col].ToString();
                    }

                    if (col.ColumnName.ToUpper() == "INSTANCENAME")
                    {
                        if (row[col].ToString() != "")
                        {
                            if (SNAME != "")
                            {
                                SNAME += "\\" + row[col].ToString();
                            }
                            else
                            {
                                SNAME = row[col].ToString();
                            }

                        }

                    }

                    //Console.WriteLine("{0} = {1}", col.ColumnName, row[col]);
                }

                RESULT.Add(SNAME);

                //cmboServers.Items.Add(SNAME);
                SNAME = "";
                //Console.WriteLine("============================");
            }

            //cmboServers.Enabled = true;

            e.Result = RESULT;

        }

        private void HandleBackgroundWorker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            List<String> res = e.Result as List<String>;

            foreach(string s in res)
            {
                cmboServers.Items.Add(s);
            }

            lblOneMoment.Visible = false;
            cmboServers.Enabled = true;

            if (res.Count == 0)
            {
                MessageBox.Show("Enumeration of SQL server instances on the network\nYielded no results\n\nYou will have to user SQL SERVER AUTHENTICATION \nand a Manual SERVER NAME like (local)","Trouble Maybe?");
            }


        }

        public static void LocateSqlInstances()
        {
            using (DataTable sqlSources = SqlDataSourceEnumerator.Instance.GetDataSources())
            {
                foreach (DataRow source in sqlSources.Rows)
                {
                    string servername;
                    string instanceName = source["InstanceName"].ToString();

                    if (!string.IsNullOrEmpty(instanceName))
                    {
                        servername = (string)source["InstanceName"] + '\\' + (string)source["ServerName"];
                    }
                    else
                    {
                        servername = (string)source["ServerName"];
                    }
                    Console.WriteLine(" Server Name:{0}", servername);
                    Console.WriteLine("     Version:{0}", source["Version"]);
                    Console.WriteLine();

                }
                //Console.ReadKey();
            }
        }


        #endregion

        #region REST Stuff

        private string GenerateRESTFULPage_Load()
        {

            string s = "protected void Page_Load(object sender, EventArgs e)\n" +
                        "{\n" +
                        "Response.Cache.SetCacheability(HttpCacheability.NoCache);\n\n" +
                        "string result = \"\";\n" +
                        "bool error = false;\n\n" +
                        "if (HttpContext.Current.Request.HttpMethod == \"GET\")\n" +
                        "{\n" +
                        "#region Get Verb\n\n" +
                        "try\n" +
                        "{\n" +
                        "string u = \"\";\n" +
                        "string pw = \"\";\n\n" +
                        "var c = HttpContext.Current;\n" +
                        "var q = HttpContext.Current.Session;\n\n" +
                        "var v = c.Request.QueryString;\n\n" +
                        "u = HttpContext.Current.Session[\"UserName\"].ToString();\n" +
                        "var ID = c.Request[\"" + "" + IDFIELDNAME + "\"];\n\n" +
                        "// Are they actually logged in\n\n" +
                        "if (u != \"\") // IF FORMS AUTH HAS NOT BEEN DONE u will me EMPTY!\n" +
                        "{\n";

            // here we will leverage the CODE written elsewhere in this tool to fetch a single record from the database
            // with the indicated ID and will then hydrate a result to be JSON serialized out to the outside world

            s += TableName + " cls = new " + TableName + "(DBCON());\n";

            string pfix = txtInterfaceOBJPrefix.Text;

            s += pfix + TableName + " obj = new " + pfix + TableName + "();\n";

            s += "cls.Read(ID);\n";

            foreach (Field f in TheFields)
            {
                s += "obj." + f.FieldName + " = cls." + f.FieldName + ";\n";
            }



            s += "//XmlSerializer xs = new XmlSerializer(obj);\n" +
                  "//StringWriter output = new StringWriter();\n\n" +
                  "//xs.Serialize(output, obj);\n\n" +
                  "//result = output.ToString();\n\n" +
                  "// do the JSON serialization Bit Here Plug it into the result variable\n" +
                  "JavaScriptSerializer js = new JavaScriptSerializer();\n" +
                  "result = js.Serialize(obj);\n\n" +
                  "js = null;\n" +
                  "cls = null;\n" +
                  "obj = null;\n" +
                  "}\n" +
                  "else\n" +
                  "{\n" +
                  "error = true;\n" +
                  "}\n\n" +
                  "}\n" +
                  "catch \n" +
                  "{\n" +
                  "error = true;\n" +
                  "// Possible log errors here\n\n" +
                  "}\n\n" +
                  "#endregion\n" +
                  "}\n" +
                  "else if (HttpContext.Current.Request.HttpMethod == \"POST\")\n" +
                  "{\n" +
                  "#region POST Verb\n" +
                  "if (!IsPostBack)\n" +
                  "{\n" +
                  "try\n" +
                  "{\n" +
                  "string u = \"\";\n" +
                  "string pw = \"\";\n\n" +
                  "var c = HttpContext.Current;\n" +
                  "var q = HttpContext.Current.Session;\n\n" +
                  "var v = c.Request.QueryString;\n\n" +
                  "u = HttpContext.Current.Session[\"UserName\"].ToString();\n\n" +
                  "//var action = c.Request[\"Action\"];   // we will use action to create differently formatted outputs\n" +
                  "                                    // so we can create different gets to drive things like Craptacular Javascript grids and such\n" +
                  "                                    // see as how the standard JSON data serializers are lacking metadata and such\n" +
                  "                                    // unfortunately we have roll our own serialization then\n\n" +
                  "//These are some examples of fetching variables from the URL in a URL encoded POST REST operation\n" +
                  "//These are only examples The variable names can be anything and will be specific implementation\n" +
                  "//dependant. Variables are usually gathered as strings and are then required to be coersed via \n" +
                  "//code into the type of data items necessary IE DATES, NUMBERS and BOOLEANS\n\n" +
                  "var ID = c.Request[\"" + "" + IDFIELDNAME + "\"];\n\n" +
                  "#region Logging Stuff for 1980's style debugging\n\n" +
                  "//Requires a class with one of our standard LOGGING methods in it instanced as gs\n" +
                  "//if (action == null)\n" +
                  "//    gs.LogError(\"WHERE EVER I AM IN CODE\", \"ACTION = null\");\n" +
                  "//else\n" +
                  "//    gs.LogError((\"WHERE EVER I AM IN CODE\", \"ACTION = \" + action);\n\n" +
                  "#endregion\n\n" +
                  "if (u != \"\") // if we are not LOGGED in then BAIL with a failure\n" +
                  "{\n";

            s += TableName + " cls = new " + TableName + "(DBCON());\n";
            s += "cls.Read(ID);\n";

            foreach (Field f in TheFields)
            {
                //s += "cls." + f.FieldName + " = c.Request[\"" + "" + f.FieldName + "\"];\n";

                if (f.FieldType == "VARCHAR" || f.FieldType == "CHAR" || f.FieldType == "NVARCHAR" ||
                    f.FieldType == "TEXT" || f.FieldType == "UNIQUEIDENTIFIER" || f.FieldType == "GUID" ||
                    f.FieldType == "SYSNAME")
                {
                    s += "cls." + f.FieldName + " = c.Request[\"" + "" + f.FieldName + "\"];\n";
                }

                if (f.FieldType == "INT" || f.FieldType == "SMALLINT" || f.FieldType == "TINYINT")
                {
                    s += "int int" + f.FieldName + " = 0;\n";
                    s += "int.TryParse(c.Request[\"" + "" + f.FieldName + "\"],out int" + f.FieldName + ");\n";

                    s += "cls." + f.FieldName + " = int" + f.FieldName + ";\n\n";
                }

                if (f.FieldType == "BIGINT")
                {
                    s += "long long" + f.FieldName + " = 0;\n";
                    s += "long.TryParse(c.Request[\"" + "" + f.FieldName + "\"],out long" + f.FieldName + ");\n";

                    s += "cls." + f.FieldName + " = long" + f.FieldName + ";\n\n";
                }

                if (f.FieldType == "DECIMAL" || f.FieldType == "DOUBLE" || f.FieldType == "MONEY" || f.FieldType == "CURRENCY" || f.FieldType == "FLOAT")
                {
                    s += "double dbl" + f.FieldName + " = 0.0;\n";
                    s += "double.TryParse(c.Request[\"" + "" + f.FieldName + "\"],out dbl" + f.FieldName + ");\n";

                    s += "cls." + f.FieldName + " = dbl" + f.FieldName + ";\n\n";
                }

                if (f.FieldType == "DATETIME" || f.FieldType == "DATE" || f.FieldType == "DATETIME2" || f.FieldType == "SMALLDATE" || f.FieldType == "SMALLDATETIME")
                {
                    s += "DateTime dt" + f.FieldName + " = Convert.ToDateTime(null);\n";
                    s += "DateTime.TryParse(c.Request[\"" + "" + f.FieldName + "\"],out dt" + f.FieldName + ");\n";

                    s += "cls." + f.FieldName + " = dt" + f.FieldName + ";\n\n";
                }

                if (f.FieldType == "BOOL" || f.FieldType == "BIT")
                {
                    s += "bool bool" + f.FieldName + " = false;\n";
                    s += "bool.TryParse(c.Request[\"" + "" + f.FieldName + "\"],out bool" + f.FieldName + ");\n";

                    s += "cls." + f.FieldName + " = bool" + f.FieldName + ";\n\n";
                }


            }



            s += "// Will leverage the fact that the TABLECLASS.ADD() method IS Smart in that it \n";
            s += "// will first check for record existing and if so will UPDATE otherwise ADD...\n";
            s += "cls.Add();\n\n";
            s += "cls = null;\n";


                s +=    "}\n" +
                        "else\n" +
                        "{\n" +
                        "error = true;\n" +
                        "}\n\n" +
                        "}\n" +
                        "catch\n" +
                        "{\n" +
                        "error = true;\n" +
                        "// Possible log errors here\n\n" +
                        "}\n" +
                        "}\n" +
                        "#endregion\n" +
                        "}\n" +
                        "else if (HttpContext.Current.Request.HttpMethod == \"PUT\")\n" +
                        "{\n" +
                        "// unused ATM\n" +
                        "}\n" +
                        "else if (HttpContext.Current.Request.HttpMethod == \"DELETE\")\n" +
                        "{\n" +
                        "// unused ATM\n" +
                        "}\n\n" +
                        "#region Error Handlers\n" +
                        "if (error)\n" +
                        "{\n" +
                        "Response.StatusCode = 401;\n" +
                        "// Return a JSON encoded Failure Status\n" +
                        "result = @\"{\"\"STATUS\"\":\"\"fail\"\"}\"; // error\n" +
                        "}\n" +
                        "#endregion\n\n" +
                        "Response.Write(result);\n" +
                        "Response.End();\n" +
                        "}\n";

            return s;
        }

        #endregion

        private void btnEnumerateLocalSQLServers_Click(object sender, EventArgs e)
        {
            lblOneMoment.Visible = true;

            backgroundworkerThread.RunWorkerAsync();
        }

        private void btnSQLPRETTY_Click(object sender, EventArgs e)
        {
            SQL_Formatter.Formatter formatter = new SQL_Formatter.Formatter();

            string opts = "LeadingCommas=False;LeadingJoins=True;RemoveComments=False";

            SQLCODEPRETTY.Text = formatter.Format(txtCRAPPYSQLCODE.Text, opts);


        }

        private void btnShowConnectionString_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DSN);
            txtDerivedConnectionString.Text = DSN;
        }

        private void btnShowTestForm_Click(object sender, EventArgs e)
        {
            TestForm1 tf = new TestForm1();

            tf.ShowDialog();

            tf.Hide();
            
            tf.Dispose();
            ;
        }
    }

    public class DOCDEFCAT
    {
        public string DocDefCat_Id = "";
        public string DocDefCatCode = "";
        public string DocDefCatDesc = "";
        public string isActive = "";

        public override string ToString()
        {
            return DocDefCatDesc + "";
        }
    }

    public class DOCDEFTYPE
    {
        public string DocDefType_Id = "";
        public string DocDefCat_Id = "";
        public string DocDefTypeCode = "";
        public string DocDefTypeDesc = "";
        public string isActive = "";
        public string Forms = "";

        public override string ToString()
        {
            return DocDefTypeDesc + "";
        }
    }

    public class DOCDEFSUBTYPE
    {
        public string DocDefTypeSub_Id = "";
        public string DocDefType_Id = "";
        public string DocDefTypeSubCode = "";
        public string DocDefTypeSubDesc = "";
        public string DocDefTypeSubOrder = "";
        public string isActive = "";

        public override string ToString()
        {
            return DocDefTypeSubDesc;
        }

    }
   
}
