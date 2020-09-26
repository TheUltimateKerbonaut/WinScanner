using System;
using System.Windows.Forms;

namespace WinScanner
{
    class FileScanner : Scan
    {

        public FileScanner(TabControl tabView) : base(tabView, "Potentially unwanted files",
            "Looks through files and folders on the system, highlighting files with media extensions\n" +
            "such as png, jpg, and mp4.",
            WinScanner.Properties.Resources.FileScanner)
        {

        }

        public override void OnScan(object sender, EventArgs e)
        {
            MessageBox.Show("don't don't me");
        }

    }
}
