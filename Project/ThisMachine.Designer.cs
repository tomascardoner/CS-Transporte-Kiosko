﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSTransporteKiosk {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.1.0.0")]
    internal sealed partial class ThisMachine : global::System.Configuration.ApplicationSettingsBase {
        
        private static ThisMachine defaultInstance = ((ThisMachine)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ThisMachine())));
        
        public static ThisMachine Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public int LugarID {
            get {
                return ((int)(this["LugarID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public byte EmpresaID {
            get {
                return ((byte)(this["EmpresaID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string DatabaseDatasource {
            get {
                return ((string)(this["DatabaseDatasource"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("CSTransporte_DelSurBus")]
        public string DatabaseDatabase {
            get {
                return ((string)(this["DatabaseDatabase"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("cstransportekiosk")]
        public string DatabaseUserID {
            get {
                return ((string)(this["DatabaseUserID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("IdcBT5Ecsf4FjrfMtH0YJ4a0L+vIV1iSGkzY30U9akZI28ZlNBx/Z+kPDNsDs+C6")]
        public string DatabasePassword {
            get {
                return ((string)(this["DatabasePassword"]));
            }
        }
    }
}
