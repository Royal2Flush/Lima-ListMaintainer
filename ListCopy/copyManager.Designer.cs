namespace ListCopy
{
    partial class copyManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(copyManager));
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.folderBrowser1 = new System.Windows.Forms.FolderBrowserDialog();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonWithFolder = new System.Windows.Forms.RadioButton();
            this.radioButtonNoFolders = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelState = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 30);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(211, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(229, 28);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(28, 23);
            this.buttonPath.TabIndex = 1;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(8, 124);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(130, 17);
            this.checkBoxOverwrite.TabIndex = 2;
            this.checkBoxOverwrite.Text = "Overwrite existing files";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(144, 124);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(122, 17);
            this.checkBoxDelete.TabIndex = 3;
            this.checkBoxDelete.Text = "Delete files not in list";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Target path";
            // 
            // radioButtonWithFolder
            // 
            this.radioButtonWithFolder.AutoSize = true;
            this.radioButtonWithFolder.Checked = true;
            this.radioButtonWithFolder.Location = new System.Drawing.Point(10, 13);
            this.radioButtonWithFolder.Name = "radioButtonWithFolder";
            this.radioButtonWithFolder.Size = new System.Drawing.Size(164, 17);
            this.radioButtonWithFolder.TabIndex = 4;
            this.radioButtonWithFolder.TabStop = true;
            this.radioButtonWithFolder.Text = "Copy files and folder structure";
            this.radioButtonWithFolder.UseVisualStyleBackColor = true;
            // 
            // radioButtonNoFolders
            // 
            this.radioButtonNoFolders.AutoSize = true;
            this.radioButtonNoFolders.Location = new System.Drawing.Point(10, 36);
            this.radioButtonNoFolders.Name = "radioButtonNoFolders";
            this.radioButtonNoFolders.Size = new System.Drawing.Size(184, 17);
            this.radioButtonNoFolders.TabIndex = 5;
            this.radioButtonNoFolders.Text = "Copy files directly in chosen folder";
            this.radioButtonNoFolders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonNoFolders);
            this.groupBox1.Controls.Add(this.radioButtonWithFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(63, 176);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(144, 176);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(9, 173);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(38, 13);
            this.labelState.TabIndex = 11;
            this.labelState.Text = "Ready";
            // 
            // copyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 207);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxDelete);
            this.Controls.Add(this.checkBoxOverwrite);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "copyManager";
            this.Text = "Copy files - LiMa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser1;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonWithFolder;
        private System.Windows.Forms.RadioButton radioButtonNoFolders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelState;
    }
}