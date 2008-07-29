using System;
using System.Collections.Generic;
using System.Text;

namespace ReallySimpleRegEx.Properties
{
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
    {
        private static Settings unsavedCopy = ( (Settings)( global::System.Configuration.ApplicationSettingsBase.Synchronized( new Settings() ) ) );

        public static void SyncSettings()
        {
            defaultInstance = Current;
        }

        public static Settings Current
        {
            get
            {
                return unsavedCopy;
            }
            set
            {
                unsavedCopy = value;
            }
        }
    }
}