using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAICodeComplete
{
    public class Field
    {
        public bool AllowNulls = false;
        public string FieldName = "";
        public string FieldNameConverted = "";
        public string FieldType = "";
        public bool IsIdentity = false;
        public int MaxLength = 0;
        public int Precision = 0;
        public int Scale = 0;
        public bool CROSSWALK = false;
        public string CROSSWALKTABLE = "";
        public string CROSSWALKVALUE = "";
        public string CROSSWALKDISPLAY = "";
        public Field()
        {

        }

        public Field(string fname, string ftype, int maxlen, bool nulls, bool identity,int precision, int scale)
        {
            FieldName = fname;
            FieldNameConverted = fname.Replace(" ", "_");
            FieldType = ftype;
            MaxLength = maxlen;
            AllowNulls = nulls;
            IsIdentity = identity;
            Precision = precision;
            Scale = scale;
            CROSSWALK = false;
            CROSSWALKTABLE = "";
            CROSSWALKVALUE = "";
            CROSSWALKDISPLAY = "";
        }

        public Field(string fname, string ftype, int maxlen, bool nulls, bool identity, int precision, int scale,bool crw, string crt, string crv, string crd)
        {
            FieldName = fname;
            FieldNameConverted = fname.Replace(" ", "_");
            FieldType = ftype;
            MaxLength = maxlen;
            AllowNulls = nulls;
            IsIdentity = identity;
            Precision = precision;
            Scale = scale;
            CROSSWALK = crw;
            CROSSWALKTABLE = crt;
            CROSSWALKVALUE = crv;
            CROSSWALKDISPLAY = crd;
        }

    }
}
