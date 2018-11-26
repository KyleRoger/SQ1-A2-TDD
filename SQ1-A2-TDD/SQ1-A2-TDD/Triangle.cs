using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQ1_A2_TDD
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        public double CalculateHyp(double A, double B)
        {
            double C = 0;

            //If either side A or B is negative, Just set C to zero.
            if (A > 0 && B > 0)
            {
                // (A^2 + B^2) = C^2
                C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            }
            return C;
        }

        public double CalculateArea(double A, double B)
        {
            double area = 0;

            if (A > 0 && B > 0)
            {
                //area == 1/2 *AB
                area = (0.5 * (A * B));
            }
            return area;
        }

        public double CalculateAngle(double angleOne, double angleTwo)
        {
            double angleThree = 0;

            if ((angleOne + angleTwo) < 180 && (angleOne + angleTwo) > 0)
            {
                angleThree = 180 - angleOne - angleTwo;
            }
            return angleThree;
        }

        private void sideBtn_Click(object sender, EventArgs e)
        {
      
           sideCtext.Text = Convert.ToString(CalculateHyp(Convert.ToDouble(sideAtext.Text), Convert.ToDouble(sideBtext.Text)));
        }

        private void areaBtn_Click(object sender, EventArgs e)
        {
            areaTxt.Text = Convert.ToString(CalculateArea(Convert.ToDouble(sideAtext.Text), Convert.ToDouble(sideBtext.Text)));
        }

        private void angleBtn_Click(object sender, EventArgs e)
        {
            angleCtext.Text = Convert.ToString(CalculateAngle(Convert.ToDouble(angleAtext.Text), Convert.ToDouble(angleBtext.Text)));
        }
    }
}
