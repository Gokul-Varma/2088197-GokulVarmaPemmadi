using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitUsage_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var task = CountCharacters();
            //task.Start();
            int count = await task;
            MessageBox.Show(count.ToString());
            
        }

        private async Task<int> CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\gokulvarma\\Desktop\\gokul.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                await Task.Delay(10000);
            }
            return count;
        }
    }
}
