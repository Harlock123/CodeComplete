using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Text;


namespace TAICodeComplete
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    public partial class tbldocDefTemplate : INotifyPropertyChanged
    {

        #region Declarations
        string _classDatabaseConnectionString = "";
        string _bulkinsertPath = "";

        SqlConnection _cn = new SqlConnection();
        SqlCommand _cmd = new SqlCommand();

        // Backing Variables for Properties
        int _DocDefTemplateID = 0;
        int _DocDefTypeId = 0;
        int _DocDefTypeSubId = 0;
        int _DocDefTemplateParID = 0;
        int _DocDefSecId = 0;
        string _TType = "";
        string _TLabel = "";
        string _TLabelPosition = "";
        string _TLabelFontWeight = "";
        string _TableName = "";
        string _TableColumnName = "";
        string _ValidationType = "";
        string _CustomParameters = "";
        int _TOrder = 0;
        int _LookupTypeId = 0;
        int _Indent = 0;
        string _TemplateCode = "";
        string _COPY = "";

        #endregion

        #region Properties

        public string classDatabaseConnectionString
        {
            get { return _classDatabaseConnectionString; }
            set { _classDatabaseConnectionString = value; }
        }

        public string bulkinsertPath
        {
            get { return _bulkinsertPath; }
            set { _bulkinsertPath = value; }
        }

        public int DocDefTemplateID
        {
            get { return _DocDefTemplateID; }
            set
            {
                _DocDefTemplateID = value;
                RaisePropertyChanged("DocDefTemplateID");
            }
        }

        public int DocDefTypeId
        {
            get { return _DocDefTypeId; }
            set
            {
                _DocDefTypeId = value;
                RaisePropertyChanged("DocDefTypeId");
            }
        }

        public int DocDefTypeSubId
        {
            get { return _DocDefTypeSubId; }
            set
            {
                _DocDefTypeSubId = value;
                RaisePropertyChanged("DocDefTypeSubId");
            }
        }

        public int DocDefTemplateParID
        {
            get { return _DocDefTemplateParID; }
            set
            {
                _DocDefTemplateParID = value;
                RaisePropertyChanged("DocDefTemplateParID");
            }
        }

        public int DocDefSecId
        {
            get { return _DocDefSecId; }
            set
            {
                _DocDefSecId = value;
                RaisePropertyChanged("DocDefSecId");
            }
        }

        public string TType
        {
            get { return _TType; }
            set
            {
                if (value.Length > 1000)
                { _TType = value.Substring(0, 1000); }
                else
                {
                    _TType = value;
                    RaisePropertyChanged("TType");
                }
            }
        }

        public string TLabel
        {
            get { return _TLabel; }
            set
            {
                if (value.Length > 1000)
                { _TLabel = value.Substring(0, 1000); }
                else
                {
                    _TLabel = value;
                    RaisePropertyChanged("TLabel");
                }
            }
        }

        public string TLabelPosition
        {
            get { return _TLabelPosition; }
            set
            {
                if (value.Length > 1000)
                { _TLabelPosition = value.Substring(0, 1000); }
                else
                {
                    _TLabelPosition = value;
                    RaisePropertyChanged("TLabelPosition");
                }
            }
        }

        public string TLabelFontWeight
        {
            get { return _TLabelFontWeight; }
            set
            {
                if (value.Length > 1000)
                { _TLabelFontWeight = value.Substring(0, 1000); }
                else
                {
                    _TLabelFontWeight = value;
                    RaisePropertyChanged("TLabelFontWeight");
                }
            }
        }

        public string TableName
        {
            get { return _TableName; }
            set
            {
                if (value.Length > 1000)
                { _TableName = value.Substring(0, 1000); }
                else
                {
                    _TableName = value;
                    RaisePropertyChanged("TableName");
                }
            }
        }

        public string TableColumnName
        {
            get { return _TableColumnName; }
            set
            {
                if (value.Length > 1000)
                { _TableColumnName = value.Substring(0, 1000); }
                else
                {
                    _TableColumnName = value;
                    RaisePropertyChanged("TableColumnName");
                }
            }
        }

        public string ValidationType
        {
            get { return _ValidationType; }
            set
            {
                if (value.Length > 1000)
                { _ValidationType = value.Substring(0, 1000); }
                else
                {
                    _ValidationType = value;
                    RaisePropertyChanged("ValidationType");
                }
            }
        }

        public string CustomParameters
        {
            get { return _CustomParameters; }
            set
            {
                if (value.Length > 1000)
                { _CustomParameters = value.Substring(0, 1000); }
                else
                {
                    _CustomParameters = value;
                    RaisePropertyChanged("CustomParameters");
                }
            }
        }

        public int TOrder
        {
            get { return _TOrder; }
            set
            {
                _TOrder = value;
                RaisePropertyChanged("TOrder");
            }
        }

        public int LookupTypeId
        {
            get { return _LookupTypeId; }
            set
            {
                _LookupTypeId = value;
                RaisePropertyChanged("LookupTypeId");
            }
        }

        public int Indent
        {
            get { return _Indent; }
            set
            {
                _Indent = value;
                RaisePropertyChanged("Indent");
            }
        }

        public string TemplateCode
        {
            get { return _TemplateCode; }
            set
            {
                if (value.Length > 115)
                { _TemplateCode = value.Substring(0, 115); }
                else
                {
                    _TemplateCode = value;
                    RaisePropertyChanged("TemplateCode");
                }
            }
        }

        public string COPY
        {
            get { return _COPY; }
            set
            {
                if (value.Length > 1000)
                { _COPY = value.Substring(0, 1000); }
                else
                {
                    _COPY = value;
                    RaisePropertyChanged("COPY");
                }
            }
        }


        #endregion

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Constructor

        public tbldocDefTemplate()
        {
            // Constructor code goes here.
            Initialize();
        }

        public tbldocDefTemplate(string DSN)
        {
            // Constructor code goes here.
            Initialize();
            classDatabaseConnectionString = DSN;
        }

        #endregion

        public void Initialize()
        {
            _DocDefTemplateID = 0;
            _DocDefTypeId = 0;
            _DocDefTypeSubId = 0;
            _DocDefTemplateParID = 0;
            _DocDefSecId = 0;
            _TType = "";
            _TLabel = "";
            _TLabelPosition = "";
            _TLabelFontWeight = "";
            _TableName = "";
            _TableColumnName = "";
            _ValidationType = "";
            _CustomParameters = "";
            _TOrder = 0;
            _LookupTypeId = 0;
            _Indent = 0;
            _TemplateCode = "";
            _COPY = "";
        }

        public void CopyFields(SqlDataReader r)
        {
            try
            {
                if (!Convert.IsDBNull(r["DocDefTemplateID"]))
                {
                    _DocDefTemplateID = Convert.ToInt32(r["DocDefTemplateID"]);
                }
                if (!Convert.IsDBNull(r["DocDefTypeId"]))
                {
                    _DocDefTypeId = Convert.ToInt32(r["DocDefTypeId"]);
                }
                if (!Convert.IsDBNull(r["DocDefTypeSubId"]))
                {
                    _DocDefTypeSubId = Convert.ToInt32(r["DocDefTypeSubId"]);
                }
                if (!Convert.IsDBNull(r["DocDefTemplateParID"]))
                {
                    _DocDefTemplateParID = Convert.ToInt32(r["DocDefTemplateParID"]);
                }
                if (!Convert.IsDBNull(r["DocDefSecId"]))
                {
                    _DocDefSecId = Convert.ToInt32(r["DocDefSecId"]);
                }
                if (!Convert.IsDBNull(r["TType"]))
                {
                    _TType = r["TType"] + "";
                }
                if (!Convert.IsDBNull(r["TLabel"]))
                {
                    _TLabel = r["TLabel"] + "";
                }
                if (!Convert.IsDBNull(r["TLabelPosition"]))
                {
                    _TLabelPosition = r["TLabelPosition"] + "";
                }
                if (!Convert.IsDBNull(r["TLabelFontWeight"]))
                {
                    _TLabelFontWeight = r["TLabelFontWeight"] + "";
                }
                if (!Convert.IsDBNull(r["TableName"]))
                {
                    _TableName = r["TableName"] + "";
                }
                if (!Convert.IsDBNull(r["TableColumnName"]))
                {
                    _TableColumnName = r["TableColumnName"] + "";
                }
                if (!Convert.IsDBNull(r["ValidationType"]))
                {
                    _ValidationType = r["ValidationType"] + "";
                }
                if (!Convert.IsDBNull(r["CustomParameters"]))
                {
                    _CustomParameters = r["CustomParameters"] + "";
                }
                if (!Convert.IsDBNull(r["TOrder"]))
                {
                    _TOrder = Convert.ToInt32(r["TOrder"]);
                }
                if (!Convert.IsDBNull(r["LookupTypeId"]))
                {
                    _LookupTypeId = Convert.ToInt32(r["LookupTypeId"]);
                }
                if (!Convert.IsDBNull(r["Indent"]))
                {
                    _Indent = Convert.ToInt32(r["Indent"]);
                }
                if (!Convert.IsDBNull(r["TemplateCode"]))
                {
                    _TemplateCode = r["TemplateCode"] + "";
                }
                if (!Convert.IsDBNull(r["COPY"]))
                {
                    _COPY = r["COPY"] + "";
                }
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.CopyFields " + ex.ToString()));
            }
        }

        public void Add()
        {
            try
            {
                string sql = GetParameterSQL();
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@DocDefTypeId", System.Data.SqlDbType.Int).Value = this._DocDefTypeId;
                cmd.Parameters.Add("@DocDefTypeSubId", System.Data.SqlDbType.Int).Value = this._DocDefTypeSubId;
                cmd.Parameters.Add("@DocDefTemplateParID", System.Data.SqlDbType.Int).Value = this._DocDefTemplateParID;
                cmd.Parameters.Add("@DocDefSecId", System.Data.SqlDbType.Int).Value = this._DocDefSecId;
                cmd.Parameters.Add("@TType", System.Data.SqlDbType.VarChar).Value = this._TType;
                cmd.Parameters.Add("@TLabel", System.Data.SqlDbType.VarChar).Value = this._TLabel;
                cmd.Parameters.Add("@TLabelPosition", System.Data.SqlDbType.VarChar).Value = this._TLabelPosition;
                cmd.Parameters.Add("@TLabelFontWeight", System.Data.SqlDbType.VarChar).Value = this._TLabelFontWeight;
                cmd.Parameters.Add("@TableName", System.Data.SqlDbType.VarChar).Value = this._TableName;
                cmd.Parameters.Add("@TableColumnName", System.Data.SqlDbType.VarChar).Value = this._TableColumnName;
                cmd.Parameters.Add("@ValidationType", System.Data.SqlDbType.VarChar).Value = this._ValidationType;
                cmd.Parameters.Add("@CustomParameters", System.Data.SqlDbType.VarChar).Value = this._CustomParameters;
                cmd.Parameters.Add("@TOrder", System.Data.SqlDbType.Int).Value = this._TOrder;
                cmd.Parameters.Add("@LookupTypeId", System.Data.SqlDbType.Int).Value = this._LookupTypeId;
                cmd.Parameters.Add("@Indent", System.Data.SqlDbType.Int).Value = this._Indent;
                cmd.Parameters.Add("@TemplateCode", System.Data.SqlDbType.VarChar).Value = this._TemplateCode;
                cmd.Parameters.Add("@COPY", System.Data.SqlDbType.VarChar).Value = this._COPY;
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                if (DocDefTemplateID < 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", cn);
                    System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());
                    cmd2.Cancel();
                    cmd2.Dispose();
                    _DocDefTemplateID = ii;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.Add " + ex.ToString()));
            }
        }

        public void Update()
        {
            try
            {
                Add();
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.Update " + ex.ToString()));
            }
        }

        public void Delete()
        {
            try
            {
                string sql = "Delete from tbldocDefTemplate WHERE DocDefTemplateID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = this._DocDefTemplateID;
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.Delete " + ex.ToString()));
            }
        }

        public void Read(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tbldocDefTemplate WHERE DocDefTemplateID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    this.CopyFields(r);
                }
                r.Close();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.Read " + ex.ToString()));
            }
        }

        public DataSet ReadAsDataSet(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tbldocDefTemplate WHERE DocDefTemplateID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tbldocDefTemplate");
                da.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
                return ds;
            }
            catch (Exception ex)
            {
                throw (new Exception("tbldocDefTemplate.ReadAsDataSet " + ex.ToString()));
            }
        }

        #region Private Methods

        private string GetParameterSQL()
        {
            string sql = "";
            if (_DocDefTemplateID < 1)
            {
                sql = "INSERT INTO tbldocDefTemplate";
                sql += "(";
                sql += "[DocDefTypeId], [DocDefTypeSubId], [DocDefTemplateParID], [DocDefSecId], [TType],";
                sql += "[TLabel], [TLabelPosition], [TLabelFontWeight], [TableName], [TableColumnName],";
                sql += "[ValidationType], [CustomParameters], [TOrder], [LookupTypeId], [Indent],";
                sql += "[TemplateCode], [COPY])";
                sql += "VALUES (";
                sql += "@DocDefTypeId,@DocDefTypeSubId,@DocDefTemplateParID,@DocDefSecId,@TType,";
                sql += "@TLabel,@TLabelPosition,@TLabelFontWeight,@TableName,@TableColumnName,@ValidationType,";
                sql += "@CustomParameters,@TOrder,@LookupTypeId,@Indent,@TemplateCode,@COPY)";
            }
            else
            {
                sql = "UPDATE tbldocDefTemplate SET ";
                sql += "[DocDefTypeId] = @DocDefTypeId, [DocDefTypeSubId] = @DocDefTypeSubId, [DocDefTemplateParID] = @DocDefTemplateParID,";
                sql += "[DocDefSecId] = @DocDefSecId, [TType] = @TType, [TLabel] = @TLabel, [TLabelPosition] = @TLabelPosition,";
                sql += "[TLabelFontWeight] = @TLabelFontWeight, [TableName] = @TableName, [TableColumnName] = @TableColumnName,";
                sql += "[ValidationType] = @ValidationType, [CustomParameters] = @CustomParameters,";
                sql += "[TOrder] = @TOrder, [LookupTypeId] = @LookupTypeId, [Indent] = @Indent, [TemplateCode] = @TemplateCode,";
                sql += "[COPY] = @COPY";
                sql += " WHERE DocDefTemplateID = " + _DocDefTemplateID.ToString();
            }
            return sql;
        }

        private object getDateOrNull(DateTime d)
        {
            if (d == Convert.ToDateTime(null))
            {
                return DBNull.Value;
            }
            else
            {
                return d;
            }
        }
        #endregion
    }

    public partial class tblLookup : INotifyPropertyChanged
    {

        #region Declarations
        string _classDatabaseConnectionString = "";
        string _bulkinsertPath = "";

        SqlConnection _cn = new SqlConnection();
        SqlCommand _cmd = new SqlCommand();

        // Backing Variables for Properties
        int _LookupId = 0;
        string _LookupType = "";
        string _LongDesc = "";
        string _ShortDesc = "";
        string _Active = "";
        int _SortOrder = 0;
        string _CoverageType = "";
        int _LookupTypeId = 0;
        int _LookupTypeId_Sub = 0;
        string _Parm = "";

        #endregion

        #region Properties

        public string classDatabaseConnectionString
        {
            get { return _classDatabaseConnectionString; }
            set { _classDatabaseConnectionString = value; }
        }

        public string bulkinsertPath
        {
            get { return _bulkinsertPath; }
            set { _bulkinsertPath = value; }
        }

        public int LookupId
        {
            get { return _LookupId; }
            set
            {
                _LookupId = value;
                RaisePropertyChanged("LookupId");
            }
        }

        public string LookupType
        {
            get { return _LookupType; }
            set
            {
                if (value.Length > 500)
                { _LookupType = value.Substring(0, 500); }
                else
                {
                    _LookupType = value;
                    RaisePropertyChanged("LookupType");
                }
            }
        }

        public string LongDesc
        {
            get { return _LongDesc; }
            set
            {
                if (value.Length > 500)
                { _LongDesc = value.Substring(0, 500); }
                else
                {
                    _LongDesc = value;
                    RaisePropertyChanged("LongDesc");
                }
            }
        }

        public string ShortDesc
        {
            get { return _ShortDesc; }
            set
            {
                if (value.Length > 100)
                { _ShortDesc = value.Substring(0, 100); }
                else
                {
                    _ShortDesc = value;
                    RaisePropertyChanged("ShortDesc");
                }
            }
        }

        public string Active
        {
            get { return _Active; }
            set
            {
                if (value.Length > 1)
                { _Active = value.Substring(0, 1); }
                else
                {
                    _Active = value;
                    RaisePropertyChanged("Active");
                }
            }
        }

        public int SortOrder
        {
            get { return _SortOrder; }
            set
            {
                _SortOrder = value;
                RaisePropertyChanged("SortOrder");
            }
        }

        public string CoverageType
        {
            get { return _CoverageType; }
            set
            {
                if (value.Length > 10)
                { _CoverageType = value.Substring(0, 10); }
                else
                {
                    _CoverageType = value;
                    RaisePropertyChanged("CoverageType");
                }
            }
        }

        public int LookupTypeId
        {
            get { return _LookupTypeId; }
            set
            {
                _LookupTypeId = value;
                RaisePropertyChanged("LookupTypeId");
            }
        }

        public int LookupTypeId_Sub
        {
            get { return _LookupTypeId_Sub; }
            set
            {
                _LookupTypeId_Sub = value;
                RaisePropertyChanged("LookupTypeId_Sub");
            }
        }

        public string Parm
        {
            get { return _Parm; }
            set
            {
                if (value.Length > 1000)
                { _Parm = value.Substring(0, 1000); }
                else
                {
                    _Parm = value;
                    RaisePropertyChanged("Parm");
                }
            }
        }


        #endregion

        #region Implement INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Constructor

        public tblLookup()
        {
            // Constructor code goes here.
            Initialize();
        }

        public tblLookup(string DSN)
        {
            // Constructor code goes here.
            Initialize();
            classDatabaseConnectionString = DSN;
        }

        #endregion

        public void Initialize()
        {
            _LookupId = 0;
            _LookupType = "";
            _LongDesc = "";
            _ShortDesc = "";
            _Active = "";
            _SortOrder = 0;
            _CoverageType = "";
            _LookupTypeId = 0;
            _LookupTypeId_Sub = 0;
            _Parm = "";
        }

        public void CopyFields(SqlDataReader r)
        {
            try
            {
                if (!Convert.IsDBNull(r["LookupId"]))
                {
                    _LookupId = Convert.ToInt32(r["LookupId"]);
                }
                if (!Convert.IsDBNull(r["LookupType"]))
                {
                    _LookupType = r["LookupType"] + "";
                }
                if (!Convert.IsDBNull(r["LongDesc"]))
                {
                    _LongDesc = r["LongDesc"] + "";
                }
                if (!Convert.IsDBNull(r["ShortDesc"]))
                {
                    _ShortDesc = r["ShortDesc"] + "";
                }
                if (!Convert.IsDBNull(r["Active"]))
                {
                    _Active = r["Active"] + "";
                }
                if (!Convert.IsDBNull(r["SortOrder"]))
                {
                    _SortOrder = Convert.ToInt32(r["SortOrder"]);
                }
                if (!Convert.IsDBNull(r["CoverageType"]))
                {
                    _CoverageType = r["CoverageType"] + "";
                }
                if (!Convert.IsDBNull(r["LookupTypeId"]))
                {
                    _LookupTypeId = Convert.ToInt32(r["LookupTypeId"]);
                }
                if (!Convert.IsDBNull(r["LookupTypeId_Sub"]))
                {
                    _LookupTypeId_Sub = Convert.ToInt32(r["LookupTypeId_Sub"]);
                }
                if (!Convert.IsDBNull(r["Parm"]))
                {
                    _Parm = r["Parm"] + "";
                }
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.CopyFields " + ex.ToString()));
            }
        }

        public void Add()
        {
            try
            {
                string sql = GetParameterSQL();
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@LookupType", System.Data.SqlDbType.VarChar).Value = this._LookupType;
                cmd.Parameters.Add("@LongDesc", System.Data.SqlDbType.VarChar).Value = this._LongDesc;
                cmd.Parameters.Add("@ShortDesc", System.Data.SqlDbType.VarChar).Value = this._ShortDesc;
                cmd.Parameters.Add("@Active", System.Data.SqlDbType.VarChar).Value = this._Active;
                cmd.Parameters.Add("@SortOrder", System.Data.SqlDbType.Int).Value = this._SortOrder;
                cmd.Parameters.Add("@CoverageType", System.Data.SqlDbType.VarChar).Value = this._CoverageType;
                cmd.Parameters.Add("@LookupTypeId", System.Data.SqlDbType.Int).Value = this._LookupTypeId;

                if (this._LookupTypeId_Sub == 0)
                    cmd.Parameters.Add("@LookupTypeId_Sub", System.Data.SqlDbType.Int).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@LookupTypeId_Sub", System.Data.SqlDbType.Int).Value = this._LookupTypeId_Sub;

                if (this._Parm == "" || this._Parm == string.Empty)
                    cmd.Parameters.Add("@Parm", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                else
                    cmd.Parameters.Add("@Parm", System.Data.SqlDbType.VarChar).Value = this._Parm;

                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                if (LookupId < 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", cn);
                    System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());
                    cmd2.Cancel();
                    cmd2.Dispose();
                    _LookupId = ii;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.Add " + ex.ToString()));
            }
        }

        public void Update()
        {
            try
            {
                Add();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.Update " + ex.ToString()));
            }
        }

        public void Delete()
        {
            try
            {
                string sql = "Delete from tblLookup WHERE LookupId = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = this._LookupId;
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.Delete " + ex.ToString()));
            }
        }

        public void Read(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tblLookup WHERE LookupId = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    this.CopyFields(r);
                }
                r.Close();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.Read " + ex.ToString()));
            }
        }

        public DataSet ReadAsDataSet(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tblLookup WHERE LookupId = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblLookup");
                da.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
                return ds;
            }
            catch (Exception ex)
            {
                throw (new Exception("tblLookup.ReadAsDataSet " + ex.ToString()));
            }
        }

        #region Private Methods

        private string GetParameterSQL()
        {
            string sql = "";
            if (_LookupId < 1)
            {
                sql = "INSERT INTO tblLookup";
                sql += "(";
                sql += "[LookupType], [LongDesc], [ShortDesc], [Active], [SortOrder], [CoverageType],";
                sql += "[LookupTypeId], [LookupTypeId_Sub], [Parm])";
                sql += "VALUES (";
                sql += "@LookupType,@LongDesc,@ShortDesc,@Active,@SortOrder,@CoverageType,@LookupTypeId,";
                sql += "@LookupTypeId_Sub,@Parm)";
            }
            else
            {
                sql = "UPDATE tblLookup SET ";
                sql += "[LookupType] = @LookupType, [LongDesc] = @LongDesc, [ShortDesc] = @ShortDesc,";
                sql += "[Active] = @Active, [SortOrder] = @SortOrder, [CoverageType] = @CoverageType,";
                sql += "[LookupTypeId] = @LookupTypeId, [LookupTypeId_Sub] = @LookupTypeId_Sub, [Parm] = @Parm";
                sql += "";
                sql += " WHERE LookupId = " + _LookupId.ToString();
            }
            return sql;
        }

        private object getDateOrNull(DateTime d)
        {
            if (d == Convert.ToDateTime(null))
            {
                return DBNull.Value;
            }
            else
            {
                return d;
            }
        }
        #endregion
    }

    static public class ApplicationInfo
    {
        public static Version Version { get { return Assembly.GetCallingAssembly().GetName().Version; } }

        public static string Title
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title.Length > 0) return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public static string ProductName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string Description
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string CopyrightHolder
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string CompanyName
        {
            get
            {
                object[] attributes = Assembly.GetCallingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

    }

    public enum RegistryHive
{
  Wow64,
  Wow6432
}

    public class RegistryValueDataReader
    {
      private static readonly int KEY_WOW64_32KEY = 0x200;
      private static readonly int KEY_WOW64_64KEY = 0x100;

      private static readonly UIntPtr HKEY_LOCAL_MACHINE = (UIntPtr)0x80000002;

      private static readonly int KEY_QUERY_VALUE = 0x1;

      [DllImport("advapi32.dll", CharSet = CharSet.Unicode, EntryPoint = "RegOpenKeyEx")]
      static extern int RegOpenKeyEx(
                  UIntPtr hKey,
                  string subKey,
                  uint options,
                  int sam,
                  out IntPtr phkResult);


      [DllImport("advapi32.dll", SetLastError = true)]
      static extern int RegQueryValueEx(
                  IntPtr hKey,
                  string lpValueName,
                  int lpReserved,
                  out uint lpType,
                  IntPtr lpData,
                  ref uint lpcbData);

      private static int GetRegistryHiveKey(RegistryHive registryHive)
      {
         return registryHive == RegistryHive.Wow64 ? KEY_WOW64_64KEY : KEY_WOW64_32KEY;
      }

      private static UIntPtr GetRegistryKeyUIntPtr(RegistryKey registry)
      {
         if (registry == Registry.LocalMachine)
         {
            return HKEY_LOCAL_MACHINE;
         }

         return UIntPtr.Zero;
      }

      public string[] ReadRegistryValueData(RegistryHive registryHive, RegistryKey registryKey, string subKey, string valueName)
      {
         string[] instanceNames = new string[0];

         int key = GetRegistryHiveKey(registryHive);
         UIntPtr registryKeyUIntPtr = GetRegistryKeyUIntPtr(registryKey);

         IntPtr hResult;

         int res = RegOpenKeyEx(registryKeyUIntPtr, subKey, 0, KEY_QUERY_VALUE | key, out hResult);

         if (res == 0)
         {
            uint type;
            uint dataLen = 0;

            RegQueryValueEx(hResult, valueName, 0, out type, IntPtr.Zero, ref dataLen);

            byte[] databuff = new byte[dataLen];
            byte[] temp = new byte[dataLen];

            List<String> values = new List<string>();

            GCHandle handle = GCHandle.Alloc(databuff, GCHandleType.Pinned);
            try
            {
               RegQueryValueEx(hResult, valueName, 0, out type, handle.AddrOfPinnedObject(), ref dataLen);
            }
            finally
            {
               handle.Free();
            }

            int i = 0;
            int j = 0;

            while (i < databuff.Length)
            {
               if (databuff[i] == '\0')
               {
                  j = 0;
                  string str = Encoding.Default.GetString(temp).Trim('\0');

                  if (!string.IsNullOrEmpty(str))
                  {
                     values.Add(str);
                  }

                  temp = new byte[dataLen];
               }
               else
               {
                  temp[j++] = databuff[i];
               }

               ++i;
            }

            instanceNames = new string[values.Count];
            values.CopyTo(instanceNames);
         }

         return instanceNames;
      }
    }


}
