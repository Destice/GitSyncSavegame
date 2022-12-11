
namespace GitSyncSavegame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gitPathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameSaveFilesPathBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.pullButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.syncedFilePathBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gitPathBox
            // 
            this.gitPathBox.Location = new System.Drawing.Point(108, 6);
            this.gitPathBox.Name = "gitPathBox";
            this.gitPathBox.Size = new System.Drawing.Size(680, 23);
            this.gitPathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Git repo link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game save files path:";
            // 
            // gameSaveFilesPathBox
            // 
            this.gameSaveFilesPathBox.Location = new System.Drawing.Point(136, 35);
            this.gameSaveFilesPathBox.Name = "gameSaveFilesPathBox";
            this.gameSaveFilesPathBox.Size = new System.Drawing.Size(652, 23);
            this.gameSaveFilesPathBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 109);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save paths";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pullButton
            // 
            this.pullButton.Location = new System.Drawing.Point(632, 109);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(75, 23);
            this.pullButton.TabIndex = 5;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            this.pullButton.Click += new System.EventHandler(this.pullButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(713, 109);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 6;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(141, 109);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(75, 23);
            this.cloneButton.TabIndex = 7;
            this.cloneButton.Text = "Clone";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.cloneButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(12, 138);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(776, 300);
            this.statusTextBox.TabIndex = 8;
            this.statusTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Synced file path: .../GameSaveFiles/";
            // 
            // syncedFilePathBox
            // 
            this.syncedFilePathBox.Location = new System.Drawing.Point(212, 64);
            this.syncedFilePathBox.Name = "syncedFilePathBox";
            this.syncedFilePathBox.Size = new System.Drawing.Size(576, 23);
            this.syncedFilePathBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syncedFilePathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.gameSaveFilesPathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gitPathBox);
            this.Name = "Form1";
            this.Text = "ChroniuGitSaveSync";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gitPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameSaveFilesPathBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button pullButton;
        private System.Windows.Forms.Button pushButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.RichTextBox statusTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox syncedFilePathBox;
    }
}

