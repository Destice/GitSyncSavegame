using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitSyncSavegame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            gitPath = gitPathBox.Text;
            savePath = savePathBox.Text;
        }
        private String userName;
        private String gitPath;
        private String savePath;
        private String gitPull;
        private String gitPush;
        private String gitClone;
        private String gitInit;

        private void pullButton_Click(object sender, EventArgs e)
        {
            if (gitPath.Length > 0 && savePath.Length > 0)
                gitPull = "cd " + savePath + "; git pull";
            System.Diagnostics.Process.Start("CMD.exe", gitPull);
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (gitPath.Length > 0 && savePath.Length > 0)
                gitPush = "cd " + savePath + "; git add .; git commit -m \"" + userName + "\"; git push";
            System.Diagnostics.Process.Start("CMD.exe", gitPush);
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (gitPath.Length > 0 && savePath.Length > 0)
                gitPush = "cd " + savePath + "; git add .; git commit -m \"" + userName + "\"; git push";
        }

        private void initButton_Click(object sender, EventArgs e)
        {

        }
    }
}
