﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.WebJobs.Script.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.WebJobs.Script.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Your function must contain a single public method, a public method named &apos;Run&apos;, or a public method matching the name specified in the &apos;entryPoint&apos; metadata property..
        /// </summary>
        internal static string DotNetFunctionEntryPointRulesMessage {
            get {
                return ResourceManager.GetString("DotNetFunctionEntryPointRulesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of id property in extensionBundle section of {0} file is invalid or missing. See https://aka.ms/functions-hostjson for more information.
        /// </summary>
        internal static string ExtensionBundleConfigMissingId {
            get {
                return ResourceManager.GetString("ExtensionBundleConfigMissingId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The id and version property are missing in extensionBundle section of {0} file. See https://aka.ms/functions-hostjson for more information&quot;.
        /// </summary>
        internal static string ExtensionBundleConfigMissingMessage {
            get {
                return ResourceManager.GetString("ExtensionBundleConfigMissingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value of version property in extensionBundle section of {0} file is invalid or missing. See https://aka.ms/functions-hostjson for more information.
        /// </summary>
        internal static string ExtensionBundleConfigMissingVersion {
            get {
                return ResourceManager.GetString("ExtensionBundleConfigMissingVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Starting language worker channel specialization.
        /// </summary>
        internal static string LanguageWorkerChannelSpecializationTrace {
            get {
                return ResourceManager.GetString("LanguageWorkerChannelSpecializationTrace", resourceCulture);
            }
        }
    }
}
