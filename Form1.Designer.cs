
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
            this.savePathBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.pullButton = new System.Windows.Forms.Button();
            this.pushButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gitPathBox
            // 
            this.gitPathBox.Location = new System.Drawing.Point(97, 6);
            this.gitPathBox.Name = "gitPathBox";
            this.gitPathBox.Size = new System.Drawing.Size(691, 23);
            this.gitPathBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Git repo path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game savegame path:";
            // 
            // savePathBox
            // 
            this.savePathBox.Location = new System.Drawing.Point(142, 42);
            this.savePathBox.Name = "savePathBox";
            this.savePathBox.Size = new System.Drawing.Size(646, 23);
            this.savePathBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 93);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save paths";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pullButton
            // 
            this.pullButton.Location = new System.Drawing.Point(632, 93);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(75, 23);
            this.pullButton.TabIndex = 5;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            this.pullButton.Click += new System.EventHandler(this.pullButton_Click);
            // 
            // pushButton
            // 
            this.pushButton.Location = new System.Drawing.Point(713, 93);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(75, 23);
            this.pushButton.TabIndex = 6;
            this.pushButton.Text = "Push";
            this.pushButton.UseVisualStyleBackColor = true;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.savePathBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gitPathBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gitPathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox savePathBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button pullButton;
        private System.Windows.Forms.Button pushButton;
    }
}

