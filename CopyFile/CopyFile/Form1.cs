using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyFile
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void FileTestBtn_Click(object sender, EventArgs e)
        {
            string testFile = "C:\\Users\\NASA\\Desktop\\Test.txt";
            DateTime dtCreated;
            DateTime dtModified;

            if (File.Exists(testFile))
            {
                textBox1.AppendText(testFile + " exists. Copying...\n");
                File.Copy(testFile, testFile + "(Copy)", true);
            }
            else
            {
                textBox1.AppendText(testFile + " does not exist\n");
            }
            if (File.Exists(testFile))
            {
                dtCreated = File.GetCreationTime(testFile);
                dtModified = File.GetLastWriteTime(testFile);
                textBox1.AppendText(testFile + "was created at: " + dtCreated);
                textBox1.AppendText(testFile + "was modified at: " + dtModified);
            }
        }
    }
}
