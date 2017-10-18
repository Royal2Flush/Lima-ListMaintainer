namespace ListCopy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browseFileAdd = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonRoot = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.browseRootFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.browseLoad = new System.Windows.Forms.OpenFileDialog();
            this.browseSave = new System.Windows.Forms.SaveFileDialog();
            this.checkedListBoxFiles = new System.Windows.Forms.CheckedListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDupes = new System.Windows.Forms.Button();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // browseFileAdd
            // 
            this.browseFileAdd.Multiselect = true;
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Enabled = false;
            this.buttonAddFiles.Location = new System.Drawing.Point(12, 121);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(127, 23);
            this.buttonAddFiles.TabIndex = 3;
            this.buttonAddFiles.Text = "Add Files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonRoot
            // 
            this.buttonRoot.Enabled = false;
            this.buttonRoot.Location = new System.Drawing.Point(12, 83);
            this.buttonRoot.Name = "buttonRoot";
            this.buttonRoot.Size = new System.Drawing.Size(127, 23);
            this.buttonRoot.TabIndex = 2;
            this.buttonRoot.Text = "Choose Root-Dir...";
            this.buttonRoot.UseVisualStyleBackColor = true;
            this.buttonRoot.Click += new System.EventHandler(this.buttonRoot_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 217);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(12, 295);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(127, 23);
            this.buttonQuit.TabIndex = 8;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 54);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(127, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Load...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // browseLoad
            // 
            this.browseLoad.DefaultExt = "list";
            this.browseLoad.Filter = "Lists|*.list|All Files|*.*";
            // 
            // browseSave
            // 
            this.browseSave.DefaultExt = "list";
            this.browseSave.Filter = "Lists|*.list|All Files|*.*";
            // 
            // checkedListBoxFiles
            // 
            this.checkedListBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxFiles.CheckOnClick = true;
            this.checkedListBoxFiles.FormattingEnabled = true;
            this.checkedListBoxFiles.HorizontalScrollbar = true;
            this.checkedListBoxFiles.Location = new System.Drawing.Point(145, 25);
            this.checkedListBoxFiles.Name = "checkedListBoxFiles";
            this.checkedListBoxFiles.ScrollAlwaysVisible = true;
            this.checkedListBoxFiles.Size = new System.Drawing.Size(312, 334);
            this.checkedListBoxFiles.TabIndex = 10;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(12, 25);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(127, 23);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDupes
            // 
            this.buttonDupes.Enabled = false;
            this.buttonDupes.Location = new System.Drawing.Point(12, 188);
            this.buttonDupes.Name = "buttonDupes";
            this.buttonDupes.Size = new System.Drawing.Size(127, 23);
            this.buttonDupes.TabIndex = 5;
            this.buttonDupes.Text = "Unmark Duplicates";
            this.buttonDupes.UseVisualStyleBackColor = true;
            this.buttonDupes.Click += new System.EventHandler(this.buttonDupes_Click);
            // 
            // buttonAddList
            // 
            this.buttonAddList.Enabled = false;
            this.buttonAddList.Location = new System.Drawing.Point(12, 150);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(127, 23);
            this.buttonAddList.TabIndex = 4;
            this.buttonAddList.Text = "Add List...";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(12, 324);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(127, 23);
            this.buttonAbout.TabIndex = 11;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Location = new System.Drawing.Point(12, 256);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(127, 23);
            this.buttonCopy.TabIndex = 12;
            this.buttonCopy.Text = "Copy Files...";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 376);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.buttonDupes);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.checkedListBoxFiles);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRoot);
            this.Controls.Add(this.buttonAddFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LiMa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog browseFileAdd;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonRoot;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.FolderBrowserDialog browseRootFolder;
        private System.Windows.Forms.OpenFileDialog browseLoad;
        private System.Windows.Forms.SaveFileDialog browseSave;
        private System.Windows.Forms.CheckedListBox checkedListBoxFiles;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDupes;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonCopy;
    }
}

