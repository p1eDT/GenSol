using WindowsInput.Native;
using WindowsInput;

namespace _Core.Helpers
{
    public class MonitorHelper
    {
        public static void MoveToRightMon()
        {
            var keysSimulator = new InputSimulator();
            keysSimulator.Keyboard.ModifiedKeyStroke(new[] { VirtualKeyCode.SHIFT, VirtualKeyCode.LWIN }, VirtualKeyCode.RIGHT);
        }
    }
}
