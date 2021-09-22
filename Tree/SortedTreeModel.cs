using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Aga.Controls.Tree
{
	public class SortedTreeModel: TreeModelBase
	{
		private ITreeModel _innerModel;
		public ITreeModel InnerModel
		{
			get { return _innerModel; }
		}

		private IComparer _comparer;
		public IComparer Comparer
		{
			get { return _comparer; }
			set 
			{ 
				_comparer = value;
				OnStructureChanged(new TreePathEventArgs(TreePath.Empty));
			}
		}

		public SortedTreeModel(ITreeModel innerModel)
		{
			_innerModel = innerModel;
		}

		public override IEnumerable GetChildren(TreePath treePath)
		{
			if (Comparer != null)
			{
				ArrayList list = new ArrayList();
				IEnumerable res = InnerModel.GetChildren(treePath);
				if (res != null)
				{
					foreach (object obj in res)
						list.Add(obj);
					list.Sort(Comparer);
					return list;
				}
				else
					return null;
			}
			else
				return InnerModel.GetChildren(treePath);
		}

		public override bool IsLeaf(TreePath treePath)
		{
			return InnerModel.IsLeaf(treePath);
		}
	}
}
