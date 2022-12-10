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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            gitPath = gitPathBox.Text;
            savePath = savePathBox.Text;
        }

        private String gitPath;
        private String savePath;
        private String gitPull;
        private String gitPush;

        private void pullButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", gitPull);
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("CMD.exe", gitPush);
        }
    }
}
