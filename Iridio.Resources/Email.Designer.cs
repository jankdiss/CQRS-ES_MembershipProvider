﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Iridio.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Email {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Email() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Iridio.Resources.Email", typeof(Email).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Congratulations&lt;/p&gt;
        ///&lt;p&gt;You have created your account on Sample&apos;s website&lt;/p&gt;.
        /// </summary>
        public static string RegisterCongratulationsBody {
            get {
                return ResourceManager.GetString("RegisterCongratulationsBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your account on Sample&apos;s website have been created successfully.
        /// </summary>
        public static string RegisterCongratulationsSubject {
            get {
                return ResourceManager.GetString("RegisterCongratulationsSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;to follow your new password&lt;/p&gt;
        ///&lt;p&gt;Password: {0}&lt;/p&gt;
        ///&lt;p&gt;We suggest you to change it as soon as possible&lt;/p&gt;.
        /// </summary>
        public static string ResetPasswordConfirmationBody {
            get {
                return ResourceManager.GetString("ResetPasswordConfirmationBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Change password confirmation.
        /// </summary>
        public static string ResetPasswordConfirmationSubject {
            get {
                return ResourceManager.GetString("ResetPasswordConfirmationSubject", resourceCulture);
            }
        }
    }
}
