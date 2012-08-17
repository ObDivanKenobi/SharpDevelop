﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Linq;

using SD = ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.PackageManagement.EnvDTE
{
	public class Globals
	{
		SolutionExtensibilityGlobals extensibilityGlobals;
		SolutionExtensibilityGlobalsPersistence extensibilityGlobalsPersistence;
		
		public Globals(Solution solution)
		{
			this.extensibilityGlobals = new SolutionExtensibilityGlobals(solution);
			this.extensibilityGlobalsPersistence = new SolutionExtensibilityGlobalsPersistence(extensibilityGlobals);
		}
		
		public virtual SolutionExtensibilityGlobals VariableValue {
			get { return extensibilityGlobals; }
		}
		
		public virtual SolutionExtensibilityGlobalsPersistence VariablePersists {
			get { return extensibilityGlobalsPersistence; }
		}
		
		public virtual bool VariableExists(string name)
		{
			return extensibilityGlobals.ItemExists(name);
		}
	}
}
