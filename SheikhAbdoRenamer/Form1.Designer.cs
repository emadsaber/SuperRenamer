namespace SheikhAbdoRenamer
{
    partial class Form1
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
            this.btnRename = new System.Windows.Forms.Button();
            this.btnBrowseForSourceFolder = new System.Windows.Forms.Button();
            this.btnBrowseForDestinationFolder = new System.Windows.Forms.Button();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstFilesNames = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRename
            // 
            this.btnRename.AccessibleDescription = "Rename the destination folder ya sheikh.";
            this.btnRename.AccessibleName = "Rename all files";
            this.btnRename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRename.Font = new System.Drawing.Font("Tahoma", 14F);
            this.btnRename.Location = new System.Drawing.Point(150, 152);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(150, 67);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "&Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnBrowseForSourceFolder
            // 
            this.btnBrowseForSourceFolder.AccessibleDescription = "Select the source folder ya sheikh";
            this.btnBrowseForSourceFolder.AccessibleName = "Browse for source folder";
            this.btnBrowseForSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForSourceFolder.Location = new System.Drawing.Point(372, 14);
            this.btnBrowseForSourceFolder.Name = "btnBrowseForSourceFolder";
            this.btnBrowseForSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForSourceFolder.TabIndex = 2;
            this.btnBrowseForSourceFolder.Text = "&Browse...";
            this.btnBrowseForSourceFolder.UseVisualStyleBackColor = true;
            this.btnBrowseForSourceFolder.Click += new System.EventHandler(this.btnBrowseForSourceFolder_Click);
            // 
            // btnBrowseForDestinationFolder
            // 
            this.btnBrowseForDestinationFolder.AccessibleDescription = "Select the destination folder ya sheikh";
            this.btnBrowseForDestinationFolder.AccessibleName = "Browse for destination folder";
            this.btnBrowseForDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForDestinationFolder.Location = new System.Drawing.Point(372, 42);
            this.btnBrowseForDestinationFolder.Name = "btnBrowseForDestinationFolder";
            this.btnBrowseForDestinationFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForDestinationFolder.TabIndex = 5;
            this.btnBrowseForDestinationFolder.Text = "&Browse...";
            this.btnBrowseForDestinationFolder.UseVisualStyleBackColor = true;
            this.btnBrowseForDestinationFolder.Click += new System.EventHandler(this.btnBrowseForDestinationFolder_Click);
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.AccessibleDescription = "The source folder\'s path ya sheikh";
            this.txtSourceFolder.AccessibleName = "Source folder path";
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(113, 15);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(253, 20);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.Leave += new System.EventHandler(this.txtSourceFolder_Leave);
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.AccessibleDescription = "The destination folder\'s path ya sheikh";
            this.txtDestinationFolder.AccessibleName = "Destination folder path";
            this.txtDestinationFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolder.Location = new System.Drawing.Point(113, 43);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(253, 20);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Folder";
            // 
            // lstFilesNames
            // 
            this.lstFilesNames.AccessibleDescription = "Contains list of files names";
            this.lstFilesNames.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstFilesNames.FormattingEnabled = true;
            this.lstFilesNames.Location = new System.Drawing.Point(461, 0);
            this.lstFilesNames.Name = "lstFilesNames";
            this.lstFilesNames.Size = new System.Drawing.Size(173, 330);
            this.lstFilesNames.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBrowseForSourceFolder);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnBrowseForDestinationFolder);
            this.panel1.Controls.Add(this.txtSourceFolder);
            this.panel1.Controls.Add(this.txtDestinationFolder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 330);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleDescription = "Exit program ya sheikh";
            this.btnExit.AccessibleName = "Close pogram";
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnExit.Location = new System.Drawing.Point(306, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 67);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "Clear the selected paths ya sheikh";
            this.btnClear.AccessibleName = "Clear all fields";
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnClear.Location = new System.Drawing.Point(54, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 67);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Version: 1.0.0";
            // 
            // btnAbout
            // 
            this.btnAbout.AccessibleDescription = "About Program";
            this.btnAbout.AccessibleName = "About Program";
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(372, 304);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "&About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstFilesNames);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheikh Abdo\'s Renamer - Special for my brother";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnBrowseForSourceFolder;
        private System.Windows.Forms.Button btnBrowseForDestinationFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstFilesNames;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label3;
    }
}

