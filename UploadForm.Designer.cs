namespace FileManagerV2
{
    partial class UploadForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.FileDescTextBox = new MetroFramework.Controls.MetroTextBox();
            this.FileNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UploadFileButton = new MetroFramework.Controls.MetroButton();
            this.UploadFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 69);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "File Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(98, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "File Description";
            // 
            // FileDescTextBox
            // 
            // 
            // 
            // 
            this.FileDescTextBox.CustomButton.Image = null;
            this.FileDescTextBox.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.FileDescTextBox.CustomButton.Name = "";
            this.FileDescTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FileDescTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FileDescTextBox.CustomButton.TabIndex = 1;
            this.FileDescTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FileDescTextBox.CustomButton.UseSelectable = true;
            this.FileDescTextBox.CustomButton.Visible = false;
            this.FileDescTextBox.Lines = new string[0];
            this.FileDescTextBox.Location = new System.Drawing.Point(128, 97);
            this.FileDescTextBox.MaxLength = 32767;
            this.FileDescTextBox.Name = "FileDescTextBox";
            this.FileDescTextBox.PasswordChar = '\0';
            this.FileDescTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileDescTextBox.SelectedText = "";
            this.FileDescTextBox.SelectionLength = 0;
            this.FileDescTextBox.SelectionStart = 0;
            this.FileDescTextBox.ShortcutsEnabled = true;
            this.FileDescTextBox.Size = new System.Drawing.Size(273, 23);
            this.FileDescTextBox.TabIndex = 2;
            this.FileDescTextBox.UseSelectable = true;
            this.FileDescTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FileDescTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FileNameTextBox
            // 
            // 
            // 
            // 
            this.FileNameTextBox.CustomButton.Image = null;
            this.FileNameTextBox.CustomButton.Location = new System.Drawing.Point(251, 1);
            this.FileNameTextBox.CustomButton.Name = "";
            this.FileNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FileNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FileNameTextBox.CustomButton.TabIndex = 1;
            this.FileNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FileNameTextBox.CustomButton.UseSelectable = true;
            this.FileNameTextBox.CustomButton.Visible = false;
            this.FileNameTextBox.Lines = new string[0];
            this.FileNameTextBox.Location = new System.Drawing.Point(128, 69);
            this.FileNameTextBox.MaxLength = 32767;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.PasswordChar = '\0';
            this.FileNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileNameTextBox.SelectedText = "";
            this.FileNameTextBox.SelectionLength = 0;
            this.FileNameTextBox.SelectionStart = 0;
            this.FileNameTextBox.ShortcutsEnabled = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(273, 23);
            this.FileNameTextBox.TabIndex = 3;
            this.FileNameTextBox.UseSelectable = true;
            this.FileNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FileNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // UploadFileButton
            // 
            this.UploadFileButton.Location = new System.Drawing.Point(207, 126);
            this.UploadFileButton.Name = "UploadFileButton";
            this.UploadFileButton.Size = new System.Drawing.Size(75, 23);
            this.UploadFileButton.TabIndex = 4;
            this.UploadFileButton.Text = "Upload File";
            this.UploadFileButton.UseSelectable = true;
            this.UploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // UploadFileDialog
            // 
            this.UploadFileDialog.FileName = "UploadFileDialog";
            this.UploadFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.UploadFileDialog_FileOk);
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 184);
            this.Controls.Add(this.UploadFileButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FileDescTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UploadForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Upload File";
            this.Load += new System.EventHandler(this.UploadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox FileDescTextBox;
        private MetroFramework.Controls.MetroTextBox FileNameTextBox;
        private MetroFramework.Controls.MetroButton UploadFileButton;
        private System.Windows.Forms.OpenFileDialog UploadFileDialog;
    }
}