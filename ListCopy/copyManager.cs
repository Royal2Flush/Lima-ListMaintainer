using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListCopy
{
    public partial class copyManager : Form
    {
        //-------------//
        // constructor //
        //-------------//

        public copyManager()
        {
            InitializeComponent();
        }

        //----------------------------//
        // my variables and functions //
        //----------------------------//

        // Information from parent form
        private List<string> filelist = new List<string>();
        private string rootDir;
        public void fillToFileList(string s)
        {
            filelist.Add(s);
        }
        public void setRootDir(string s)
        {
            rootDir = s;
        }

        // Deletes every file in dest directory that isn't on the list
        private void fileDelete(string path, string folder)
        {
            string[] flist = Directory.GetFiles(path+folder);
            string[] dlist = Directory.GetDirectories(path+folder);

            foreach (string f in flist) // compare all files found...
            {
                bool found = false;
                filelist.ForEach(delegate(string i) // ...with the filelist
                {
                    string t = "";
                    if (radioButtonNoFolders.Checked)
                    {
                        t += i.Substring(i.ToString().LastIndexOf("/") + 1);
                    }
                    else
                    {
                        t += i;
                    }
                    if (t == f.Substring(path.Length+1).Replace("\\", "/"))
                    {
                        found = true;
                        return;
                    }
                }); //filelist.ForEach
                if(!found)
                {
                    //MessageBox.Show("Deleting file " + f.Replace("\\", "/"));
                    File.Delete(f.Replace("\\", "/"));                   
                }
            } //foreach f in flist

            foreach (string d in dlist) // recursively go through subdirectories
            {
                fileDelete(path, d.Substring(path.Length).Replace("\\", "/"));
            }

            if(Directory.GetFiles(path+folder).Length==0 && Directory.GetDirectories(path+folder).Length==0) // if current folder is empty
            {
                //MessageBox.Show("Deleting folder " + path + folder);
                Directory.Delete(path+folder);
            }
        } //fileDelete

        // checks if we have write permission in dest directory
        // stolen from the internet: http://stackoverflow.com/questions/1281620/checking-for-directory-and-file-write-permissions-in-net
        //
        // <summary>
        // Checks the ability to create and write to a file in the supplied directory.
        // </summary>
        // <param name="directory">String representing the directory path to check.</param>
        // <returns>True if successful; otherwise false.</returns>
        private const string TEMP_FILE = "\\tempFile.tmp";
        private static bool CheckDirectoryAccess(string directory)
        {
            bool success = false;
            string fullPath = directory + TEMP_FILE;

            if (Directory.Exists(directory))
            {
                try
                {
                    using (FileStream fs = new FileStream(fullPath, FileMode.CreateNew, FileAccess.Write))
                    {
                        fs.WriteByte(0xff);
                    }

                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                        success = true;
                    }
                }
                catch (Exception)
                {
                    success = false;
                }
            }
            return success;
        }

        //--------------//
        // click events //
        //--------------//

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
			// sets the path to which the files should be copied
			
            if (folderBrowser1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxPath.Text = folderBrowser1.SelectedPath;
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
			// copies the files to the specified dest directory
			
            bool ovw = checkBoxOverwrite.Checked;
            bool del = checkBoxDelete.Checked;
            string cpp = textBoxPath.Text.Replace("\\", "/");
            progressBar1.Maximum = filelist.Count;

            if (cpp == "")
            {
                MessageBox.Show("Please select a folder to copy to!", "No folder selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Directory.Exists(cpp))
            {
                if(del)
                {
                    if (MessageBox.Show("All files and folders in\n\n" + cpp + "\n\nnot on the current list will be deleted!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            else //directory does not yet exist
            {
                Directory.CreateDirectory(cpp);
            }

            if (!CheckDirectoryAccess(cpp))
            {
                MessageBox.Show("Seems like you don't have write permission in the target folder. Please get write permissions or choose another folder!", "Missing write permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (del && ovw) // we then can just delete everything and start over
            {
                labelState.Text = "Deleting";
                Directory.Delete(cpp, true);
                Directory.CreateDirectory(cpp);
                //MessageBox.Show("Deleting and recreating "+cpp);
            }

            labelState.Text = "Copying";
            progressBar1.Value = 0;
            filelist.ForEach(delegate(string i)
                {
                    progressBar1.Value++;

                    string t = "/";
                    if(radioButtonNoFolders.Checked)
                    {
                        t += i.Substring(i.ToString().LastIndexOf("/") + 1);
                    }
                    else
                    {
                        t += i;
                    }

                    if(ovw || !File.Exists(cpp + t))
                    {
                        if (i.Contains("/"))
                        {
                            string d = "/" + i.Substring(0, i.LastIndexOf("/"));
                            if (!Directory.Exists(cpp + d))
                            {
                                //MessageBox.Show("Creating directory " + cpp + d);
                                Directory.CreateDirectory(cpp + d);
                            }
                        }
                        //MessageBox.Show("Copying " + rootDir + i + " to " + cpp + t);
                        File.Copy(rootDir + i, cpp + t, true);
                    }
                }); //filelist.ForEach

            if (del && !ovw)
            {
                labelState.Text = "Deleting";
                fileDelete(cpp,"");
            }
            labelState.Text = "Ready";
            progressBar1.Value = 0;
        }// buttonCopy_Click
    }// partial class
}// namespace
