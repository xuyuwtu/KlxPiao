﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlxPiaoDemo.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KlxPiaoDemo.Properties.Resources", typeof(Resources).Assembly);
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
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        internal static System.Drawing.Bitmap TestImage {
            get {
                object obj = ResourceManager.GetObject("TestImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 using System.ComponentModel;
        ///
        ///namespace {命名空间}
        ///{
        ///    [Serializable]
        ///    [TypeConverter(typeof({转换器名称}))]
        ///    public struct {结构名称}
        ///    {
        ///        public {元素类型} TopLeft { get; set; }
        ///        public {元素类型} TopRight { get; set; }
        ///        public {元素类型} BottomRight { get; set; }
        ///        public {元素类型} BottomLeft { get; set; }
        ///
        ///        public {结构名称}() { }
        ///
        ///        public {结构名称}({元素类型} uniform)
        ///        {
        ///            TopLeft = TopRight = BottomRight = BottomLeft = uniform;
        ///        }
        ///
        ///        public [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string 结构 {
            get {
                return ResourceManager.GetString("结构", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 using System.Collections;
        ///using System.ComponentModel;
        ///using System.ComponentModel.Design.Serialization;
        ///using System.Globalization;
        ///
        ///namespace {命名空间}
        ///{
        ///    /// &lt;summary&gt;提供了一种类型转换器，用于将 &lt;see cref=&quot;{结构名称}&quot; /&gt; 值与其他各种表示形式进行转换。&lt;/summary&gt;
        ///    public class {转换器名称} : TypeConverter
        ///    {
        ///
        ///#pragma warning disable CS8765 // 参数类型的为 Null 性与重写成员不匹配(可能是由于为 Null 性特性)。
        ///#pragma warning disable CA2208 // 正确实例化参数异常
        ///#pragma warning disable CS8604 // 引用类型参数可能为 null。
        ///#pragma warning disable CS8601 // 引用类型赋值可能为 null。 [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string 转换器 {
            get {
                return ResourceManager.GetString("转换器", resourceCulture);
            }
        }
    }
}
