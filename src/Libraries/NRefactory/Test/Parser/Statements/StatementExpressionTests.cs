// <file>
//     <copyright see="prj:///doc/copyright.txt">2002-2005 AlphaSierraPapa</copyright>
//     <license see="prj:///doc/license.txt">GNU General Public License</license>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.IO;
using MbUnit.Framework;
using ICSharpCode.NRefactory.Parser;
using ICSharpCode.NRefactory.Parser.AST;

namespace ICSharpCode.NRefactory.Tests.AST
{
	[TestFixture]
	public class StatementExpressionTests
	{
		#region C#
		[Test]
		public void CSharpStatementExpressionTest()
		{
			StatementExpression stmtExprStmt = (StatementExpression)ParseUtilCSharp.ParseStatment("my.Obj.PropCall;", typeof(StatementExpression));
			Assert.IsTrue(stmtExprStmt.Expression is FieldReferenceExpression);
		}
		[Test]
		public void CSharpStatementExpressionTest1()
		{
			StatementExpression stmtExprStmt = (StatementExpression)ParseUtilCSharp.ParseStatment("yield.yield;", typeof(StatementExpression));
			Assert.IsTrue(stmtExprStmt.Expression is FieldReferenceExpression);
		}
		#endregion
		
		#region VB.NET
			// TODO
		#endregion 
	}
}
