using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Aga.Controls.Tree
{
	public interface ITreeModel
	{
		IEnumerable GetChildren(TreePath treePath);
		bool IsLeaf(TreePath treePath);
	}
}
