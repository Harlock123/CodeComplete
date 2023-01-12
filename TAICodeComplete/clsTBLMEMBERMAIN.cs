using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace TAICodeComplete
{
    

    public partial class tblMemberMain : INotifyPropertyChanged
    {

        #region Declarations
        string _classDatabaseConnectionString = "";
        string _bulkinsertPath = "";

        SqlConnection _cn = new SqlConnection();
        SqlCommand _cmd = new SqlCommand();

        // Backing Variables for Properties
        int _mmID = 0;
        int _MEMBERID = 0;
        string _MEMBERLASTNAME = "";
        string _MEMBERFIRSTNAME = "";
        string _MEMBERMIDDLENAME = "";
        DateTime _MEMBERDOB = Convert.ToDateTime(null);
        string _MEMBERGENDER = "";
        string _MEMBERSSN = "";
        string _MEMBERAHCCCSID = "";
        string _MEMBERADDRESS1 = "";
        string _MEMBERADDRESS2 = "";
        string _MEMBERADDRESS3 = "";
        string _MEMBERCROSSSTREETS = "";
        string _MEMBERAREACODE1 = "";
        string _MEMBERPHONENUMBER1 = "";
        string _MEMBERAREACODE2 = "";
        string _MEMBERPHONENUMBER2 = "";
        string _MEMBERPARENTNAME = "";
        string _MEMBERPARENTPHONE = "";
        string _MEMBERPARENTEMAIL = "";
        string _MEMBERHEIGHT = "";
        string _MEMBERWEIGHT = "";
        string _MEMBEREYECOLOR = "";
        string _MEMBERHAIRCOLOR = "";
        string _MEMBERMARITALSTATUS = "";
        string _MEMBERCENSUSTRACT = "";
        string _MEMBERCENSUSPLACE = "";
        string _MEMBERIDMARKINGSCOMMENTS = "";
        DateTime _ALTAHCCCSDOB = Convert.ToDateTime(null);
        string _ALTAHCCCSSSN = "";
        string _ALTAHCCCSGENDER = "";
        string _ALTAHCCCSLASTNAME = "";
        string _ALTAHCCCSFIRSTNAME = "";
        string _ALTAHCCCSMIDDLENAME = "";
        string _MEMBERPHONETICCODE = "";
        string _MEMBEREVSVERIFIEDFLAG = "";
        string _MEMBEREMPLOYERNAME = "";
        string _MEMBEREMPLOYERPHONE = "";
        string _MEMBERXIXSTATUS = "";
        DateTime _MEMBERXIXSTSDATEVERIFIED = Convert.ToDateTime(null);
        string _MEMBERLEGALMHSTATUS = "";
        DateTime _MEMBERCOTDATE = Convert.ToDateTime(null);
        string _MEMBERNEEDFORSPCLSSASSIST = "";
        string _MEMBERCRISISPLANLINE1 = "";
        string _MEMBERCRISISPLANLINE2 = "";
        string _MEMBERRELIGIOUSPREF = "";
        string _MEMBERPROGRAM = "";
        string _MEMBERSTATUS = "";
        DateTime _MEMBERWAITDATE = Convert.ToDateTime(null);
        DateTime _MEMBERENDDATE = Convert.ToDateTime(null);
        DateTime _MEMBERBRIEFDATE = Convert.ToDateTime(null);
        string _MEMBERSUBCONTRACTOR = "";
        DateTime _MEMBERSTARTUP = Convert.ToDateTime(null);
        string _MEMBERZIPCODE = "";
        string _MEMBERETHNICITYCODE = "";
        string _MEMBERID2 = "";
        string _MEMBERUSERID = "";
        DateTime _CREATEDATE = Convert.ToDateTime(null);
        string _CREATEUSER = "";
        string _CREATEPLACE = "";
        DateTime _UPDATEDATE = Convert.ToDateTime(null);
        string _UPDATEUSER = "";
        string _UPDATEPLACE = "";
        string _EMAIL = "";
        string _MEMBERMARITALSTATUS_LookupID = "";
        string _MEMBERVETERANSTATUS_LookupID = "";
        string _METHODOFCONTACT_LookupID = "";
        string _ParGurMaritalStatus = "";

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

        public int mmID
        {
            get { return _mmID; }
            set
            {
                _mmID = value;
                RaisePropertyChanged("mmID");
            }
        }

        public int MEMBERID
        {
            get { return _MEMBERID; }
            set
            {
                _MEMBERID = value;
                RaisePropertyChanged("MEMBERID");
            }
        }

        public string MEMBERLASTNAME
        {
            get { return _MEMBERLASTNAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERLASTNAME = value.Substring(0, 50); }
                else
                {
                    _MEMBERLASTNAME = value;
                    RaisePropertyChanged("MEMBERLASTNAME");
                }
            }
        }

        public string MEMBERFIRSTNAME
        {
            get { return _MEMBERFIRSTNAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERFIRSTNAME = value.Substring(0, 50); }
                else
                {
                    _MEMBERFIRSTNAME = value;
                    RaisePropertyChanged("MEMBERFIRSTNAME");
                }
            }
        }

        public string MEMBERMIDDLENAME
        {
            get { return _MEMBERMIDDLENAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERMIDDLENAME = value.Substring(0, 50); }
                else
                {
                    _MEMBERMIDDLENAME = value;
                    RaisePropertyChanged("MEMBERMIDDLENAME");
                }
            }
        }

        public DateTime MEMBERDOB
        {
            get { return _MEMBERDOB; }
            set
            {
                _MEMBERDOB = value;
                RaisePropertyChanged("MEMBERDOB");
            }
        }

        public string MEMBERGENDER
        {
            get { return _MEMBERGENDER; }
            set
            {
                if (value != null && value.Length > 1)
                { _MEMBERGENDER = value.Substring(0, 1); }
                else
                {
                    _MEMBERGENDER = value;
                    RaisePropertyChanged("MEMBERGENDER");
                }
            }
        }

        public string MEMBERSSN
        {
            get { return _MEMBERSSN; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBERSSN = value.Substring(0, 12); }
                else
                {
                    _MEMBERSSN = value;
                    RaisePropertyChanged("MEMBERSSN");
                }
            }
        }

        public string MEMBERAHCCCSID
        {
            get { return _MEMBERAHCCCSID; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERAHCCCSID = value.Substring(0, 10); }
                else
                {
                    _MEMBERAHCCCSID = value;
                    RaisePropertyChanged("MEMBERAHCCCSID");
                }
            }
        }

        public string MEMBERADDRESS1
        {
            get { return _MEMBERADDRESS1; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERADDRESS1 = value.Substring(0, 50); }
                else
                {
                    _MEMBERADDRESS1 = value;
                    RaisePropertyChanged("MEMBERADDRESS1");
                }
            }
        }

        public string MEMBERADDRESS2
        {
            get { return _MEMBERADDRESS2; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERADDRESS2 = value.Substring(0, 50); }
                else
                {
                    _MEMBERADDRESS2 = value;
                    RaisePropertyChanged("MEMBERADDRESS2");
                }
            }
        }

        public string MEMBERADDRESS3
        {
            get { return _MEMBERADDRESS3; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERADDRESS3 = value.Substring(0, 50); }
                else
                {
                    _MEMBERADDRESS3 = value;
                    RaisePropertyChanged("MEMBERADDRESS3");
                }
            }
        }

        public string MEMBERCROSSSTREETS
        {
            get { return _MEMBERCROSSSTREETS; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERCROSSSTREETS = value.Substring(0, 50); }
                else
                {
                    _MEMBERCROSSSTREETS = value;
                    RaisePropertyChanged("MEMBERCROSSSTREETS");
                }
            }
        }

        public string MEMBERAREACODE1
        {
            get { return _MEMBERAREACODE1; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBERAREACODE1 = value.Substring(0, 12); }
                else
                {
                    _MEMBERAREACODE1 = value;
                    RaisePropertyChanged("MEMBERAREACODE1");
                }
            }
        }

        public string MEMBERPHONENUMBER1
        {
            get { return _MEMBERPHONENUMBER1; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBERPHONENUMBER1 = value.Substring(0, 12); }
                else
                {
                    _MEMBERPHONENUMBER1 = value;
                    RaisePropertyChanged("MEMBERPHONENUMBER1");
                }
            }
        }

        public string MEMBERAREACODE2
        {
            get { return _MEMBERAREACODE2; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBERAREACODE2 = value.Substring(0, 12); }
                else
                {
                    _MEMBERAREACODE2 = value;
                    RaisePropertyChanged("MEMBERAREACODE2");
                }
            }
        }

        public string MEMBERPHONENUMBER2
        {
            get { return _MEMBERPHONENUMBER2; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBERPHONENUMBER2 = value.Substring(0, 12); }
                else
                {
                    _MEMBERPHONENUMBER2 = value;
                    RaisePropertyChanged("MEMBERPHONENUMBER2");
                }
            }
        }

        public string MEMBERPARENTNAME
        {
            get { return _MEMBERPARENTNAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERPARENTNAME = value.Substring(0, 50); }
                else
                {
                    _MEMBERPARENTNAME = value;
                    RaisePropertyChanged("MEMBERPARENTNAME");
                }
            }
        }

        public string MEMBERPARENTPHONE
        {
            get { return _MEMBERPARENTPHONE; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERPARENTPHONE = value.Substring(0, 50); }
                else
                {
                    _MEMBERPARENTPHONE = value;
                    RaisePropertyChanged("MEMBERPARENTPHONE");
                }
            }
        }

        public string MEMBERPARENTEMAIL
        {
            get { return _MEMBERPARENTEMAIL; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERPARENTEMAIL = value.Substring(0, 50); }
                else
                {
                    _MEMBERPARENTEMAIL = value;
                    RaisePropertyChanged("MEMBERPARENTEMAIL");
                }
            }
        }

        public string MEMBERHEIGHT
        {
            get { return _MEMBERHEIGHT; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERHEIGHT = value.Substring(0, 10); }
                else
                {
                    _MEMBERHEIGHT = value;
                    RaisePropertyChanged("MEMBERHEIGHT");
                }
            }
        }

        public string MEMBERWEIGHT
        {
            get { return _MEMBERWEIGHT; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERWEIGHT = value.Substring(0, 10); }
                else
                {
                    _MEMBERWEIGHT = value;
                    RaisePropertyChanged("MEMBERWEIGHT");
                }
            }
        }

        public string MEMBEREYECOLOR
        {
            get { return _MEMBEREYECOLOR; }
            set
            {
                if (value != null && value.Length > 4)
                { _MEMBEREYECOLOR = value.Substring(0, 4); }
                else
                {
                    _MEMBEREYECOLOR = value;
                    RaisePropertyChanged("MEMBEREYECOLOR");
                }
            }
        }

        public string MEMBERHAIRCOLOR
        {
            get { return _MEMBERHAIRCOLOR; }
            set
            {
                if (value != null && value.Length > 4)
                { _MEMBERHAIRCOLOR = value.Substring(0, 4); }
                else
                {
                    _MEMBERHAIRCOLOR = value;
                    RaisePropertyChanged("MEMBERHAIRCOLOR");
                }
            }
        }

        public string MEMBERMARITALSTATUS
        {
            get { return _MEMBERMARITALSTATUS; }
            set
            {
                if (value != null && value.Length > 2)
                { _MEMBERMARITALSTATUS = value.Substring(0, 2); }
                else
                {
                    _MEMBERMARITALSTATUS = value;
                    RaisePropertyChanged("MEMBERMARITALSTATUS");
                }
            }
        }

        public string MEMBERCENSUSTRACT
        {
            get { return _MEMBERCENSUSTRACT; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERCENSUSTRACT = value.Substring(0, 10); }
                else
                {
                    _MEMBERCENSUSTRACT = value;
                    RaisePropertyChanged("MEMBERCENSUSTRACT");
                }
            }
        }

        public string MEMBERCENSUSPLACE
        {
            get { return _MEMBERCENSUSPLACE; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERCENSUSPLACE = value.Substring(0, 10); }
                else
                {
                    _MEMBERCENSUSPLACE = value;
                    RaisePropertyChanged("MEMBERCENSUSPLACE");
                }
            }
        }

        public string MEMBERIDMARKINGSCOMMENTS
        {
            get { return _MEMBERIDMARKINGSCOMMENTS; }
            set
            {
                if (value != null && value.Length > 100)
                { _MEMBERIDMARKINGSCOMMENTS = value.Substring(0, 100); }
                else
                {
                    _MEMBERIDMARKINGSCOMMENTS = value;
                    RaisePropertyChanged("MEMBERIDMARKINGSCOMMENTS");
                }
            }
        }

        public DateTime ALTAHCCCSDOB
        {
            get { return _ALTAHCCCSDOB; }
            set
            {
                _ALTAHCCCSDOB = value;
                RaisePropertyChanged("ALTAHCCCSDOB");
            }
        }

        public string ALTAHCCCSSSN
        {
            get { return _ALTAHCCCSSSN; }
            set
            {
                if (value != null && value.Length > 12)
                { _ALTAHCCCSSSN = value.Substring(0, 12); }
                else
                {
                    _ALTAHCCCSSSN = value;
                    RaisePropertyChanged("ALTAHCCCSSSN");
                }
            }
        }

        public string ALTAHCCCSGENDER
        {
            get { return _ALTAHCCCSGENDER; }
            set
            {
                if (value != null && value.Length > 1)
                { _ALTAHCCCSGENDER = value.Substring(0, 1); }
                else
                {
                    _ALTAHCCCSGENDER = value;
                    RaisePropertyChanged("ALTAHCCCSGENDER");
                }
            }
        }

        public string ALTAHCCCSLASTNAME
        {
            get { return _ALTAHCCCSLASTNAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _ALTAHCCCSLASTNAME = value.Substring(0, 50); }
                else
                {
                    _ALTAHCCCSLASTNAME = value;
                    RaisePropertyChanged("ALTAHCCCSLASTNAME");
                }
            }
        }

        public string ALTAHCCCSFIRSTNAME
        {
            get { return _ALTAHCCCSFIRSTNAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _ALTAHCCCSFIRSTNAME = value.Substring(0, 50); }
                else
                {
                    _ALTAHCCCSFIRSTNAME = value;
                    RaisePropertyChanged("ALTAHCCCSFIRSTNAME");
                }
            }
        }

        public string ALTAHCCCSMIDDLENAME
        {
            get { return _ALTAHCCCSMIDDLENAME; }
            set
            {
                if (value != null && value.Length > 50)
                { _ALTAHCCCSMIDDLENAME = value.Substring(0, 50); }
                else
                {
                    _ALTAHCCCSMIDDLENAME = value;
                    RaisePropertyChanged("ALTAHCCCSMIDDLENAME");
                }
            }
        }

        public string MEMBERPHONETICCODE
        {
            get { return _MEMBERPHONETICCODE; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERPHONETICCODE = value.Substring(0, 10); }
                else
                {
                    _MEMBERPHONETICCODE = value;
                    RaisePropertyChanged("MEMBERPHONETICCODE");
                }
            }
        }

        public string MEMBEREVSVERIFIEDFLAG
        {
            get { return _MEMBEREVSVERIFIEDFLAG; }
            set
            {
                if (value != null && value.Length > 1)
                { _MEMBEREVSVERIFIEDFLAG = value.Substring(0, 1); }
                else
                {
                    _MEMBEREVSVERIFIEDFLAG = value;
                    RaisePropertyChanged("MEMBEREVSVERIFIEDFLAG");
                }
            }
        }

        public string MEMBEREMPLOYERNAME
        {
            get { return _MEMBEREMPLOYERNAME; }
            set
            {
                if (value != null && value.Length > 100)
                { _MEMBEREMPLOYERNAME = value.Substring(0, 100); }
                else
                {
                    _MEMBEREMPLOYERNAME = value;
                    RaisePropertyChanged("MEMBEREMPLOYERNAME");
                }
            }
        }

        public string MEMBEREMPLOYERPHONE
        {
            get { return _MEMBEREMPLOYERPHONE; }
            set
            {
                if (value != null && value.Length > 12)
                { _MEMBEREMPLOYERPHONE = value.Substring(0, 12); }
                else
                {
                    _MEMBEREMPLOYERPHONE = value;
                    RaisePropertyChanged("MEMBEREMPLOYERPHONE");
                }
            }
        }

        public string MEMBERXIXSTATUS
        {
            get { return _MEMBERXIXSTATUS; }
            set
            {
                if (value != null && value.Length > 1)
                { _MEMBERXIXSTATUS = value.Substring(0, 1); }
                else
                {
                    _MEMBERXIXSTATUS = value;
                    RaisePropertyChanged("MEMBERXIXSTATUS");
                }
            }
        }

        public DateTime MEMBERXIXSTSDATEVERIFIED
        {
            get { return _MEMBERXIXSTSDATEVERIFIED; }
            set
            {
                _MEMBERXIXSTSDATEVERIFIED = value;
                RaisePropertyChanged("MEMBERXIXSTSDATEVERIFIED");
            }
        }

        public string MEMBERLEGALMHSTATUS
        {
            get { return _MEMBERLEGALMHSTATUS; }
            set
            {
                if (value != null && value.Length > 1)
                { _MEMBERLEGALMHSTATUS = value.Substring(0, 1); }
                else
                {
                    _MEMBERLEGALMHSTATUS = value;
                    RaisePropertyChanged("MEMBERLEGALMHSTATUS");
                }
            }
        }

        public DateTime MEMBERCOTDATE
        {
            get { return _MEMBERCOTDATE; }
            set
            {
                _MEMBERCOTDATE = value;
                RaisePropertyChanged("MEMBERCOTDATE");
            }
        }

        public string MEMBERNEEDFORSPCLSSASSIST
        {
            get { return _MEMBERNEEDFORSPCLSSASSIST; }
            set
            {
                if (value != null && value.Length > 100)
                { _MEMBERNEEDFORSPCLSSASSIST = value.Substring(0, 100); }
                else
                {
                    _MEMBERNEEDFORSPCLSSASSIST = value;
                    RaisePropertyChanged("MEMBERNEEDFORSPCLSSASSIST");
                }
            }
        }

        public string MEMBERCRISISPLANLINE1
        {
            get { return _MEMBERCRISISPLANLINE1; }
            set
            {
                if (value != null && value.Length > 100)
                { _MEMBERCRISISPLANLINE1 = value.Substring(0, 100); }
                else
                {
                    _MEMBERCRISISPLANLINE1 = value;
                    RaisePropertyChanged("MEMBERCRISISPLANLINE1");
                }
            }
        }

        public string MEMBERCRISISPLANLINE2
        {
            get { return _MEMBERCRISISPLANLINE2; }
            set
            {
                if (value != null && value.Length > 100)
                { _MEMBERCRISISPLANLINE2 = value.Substring(0, 100); }
                else
                {
                    _MEMBERCRISISPLANLINE2 = value;
                    RaisePropertyChanged("MEMBERCRISISPLANLINE2");
                }
            }
        }

        public string MEMBERRELIGIOUSPREF
        {
            get { return _MEMBERRELIGIOUSPREF; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERRELIGIOUSPREF = value.Substring(0, 50); }
                else
                {
                    _MEMBERRELIGIOUSPREF = value;
                    RaisePropertyChanged("MEMBERRELIGIOUSPREF");
                }
            }
        }

        public string MEMBERPROGRAM
        {
            get { return _MEMBERPROGRAM; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERPROGRAM = value.Substring(0, 10); }
                else
                {
                    _MEMBERPROGRAM = value;
                    RaisePropertyChanged("MEMBERPROGRAM");
                }
            }
        }

        public string MEMBERSTATUS
        {
            get { return _MEMBERSTATUS; }
            set
            {
                if (value != null && value.Length > 1)
                { _MEMBERSTATUS = value.Substring(0, 1); }
                else
                {
                    _MEMBERSTATUS = value;
                    RaisePropertyChanged("MEMBERSTATUS");
                }
            }
        }

        public DateTime MEMBERWAITDATE
        {
            get { return _MEMBERWAITDATE; }
            set
            {
                _MEMBERWAITDATE = value;
                RaisePropertyChanged("MEMBERWAITDATE");
            }
        }

        public DateTime MEMBERENDDATE
        {
            get { return _MEMBERENDDATE; }
            set
            {
                _MEMBERENDDATE = value;
                RaisePropertyChanged("MEMBERENDDATE");
            }
        }

        public DateTime MEMBERBRIEFDATE
        {
            get { return _MEMBERBRIEFDATE; }
            set
            {
                _MEMBERBRIEFDATE = value;
                RaisePropertyChanged("MEMBERBRIEFDATE");
            }
        }

        public string MEMBERSUBCONTRACTOR
        {
            get { return _MEMBERSUBCONTRACTOR; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERSUBCONTRACTOR = value.Substring(0, 10); }
                else
                {
                    _MEMBERSUBCONTRACTOR = value;
                    RaisePropertyChanged("MEMBERSUBCONTRACTOR");
                }
            }
        }

        public DateTime MEMBERSTARTUP
        {
            get { return _MEMBERSTARTUP; }
            set
            {
                _MEMBERSTARTUP = value;
                RaisePropertyChanged("MEMBERSTARTUP");
            }
        }

        public string MEMBERZIPCODE
        {
            get { return _MEMBERZIPCODE; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERZIPCODE = value.Substring(0, 10); }
                else
                {
                    _MEMBERZIPCODE = value;
                    RaisePropertyChanged("MEMBERZIPCODE");
                }
            }
        }

        public string MEMBERETHNICITYCODE
        {
            get { return _MEMBERETHNICITYCODE; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERETHNICITYCODE = value.Substring(0, 10); }
                else
                {
                    _MEMBERETHNICITYCODE = value;
                    RaisePropertyChanged("MEMBERETHNICITYCODE");
                }
            }
        }

        public string MEMBERID2
        {
            get { return _MEMBERID2; }
            set
            {
                if (value != null && value.Length > 10)
                { _MEMBERID2 = value.Substring(0, 10); }
                else
                {
                    _MEMBERID2 = value;
                    RaisePropertyChanged("MEMBERID2");
                }
            }
        }

        public string MEMBERUSERID
        {
            get { return _MEMBERUSERID; }
            set
            {
                if (value != null && value.Length > 15)
                { _MEMBERUSERID = value.Substring(0, 15); }
                else
                {
                    _MEMBERUSERID = value;
                    RaisePropertyChanged("MEMBERUSERID");
                }
            }
        }

        public DateTime CREATEDATE
        {
            get { return _CREATEDATE; }
            set
            {
                _CREATEDATE = value;
                RaisePropertyChanged("CREATEDATE");
            }
        }

        public string CREATEUSER
        {
            get { return _CREATEUSER; }
            set
            {
                if (value != null && value.Length > 50)
                { _CREATEUSER = value.Substring(0, 50); }
                else
                {
                    _CREATEUSER = value;
                    RaisePropertyChanged("CREATEUSER");
                }
            }
        }

        public string CREATEPLACE
        {
            get { return _CREATEPLACE; }
            set
            {
                if (value != null && value.Length > 50)
                { _CREATEPLACE = value.Substring(0, 50); }
                else
                {
                    _CREATEPLACE = value;
                    RaisePropertyChanged("CREATEPLACE");
                }
            }
        }

        public DateTime UPDATEDATE
        {
            get { return _UPDATEDATE; }
            set
            {
                _UPDATEDATE = value;
                RaisePropertyChanged("UPDATEDATE");
            }
        }

        public string UPDATEUSER
        {
            get { return _UPDATEUSER; }
            set
            {
                if (value != null && value.Length > 50)
                { _UPDATEUSER = value.Substring(0, 50); }
                else
                {
                    _UPDATEUSER = value;
                    RaisePropertyChanged("UPDATEUSER");
                }
            }
        }

        public string UPDATEPLACE
        {
            get { return _UPDATEPLACE; }
            set
            {
                if (value != null && value.Length > 50)
                { _UPDATEPLACE = value.Substring(0, 50); }
                else
                {
                    _UPDATEPLACE = value;
                    RaisePropertyChanged("UPDATEPLACE");
                }
            }
        }

        public string EMAIL
        {
            get { return _EMAIL; }
            set
            {
                if (value != null && value.Length > 100)
                { _EMAIL = value.Substring(0, 100); }
                else
                {
                    _EMAIL = value;
                    RaisePropertyChanged("EMAIL");
                }
            }
        }

        public string MEMBERMARITALSTATUS_LookupID
        {
            get { return _MEMBERMARITALSTATUS_LookupID; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERMARITALSTATUS_LookupID = value.Substring(0, 50); }
                else
                {
                    _MEMBERMARITALSTATUS_LookupID = value;
                    RaisePropertyChanged("MEMBERMARITALSTATUS_LookupID");
                }
            }
        }

        public string MEMBERVETERANSTATUS_LookupID
        {
            get { return _MEMBERVETERANSTATUS_LookupID; }
            set
            {
                if (value != null && value.Length > 50)
                { _MEMBERVETERANSTATUS_LookupID = value.Substring(0, 50); }
                else
                {
                    _MEMBERVETERANSTATUS_LookupID = value;
                    RaisePropertyChanged("MEMBERVETERANSTATUS_LookupID");
                }
            }
        }

        public string METHODOFCONTACT_LookupID
        {
            get { return _METHODOFCONTACT_LookupID; }
            set
            {
                if (value != null && value.Length > 50)
                { _METHODOFCONTACT_LookupID = value.Substring(0, 50); }
                else
                {
                    _METHODOFCONTACT_LookupID = value;
                    RaisePropertyChanged("METHODOFCONTACT_LookupID");
                }
            }
        }

        public string ParGurMaritalStatus
        {
            get { return _ParGurMaritalStatus; }
            set
            {
                if (value != null && value.Length > 50)
                { _ParGurMaritalStatus = value.Substring(0, 50); }
                else
                {
                    _ParGurMaritalStatus = value;
                    RaisePropertyChanged("ParGurMaritalStatus");
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

        public tblMemberMain()
        {
            // Constructor code goes here.
            Initialize();
        }

        public tblMemberMain(string DSN)
        {
            // Constructor code goes here.
            Initialize();
            classDatabaseConnectionString = DSN;
        }

        #endregion

        #region Public Methods

        public void Initialize()
        {
            _mmID = 0;
            _MEMBERID = 0;
            _MEMBERLASTNAME = "";
            _MEMBERFIRSTNAME = "";
            _MEMBERMIDDLENAME = "";
            _MEMBERDOB = Convert.ToDateTime(null);
            _MEMBERGENDER = "";
            _MEMBERSSN = "";
            _MEMBERAHCCCSID = "";
            _MEMBERADDRESS1 = "";
            _MEMBERADDRESS2 = "";
            _MEMBERADDRESS3 = "";
            _MEMBERCROSSSTREETS = "";
            _MEMBERAREACODE1 = "";
            _MEMBERPHONENUMBER1 = "";
            _MEMBERAREACODE2 = "";
            _MEMBERPHONENUMBER2 = "";
            _MEMBERPARENTNAME = "";
            _MEMBERPARENTPHONE = "";
            _MEMBERPARENTEMAIL = "";
            _MEMBERHEIGHT = "";
            _MEMBERWEIGHT = "";
            _MEMBEREYECOLOR = "";
            _MEMBERHAIRCOLOR = "";
            _MEMBERMARITALSTATUS = "";
            _MEMBERCENSUSTRACT = "";
            _MEMBERCENSUSPLACE = "";
            _MEMBERIDMARKINGSCOMMENTS = "";
            _ALTAHCCCSDOB = Convert.ToDateTime(null);
            _ALTAHCCCSSSN = "";
            _ALTAHCCCSGENDER = "";
            _ALTAHCCCSLASTNAME = "";
            _ALTAHCCCSFIRSTNAME = "";
            _ALTAHCCCSMIDDLENAME = "";
            _MEMBERPHONETICCODE = "";
            _MEMBEREVSVERIFIEDFLAG = "";
            _MEMBEREMPLOYERNAME = "";
            _MEMBEREMPLOYERPHONE = "";
            _MEMBERXIXSTATUS = "";
            _MEMBERXIXSTSDATEVERIFIED = Convert.ToDateTime(null);
            _MEMBERLEGALMHSTATUS = "";
            _MEMBERCOTDATE = Convert.ToDateTime(null);
            _MEMBERNEEDFORSPCLSSASSIST = "";
            _MEMBERCRISISPLANLINE1 = "";
            _MEMBERCRISISPLANLINE2 = "";
            _MEMBERRELIGIOUSPREF = "";
            _MEMBERPROGRAM = "";
            _MEMBERSTATUS = "";
            _MEMBERWAITDATE = Convert.ToDateTime(null);
            _MEMBERENDDATE = Convert.ToDateTime(null);
            _MEMBERBRIEFDATE = Convert.ToDateTime(null);
            _MEMBERSUBCONTRACTOR = "";
            _MEMBERSTARTUP = Convert.ToDateTime(null);
            _MEMBERZIPCODE = "";
            _MEMBERETHNICITYCODE = "";
            _MEMBERID2 = "";
            _MEMBERUSERID = "";
            _CREATEDATE = Convert.ToDateTime(null);
            _CREATEUSER = "";
            _CREATEPLACE = "";
            _UPDATEDATE = Convert.ToDateTime(null);
            _UPDATEUSER = "";
            _UPDATEPLACE = "";
            _EMAIL = "";
            _MEMBERMARITALSTATUS_LookupID = "";
            _MEMBERVETERANSTATUS_LookupID = "";
            _METHODOFCONTACT_LookupID = "";
            _ParGurMaritalStatus = "";
        }

        public void CopyFields(SqlDataReader r)
        {
            try
            {
                if (!Convert.IsDBNull(r["mmID"]))
                {
                    _mmID = Convert.ToInt32(r["mmID"]);
                }
                if (!Convert.IsDBNull(r["MEMBERID"]))
                {
                    _MEMBERID = Convert.ToInt32(r["MEMBERID"]);
                }
                if (!Convert.IsDBNull(r["MEMBERLASTNAME"]))
                {
                    _MEMBERLASTNAME = r["MEMBERLASTNAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERFIRSTNAME"]))
                {
                    _MEMBERFIRSTNAME = r["MEMBERFIRSTNAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERMIDDLENAME"]))
                {
                    _MEMBERMIDDLENAME = r["MEMBERMIDDLENAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERDOB"]))
                {
                    _MEMBERDOB = Convert.ToDateTime(r["MEMBERDOB"]);
                }
                if (!Convert.IsDBNull(r["MEMBERGENDER"]))
                {
                    _MEMBERGENDER = r["MEMBERGENDER"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERSSN"]))
                {
                    _MEMBERSSN = r["MEMBERSSN"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERAHCCCSID"]))
                {
                    _MEMBERAHCCCSID = r["MEMBERAHCCCSID"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERADDRESS1"]))
                {
                    _MEMBERADDRESS1 = r["MEMBERADDRESS1"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERADDRESS2"]))
                {
                    _MEMBERADDRESS2 = r["MEMBERADDRESS2"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERADDRESS3"]))
                {
                    _MEMBERADDRESS3 = r["MEMBERADDRESS3"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCROSSSTREETS"]))
                {
                    _MEMBERCROSSSTREETS = r["MEMBERCROSSSTREETS"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERAREACODE1"]))
                {
                    _MEMBERAREACODE1 = r["MEMBERAREACODE1"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPHONENUMBER1"]))
                {
                    _MEMBERPHONENUMBER1 = r["MEMBERPHONENUMBER1"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERAREACODE2"]))
                {
                    _MEMBERAREACODE2 = r["MEMBERAREACODE2"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPHONENUMBER2"]))
                {
                    _MEMBERPHONENUMBER2 = r["MEMBERPHONENUMBER2"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPARENTNAME"]))
                {
                    _MEMBERPARENTNAME = r["MEMBERPARENTNAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPARENTPHONE"]))
                {
                    _MEMBERPARENTPHONE = r["MEMBERPARENTPHONE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPARENTEMAIL"]))
                {
                    _MEMBERPARENTEMAIL = r["MEMBERPARENTEMAIL"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERHEIGHT"]))
                {
                    _MEMBERHEIGHT = r["MEMBERHEIGHT"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERWEIGHT"]))
                {
                    _MEMBERWEIGHT = r["MEMBERWEIGHT"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBEREYECOLOR"]))
                {
                    _MEMBEREYECOLOR = r["MEMBEREYECOLOR"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERHAIRCOLOR"]))
                {
                    _MEMBERHAIRCOLOR = r["MEMBERHAIRCOLOR"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERMARITALSTATUS"]))
                {
                    _MEMBERMARITALSTATUS = r["MEMBERMARITALSTATUS"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCENSUSTRACT"]))
                {
                    _MEMBERCENSUSTRACT = r["MEMBERCENSUSTRACT"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCENSUSPLACE"]))
                {
                    _MEMBERCENSUSPLACE = r["MEMBERCENSUSPLACE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERIDMARKINGSCOMMENTS"]))
                {
                    _MEMBERIDMARKINGSCOMMENTS = r["MEMBERIDMARKINGSCOMMENTS"] + "";
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSDOB"]))
                {
                    _ALTAHCCCSDOB = Convert.ToDateTime(r["ALTAHCCCSDOB"]);
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSSSN"]))
                {
                    _ALTAHCCCSSSN = r["ALTAHCCCSSSN"] + "";
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSGENDER"]))
                {
                    _ALTAHCCCSGENDER = r["ALTAHCCCSGENDER"] + "";
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSLASTNAME"]))
                {
                    _ALTAHCCCSLASTNAME = r["ALTAHCCCSLASTNAME"] + "";
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSFIRSTNAME"]))
                {
                    _ALTAHCCCSFIRSTNAME = r["ALTAHCCCSFIRSTNAME"] + "";
                }
                if (!Convert.IsDBNull(r["ALTAHCCCSMIDDLENAME"]))
                {
                    _ALTAHCCCSMIDDLENAME = r["ALTAHCCCSMIDDLENAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPHONETICCODE"]))
                {
                    _MEMBERPHONETICCODE = r["MEMBERPHONETICCODE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBEREVSVERIFIEDFLAG"]))
                {
                    _MEMBEREVSVERIFIEDFLAG = r["MEMBEREVSVERIFIEDFLAG"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBEREMPLOYERNAME"]))
                {
                    _MEMBEREMPLOYERNAME = r["MEMBEREMPLOYERNAME"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBEREMPLOYERPHONE"]))
                {
                    _MEMBEREMPLOYERPHONE = r["MEMBEREMPLOYERPHONE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERXIXSTATUS"]))
                {
                    _MEMBERXIXSTATUS = r["MEMBERXIXSTATUS"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERXIXSTSDATEVERIFIED"]))
                {
                    _MEMBERXIXSTSDATEVERIFIED = Convert.ToDateTime(r["MEMBERXIXSTSDATEVERIFIED"]);
                }
                if (!Convert.IsDBNull(r["MEMBERLEGALMHSTATUS"]))
                {
                    _MEMBERLEGALMHSTATUS = r["MEMBERLEGALMHSTATUS"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCOTDATE"]))
                {
                    _MEMBERCOTDATE = Convert.ToDateTime(r["MEMBERCOTDATE"]);
                }
                if (!Convert.IsDBNull(r["MEMBERNEEDFORSPCLSSASSIST"]))
                {
                    _MEMBERNEEDFORSPCLSSASSIST = r["MEMBERNEEDFORSPCLSSASSIST"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCRISISPLANLINE1"]))
                {
                    _MEMBERCRISISPLANLINE1 = r["MEMBERCRISISPLANLINE1"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERCRISISPLANLINE2"]))
                {
                    _MEMBERCRISISPLANLINE2 = r["MEMBERCRISISPLANLINE2"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERRELIGIOUSPREF"]))
                {
                    _MEMBERRELIGIOUSPREF = r["MEMBERRELIGIOUSPREF"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERPROGRAM"]))
                {
                    _MEMBERPROGRAM = r["MEMBERPROGRAM"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERSTATUS"]))
                {
                    _MEMBERSTATUS = r["MEMBERSTATUS"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERWAITDATE"]))
                {
                    _MEMBERWAITDATE = Convert.ToDateTime(r["MEMBERWAITDATE"]);
                }
                if (!Convert.IsDBNull(r["MEMBERENDDATE"]))
                {
                    _MEMBERENDDATE = Convert.ToDateTime(r["MEMBERENDDATE"]);
                }
                if (!Convert.IsDBNull(r["MEMBERBRIEFDATE"]))
                {
                    _MEMBERBRIEFDATE = Convert.ToDateTime(r["MEMBERBRIEFDATE"]);
                }
                if (!Convert.IsDBNull(r["MEMBERSUBCONTRACTOR"]))
                {
                    _MEMBERSUBCONTRACTOR = r["MEMBERSUBCONTRACTOR"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERSTARTUP"]))
                {
                    _MEMBERSTARTUP = Convert.ToDateTime(r["MEMBERSTARTUP"]);
                }
                if (!Convert.IsDBNull(r["MEMBERZIPCODE"]))
                {
                    _MEMBERZIPCODE = r["MEMBERZIPCODE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERETHNICITYCODE"]))
                {
                    _MEMBERETHNICITYCODE = r["MEMBERETHNICITYCODE"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERID2"]))
                {
                    _MEMBERID2 = r["MEMBERID2"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERUSERID"]))
                {
                    _MEMBERUSERID = r["MEMBERUSERID"] + "";
                }
                if (!Convert.IsDBNull(r["CREATEDATE"]))
                {
                    _CREATEDATE = Convert.ToDateTime(r["CREATEDATE"]);
                }
                if (!Convert.IsDBNull(r["CREATEUSER"]))
                {
                    _CREATEUSER = r["CREATEUSER"] + "";
                }
                if (!Convert.IsDBNull(r["CREATEPLACE"]))
                {
                    _CREATEPLACE = r["CREATEPLACE"] + "";
                }
                if (!Convert.IsDBNull(r["UPDATEDATE"]))
                {
                    _UPDATEDATE = Convert.ToDateTime(r["UPDATEDATE"]);
                }
                if (!Convert.IsDBNull(r["UPDATEUSER"]))
                {
                    _UPDATEUSER = r["UPDATEUSER"] + "";
                }
                if (!Convert.IsDBNull(r["UPDATEPLACE"]))
                {
                    _UPDATEPLACE = r["UPDATEPLACE"] + "";
                }
                if (!Convert.IsDBNull(r["EMAIL"]))
                {
                    _EMAIL = r["EMAIL"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERMARITALSTATUS_LookupID"]))
                {
                    _MEMBERMARITALSTATUS_LookupID = r["MEMBERMARITALSTATUS_LookupID"] + "";
                }
                if (!Convert.IsDBNull(r["MEMBERVETERANSTATUS_LookupID"]))
                {
                    _MEMBERVETERANSTATUS_LookupID = r["MEMBERVETERANSTATUS_LookupID"] + "";
                }
                if (!Convert.IsDBNull(r["METHODOFCONTACT_LookupID"]))
                {
                    _METHODOFCONTACT_LookupID = r["METHODOFCONTACT_LookupID"] + "";
                }
                if (!Convert.IsDBNull(r["ParGurMaritalStatus"]))
                {
                    _ParGurMaritalStatus = r["ParGurMaritalStatus"] + "";
                }
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.CopyFields " + ex.ToString()));
            }
        }

        public bool RecExists(System.Int32 idx)
        {
            bool Result = false;
            try
            {
                string sql = "Select count(*) from tblMemberMain WHERE mmID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if (r.GetInt32(0) > 0)
                    {
                        Result = true;
                    }
                }
                r.Close();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.RecExists " + ex.ToString()));
            }

            return Result;
        }

        public void Add()
        {
            try
            {
                string sql = GetParameterSQL();
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@MEMBERID", System.Data.SqlDbType.Int).Value = this._MEMBERID;
                cmd.Parameters.Add("@MEMBERLASTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERLASTNAME;
                if (this._MEMBERFIRSTNAME == null || this._MEMBERFIRSTNAME == "" || this._MEMBERFIRSTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERFIRSTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERFIRSTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERFIRSTNAME;
                }
                if (this._MEMBERMIDDLENAME == null || this._MEMBERMIDDLENAME == "" || this._MEMBERMIDDLENAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMIDDLENAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMIDDLENAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERMIDDLENAME;
                }
                cmd.Parameters.Add("@MEMBERDOB", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERDOB);
                if (this._MEMBERGENDER == null || this._MEMBERGENDER == "" || this._MEMBERGENDER == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERGENDER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERGENDER", System.Data.SqlDbType.VarChar).Value = this._MEMBERGENDER;
                }
                if (this._MEMBERSSN == null || this._MEMBERSSN == "" || this._MEMBERSSN == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSSN", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSSN", System.Data.SqlDbType.VarChar).Value = this._MEMBERSSN;
                }
                if (this._MEMBERAHCCCSID == null || this._MEMBERAHCCCSID == "" || this._MEMBERAHCCCSID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAHCCCSID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAHCCCSID", System.Data.SqlDbType.VarChar).Value = this._MEMBERAHCCCSID;
                }
                if (this._MEMBERADDRESS1 == null || this._MEMBERADDRESS1 == "" || this._MEMBERADDRESS1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS1", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS1;
                }
                if (this._MEMBERADDRESS2 == null || this._MEMBERADDRESS2 == "" || this._MEMBERADDRESS2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS2", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS2;
                }
                if (this._MEMBERADDRESS3 == null || this._MEMBERADDRESS3 == "" || this._MEMBERADDRESS3 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS3", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS3", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS3;
                }
                if (this._MEMBERCROSSSTREETS == null || this._MEMBERCROSSSTREETS == "" || this._MEMBERCROSSSTREETS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCROSSSTREETS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCROSSSTREETS", System.Data.SqlDbType.VarChar).Value = this._MEMBERCROSSSTREETS;
                }
                if (this._MEMBERAREACODE1 == null || this._MEMBERAREACODE1 == "" || this._MEMBERAREACODE1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAREACODE1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAREACODE1", System.Data.SqlDbType.VarChar).Value = this._MEMBERAREACODE1;
                }
                if (this._MEMBERPHONENUMBER1 == null || this._MEMBERPHONENUMBER1 == "" || this._MEMBERPHONENUMBER1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER1", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONENUMBER1;
                }
                if (this._MEMBERAREACODE2 == null || this._MEMBERAREACODE2 == "" || this._MEMBERAREACODE2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAREACODE2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAREACODE2", System.Data.SqlDbType.VarChar).Value = this._MEMBERAREACODE2;
                }
                if (this._MEMBERPHONENUMBER2 == null || this._MEMBERPHONENUMBER2 == "" || this._MEMBERPHONENUMBER2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER2", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONENUMBER2;
                }
                if (this._MEMBERPARENTNAME == null || this._MEMBERPARENTNAME == "" || this._MEMBERPARENTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTNAME;
                }
                if (this._MEMBERPARENTPHONE == null || this._MEMBERPARENTPHONE == "" || this._MEMBERPARENTPHONE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTPHONE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTPHONE", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTPHONE;
                }
                if (this._MEMBERPARENTEMAIL == null || this._MEMBERPARENTEMAIL == "" || this._MEMBERPARENTEMAIL == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTEMAIL", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTEMAIL", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTEMAIL;
                }
                if (this._MEMBERHEIGHT == null || this._MEMBERHEIGHT == "" || this._MEMBERHEIGHT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERHEIGHT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERHEIGHT", System.Data.SqlDbType.VarChar).Value = this._MEMBERHEIGHT;
                }
                if (this._MEMBERWEIGHT == null || this._MEMBERWEIGHT == "" || this._MEMBERWEIGHT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERWEIGHT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERWEIGHT", System.Data.SqlDbType.VarChar).Value = this._MEMBERWEIGHT;
                }
                if (this._MEMBEREYECOLOR == null || this._MEMBEREYECOLOR == "" || this._MEMBEREYECOLOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREYECOLOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREYECOLOR", System.Data.SqlDbType.VarChar).Value = this._MEMBEREYECOLOR;
                }
                if (this._MEMBERHAIRCOLOR == null || this._MEMBERHAIRCOLOR == "" || this._MEMBERHAIRCOLOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERHAIRCOLOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERHAIRCOLOR", System.Data.SqlDbType.VarChar).Value = this._MEMBERHAIRCOLOR;
                }
                if (this._MEMBERMARITALSTATUS == null || this._MEMBERMARITALSTATUS == "" || this._MEMBERMARITALSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERMARITALSTATUS;
                }
                if (this._MEMBERCENSUSTRACT == null || this._MEMBERCENSUSTRACT == "" || this._MEMBERCENSUSTRACT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCENSUSTRACT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCENSUSTRACT", System.Data.SqlDbType.VarChar).Value = this._MEMBERCENSUSTRACT;
                }
                if (this._MEMBERCENSUSPLACE == null || this._MEMBERCENSUSPLACE == "" || this._MEMBERCENSUSPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCENSUSPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCENSUSPLACE", System.Data.SqlDbType.VarChar).Value = this._MEMBERCENSUSPLACE;
                }
                if (this._MEMBERIDMARKINGSCOMMENTS == null || this._MEMBERIDMARKINGSCOMMENTS == "" || this._MEMBERIDMARKINGSCOMMENTS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERIDMARKINGSCOMMENTS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERIDMARKINGSCOMMENTS", System.Data.SqlDbType.VarChar).Value = this._MEMBERIDMARKINGSCOMMENTS;
                }
                cmd.Parameters.Add("@ALTAHCCCSDOB", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._ALTAHCCCSDOB);
                if (this._ALTAHCCCSSSN == null || this._ALTAHCCCSSSN == "" || this._ALTAHCCCSSSN == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSSSN", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSSSN", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSSSN;
                }
                if (this._ALTAHCCCSGENDER == null || this._ALTAHCCCSGENDER == "" || this._ALTAHCCCSGENDER == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSGENDER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSGENDER", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSGENDER;
                }
                if (this._ALTAHCCCSLASTNAME == null || this._ALTAHCCCSLASTNAME == "" || this._ALTAHCCCSLASTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSLASTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSLASTNAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSLASTNAME;
                }
                if (this._ALTAHCCCSFIRSTNAME == null || this._ALTAHCCCSFIRSTNAME == "" || this._ALTAHCCCSFIRSTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSFIRSTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSFIRSTNAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSFIRSTNAME;
                }
                if (this._ALTAHCCCSMIDDLENAME == null || this._ALTAHCCCSMIDDLENAME == "" || this._ALTAHCCCSMIDDLENAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSMIDDLENAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSMIDDLENAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSMIDDLENAME;
                }
                if (this._MEMBERPHONETICCODE == null || this._MEMBERPHONETICCODE == "" || this._MEMBERPHONETICCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONETICCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONETICCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONETICCODE;
                }
                if (this._MEMBEREVSVERIFIEDFLAG == null || this._MEMBEREVSVERIFIEDFLAG == "" || this._MEMBEREVSVERIFIEDFLAG == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREVSVERIFIEDFLAG", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREVSVERIFIEDFLAG", System.Data.SqlDbType.VarChar).Value = this._MEMBEREVSVERIFIEDFLAG;
                }
                if (this._MEMBEREMPLOYERNAME == null || this._MEMBEREMPLOYERNAME == "" || this._MEMBEREMPLOYERNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBEREMPLOYERNAME;
                }
                if (this._MEMBEREMPLOYERPHONE == null || this._MEMBEREMPLOYERPHONE == "" || this._MEMBEREMPLOYERPHONE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERPHONE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERPHONE", System.Data.SqlDbType.VarChar).Value = this._MEMBEREMPLOYERPHONE;
                }
                if (this._MEMBERXIXSTATUS == null || this._MEMBERXIXSTATUS == "" || this._MEMBERXIXSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERXIXSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERXIXSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERXIXSTATUS;
                }
                cmd.Parameters.Add("@MEMBERXIXSTSDATEVERIFIED", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERXIXSTSDATEVERIFIED);
                if (this._MEMBERLEGALMHSTATUS == null || this._MEMBERLEGALMHSTATUS == "" || this._MEMBERLEGALMHSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERLEGALMHSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERLEGALMHSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERLEGALMHSTATUS;
                }
                cmd.Parameters.Add("@MEMBERCOTDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERCOTDATE);
                if (this._MEMBERNEEDFORSPCLSSASSIST == null || this._MEMBERNEEDFORSPCLSSASSIST == "" || this._MEMBERNEEDFORSPCLSSASSIST == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERNEEDFORSPCLSSASSIST", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERNEEDFORSPCLSSASSIST", System.Data.SqlDbType.VarChar).Value = this._MEMBERNEEDFORSPCLSSASSIST;
                }
                if (this._MEMBERCRISISPLANLINE1 == null || this._MEMBERCRISISPLANLINE1 == "" || this._MEMBERCRISISPLANLINE1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE1", System.Data.SqlDbType.VarChar).Value = this._MEMBERCRISISPLANLINE1;
                }
                if (this._MEMBERCRISISPLANLINE2 == null || this._MEMBERCRISISPLANLINE2 == "" || this._MEMBERCRISISPLANLINE2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE2", System.Data.SqlDbType.VarChar).Value = this._MEMBERCRISISPLANLINE2;
                }
                if (this._MEMBERRELIGIOUSPREF == null || this._MEMBERRELIGIOUSPREF == "" || this._MEMBERRELIGIOUSPREF == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERRELIGIOUSPREF", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERRELIGIOUSPREF", System.Data.SqlDbType.VarChar).Value = this._MEMBERRELIGIOUSPREF;
                }
                if (this._MEMBERPROGRAM == null || this._MEMBERPROGRAM == "" || this._MEMBERPROGRAM == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPROGRAM", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPROGRAM", System.Data.SqlDbType.VarChar).Value = this._MEMBERPROGRAM;
                }
                if (this._MEMBERSTATUS == null || this._MEMBERSTATUS == "" || this._MEMBERSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERSTATUS;
                }
                cmd.Parameters.Add("@MEMBERWAITDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERWAITDATE);
                cmd.Parameters.Add("@MEMBERENDDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERENDDATE);
                cmd.Parameters.Add("@MEMBERBRIEFDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERBRIEFDATE);
                if (this._MEMBERSUBCONTRACTOR == null || this._MEMBERSUBCONTRACTOR == "" || this._MEMBERSUBCONTRACTOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSUBCONTRACTOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSUBCONTRACTOR", System.Data.SqlDbType.VarChar).Value = this._MEMBERSUBCONTRACTOR;
                }
                cmd.Parameters.Add("@MEMBERSTARTUP", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERSTARTUP);
                if (this._MEMBERZIPCODE == null || this._MEMBERZIPCODE == "" || this._MEMBERZIPCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERZIPCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERZIPCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERZIPCODE;
                }
                if (this._MEMBERETHNICITYCODE == null || this._MEMBERETHNICITYCODE == "" || this._MEMBERETHNICITYCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERETHNICITYCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERETHNICITYCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERETHNICITYCODE;
                }
                if (this._MEMBERID2 == null || this._MEMBERID2 == "" || this._MEMBERID2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERID2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERID2", System.Data.SqlDbType.VarChar).Value = this._MEMBERID2;
                }
                if (this._MEMBERUSERID == null || this._MEMBERUSERID == "" || this._MEMBERUSERID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERUSERID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERUSERID", System.Data.SqlDbType.VarChar).Value = this._MEMBERUSERID;
                }
                cmd.Parameters.Add("@CREATEDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._CREATEDATE);
                if (this._CREATEUSER == null || this._CREATEUSER == "" || this._CREATEUSER == string.Empty)
                {
                    cmd.Parameters.Add("@CREATEUSER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CREATEUSER", System.Data.SqlDbType.VarChar).Value = this._CREATEUSER;
                }
                if (this._CREATEPLACE == null || this._CREATEPLACE == "" || this._CREATEPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@CREATEPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CREATEPLACE", System.Data.SqlDbType.VarChar).Value = this._CREATEPLACE;
                }
                cmd.Parameters.Add("@UPDATEDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._UPDATEDATE);
                if (this._UPDATEUSER == null || this._UPDATEUSER == "" || this._UPDATEUSER == string.Empty)
                {
                    cmd.Parameters.Add("@UPDATEUSER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@UPDATEUSER", System.Data.SqlDbType.VarChar).Value = this._UPDATEUSER;
                }
                if (this._UPDATEPLACE == null || this._UPDATEPLACE == "" || this._UPDATEPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@UPDATEPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@UPDATEPLACE", System.Data.SqlDbType.VarChar).Value = this._UPDATEPLACE;
                }
                if (this._EMAIL == null || this._EMAIL == "" || this._EMAIL == string.Empty)
                {
                    cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = this._EMAIL;
                }
                if (this._MEMBERMARITALSTATUS_LookupID == null || this._MEMBERMARITALSTATUS_LookupID == "" || this._MEMBERMARITALSTATUS_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = this._MEMBERMARITALSTATUS_LookupID;
                }
                if (this._MEMBERVETERANSTATUS_LookupID == null || this._MEMBERVETERANSTATUS_LookupID == "" || this._MEMBERVETERANSTATUS_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERVETERANSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERVETERANSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = this._MEMBERVETERANSTATUS_LookupID;
                }
                if (this._METHODOFCONTACT_LookupID == null || this._METHODOFCONTACT_LookupID == "" || this._METHODOFCONTACT_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@METHODOFCONTACT_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@METHODOFCONTACT_LookupID", System.Data.SqlDbType.VarChar).Value = this._METHODOFCONTACT_LookupID;
                }
                if (this._ParGurMaritalStatus == null || this._ParGurMaritalStatus == "" || this._ParGurMaritalStatus == string.Empty)
                {
                    cmd.Parameters.Add("@ParGurMaritalStatus", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ParGurMaritalStatus", System.Data.SqlDbType.VarChar).Value = this._ParGurMaritalStatus;
                }
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                if (mmID < 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", cn);
                    System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());
                    cmd2.Cancel();
                    cmd2.Dispose();
                    _mmID = ii;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.Add " + ex.ToString()));
            }
        }

        public void Update()
        {
            try
            {
                string sql = GetParameterSQL();
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@MEMBERID", System.Data.SqlDbType.Int).Value = this._MEMBERID;
                cmd.Parameters.Add("@MEMBERLASTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERLASTNAME;
                if (this._MEMBERFIRSTNAME == null || this._MEMBERFIRSTNAME == "" || this._MEMBERFIRSTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERFIRSTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERFIRSTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERFIRSTNAME;
                }
                if (this._MEMBERMIDDLENAME == null || this._MEMBERMIDDLENAME == "" || this._MEMBERMIDDLENAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMIDDLENAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMIDDLENAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERMIDDLENAME;
                }
                cmd.Parameters.Add("@MEMBERDOB", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERDOB);
                if (this._MEMBERGENDER == null || this._MEMBERGENDER == "" || this._MEMBERGENDER == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERGENDER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERGENDER", System.Data.SqlDbType.VarChar).Value = this._MEMBERGENDER;
                }
                if (this._MEMBERSSN == null || this._MEMBERSSN == "" || this._MEMBERSSN == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSSN", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSSN", System.Data.SqlDbType.VarChar).Value = this._MEMBERSSN;
                }
                if (this._MEMBERAHCCCSID == null || this._MEMBERAHCCCSID == "" || this._MEMBERAHCCCSID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAHCCCSID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAHCCCSID", System.Data.SqlDbType.VarChar).Value = this._MEMBERAHCCCSID;
                }
                if (this._MEMBERADDRESS1 == null || this._MEMBERADDRESS1 == "" || this._MEMBERADDRESS1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS1", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS1;
                }
                if (this._MEMBERADDRESS2 == null || this._MEMBERADDRESS2 == "" || this._MEMBERADDRESS2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS2", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS2;
                }
                if (this._MEMBERADDRESS3 == null || this._MEMBERADDRESS3 == "" || this._MEMBERADDRESS3 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERADDRESS3", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERADDRESS3", System.Data.SqlDbType.VarChar).Value = this._MEMBERADDRESS3;
                }
                if (this._MEMBERCROSSSTREETS == null || this._MEMBERCROSSSTREETS == "" || this._MEMBERCROSSSTREETS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCROSSSTREETS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCROSSSTREETS", System.Data.SqlDbType.VarChar).Value = this._MEMBERCROSSSTREETS;
                }
                if (this._MEMBERAREACODE1 == null || this._MEMBERAREACODE1 == "" || this._MEMBERAREACODE1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAREACODE1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAREACODE1", System.Data.SqlDbType.VarChar).Value = this._MEMBERAREACODE1;
                }
                if (this._MEMBERPHONENUMBER1 == null || this._MEMBERPHONENUMBER1 == "" || this._MEMBERPHONENUMBER1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER1", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONENUMBER1;
                }
                if (this._MEMBERAREACODE2 == null || this._MEMBERAREACODE2 == "" || this._MEMBERAREACODE2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERAREACODE2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERAREACODE2", System.Data.SqlDbType.VarChar).Value = this._MEMBERAREACODE2;
                }
                if (this._MEMBERPHONENUMBER2 == null || this._MEMBERPHONENUMBER2 == "" || this._MEMBERPHONENUMBER2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONENUMBER2", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONENUMBER2;
                }
                if (this._MEMBERPARENTNAME == null || this._MEMBERPARENTNAME == "" || this._MEMBERPARENTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTNAME;
                }
                if (this._MEMBERPARENTPHONE == null || this._MEMBERPARENTPHONE == "" || this._MEMBERPARENTPHONE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTPHONE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTPHONE", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTPHONE;
                }
                if (this._MEMBERPARENTEMAIL == null || this._MEMBERPARENTEMAIL == "" || this._MEMBERPARENTEMAIL == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPARENTEMAIL", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPARENTEMAIL", System.Data.SqlDbType.VarChar).Value = this._MEMBERPARENTEMAIL;
                }
                if (this._MEMBERHEIGHT == null || this._MEMBERHEIGHT == "" || this._MEMBERHEIGHT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERHEIGHT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERHEIGHT", System.Data.SqlDbType.VarChar).Value = this._MEMBERHEIGHT;
                }
                if (this._MEMBERWEIGHT == null || this._MEMBERWEIGHT == "" || this._MEMBERWEIGHT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERWEIGHT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERWEIGHT", System.Data.SqlDbType.VarChar).Value = this._MEMBERWEIGHT;
                }
                if (this._MEMBEREYECOLOR == null || this._MEMBEREYECOLOR == "" || this._MEMBEREYECOLOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREYECOLOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREYECOLOR", System.Data.SqlDbType.VarChar).Value = this._MEMBEREYECOLOR;
                }
                if (this._MEMBERHAIRCOLOR == null || this._MEMBERHAIRCOLOR == "" || this._MEMBERHAIRCOLOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERHAIRCOLOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERHAIRCOLOR", System.Data.SqlDbType.VarChar).Value = this._MEMBERHAIRCOLOR;
                }
                if (this._MEMBERMARITALSTATUS == null || this._MEMBERMARITALSTATUS == "" || this._MEMBERMARITALSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERMARITALSTATUS;
                }
                if (this._MEMBERCENSUSTRACT == null || this._MEMBERCENSUSTRACT == "" || this._MEMBERCENSUSTRACT == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCENSUSTRACT", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCENSUSTRACT", System.Data.SqlDbType.VarChar).Value = this._MEMBERCENSUSTRACT;
                }
                if (this._MEMBERCENSUSPLACE == null || this._MEMBERCENSUSPLACE == "" || this._MEMBERCENSUSPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCENSUSPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCENSUSPLACE", System.Data.SqlDbType.VarChar).Value = this._MEMBERCENSUSPLACE;
                }
                if (this._MEMBERIDMARKINGSCOMMENTS == null || this._MEMBERIDMARKINGSCOMMENTS == "" || this._MEMBERIDMARKINGSCOMMENTS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERIDMARKINGSCOMMENTS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERIDMARKINGSCOMMENTS", System.Data.SqlDbType.VarChar).Value = this._MEMBERIDMARKINGSCOMMENTS;
                }
                cmd.Parameters.Add("@ALTAHCCCSDOB", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._ALTAHCCCSDOB);
                if (this._ALTAHCCCSSSN == null || this._ALTAHCCCSSSN == "" || this._ALTAHCCCSSSN == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSSSN", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSSSN", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSSSN;
                }
                if (this._ALTAHCCCSGENDER == null || this._ALTAHCCCSGENDER == "" || this._ALTAHCCCSGENDER == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSGENDER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSGENDER", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSGENDER;
                }
                if (this._ALTAHCCCSLASTNAME == null || this._ALTAHCCCSLASTNAME == "" || this._ALTAHCCCSLASTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSLASTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSLASTNAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSLASTNAME;
                }
                if (this._ALTAHCCCSFIRSTNAME == null || this._ALTAHCCCSFIRSTNAME == "" || this._ALTAHCCCSFIRSTNAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSFIRSTNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSFIRSTNAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSFIRSTNAME;
                }
                if (this._ALTAHCCCSMIDDLENAME == null || this._ALTAHCCCSMIDDLENAME == "" || this._ALTAHCCCSMIDDLENAME == string.Empty)
                {
                    cmd.Parameters.Add("@ALTAHCCCSMIDDLENAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ALTAHCCCSMIDDLENAME", System.Data.SqlDbType.VarChar).Value = this._ALTAHCCCSMIDDLENAME;
                }
                if (this._MEMBERPHONETICCODE == null || this._MEMBERPHONETICCODE == "" || this._MEMBERPHONETICCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPHONETICCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPHONETICCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERPHONETICCODE;
                }
                if (this._MEMBEREVSVERIFIEDFLAG == null || this._MEMBEREVSVERIFIEDFLAG == "" || this._MEMBEREVSVERIFIEDFLAG == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREVSVERIFIEDFLAG", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREVSVERIFIEDFLAG", System.Data.SqlDbType.VarChar).Value = this._MEMBEREVSVERIFIEDFLAG;
                }
                if (this._MEMBEREMPLOYERNAME == null || this._MEMBEREMPLOYERNAME == "" || this._MEMBEREMPLOYERNAME == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERNAME", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERNAME", System.Data.SqlDbType.VarChar).Value = this._MEMBEREMPLOYERNAME;
                }
                if (this._MEMBEREMPLOYERPHONE == null || this._MEMBEREMPLOYERPHONE == "" || this._MEMBEREMPLOYERPHONE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERPHONE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBEREMPLOYERPHONE", System.Data.SqlDbType.VarChar).Value = this._MEMBEREMPLOYERPHONE;
                }
                if (this._MEMBERXIXSTATUS == null || this._MEMBERXIXSTATUS == "" || this._MEMBERXIXSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERXIXSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERXIXSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERXIXSTATUS;
                }
                cmd.Parameters.Add("@MEMBERXIXSTSDATEVERIFIED", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERXIXSTSDATEVERIFIED);
                if (this._MEMBERLEGALMHSTATUS == null || this._MEMBERLEGALMHSTATUS == "" || this._MEMBERLEGALMHSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERLEGALMHSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERLEGALMHSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERLEGALMHSTATUS;
                }
                cmd.Parameters.Add("@MEMBERCOTDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERCOTDATE);
                if (this._MEMBERNEEDFORSPCLSSASSIST == null || this._MEMBERNEEDFORSPCLSSASSIST == "" || this._MEMBERNEEDFORSPCLSSASSIST == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERNEEDFORSPCLSSASSIST", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERNEEDFORSPCLSSASSIST", System.Data.SqlDbType.VarChar).Value = this._MEMBERNEEDFORSPCLSSASSIST;
                }
                if (this._MEMBERCRISISPLANLINE1 == null || this._MEMBERCRISISPLANLINE1 == "" || this._MEMBERCRISISPLANLINE1 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE1", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE1", System.Data.SqlDbType.VarChar).Value = this._MEMBERCRISISPLANLINE1;
                }
                if (this._MEMBERCRISISPLANLINE2 == null || this._MEMBERCRISISPLANLINE2 == "" || this._MEMBERCRISISPLANLINE2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERCRISISPLANLINE2", System.Data.SqlDbType.VarChar).Value = this._MEMBERCRISISPLANLINE2;
                }
                if (this._MEMBERRELIGIOUSPREF == null || this._MEMBERRELIGIOUSPREF == "" || this._MEMBERRELIGIOUSPREF == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERRELIGIOUSPREF", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERRELIGIOUSPREF", System.Data.SqlDbType.VarChar).Value = this._MEMBERRELIGIOUSPREF;
                }
                if (this._MEMBERPROGRAM == null || this._MEMBERPROGRAM == "" || this._MEMBERPROGRAM == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERPROGRAM", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERPROGRAM", System.Data.SqlDbType.VarChar).Value = this._MEMBERPROGRAM;
                }
                if (this._MEMBERSTATUS == null || this._MEMBERSTATUS == "" || this._MEMBERSTATUS == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSTATUS", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSTATUS", System.Data.SqlDbType.VarChar).Value = this._MEMBERSTATUS;
                }
                cmd.Parameters.Add("@MEMBERWAITDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERWAITDATE);
                cmd.Parameters.Add("@MEMBERENDDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERENDDATE);
                cmd.Parameters.Add("@MEMBERBRIEFDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERBRIEFDATE);
                if (this._MEMBERSUBCONTRACTOR == null || this._MEMBERSUBCONTRACTOR == "" || this._MEMBERSUBCONTRACTOR == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERSUBCONTRACTOR", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERSUBCONTRACTOR", System.Data.SqlDbType.VarChar).Value = this._MEMBERSUBCONTRACTOR;
                }
                cmd.Parameters.Add("@MEMBERSTARTUP", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._MEMBERSTARTUP);
                if (this._MEMBERZIPCODE == null || this._MEMBERZIPCODE == "" || this._MEMBERZIPCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERZIPCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERZIPCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERZIPCODE;
                }
                if (this._MEMBERETHNICITYCODE == null || this._MEMBERETHNICITYCODE == "" || this._MEMBERETHNICITYCODE == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERETHNICITYCODE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERETHNICITYCODE", System.Data.SqlDbType.VarChar).Value = this._MEMBERETHNICITYCODE;
                }
                if (this._MEMBERID2 == null || this._MEMBERID2 == "" || this._MEMBERID2 == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERID2", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERID2", System.Data.SqlDbType.VarChar).Value = this._MEMBERID2;
                }
                if (this._MEMBERUSERID == null || this._MEMBERUSERID == "" || this._MEMBERUSERID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERUSERID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERUSERID", System.Data.SqlDbType.VarChar).Value = this._MEMBERUSERID;
                }
                cmd.Parameters.Add("@CREATEDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._CREATEDATE);
                if (this._CREATEUSER == null || this._CREATEUSER == "" || this._CREATEUSER == string.Empty)
                {
                    cmd.Parameters.Add("@CREATEUSER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CREATEUSER", System.Data.SqlDbType.VarChar).Value = this._CREATEUSER;
                }
                if (this._CREATEPLACE == null || this._CREATEPLACE == "" || this._CREATEPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@CREATEPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@CREATEPLACE", System.Data.SqlDbType.VarChar).Value = this._CREATEPLACE;
                }
                cmd.Parameters.Add("@UPDATEDATE", System.Data.SqlDbType.DateTime).Value = getDateOrNull(this._UPDATEDATE);
                if (this._UPDATEUSER == null || this._UPDATEUSER == "" || this._UPDATEUSER == string.Empty)
                {
                    cmd.Parameters.Add("@UPDATEUSER", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@UPDATEUSER", System.Data.SqlDbType.VarChar).Value = this._UPDATEUSER;
                }
                if (this._UPDATEPLACE == null || this._UPDATEPLACE == "" || this._UPDATEPLACE == string.Empty)
                {
                    cmd.Parameters.Add("@UPDATEPLACE", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@UPDATEPLACE", System.Data.SqlDbType.VarChar).Value = this._UPDATEPLACE;
                }
                if (this._EMAIL == null || this._EMAIL == "" || this._EMAIL == string.Empty)
                {
                    cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@EMAIL", System.Data.SqlDbType.VarChar).Value = this._EMAIL;
                }
                if (this._MEMBERMARITALSTATUS_LookupID == null || this._MEMBERMARITALSTATUS_LookupID == "" || this._MEMBERMARITALSTATUS_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERMARITALSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = this._MEMBERMARITALSTATUS_LookupID;
                }
                if (this._MEMBERVETERANSTATUS_LookupID == null || this._MEMBERVETERANSTATUS_LookupID == "" || this._MEMBERVETERANSTATUS_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@MEMBERVETERANSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@MEMBERVETERANSTATUS_LookupID", System.Data.SqlDbType.VarChar).Value = this._MEMBERVETERANSTATUS_LookupID;
                }
                if (this._METHODOFCONTACT_LookupID == null || this._METHODOFCONTACT_LookupID == "" || this._METHODOFCONTACT_LookupID == string.Empty)
                {
                    cmd.Parameters.Add("@METHODOFCONTACT_LookupID", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@METHODOFCONTACT_LookupID", System.Data.SqlDbType.VarChar).Value = this._METHODOFCONTACT_LookupID;
                }
                if (this._ParGurMaritalStatus == null || this._ParGurMaritalStatus == "" || this._ParGurMaritalStatus == string.Empty)
                {
                    cmd.Parameters.Add("@ParGurMaritalStatus", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@ParGurMaritalStatus", System.Data.SqlDbType.VarChar).Value = this._ParGurMaritalStatus;
                }
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                if (mmID < 1)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT @@IDENTITY", cn);
                    System.Int32 ii = Convert.ToInt32(cmd2.ExecuteScalar());
                    cmd2.Cancel();
                    cmd2.Dispose();
                    _mmID = ii;
                }
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.Update " + ex.ToString()));
            }
        }

        public void Delete()
        {
            try
            {
                string sql = "Delete from tblMemberMain WHERE mmID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = this._mmID;
                cmd.ExecuteNonQuery();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.Delete " + ex.ToString()));
            }
        }

        public void Read(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tblMemberMain WHERE mmID = @ID";
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
                throw (new Exception("tblMemberMain.Read " + ex.ToString()));
            }
        }

        public DataSet ReadAsDataSet(System.Int32 idx)
        {
            try
            {
                string sql = "Select * from tblMemberMain WHERE mmID = @ID";
                SqlConnection cn = new SqlConnection(_classDatabaseConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = idx;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "tblMemberMain");
                da.Dispose();
                cmd.Cancel();
                cmd.Dispose();
                cn.Close();
                cn.Dispose();
                return ds;
            }
            catch (Exception ex)
            {
                throw (new Exception("tblMemberMain.ReadAsDataSet " + ex.ToString()));
            }
        }

        #endregion

        #region Private Methods

        private string GetParameterSQL()
        {
            string sql = "";
            if (_mmID < 1)
            {
                sql = "INSERT INTO tblMemberMain";
                sql += "(";
                sql += "[MEMBERID], [MEMBERLASTNAME], [MEMBERFIRSTNAME], [MEMBERMIDDLENAME], [MEMBERDOB],";
                sql += "[MEMBERGENDER], [MEMBERSSN], [MEMBERAHCCCSID], [MEMBERADDRESS1], [MEMBERADDRESS2],";
                sql += "[MEMBERADDRESS3], [MEMBERCROSSSTREETS], [MEMBERAREACODE1], [MEMBERPHONENUMBER1],";
                sql += "[MEMBERAREACODE2], [MEMBERPHONENUMBER2], [MEMBERPARENTNAME], [MEMBERPARENTPHONE],";
                sql += "[MEMBERPARENTEMAIL], [MEMBERHEIGHT], [MEMBERWEIGHT], [MEMBEREYECOLOR], [MEMBERHAIRCOLOR],";
                sql += "[MEMBERMARITALSTATUS], [MEMBERCENSUSTRACT], [MEMBERCENSUSPLACE], [MEMBERIDMARKINGSCOMMENTS],";
                sql += "[ALTAHCCCSDOB], [ALTAHCCCSSSN], [ALTAHCCCSGENDER], [ALTAHCCCSLASTNAME], [ALTAHCCCSFIRSTNAME],";
                sql += "[ALTAHCCCSMIDDLENAME], [MEMBERPHONETICCODE], [MEMBEREVSVERIFIEDFLAG], [MEMBEREMPLOYERNAME],";
                sql += "[MEMBEREMPLOYERPHONE], [MEMBERXIXSTATUS], [MEMBERXIXSTSDATEVERIFIED], [MEMBERLEGALMHSTATUS],";
                sql += "[MEMBERCOTDATE], [MEMBERNEEDFORSPCLSSASSIST], [MEMBERCRISISPLANLINE1], [MEMBERCRISISPLANLINE2],";
                sql += "[MEMBERRELIGIOUSPREF], [MEMBERPROGRAM], [MEMBERSTATUS], [MEMBERWAITDATE],";
                sql += "[MEMBERENDDATE], [MEMBERBRIEFDATE], [MEMBERSUBCONTRACTOR], [MEMBERSTARTUP],";
                sql += "[MEMBERZIPCODE], [MEMBERETHNICITYCODE], [MEMBERID2], [MEMBERUSERID], [CREATEDATE],";
                sql += "[CREATEUSER], [CREATEPLACE], [UPDATEDATE], [UPDATEUSER], [UPDATEPLACE], [EMAIL],";
                sql += "[MEMBERMARITALSTATUS_LookupID], [MEMBERVETERANSTATUS_LookupID], [METHODOFCONTACT_LookupID],";
                sql += "[ParGurMaritalStatus])";
                sql += " VALUES (";
                sql += "@MEMBERID,@MEMBERLASTNAME,@MEMBERFIRSTNAME,@MEMBERMIDDLENAME,@MEMBERDOB,";
                sql += "@MEMBERGENDER,@MEMBERSSN,@MEMBERAHCCCSID,@MEMBERADDRESS1,@MEMBERADDRESS2,";
                sql += "@MEMBERADDRESS3,@MEMBERCROSSSTREETS,@MEMBERAREACODE1,@MEMBERPHONENUMBER1,";
                sql += "@MEMBERAREACODE2,@MEMBERPHONENUMBER2,@MEMBERPARENTNAME,@MEMBERPARENTPHONE,";
                sql += "@MEMBERPARENTEMAIL,@MEMBERHEIGHT,@MEMBERWEIGHT,@MEMBEREYECOLOR,@MEMBERHAIRCOLOR,";
                sql += "@MEMBERMARITALSTATUS,@MEMBERCENSUSTRACT,@MEMBERCENSUSPLACE,@MEMBERIDMARKINGSCOMMENTS,";
                sql += "@ALTAHCCCSDOB,@ALTAHCCCSSSN,@ALTAHCCCSGENDER,@ALTAHCCCSLASTNAME,@ALTAHCCCSFIRSTNAME,";
                sql += "@ALTAHCCCSMIDDLENAME,@MEMBERPHONETICCODE,@MEMBEREVSVERIFIEDFLAG,@MEMBEREMPLOYERNAME,";
                sql += "@MEMBEREMPLOYERPHONE,@MEMBERXIXSTATUS,@MEMBERXIXSTSDATEVERIFIED,@MEMBERLEGALMHSTATUS,";
                sql += "@MEMBERCOTDATE,@MEMBERNEEDFORSPCLSSASSIST,@MEMBERCRISISPLANLINE1,@MEMBERCRISISPLANLINE2,";
                sql += "@MEMBERRELIGIOUSPREF,@MEMBERPROGRAM,@MEMBERSTATUS,@MEMBERWAITDATE,@MEMBERENDDATE,";
                sql += "@MEMBERBRIEFDATE,@MEMBERSUBCONTRACTOR,@MEMBERSTARTUP,@MEMBERZIPCODE,@MEMBERETHNICITYCODE,";
                sql += "@MEMBERID2,@MEMBERUSERID,@CREATEDATE,@CREATEUSER,@CREATEPLACE,@UPDATEDATE,";
                sql += "@UPDATEUSER,@UPDATEPLACE,@EMAIL,@MEMBERMARITALSTATUS_LookupID,@MEMBERVETERANSTATUS_LookupID,";
                sql += "@METHODOFCONTACT_LookupID,@ParGurMaritalStatus)";
            }
            else
            {
                sql = "UPDATE tblMemberMain SET ";
                sql += "[MEMBERID] = @MEMBERID, [MEMBERLASTNAME] = @MEMBERLASTNAME, [MEMBERFIRSTNAME] = @MEMBERFIRSTNAME,";
                sql += "[MEMBERMIDDLENAME] = @MEMBERMIDDLENAME, [MEMBERDOB] = @MEMBERDOB, [MEMBERGENDER] = @MEMBERGENDER,";
                sql += "[MEMBERSSN] = @MEMBERSSN, [MEMBERAHCCCSID] = @MEMBERAHCCCSID, [MEMBERADDRESS1] = @MEMBERADDRESS1,";
                sql += "[MEMBERADDRESS2] = @MEMBERADDRESS2, [MEMBERADDRESS3] = @MEMBERADDRESS3, [MEMBERCROSSSTREETS] = @MEMBERCROSSSTREETS,";
                sql += "[MEMBERAREACODE1] = @MEMBERAREACODE1, [MEMBERPHONENUMBER1] = @MEMBERPHONENUMBER1,";
                sql += "[MEMBERAREACODE2] = @MEMBERAREACODE2, [MEMBERPHONENUMBER2] = @MEMBERPHONENUMBER2,";
                sql += "[MEMBERPARENTNAME] = @MEMBERPARENTNAME, [MEMBERPARENTPHONE] = @MEMBERPARENTPHONE,";
                sql += "[MEMBERPARENTEMAIL] = @MEMBERPARENTEMAIL, [MEMBERHEIGHT] = @MEMBERHEIGHT,";
                sql += "[MEMBERWEIGHT] = @MEMBERWEIGHT, [MEMBEREYECOLOR] = @MEMBEREYECOLOR, [MEMBERHAIRCOLOR] = @MEMBERHAIRCOLOR,";
                sql += "[MEMBERMARITALSTATUS] = @MEMBERMARITALSTATUS, [MEMBERCENSUSTRACT] = @MEMBERCENSUSTRACT,";
                sql += "[MEMBERCENSUSPLACE] = @MEMBERCENSUSPLACE, [MEMBERIDMARKINGSCOMMENTS] = @MEMBERIDMARKINGSCOMMENTS,";
                sql += "[ALTAHCCCSDOB] = @ALTAHCCCSDOB, [ALTAHCCCSSSN] = @ALTAHCCCSSSN, [ALTAHCCCSGENDER] = @ALTAHCCCSGENDER,";
                sql += "[ALTAHCCCSLASTNAME] = @ALTAHCCCSLASTNAME, [ALTAHCCCSFIRSTNAME] = @ALTAHCCCSFIRSTNAME,";
                sql += "[ALTAHCCCSMIDDLENAME] = @ALTAHCCCSMIDDLENAME, [MEMBERPHONETICCODE] = @MEMBERPHONETICCODE,";
                sql += "[MEMBEREVSVERIFIEDFLAG] = @MEMBEREVSVERIFIEDFLAG, [MEMBEREMPLOYERNAME] = @MEMBEREMPLOYERNAME,";
                sql += "[MEMBEREMPLOYERPHONE] = @MEMBEREMPLOYERPHONE, [MEMBERXIXSTATUS] = @MEMBERXIXSTATUS,";
                sql += "[MEMBERXIXSTSDATEVERIFIED] = @MEMBERXIXSTSDATEVERIFIED, [MEMBERLEGALMHSTATUS] = @MEMBERLEGALMHSTATUS,";
                sql += "[MEMBERCOTDATE] = @MEMBERCOTDATE, [MEMBERNEEDFORSPCLSSASSIST] = @MEMBERNEEDFORSPCLSSASSIST,";
                sql += "[MEMBERCRISISPLANLINE1] = @MEMBERCRISISPLANLINE1, [MEMBERCRISISPLANLINE2] = @MEMBERCRISISPLANLINE2,";
                sql += "[MEMBERRELIGIOUSPREF] = @MEMBERRELIGIOUSPREF, [MEMBERPROGRAM] = @MEMBERPROGRAM,";
                sql += "[MEMBERSTATUS] = @MEMBERSTATUS, [MEMBERWAITDATE] = @MEMBERWAITDATE, [MEMBERENDDATE] = @MEMBERENDDATE,";
                sql += "[MEMBERBRIEFDATE] = @MEMBERBRIEFDATE, [MEMBERSUBCONTRACTOR] = @MEMBERSUBCONTRACTOR,";
                sql += "[MEMBERSTARTUP] = @MEMBERSTARTUP, [MEMBERZIPCODE] = @MEMBERZIPCODE, [MEMBERETHNICITYCODE] = @MEMBERETHNICITYCODE,";
                sql += "[MEMBERID2] = @MEMBERID2, [MEMBERUSERID] = @MEMBERUSERID, [CREATEDATE] = @CREATEDATE,";
                sql += "[CREATEUSER] = @CREATEUSER, [CREATEPLACE] = @CREATEPLACE, [UPDATEDATE] = @UPDATEDATE,";
                sql += "[UPDATEUSER] = @UPDATEUSER, [UPDATEPLACE] = @UPDATEPLACE, [EMAIL] = @EMAIL,";
                sql += "[MEMBERMARITALSTATUS_LookupID] = @MEMBERMARITALSTATUS_LookupID, [MEMBERVETERANSTATUS_LookupID] = @MEMBERVETERANSTATUS_LookupID,";
                sql += "[METHODOFCONTACT_LookupID] = @METHODOFCONTACT_LookupID, [ParGurMaritalStatus] = @ParGurMaritalStatus";
                sql += "";
                sql += " WHERE mmID = " + _mmID.ToString();
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


}
