/*
 * Created by SharpDevelop.
 * User: jkuehner
 * Date: 05/05/2014
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace SearchAndReplace.Gui
{
	/// <summary>
	/// Interaction logic for SearchAndReplaceDialog.xaml
	/// </summary>
	public partial class SearchAndReplaceDialog
	{
		static SearchAndReplaceDialog Instance;
		
		public static void ShowSingleInstance(SearchAndReplaceMode searchAndReplaceMode)
		{
			if (Instance == null) {
				Instance = new SearchAndReplaceDialog(searchAndReplaceMode);
				//Instance.Owner = SD.
				Instance.Show();
				//Instance.Show(SD.WinForms.MainWin32Window);
			} else {
				if (searchAndReplaceMode == SearchAndReplaceMode.Search) {
					Instance.searchButton.PerformClick();
				} else {
					Instance.replaceButton.PerformClick();
				}
				Instance.Focus();
			}
		}
		
		public SearchAndReplaceDialog(SearchAndReplaceMode searchAndReplaceMode)
		{
			InitializeComponent();
		}
	}
}