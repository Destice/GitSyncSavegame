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
            gameSaveFilesPath = gameSaveFilesPathBox.Text = Properties.Settings.Default.StoredGameSaveFilesPath;
            syncedFilePath = syncedFilePathBox.Text = Properties.Settings.Default.StoredSyncedFilePath;
            repoName = gitPath.Split("/")[gitPath.Split("/").Length - 1];
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
            Properties.Settings.Default.StoredGameSaveFilesPath = gameSaveFilesPath = gameSaveFilesPathBox.Text;
            Properties.Settings.Default.StoredSyncedFilePath = syncedFilePath = syncedFilePathBox.Text;
            Properties.Settings.Default.Save();

            repoName = gitPath.Split("/")[gitPath.Split("/").Length - 1]; //shitty way to take last
            statusTextBox.Text = "Saved!\nRepo name: " + repoName;
        }

        private void pullButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && gameSaveFilesPath != null)
            {
                gitPull = "cd " + gameSaveFilesPath + " && git pull";
                executeCommand(gitPull);
            }
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && gameSaveFilesPath != null)
            {
                gitPush = "cd " + gameSaveFilesPath + " && cd " + syncedFilePath + " && git add . && git commit -m \"" + userName + "\" && git push";
                executeCommand(gitPush);
            }
        }

        private void cloneButton_Click(object sender, EventArgs e)
        {
            if (gitPath != null && gameSaveFilesPath != null)
            {
                //MessageBox.Show(gitPath + "   " + gameSaveFilesPath);
                //gitClone = "/C cd " + gameSaveFilesPath + " && git clone " + gitPath + " && cd " + repoName + " && git init";

                //gitClone = "/K cd " + gameSaveFilesPath + " && del /f savegame3 && git clone " + gitPath;// + " && cd " + repoName + " && git init";
                //string addOrigin = "/K cd " + gameSaveFilesPath + " && cd " + repoName +
                //    " && del /F /Q savegame3 && git init && git remote add origin " + gitPath;
                //System.Diagnostics.Process.Start("CMD.exe", addOrigin);

                //string pull = "/C git pull";
                //System.Diagnostics.Process.Start("CMD.exe", pull);

                //string checkout = "/C git checkout main -f && git pull && git branch --set-upstream-to origin/main";
                //System.Diagnostics.Process.Start("CMD.exe", checkout);

                gitClone = "cd " + gameSaveFilesPath +
                    " && del /F /Q savegame3 && del /F /Q .git && git init && git remote add origin " + gitPath +
                    " && git pull & git checkout main -f && git branch --set-upstream-to origin/main";// + " && cd " + repoName + " && git init";
                //System.Diagnostics.Process.Start("CMD.exe", gitClone);

                executeCommand(gitClone);
                //executeCommand("git checkout main -f && git branch --set-upstream-to origin/main");


                //statusTextBox.Text = "gameSaveFilesPath: " + GitSyncSavegame.Properties.Settings.Default.StoredgameSaveFilesPath;
                //Properties.Settings.Default.Upgrade();
            }
        }

        private string userName;
        private string gitPath;
        private string gameSaveFilesPath;
        private string syncedFilePath;
        private string gitPull;
        private string gitPush;
        private string gitClone;
        private string repoName;
    }
}
