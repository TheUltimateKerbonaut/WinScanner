using System;
using System.Windows.Forms;

namespace WinScanner
{
    class LocalSecurityGroupPolicy : Scan
    {
        public LocalSecurityGroupPolicy(TabControl tabView) : base(tabView, "Local Security Group Policy", 
            "Enumerates through entires in the local security group policy, fixing configuration issues. In\n" +
            "case an error is made, a backup of previous configurations is stored in WinScanner's backup\n" +
            "folder.", 
            WinScanner.Properties.Resources.LocalSecurityGroupPolicy)
        {
            
        }

        public override void OnScan(object sender, EventArgs e)
        {
            MessageBox.Show("help me");
        }
    }
}
