using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FileManagerV2
{
    public partial class UploadForm : MetroForm
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void UploadForm_Load(object sender, EventArgs e)
        {
            UploadFileDialog.Filter = "Excel Documents|*.xlsx|PDF Document|*.PDF|Text File|*.txt";
        }

        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            if (UploadFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = UploadFileDialog.FileName;
                FileUploader fileUploader = new FileUploader
                {
                    FileName = FileNameTextBox.Text,
                    FileSource = filePath
                };

                fileUploader.UploadFile();
            }
        }

        private void UploadFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
