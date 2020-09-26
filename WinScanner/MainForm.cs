using System;
using System.Windows.Forms;

namespace WinScanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Add tabs for each module
            LocalSecurityGroupPolicy localSecurityGroupPolicy = new LocalSecurityGroupPolicy(tabView);
            System32 system32 = new System32(tabView);
            FileScanner fileScanner = new FileScanner(tabView);
        }
    }
}
