﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LogicalSort.Core;

namespace SheikhAbdoRenamer
{
    public partial class Form1 : Form
    {
        #region Constructors
        public Form1()
        {
            InitializeComponent();
        } 
        #endregion

        #region Methods
        private void Clear()
        {
            txtSourceFolder.Text = "";
            txtDestinationFolder.Text = "";
            lstFilesNames.Items.Clear();
        }
        private void DisplayFolder()
        {
            if (!Directory.Exists(txtSourceFolder.Text)) return;
            lstFilesNames.Items.Clear();
            lstFilesNames.Items.AddRange(GetFileNames(txtSourceFolder.Text).ToArray().Sort());
        }
        private string BrowseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select a folder",
                ShowNewFolderButton = false
            };

            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return fbd.SelectedPath;
            }
            return null;
        }
        private bool ValidateFields()
        {
            if (txtSourceFolder.Text == "")
            {
                MessageBox.Show("Please select a source folder");
                return false;
            }

            if (txtDestinationFolder.Text == "")
            {
                MessageBox.Show("Please specify a destination folder");
                return false;
            }
            if (!Directory.Exists(txtSourceFolder.Text))
            {
                MessageBox.Show("Please select a valid source folder path");
                return false;
            }

            if (!Directory.Exists(txtDestinationFolder.Text))
            {
                MessageBox.Show("Please select a valid destination folder path");
                return false;
            }

            if (Directory.GetFiles(txtSourceFolder.Text).Length == 0)
            {
                MessageBox.Show("Please select a folder that contains files");
                return false;
            }
            if (Directory.GetFiles(txtSourceFolder.Text).Length == 0)
            {
                MessageBox.Show("Please select a source folder that contains files");
                return false;
            }
            if (Directory.GetFiles(txtDestinationFolder.Text).Length == 0)
            {
                MessageBox.Show("Please select a destination folder that contains files");
                return false;
            }
            return true;
        }
        private List<string> GetFileNames(string folder)
        {
            try
            {
                List<string> filenames = new List<string>();

                string[] files = Directory.GetFiles(folder);
                foreach (string name in files)
                {
                    FileInfo f = new FileInfo(name);
                    if (f.Name.Contains("."))
                        filenames.Add(f.Name.Split('.')[0]);
                    else
                        filenames.Add(f.Name);
                }
                return filenames;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get files names, check that all files have extensions " + Environment.NewLine + ex.Message);
                return null;
            }
        }

        private bool RenameAll(string source, string destination)
        {
            try
            {
                if (!ValidateFields()) return false;
                if (Directory.GetFiles(source).Length != Directory.GetFiles(destination).Length)
                {
                    if (MessageBox.Show("Source and destination folder doesn't have the same number of files! Are you sure your want to continue?",
                        "Alert",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.No)
                    {
                        return false;
                    }
                }
                var SourceFilesNames = GetFileNames(source).ToArray();
                string[] DestinationFilesNames = Directory.GetFiles(destination);
                DestinationFilesNames = DestinationFilesNames.Sort();
                SourceFilesNames = SourceFilesNames.Sort();

                for (int i = 0; i < DestinationFilesNames.Length; i++)
                {
                    if (!DestinationFilesNames[i].Contains(".")) continue;
                    if (i > SourceFilesNames.Length - 1) throw new Exception("Failed to rename all files");
                    string[] filenameportions = DestinationFilesNames[i].Split('.');
                    File.Move(DestinationFilesNames[i], destination + "\\" + SourceFilesNames[i] + "." + filenameportions[filenameportions.Length - 1]);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to rename all files." + Environment.NewLine + ex.Message);
                return false;
            }
        }

        public void Exit()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowseForSourceFolder_Click(object sender, EventArgs e)
        {
            txtSourceFolder.Text = BrowseFolder();
            if (txtSourceFolder.Text == "") return;
            DisplayFolder();
        }



        private void btnBrowseForDestinationFolder_Click(object sender, EventArgs e)
        {
            txtDestinationFolder.Text = BrowseFolder();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (RenameAll(txtSourceFolder.Text, txtDestinationFolder.Text))
            {
                MessageBox.Show("Operation Succeeded", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation Failed", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program developed by: Emad Saber exclusively for Shiekh Abdel Rahman Esmat");
        }

        private void txtSourceFolder_Leave(object sender, EventArgs e)
        {
            DisplayFolder();
        }
        #endregion
    }
}
