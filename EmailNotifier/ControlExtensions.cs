using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailNotifier
{
    public static class ControlExtensions
    {
        public static void CrossThreadUpdate(this Control control, Action action)
        {
            if (control.InvokeRequired) control.BeginInvoke(action);
            else action();

        }
    }
}
