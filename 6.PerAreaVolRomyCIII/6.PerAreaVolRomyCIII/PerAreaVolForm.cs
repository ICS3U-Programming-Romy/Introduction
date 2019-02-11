using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.PerAreaVolRomyCIII
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(2 * 5 + 2 *8) + " cm";
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(5 * 8) + " cm^2";
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            //var x = new decimal(4 / 3);
            lblAnswer3.Text = Convert.ToString(Convert.ToDecimal(Math.Round(Math.PI * 4 / 3 * Math.Pow(8, 3), 4))) + " cm^3";
        }
    }
}
