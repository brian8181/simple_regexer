﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace simple_regexer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("simple_regexer.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to rgx.
        /// </summary>
        internal static string DEFAULT_EXT {
            get {
                return ResourceManager.GetString("DEFAULT_EXT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Editing..
        /// </summary>
        internal static string EDITING_EXP {
            get {
                return ResourceManager.GetString("EDITING_EXP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Editing input text..
        /// </summary>
        internal static string EDITING_INPUT {
            get {
                return ResourceManager.GetString("EDITING_INPUT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Text files *.txt|*.txt|Regex files *.rgx|*.rgx|Common *.htm *.html *.sql *.txt|*.htm*;*.html;*.sql;*.txt|All files (*.*)|*.*.
        /// </summary>
        internal static string FILE_FILTER {
            get {
                return ResourceManager.GetString("FILE_FILTER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current expression is invalid..
        /// </summary>
        internal static string INVALID_EXPRESSION {
            get {
                return ResourceManager.GetString("INVALID_EXPRESSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Matched, ready to continue..
        /// </summary>
        internal static string MATCHED {
            get {
                return ResourceManager.GetString("MATCHED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ready..
        /// </summary>
        internal static string READY_WAITING {
            get {
                return ResourceManager.GetString("READY_WAITING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Waiting for input..
        /// </summary>
        internal static string READY_WAITING_ALT1 {
            get {
                return ResourceManager.GetString("READY_WAITING_ALT1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save you current work?.
        /// </summary>
        internal static string SAVE_PROMPT {
            get {
                return ResourceManager.GetString("SAVE_PROMPT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Save work?.
        /// </summary>
        internal static string SAVE_PROMPT_CAPTION {
            get {
                return ResourceManager.GetString("SAVE_PROMPT_CAPTION", resourceCulture);
            }
        }
    }
}
