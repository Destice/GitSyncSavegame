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
            gitPath = gitPathBox.Text = Properties.Settings.Default.StoredGitPath;
            savePath = savePathBox.Text = Properties.Settings.Default.StoredSavePath;
        }

        private void executeCommand(string command)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine(command);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            string output = cmd.StandardOutput.ReadToEnd() + cmd.StandardError.ReadToEnd();
            statusTextBox.Text = Encoding.UTF7.GetString(Encoding.ASCII.GetBytes(output));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StoredGitPath = gitPath = gitPathBox.Text;
            Properties.Settings.Default.StoredSavePath = savePath = savePathBox.Text;
            Properties.Settings.Default.Save();

            repoName = gitPath.Split("/")[gitPath.Split("/").Length - 1]; //shitty way to take last
            statusTextBox.Text = "Saved!\nRepo name: " + repoName;
        }

        private void pullButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                gitPull = "cd " + savePath + " && cd " + repoName + " && git pull";
                executeCommand(gitPull);
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                gitPush = "cd " + savePath + " && cd " + repoName + " && git add . && git commit -m \"" + userName + "\" && git push";
                executeCommand(gitPush);
            }
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && savePath != null)
            {
                //MessageBox.Show(gitPath + "   " + savePath);
                //gitClone = "/C cd " + savePath + " && git clone " + gitPath + " && cd " + repoName + " && git init";

                gitClone = "cd " + savePath + " && git clone " + gitPath;
                executeCommand(gitClone);


                //statusTextBox.Text = "savepath: " + GitSyncSavegame.Properties.Settings.Default.StoredSavePath;
                //Properties.Settings.Default.Upgrade();
            }
        }

        private string userName;
        private string gitPath;
        private string savePath;
        private string gitPull;
        private string gitPush;
        private string gitClone;
        private string repoName;
    }
}
