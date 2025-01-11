using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceWF.CustomComponents
{
    internal class CustomListviewItem : ListViewItem
    {
        public override string ToString()
        {
            return base.Text;
        }
    }
}
