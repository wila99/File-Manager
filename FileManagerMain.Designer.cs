namespace FileManagerV2
{
    partial class FileManagerMain
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
            this.DirectoryListView = new MetroFramework.Controls.MetroListView();
            this.GetDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.GetDirectoryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UploadFileButton = new MetroFramework.Controls.MetroButton();
            this.CreateFolderButton = new MetroFramework.Controls.MetroButton();
            this.DeleteFileButton = new MetroFramework.Controls.MetroButton();
            this.SearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // DirectoryListView
            // 
            this.DirectoryListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DirectoryListView.FullRowSelect = true;
            this.DirectoryListView.Location = new System.Drawing.Point(23, 157);
            this.DirectoryListView.Name = "DirectoryListView";
            this.DirectoryListView.OwnerDraw = true;
            this.DirectoryListView.Size = new System.Drawing.Size(531, 326);
            this.DirectoryListView.TabIndex = 0;
            this.DirectoryListView.UseCompatibleStateImageBehavior = false;
            this.DirectoryListView.UseSelectable = true;
            // 
            // GetDirectoryButton
            // 
            this.GetDirectoryButton.Location = new System.Drawing.Point(462, 68);
            this.GetDirectoryButton.Name = "GetDirectoryButton";
            this.GetDirectoryButton.Size = new System.Drawing.Size(92, 23);
            this.GetDirectoryButton.TabIndex = 1;
            this.GetDirectoryButton.Text = "Load Directory";
            this.GetDirectoryButton.UseSelectable = true;
            this.GetDirectoryButton.Click += new System.EventHandler(this.GetDirectoryButton_Click);
            // 
            // GetDirectoryTextBox
            // 
            // 
            // 
            // 
            this.GetDirectoryTextBox.CustomButton.Image = null;
            this.GetDirectoryTextBox.CustomButton.Location = new System.Drawing.Point(418, 1);
            this.GetDirectoryTextBox.CustomButton.Name = "";
            this.GetDirectoryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.GetDirectoryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.GetDirectoryTextBox.CustomButton.TabIndex = 1;
            this.GetDirectoryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GetDirectoryTextBox.CustomButton.UseSelectable = true;
            this.GetDirectoryTextBox.CustomButton.Visible = false;
            this.GetDirectoryTextBox.Lines = new string[0];
            this.GetDirectoryTextBox.Location = new System.Drawing.Point(23, 68);
            this.GetDirectoryTextBox.MaxLength = 32767;
            this.GetDirectoryTextBox.Name = "GetDirectoryTextBox";
            this.GetDirectoryTextBox.PasswordChar = '\0';
            this.GetDirectoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GetDirectoryTextBox.SelectedText = "";
            this.GetDirectoryTextBox.SelectionLength = 0;
            this.GetDirectoryTextBox.SelectionStart = 0;
            this.GetDirectoryTextBox.ShortcutsEnabled = true;
            this.GetDirectoryTextBox.Size = new System.Drawing.Size(440, 23);
            this.GetDirectoryTextBox.TabIndex = 2;
            this.GetDirectoryTextBox.UseSelectable = true;
            this.GetDirectoryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.GetDirectoryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.GetDirectoryTextBox.Click += new System.EventHandler(this.GetDirectoryTextBox_Click);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.BackColor = System.Drawing.Color.Transparent;
            this.UploadFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UploadFileButton.ForeColor = System.Drawing.Color.White;
            this.UploadFileButton.Location = new System.Drawing.Point(23, 97);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(85, 25);
            this.UploadFileButton.TabIndex = 3;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseSelectable = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // CreateFolderButton
            // 
            this.CreateFolderButton.Location = new System.Drawing.Point(114, 97);
            this.CreateFolderButton.Name = "CreateFolderButton";
            this.CreateFolderButton.Size = new System.Drawing.Size(85, 25);
            this.CreateFolderButton.TabIndex = 4;
            this.CreateFolderButton.Text = "Create Folder";
            this.CreateFolderButton.UseSelectable = true;
            // 
            // DeleteFileButton
            // 
            this.DeleteFileButton.Location = new System.Drawing.Point(205, 97);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(85, 25);
            this.DeleteFileButton.TabIndex = 5;
            this.DeleteFileButton.Text = "Delete File";
            this.DeleteFileButton.UseSelectable = true;
            // 
            // SearchTextBox
            // 
            // 
            // 
            // 
            this.SearchTextBox.CustomButton.Image = null;
            this.SearchTextBox.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.SearchTextBox.CustomButton.Name = "";
            this.SearchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTextBox.CustomButton.TabIndex = 1;
            this.SearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTextBox.CustomButton.UseSelectable = true;
            this.SearchTextBox.CustomButton.Visible = false;
            this.SearchTextBox.Lines = new string[0];
            this.SearchTextBox.Location = new System.Drawing.Point(23, 128);
            this.SearchTextBox.MaxLength = 32767;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.SelectionLength = 0;
            this.SearchTextBox.SelectionStart = 0;
            this.SearchTextBox.ShortcutsEnabled = true;
            this.SearchTextBox.Size = new System.Drawing.Size(161, 23);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.UseSelectable = true;
            this.SearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(180, 128);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(53, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseSelectable = true;
            // 
            // FileManagerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 506);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.DeleteFileButton);
            this.Controls.Add(this.CreateFolderButton);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.GetDirectoryTextBox);
            this.Controls.Add(this.GetDirectoryButton);
            this.Controls.Add(this.DirectoryListView);
            this.Name = "FileManagerMain";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.FileManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView DirectoryListView;
        private MetroFramework.Controls.MetroButton GetDirectoryButton;
        private MetroFramework.Controls.MetroTextBox GetDirectoryTextBox;
        private MetroFramework.Controls.MetroButton UploadFileButton;
        private MetroFramework.Controls.MetroButton CreateFolderButton;
        private MetroFramework.Controls.MetroButton DeleteFileButton;
        private MetroFramework.Controls.MetroTextBox SearchTextBox;
        private MetroFramework.Controls.MetroButton SearchButton;
    }
}

