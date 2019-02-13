/*
 * Created by: Romy I. Chu III
 * Created on: 11-02-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - PerAreaVol Program
 * This program... has three buttons. When the buttons are clicked, it calculates the 
 *                 perimeter of a rectangle, area of a rectangle, and volume of a sphere.
 *                 It then displays the answer.
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

namespace _6.PerAreaVolRomyCIII
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        //This button calculates the perimeter of a rectangle (2*Length[8] + 2*Width[5]) and changes the label to the answer of the equation.
        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(2 * 5 + 2 *8) + " cm";
        }

        //This button calculates the area of a rectangle (Length[8]*Width[5]) and changes the label to the answer of the equation.
        private void btnArea_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(5 * 8) + " cm^2";
        }

        //This button calculates the volume of a sphere ([4/3]*pi*[r^3] r=8) and changes the label to the answer of the equation.
        //The answer is also rounded to the 4th decimal place.
        private void btnVolume_Click(object sender, EventArgs e)
        {
            //You can use this way to calculate the answer.
            //lblAnswer3.Text = Convert.ToString(Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(8, 3), 4)) + " cm^3";

            //or this way.
            lblAnswer3.Text = Convert.ToString(Math.Round(((Double)4 / (Double)3) * Math.PI * Math.Pow(8, 3), 4)) + " cm^3";

            //or this way.
            //lblAnswer3.Text = Convert.ToString(Convert.ToDecimal(Math.Round(Math.PI * 4 / 3 * Math.Pow(8, 3), 4))) + " cm^3";
        }
    }
}
