using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCopy
{
    public partial class Form1 : Form
    {
        //-------------//
        // constructor //
        //-------------//

        public Form1()
        {
            InitializeComponent();
        }


        //----------------------------//
        // my variables and functions //
        //----------------------------//

        private string rootDir;
        private string fileName;

        private void loadList(string name)
        {
			// Loads an existing list file
			
            System.IO.StreamReader reader = new System.IO.StreamReader(name);
            while (reader.Peek() >= 0)
            {
                checkedListBoxFiles.Items.Add(reader.ReadLine(), true);
            }
            reader.Close();
        }

        private void checkFiles()
        {
			// Checks if the files in a loaded list still exist. If they don't the user can automatically mark them for deletion from the list.
			
            bool fileNotFound = false;
            bool disableNotFound = true;
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                if (!System.IO.File.Exists(rootDir + (string)checkedListBoxFiles.Items[i]))
                {
                    if (!fileNotFound)
                    {
                        if (MessageBox.Show("One or more files not found. Should they be marked as disabled?", "Files not found", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            disableNotFound = true;
                        }
                        else
                        {
                            disableNotFound = false;
                        }
                        fileNotFound = true;
                    }// if !fileNotFound
                    if (disableNotFound)
                    {
                        checkedListBoxFiles.SetItemChecked(i, false);
                    }
                }// if !File.Exists
            } //for
            fileNotFound = false;
        }// checkFiles()

        private void enableButtons(bool e)
        {
            buttonAddFiles.Enabled = e;
            buttonAddList.Enabled = e;
            buttonDupes.Enabled = e;
            buttonSave.Enabled = e;
            buttonCopy.Enabled = e;
        }


        //--------------//
        // click events //
        //--------------//

        private void buttonNew_Click(object sender, EventArgs e)
        {
			// creates a new list file
			
            fileName = "";
            enableButtons(false);
            buttonRoot.Enabled = true;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
			// loads an existing list
			
            if (browseLoad.ShowDialog() == DialogResult.OK)
            {
                fileName = browseLoad.FileName;
                loadList(fileName);

                enableButtons(false);
                buttonRoot.Enabled = true;
            }
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
			// Changes the root directory for the list. Pathes in the list are relative to the root dir.
			
            if (browseRootFolder.ShowDialog() == DialogResult.OK)
            {
                rootDir = browseRootFolder.SelectedPath + "\\";
                rootDir = rootDir.Replace("\\", "/");
                browseFileAdd.InitialDirectory = rootDir;

                checkFiles();
                enableButtons(true);
            }            
        }

        private void buttonAddFiles_Click(object sender, EventArgs e)
        {
			// Adds files to the list
			
            browseFileAdd.InitialDirectory = rootDir;
            if (browseFileAdd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string f in browseFileAdd.FileNames)
                {
                    checkedListBoxFiles.Items.Add((f.Replace("\\", "/")).Replace(rootDir, ""), true);
                }
            }
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
			// adds all files in another list to the current list.
			
            if (browseLoad.ShowDialog() == DialogResult.OK)
            {
                loadList(browseLoad.FileName);
                checkFiles();
            }
        }

        private void buttonDupes_Click(object sender, EventArgs e)
        {
			// Checks the list for duplicate entries and marks the duplicates for deletion.
			
            for(int i = 0; i < checkedListBoxFiles.Items.Count; i++ )
            {
                if (checkedListBoxFiles.GetItemChecked(i))
                {
                    for (int j = i + 1; j < checkedListBoxFiles.Items.Count; j++)
                    {
                        if (checkedListBoxFiles.GetItemChecked(j))
                        {
                            if ((string)checkedListBoxFiles.Items[i] == (string)checkedListBoxFiles.Items[j])
                            {
                                checkedListBoxFiles.SetItemChecked(j, false);
                            }
                        }// if j checked
                    }// for j
                }// if i checked
            }// for i
        }// buttonDupes_Click

        private void buttonSave_Click(object sender, EventArgs e)
        {
			// Save the current list to a list file without the entries marked for deletion.
			
            if (MessageBox.Show("Entries without tick won't be saved!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                browseSave.InitialDirectory = rootDir;
                if (browseSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.StreamWriter w = new System.IO.StreamWriter(browseSave.FileName);
                    foreach (object i in checkedListBoxFiles.CheckedItems)
                    {
                        w.WriteLine(i.ToString());
                    }
                    w.Close();
                }
            }
        }// buttonSave_Click

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LiMa List Maintainer v1.2 \n\nCreated by and copyright of Tobias Kohl, 2015\n\nIcon \"Escudomunlima\" by \"Huhsunqu\" released under CC BY-SA 3.0 (http://commons.wikimedia.org/wiki/File:Escudomunlima.png)", "About LiMa");
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
			// starts the copy manager to copy all files in the list to some directory
			
            copyManager cp = new copyManager();
            foreach (object i in checkedListBoxFiles.CheckedItems)
            {
                cp.fillToFileList(i.ToString());            
            }
            cp.setRootDir(rootDir);
            cp.Show();
        }

    }// partial class
}// namespace
