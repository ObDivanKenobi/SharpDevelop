﻿// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System.Security.Cryptography;
using System.Windows;

namespace ICSharpCode.WpfDesign.XamlDom
{
	/// <summary>
	/// Helper Class for the Markup Compatibility Properties used by VS and Blend
	/// </summary>
    public class XamlNamespaceProperties : FrameworkElement
	{
		#region Class

		/// <summary>
        /// Getter for the <see cref="ClassProperty"/>
		/// </summary>
		public static string GetClass(DependencyObject obj)
		{
			return (string)obj.GetValue(ClassProperty);
		}

		/// <summary>
        /// Setter for the <see cref="ClassProperty"/>
		/// </summary>
		public static void SetClass(DependencyObject obj, string value)
		{
            obj.SetValue(ClassProperty, value);
		}

		/// <summary>
		/// Class-Name
		/// </summary>
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.RegisterAttached("Class", typeof(string), typeof(XamlNamespaceProperties));
		
		#endregion
	}
}
