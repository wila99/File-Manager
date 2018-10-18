using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManagerV2
{
    public class FileUploader : Directory
    {
        public string FileSource { get {return fileSource; } set { fileSource = value; } }
        public string FileName { get { return fileName; } set { fileName = value; } }

        private string fileSource;
        private string fileName;

        public bool UploadFile()
        {
            string fileTarget = Path.Combine(Directory.CurrentPath().ToString(), fileName,Path.GetExtension(fileSource));
            File.Copy(fileSource, fileTarget,true);

            if (File.Exists(fileTarget))
            {
                return true;
            }
            else
            {
                return false;
                
            }
        }
    }
}
