﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1313
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWord2007Addin {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestWord2007Addin.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;customUI xmlns=&quot;http://schemas.microsoft.com/office/2006/01/customui&quot; &gt;
        ///	&lt;ribbon&gt;
        ///		&lt;tabs&gt;
        ///			&lt;tab idMso=&quot;TabAddIns&quot;&gt;
        ///				&lt;group id=&quot;testAddinGroup&quot; label=&quot;TestAddin&quot;&gt;
        ///					&lt;toggleButton id=&quot;taskPaneToggle&quot;
        ///								  label=&quot;TaskPane&quot;
        ///								  imageMso=&quot;ControlLayoutStacked&quot;
        ///								  size=&quot;large&quot;
        ///								  onAction=&quot;OnTaskPaneToggle&quot; /&gt;
        ///				&lt;/group&gt;
        ///			&lt;/tab&gt;
        ///		&lt;/tabs&gt;
        ///	&lt;/ribbon&gt;
        ///&lt;/customUI&gt;
        ///.
        /// </summary>
        internal static string RibbonX {
            get {
                return ResourceManager.GetString("RibbonX", resourceCulture);
            }
        }
    }
}