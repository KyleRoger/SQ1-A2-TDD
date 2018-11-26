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
            // (A^2 + B^2) = C^2
            C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            return C;
        }
    }
}
