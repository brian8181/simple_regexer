using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace simple_regexer
{
    /// <summary>
    /// the document
    /// </summary>
    public class Document
    {
        private FileInfo fi = null; 
        private RichTextBox exp =  null;
        private RichTextBox input = null;

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return fi.Name;
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
        /// <param name="path"></param>
        public void Open( string path )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Save()
        {
            exp.Modified = false;
            input.Modified = false;
        }
     
    }
}
