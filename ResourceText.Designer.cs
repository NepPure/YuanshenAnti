﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YuanshenAnti {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceText() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("YuanshenAnti.ResourceText", typeof(ResourceText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 {&quot;remoteName&quot;: &quot;blocks/00/22551915.blk&quot;, &quot;md5&quot;: &quot;0cf3d6b599d443c7cfa4a3e6189a7757&quot;, &quot;fileSize&quot;: 3184}
        ///{&quot;remoteName&quot;: &quot;blocks/00/25060239.blk&quot;, &quot;md5&quot;: &quot;f3cf18d697e3380b2f833ccf2c7d4194&quot;, &quot;fileSize&quot;: 3328}
        ///{&quot;remoteName&quot;: &quot;blocks/00/32070509.blk&quot;, &quot;md5&quot;: &quot;07255cf80c8774efc06c7522b622c4e1&quot;, &quot;fileSize&quot;: 1021}
        ///{&quot;remoteName&quot;: &quot;blocks/00/33067900.blk&quot;, &quot;md5&quot;: &quot;0b4d781c1633537d2fa4b4f0f567d2ca&quot;, &quot;fileSize&quot;: 454} 的本地化字符串。
        /// </summary>
        internal static string silence_data_versions_persist {
            get {
                return ResourceManager.GetString("silence_data_versions_persist", resourceCulture);
            }
        }
    }
}