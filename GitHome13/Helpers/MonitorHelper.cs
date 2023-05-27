using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;
using WindowsInput;

namespace GitHome13.Helpers
{
    internal class MonitorHelper
    {
        public static void MoveToRightMon()
        {
            var keysSimulator = new InputSimulator();
            keysSimulator.Keyboard.ModifiedKeyStroke(new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.LWIN }, VirtualKeyCode.RIGHT);
        }
    }
}
