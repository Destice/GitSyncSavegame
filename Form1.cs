using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            repoName = gitPathBox.Text.Split("/")[gitPathBox.Text.Split("/").Length-1]; //shitty way to take last
            MessageBox.Show(repoName);
        }
        private string userName;
        private string gitPath;
        private string savePath;
        private string gitPull;
        private string gitPush;
        private string gitClone;
        private string repoName;

        private void pullButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                gitPull = "/C cd " + savePath + " && cd " + repoName + " && git pull";
                System.Diagnostics.Process.Start("CMD.exe", gitPull);
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                gitPush = "/C cd " + savePath + " && cd " + repoName + " && git add . && git commit -m \"" + userName + "\" && git push";
                System.Diagnostics.Process.Start("CMD.exe", gitPush);
            }
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                //MessageBox.Show(gitPath + "   " + savePath);
                gitClone = "/C cd " + savePath + " && git clone " + gitPath + " && cd " + repoName + " && git init";

                

                //Process cmd = new Process();
                //cmd.StartInfo.FileName = "cmd.exe";
                //cmd.StartInfo.RedirectStandardInput = true;
                //cmd.StartInfo.RedirectStandardOutput = true;
                //cmd.StartInfo.CreateNoWindow = true;
                //cmd.StartInfo.UseShellExecute = false;
                //cmd.Start();

                //cmd.StandardInput.WriteLine("cd " + savePath + "; git clone " + gitPath);
                //cmd.StandardInput.Flush();
                //cmd.StandardInput.Close();
                //cmd.WaitForExit();
                //MessageBox.Show(cmd.StandardOutput.ReadToEnd());

                System.Diagnostics.Process.Start("CMD.exe", gitClone);
                GitSyncSavegame.Properties.Settings.Default.StoredGitPath = gitPath;
                GitSyncSavegame.Properties.Settings.Default.StoredSavePath = gitPath;
                GitSyncSavegame.Properties.Settings.Default.Save();
            }
        }
    }
}
