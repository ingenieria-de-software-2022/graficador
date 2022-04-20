using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFgraficador
{
    public partial class Form1 : Form
    {
        double xi, xf, x, y;
        int n;

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

        private void fx_Click(object sender, EventArgs e)
        {
            inputProcess();
            chartProcess();
        }

        public void inputProcess()
        {
            try
            {
                xi = double.Parse(textBoxXi.Text);
                xf = double.Parse(textBoxXf.Text);
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
            chart1.Series["Series1"].Points.Clear();


            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = Math.Cos(x);
                chart1.Series["Series1"].Points.AddXY(x, y);
            }
        }
    }
}
