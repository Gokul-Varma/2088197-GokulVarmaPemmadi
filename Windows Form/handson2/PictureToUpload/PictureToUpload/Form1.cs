using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureToUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnforUpload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               imagelocation = dialog.FileName;
               pictureBox1.ImageLocation = imagelocation;
            }
        }
    }
}
