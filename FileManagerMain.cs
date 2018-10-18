using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;


namespace FileManagerV2
{
    public partial class FileManagerMain : MetroForm
    {
        UploadForm form = new UploadForm();

        public FileManagerMain()
        {
            InitializeComponent();
        }

        private void FileManager_Load(object sender, EventArgs e)
        {
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            form.Show();
            
        }

        private void GetDirectoryTextBox_Click(object sender, EventArgs e)
        {

        }

        private void GetDirectoryButton_Click(object sender, EventArgs e)
        {

        }
    }
}
