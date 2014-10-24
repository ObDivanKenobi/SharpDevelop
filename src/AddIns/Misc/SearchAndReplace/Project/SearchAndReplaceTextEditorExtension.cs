// Copyright (c) 2014 AlphaSierraPapa for the SharpDevelop Team
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
using System;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Search;
using ICSharpCode.SharpDevelop.Editor;

namespace SearchAndReplace
{
	/// <summary>
	/// Description of SearchAndReplaceTextEditorExtension.
	/// </summary>
	public class SearchAndReplaceTextEditorExtension : ITextEditorExtension
	{
		SearchPanel panel;
		
		public void Attach(ITextEditor editor)
		{
			TextArea textArea = editor.GetService(typeof(TextArea)) as TextArea;
			if (textArea != null) {
				panel = SearchPanel.Install(textArea);
				panel.SearchOptionsChanged += SearchOptionsChanged;
			}
		}

		void SearchOptionsChanged(object sender, SearchOptionsChangedEventArgs e)
		{
			SearchOptions.CurrentFindPattern = e.SearchPattern;
			SearchOptions.MatchCase = e.MatchCase;
			SearchOptions.MatchWholeWord = e.WholeWords;
			SearchOptions.SearchMode = e.UseRegex ? SearchMode.RegEx : SearchMode.Normal;
		}
		
		public void Detach()
		{
			if (panel != null) {
				panel.SearchOptionsChanged -= SearchOptionsChanged;
				panel.Uninstall();
				panel = null;
			}
		}
	}
}
