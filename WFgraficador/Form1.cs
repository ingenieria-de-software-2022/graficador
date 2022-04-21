using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;


namespace WFgraficador
{
    public partial class Form1 : Form
    {
        double xi, xf, x, y, yi, y1, angle, magnitude, t;
        int n;
        string functionFx, functionF1x, functionFpolar;

        public Form1()
        {
            InitializeComponent();
            listBoxOutput.Items.Clear();

            xi = 0;
            xf = 0;
            n = 0;
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void fxFt_Click(object sender, EventArgs e)
        {
            inputProcess();
            chartParametricProcess();
            outputProcess();
        }

        private void fxF1xButton_Click(object sender, EventArgs e)
        {
            inputProcess();
            chartProcess2();
            outputProcess();
        }

        private void rga_Click(object sender, EventArgs e)
        {
            inputProcess();
            chartPolarProcess();
            outputProcess();
        }

        private void fx_Click(object sender, EventArgs e)
        {
            inputProcess();
            chartProcess();
            outputProcess();
        }

        public void inputProcess()
        {
            try
            {
                xi = double.Parse(textBoxXi.Text);
                xf = double.Parse(textBoxXf.Text);
                functionFx = textBoxFx.Text;
                functionF1x = textBoxF1x.Text;
                n = chart1.Width;

            }
            catch
            {
                MessageBox.Show("Ingrese únicamente números en los valores de entrada");
            }
        }

        public void chartProcess()
        {
            double h;
            h = (xf - xi) / n;
            yi = parsedFunction(xi, functionFx);
            chart2.Series["Series1"].Points.Clear();
            listBoxOutput.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = parsedFunction(x, functionFx);
                chart2.Series["Series1"].Points.AddXY(x, y);
                listBoxOutput.Items.Add(x + "\t\t" + y);
            }
        }
        
        public void chartParametricProcess()
        {
            double h;
            h = (xf - xi) / n;
            chart4.Series["Series1"].Points.Clear();
            listBoxOutput.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                t = xi + k * h;
                x = parsedFunction(t, functionFx);
                y = parsedFunction(t, functionF1x);
                chart4.Series["Series1"].Points.AddXY(x, y);
                listBoxOutput.Items.Add(t + "\t\t" + x + "\t\t" + y);
            }
        }
        
        public void chartProcess2()
        {
            double h;
            h = (xf - xi) / n;
            yi = parsedFunction(xi, functionFx);
            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series2"].Points.Clear();
            listBoxOutput.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = parsedFunction(x, functionFx);
                y1 = parsedFunction(x, functionF1x);
                chart1.Series["Series1"].Points.AddXY(x, y);
                chart1.Series["Series2"].Points.AddXY(x, y1);
                listBoxOutput.Items.Add(x + "\t\t" + y);
            }
        }
         
        public void chartPolarProcess()
        {            
            double h;
            h = (xf - xi) / n;
            chart3.Series["Series1"].Points.Clear();
            listBoxOutput.Items.Clear();

            for (int k = 0; k < n; k++)
            {
                angle = xi + k * h;
                magnitude = parsedFunction(angle, functionFx);
                x = magnitude * Math.Cos(angle);
                y = magnitude * Math.Sin(angle);
                chart3.Series["Series1"].Points.AddXY(x, y);
                listBoxOutput.Items.Add(angle + "\t\t" + magnitude);
            }
        }

        public double parsedFunction(double x, string fx)
        {
            ExpressionParser parser1 = new ExpressionParser();
            parser1.Values.Add("x", x);
            return parser1.Parse(fx);            
        }

        public void outputProcess()
        {

        }
    }
}
