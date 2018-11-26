/*
 * 
 * Author:      Kyle Horsley
 * Date:        Nov 25, 2018
 * Project:     SQ1-A2- Test Driven Development
 * File:        Triangle.cs
 * Description: This is Triangle class for my project it is where the functionality of
 *              the triangle is found.
 * 
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

namespace SQ1_A2_TDD
{
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        /*
        * Name:    CalculateHyp
        * Purpose: To calculate the hypotenuese of a Triangle
        * Inputs:  Two sides of a triangle
        * Returns: The third side value.
        */
        public double CalculateHyp(double A, double B)
        {
            double C = -1;

            //If either side A or B is negative, Just set C to zero.
            if (A > 0 && B > 0)
            {
                // (A^2 + B^2) = C^2
                C = Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
            }

            return C;
        }


        /*
        * Name:    CalculateArea
        * Purpose: To calculate the Area Of a Triangle
        * Inputs:  To sides of a triangle
        * Returns: The area of the triangle based on the two inputted sides.
        */
        public double CalculateArea(double A, double B)
        {
            double area = -1;

            if (A > 0 && B > 0)
            {
                //area == 1/2 *AB
                area = (0.5 * (A * B));
            }
            return area;
        }

        /*
        * Name:    Calculate Angle
        * Purpose: To calculate the final angle of a triangle
        * Inputs:  Two angles of a given triangle
        * Returns:  The third angle of the triangle.
        */
        public double CalculateAngle(double angleOne, double angleTwo)
        {
            double angleThree = -1;

            if ((angleOne + angleTwo) < 180 && (angleOne + angleTwo) > 0)
            {
                angleThree = 180 - angleOne - angleTwo;
            }
            return angleThree;
        }


        public void sideBtn_Click(object sender, EventArgs e)
        {
           double number = -1;
           
           number = CalculateHyp(Convert.ToDouble(sideAnum.Value), Convert.ToDouble(sideBnum.Value));

            if (number == -1)
            {
                sideCtext.Text = "Input Not Accepted!";
            }
            else
            {
                sideCtext.Text = Convert.ToString(number);
            }
        }

        private void areaBtn_Click(object sender, EventArgs e)
        {
            double number = -1;
            number = CalculateArea(Convert.ToDouble(sideAnum.Value),Convert.ToDouble(sideBnum.Value));
            if (number == -1)
            {
                sideCtext.Text = "Input Not Accepted!";
            }
            else
            {
                sideCtext.Text = Convert.ToString(number);
            }
        }

        private void angleBtn_Click(object sender, EventArgs e)
        {
            double number = -1;
            number = CalculateAngle(Convert.ToDouble(angleAnum.Value), Convert.ToDouble(angleBnum.Value));

            if (number == -1)
            {
                sideCtext.Text = "Input Not Accepted!";
            }
            else
            {
                sideCtext.Text = Convert.ToString(number);
            }
        }
    }
}
