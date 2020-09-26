using System;
using System.Windows.Forms;

namespace WinScanner
{
    class System32 : Scan
    {

        public System32(TabControl tabView) : base(tabView, "System 32 Files",
            "Looks through files and folders in System32, comparing names to a wordlist. In theory, this\n" +
            "should find potentially unwanted programs and/or folders. Useful for detecting malware.",
            WinScanner.Properties.Resources.System32)
        {

        }

        public override void OnScan(object sender, EventArgs e)
        {
            MessageBox.Show("don't me");
        }

    }
}
