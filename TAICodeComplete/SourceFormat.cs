using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;

namespace TAICodeComplete
{
    /// <summary>
    /// Provides a base class for formatting languages similar to C.
    /// </summary>
    public abstract class CLikeFormat : CodeFormat
    {
        /// <summary>
        /// Regular expression string to match single line and multi-line 
        /// comments (// and /* */). 
        /// </summary>
        protected override string CommentRegEx
        {
            get { return @"/\*.*?\*/|//.*?(?=\r|\n)"; }
        }

        /// <summary>
        /// Regular expression string to match string and character literals. 
        /// </summary>
        protected override string StringRegEx
        {
            get { return @"@?""""|@?"".*?(?!\\).""|''|'.*?(?!\\).'"; }
        }
    }

    /// <summary>
    /// Provides a base class for formatting most programming languages.
    /// </summary>
    public abstract class CodeFormat : SourceFormat
    {
        /// <summary/>
        protected CodeFormat()
        {
            //generate the keyword and preprocessor regexes from the keyword lists
            Regex r;
            r = new Regex(@"\w+|-\w+|#\w+|@@\w+|#(?:\\(?:s|w)(?:\*|\+)?\w+)+|@\\w\*+");
            string regKeyword = r.Replace(Keywords, @"(?<=^|\W)$0(?=\W)");
            string regPreproc = r.Replace(Preprocessors, @"(?<=^|\s)$0(?=\s|$)");
            r = new Regex(@" +");
            regKeyword = r.Replace(regKeyword, @"|");
            regPreproc = r.Replace(regPreproc, @"|");

            if (regPreproc.Length == 0)
            {
                regPreproc = "(?!.*)_{37}(?<!.*)"; //use something quite impossible...
            }

            //build a master regex with capturing groups
            StringBuilder regAll = new StringBuilder();
            regAll.Append("(");
            regAll.Append(CommentRegEx);
            regAll.Append(")|(");
            regAll.Append(StringRegEx);
            if (regPreproc.Length > 0)
            {
                regAll.Append(")|(");
                regAll.Append(regPreproc);
            }
            regAll.Append(")|(");
            regAll.Append(regKeyword);
            regAll.Append(")");

            RegexOptions caseInsensitive = CaseSensitive ? 0 : RegexOptions.IgnoreCase;
            CodeRegex = new Regex(regAll.ToString(), RegexOptions.Singleline | caseInsensitive);
        }

        /// <summary>
        /// Determines if the language is case sensitive.
        /// </summary>
        /// <value><b>true</b> if the language is case sensitive, <b>false</b> 
        /// otherwise. The default is true.</value>
        /// <remarks>
        /// A case-insensitive language formatter must override this 
        /// property to return false.
        /// </remarks>
        public virtual bool CaseSensitive
        {
            get { return true; }
        }

        /// <summary>
        /// Must be overridden to provide a regular expression string
        /// to match comments. 
        /// </summary>
        protected abstract string CommentRegEx
        {
            get;
        }

        /// <summary>
        /// Must be overridden to provide a list of keywords defined in 
        /// each language.
        /// </summary>
        /// <remarks>
        /// Keywords must be separated with spaces.
        /// </remarks>
        protected abstract string Keywords
        {
            get;
        }

        /// <summary>
        /// Can be overridden to provide a list of preprocessors defined in 
        /// each language.
        /// </summary>
        /// <remarks>
        /// Preprocessors must be separated with spaces.
        /// </remarks>
        protected virtual string Preprocessors
        {
            get { return ""; }
        }

        /// <summary>
        /// Must be overridden to provide a regular expression string
        /// to match strings literals. 
        /// </summary>
        protected abstract string StringRegEx
        {
            get;
        }
        /// <summary>
        /// Called to evaluate the HTML fragment corresponding to each 
        /// matching token in the code.
        /// </summary>
        /// <param name="match">The <see cref="Match"/> resulting from a 
        /// single regular expression match.</param>
        /// <returns>A string containing the HTML code fragment.</returns>
        protected override string MatchEval(Match match)
        {
            if (match.Groups[1].Success) //comment
            {
                StringReader reader = new StringReader(match.ToString());
                string line;
                StringBuilder sb = new StringBuilder();
                while ((line = reader.ReadLine()) != null)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append("\n");
                    }
                    sb.Append("<span class=\"rem\">");
                    sb.Append(line);
                    sb.Append("</span>");
                }
                return sb.ToString();
            }
            if (match.Groups[2].Success) //string literal
            {
                return "<span class=\"str\">" + match.ToString() + "</span>";
            }
            if (match.Groups[3].Success) //preprocessor keyword
            {
                return "<span class=\"preproc\">" + match.ToString() + "</span>";
            }
            if (match.Groups[4].Success) //keyword
            {
                return "<span class=\"kwrd\">" + match.ToString() + "</span>";
            }
            System.Diagnostics.Debug.Assert(false, "None of the above!");
            return ""; //none of the above
        }
    }

    /// <summary>
    /// Generates color-coded HTML 4.01 from C# source code.
    /// </summary>
    public class CSharpFormat : CLikeFormat
    {
        /// <summary>
        /// The list of C# keywords.
        /// </summary>
        protected override string Keywords
        {
            get
            {
                return "abstract as base bool break byte case catch char "
                + "checked class const continue decimal default delegate do double else "
                + "enum event explicit extern false finally fixed float for foreach goto "
                + "if implicit in int interface internal is lock long namespace new null "
                + "object operator out override partial params private protected public readonly "
                + "ref return sbyte sealed short sizeof stackalloc static string struct "
                + "switch this throw true try typeof uint ulong unchecked unsafe ushort "
                + "using value virtual void volatile where while yield";
            }
        }

        /// <summary>
        /// The list of C# preprocessors.
        /// </summary>
        protected override string Preprocessors
        {
            get
            {
                return "#if #else #elif #endif #define #undef #warning "
                    + "#error #line #region #endregion #pragma";
            }
        }
    }

    /// <summary>
    ///	Provides a base implementation for all code formatters.
    /// </summary>
    /// <remarks>
    /// <para>
    /// To display the formatted code on your web site, the web page must 
    /// refer to a stylesheet that defines the formatting for the different 
    /// CSS classes generated by CSharpFormat:
    /// .csharpcode, pre, .rem, .kwrd, .str, .op, .preproc, .alt, .lnum.
    /// </para>
    /// <para>
    /// Note that if you have multi-line comments in your source code
    /// (like /* ... */), the "line numbers" or "alternate line background" 
    /// options will generate code that is not strictly HTML 4.01 compliant. 
    /// The code will still look good with IE5+ or Mozilla 0.8+. 
    /// </para>
    /// </remarks>
    public abstract class SourceFormat
    {
        private bool _alternate;

        private bool _embedStyleSheet;

        private bool _lineNumbers;

        private byte _tabSpaces;

        private Regex codeRegex;

        /// <summary/>
        protected SourceFormat()
        {
            _tabSpaces = 4;
            _lineNumbers = false;
            _alternate = false;
            _embedStyleSheet = false;
        }
        /// <summary>
        /// Enables or disables alternating line background.
        /// </summary>
        /// <value>When <b>true</b>, lines background is alternated. 
        /// The default is <b>false</b>.</value>
        public bool Alternate
        {
            get { return _alternate; }
            set { _alternate = value; }
        }

        /// <summary>
        /// Enables or disables the embedded CSS style sheet.
        /// </summary>
        /// <value>When <b>true</b>, the CSS &lt;style&gt; element is included 
        /// in the HTML output. The default is <b>false</b>.</value>
        public bool EmbedStyleSheet
        {
            get { return _embedStyleSheet; }
            set { _embedStyleSheet = value; }
        }

        /// <summary>
        /// Enables or disables line numbers in output.
        /// </summary>
        /// <value>When <b>true</b>, line numbers are generated. 
        /// The default is <b>false</b>.</value>
        public bool LineNumbers
        {
            get { return _lineNumbers; }
            set { _lineNumbers = value; }
        }

        /// <summary>
        /// Gets or sets the tabs width.
        /// </summary>
        /// <value>The number of space characters to substitute for tab 
        /// characters. The default is <b>4</b>, unless overridden is a 
        /// derived class.</value>
        public byte TabSpaces
        {
            get { return _tabSpaces; }
            set { _tabSpaces = value; }
        }
        /// <summary>
        /// The regular expression used to capture language tokens.
        /// </summary>
        protected Regex CodeRegex
        {
            get { return codeRegex; }
            set { codeRegex = value; }
        }

        /// <summary>
        /// Gets the CSS stylesheet as a stream.
        /// </summary>
        /// <returns>A text <see cref="Stream"/> of the CSS definitions.</returns>
        public static Stream GetCssStream()
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream(
                "Manoli.Utils.CSharpFormat.csharp.css");
        }

        /// <summary>
        /// Gets the CSS stylesheet as a string.
        /// </summary>
        /// <returns>A string containing the CSS definitions.</returns>
        public static string GetCssString()
        {
            StreamReader reader = new StreamReader(GetCssStream());
            return reader.ReadToEnd();
        }

        /// <overloads>Transform source code to HTML 4.01.</overloads>
        /// 
        /// <summary>
        /// Transforms a source code stream to HTML 4.01.
        /// </summary>
        /// <param name="source">Source code stream.</param>
        /// <returns>A string containing the HTML formatted code.</returns>
        public string FormatCode(Stream source)
        {
            StreamReader reader = new StreamReader(source);
            string s = reader.ReadToEnd();
            reader.Close();
            return FormatCode(s, _lineNumbers, _alternate, _embedStyleSheet, false);
        }

        /// <summary>
        /// Transforms a source code string to HTML 4.01.
        /// </summary>
        /// <returns>A string containing the HTML formatted code.</returns>
        public string FormatCode(string source)
        {
            return FormatCode(source, _lineNumbers, _alternate, _embedStyleSheet, false);
        }

        /// <summary>
        /// Allows formatting a part of the code in a different language,
        /// for example a JavaScript block inside an HTML file.
        /// </summary>
        public string FormatSubCode(string source)
        {
            return FormatCode(source, false, false, false, true);
        }
        /// <summary>
        /// Called to evaluate the HTML fragment corresponding to each 
        /// matching token in the code.
        /// </summary>
        /// <param name="match">The <see cref="Match"/> resulting from a 
        /// single regular expression match.</param>
        /// <returns>A string containing the HTML code fragment.</returns>
        protected abstract string MatchEval(Match match);

        //does the formatting job
        private string FormatCode(string source, bool lineNumbers,
            bool alternate, bool embedStyleSheet, bool subCode)
        {
            //replace special characters
            StringBuilder sb = new StringBuilder(source);

            if (!subCode)
            {
                sb.Replace("&", "&amp;");
                sb.Replace("<", "&lt;");
                sb.Replace(">", "&gt;");
                sb.Replace("\t", string.Empty.PadRight(_tabSpaces));
            }

            //color the code
            source = codeRegex.Replace(sb.ToString(), new MatchEvaluator(this.MatchEval));

            sb = new StringBuilder();

            if (embedStyleSheet)
            {
                sb.Append("<style type=\"text/css\">\n");
                sb.Append(GetCssString());
                sb.Append("</style>\n");
            }

            if (lineNumbers || alternate) //we have to process the code line by line
            {
                if (!subCode)
                    sb.Append("<div class=\"csharpcode\">\n");
                StringReader reader = new StringReader(source);
                int i = 0;
                string spaces = "    ";
                int order;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    i++;
                    if (alternate && ((i % 2) == 1))
                    {
                        sb.Append("<pre class=\"alt\">");
                    }
                    else
                    {
                        sb.Append("<pre>");
                    }

                    if (lineNumbers)
                    {
                        order = (int)Math.Log10(i);
                        sb.Append("<span class=\"lnum\">"
                            + spaces.Substring(0, 3 - order) + i.ToString()
                            + ":  </span>");
                    }

                    if (line.Length == 0)
                        sb.Append("&nbsp;");
                    else
                        sb.Append(line);
                    sb.Append("</pre>\n");
                }
                reader.Close();
                if (!subCode)
                    sb.Append("</div>");
            }
            else
            {
                //have to use a <pre> because IE below ver 6 does not understand 
                //the "white-space: pre" CSS value
                if (!subCode)
                    sb.Append("<pre class=\"csharpcode\">\n");
                sb.Append(source);
                if (!subCode)
                    sb.Append("</pre>");
            }

            return sb.ToString();
        }

    }
}
