/*
 * Created by: Romy I. Chu III
 * Created on: 07-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #4 - School App Program
 * This program...Displays 2 labels a menu strip and 2 menu items. When "Exit" is clicked, the program is closed.
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

namespace SchoolAppRomyCIII
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //This closes the program
            this.Close();
        }
    }
}
