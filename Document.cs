using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace simple_regexer
{
    /// <summary>
    /// the document
    /// </summary>
    public class Document
    {
        public event EventHandler StatusChanged;
        private FileInfo fi = null; 
        private RichTextBox exp =  null;
        private RichTextBox input = null;
        private bool changed_once;
       
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                if(fi != null)
                    return fi.Name;
                else
                    return "New";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool isDirty
        {
            get
            {
                if(exp.Modified || input.Modified)
                    return true;
                return false;
            }
            set
            {
                exp.Modified = value;
                input.Modified = value;
                changed_once = value;
                OnStatusChanged();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exp"></param>
        /// <param name="input"></param>
        public Document( RichTextBox exp, RichTextBox input )
        {
            this.exp = exp;
            this.input = input;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void input_ModifiedChanged( object sender, EventArgs e )
        {
            if(changed_once == false)
            {
                OnStatusChanged();
                changed_once = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void exp_ModifiedChanged( object sender, EventArgs e )
        {
            if(changed_once == false)
            {
                OnStatusChanged();
                changed_once = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Open( string path )
        {
            fi = new FileInfo( path );
            Open( fi );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fi"></param>
        public void Open( FileInfo fi )
        {
            this.fi = fi;
            isDirty = false;

            exp.ModifiedChanged += new EventHandler( exp_ModifiedChanged );
            input.ModifiedChanged += new EventHandler( input_ModifiedChanged );
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Read()
        {
            if(fi != null && fi.Exists)
            {
                if(fi.Extension == ".rgx")
                {
                    StreamReader sr = fi.OpenText();
                    XmlTextReader reader = new XmlTextReader( sr );
                    
                    reader.Read();
                    reader.Read();
                    reader.Read();
                    reader.Read();

                    exp.Text = reader.ReadContentAsString();

                    reader.Read();
                    reader.Read();

                    input.Rtf = reader.ReadContentAsString();
                }
                else
                {
                    exp.Text = File.ReadAllText( fi.FullName );
                }
            }
            isDirty = false;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Write()
        {
            if(fi.Extension == ".rgx")
            {
                StreamWriter sw = fi.CreateText();
                XmlTextWriter writer = new XmlTextWriter( sw );
                writer.WriteStartDocument();
                writer.WriteStartElement( "REGX" );
                writer.WriteStartElement( "Expression" );
                writer.WriteString( exp.Text );
                writer.WriteEndElement();
                writer.WriteStartElement( "Input" );
                writer.WriteString( input.Rtf );
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                File.WriteAllText( fi.FullName, exp.Text );
            }
            isDirty = false;
        }
        /// <summary>
        /// 
        /// </summary>
        protected void OnStatusChanged()
        {
            if( StatusChanged != null )
                StatusChanged( this, EventArgs.Empty );
        }
    }
}