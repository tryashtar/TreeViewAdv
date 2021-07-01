using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Aga.Controls.Tree
{
	public class ImprovedTooltip : ToolTip
	{
		public ImprovedTooltip()
        {
			this.AutoPopDelay = 100000;
        }
	}
}
