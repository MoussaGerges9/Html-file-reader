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

namespace Html_file_reader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
                {Multiselect = false, ValidateNames = true, Filter = "HTML|*.html"})
            {
                if (openFileDialog.ShowDialog()==DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(openFileDialog.FileName,FileMode.Open,FileAccess.Read);
                    webBrowser1.DocumentStream = fileStream;
                }
            }
            
        }
    }
}
