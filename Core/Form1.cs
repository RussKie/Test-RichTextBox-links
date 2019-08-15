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

namespace testapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.LoadFile(File.OpenRead(@"..\..\..\..\example.rtf"), RichTextBoxStreamType.RichText);
        }

        private void RichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            MessageBox.Show(this, e.LinkText, "link clicked");
        }
    }
}
