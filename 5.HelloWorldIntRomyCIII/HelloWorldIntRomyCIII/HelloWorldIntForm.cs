/*
 * Created by: Romy I. Chu III
 * Created on: 08-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
 * This program... Displays "Hello World!" in different languages when you click the specified radio button.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntRomyCIII
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Hello, World!";
        }

        private void radArabic_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "مرحبا بالعالم!";
        }

        private void radChineseTrad_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "你好，世界！";
        }

        private void radJapanese_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "こんにちは世界！";
        }

        private void radTagalog_CheckedChanged(object sender, EventArgs e)
        {
            lblHelloWorldInt.Text = "Kumusta, Mundo!";
        }
    }
}
