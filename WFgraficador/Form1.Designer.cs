namespace WFgraficador
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.input = new System.Windows.Forms.GroupBox();
            this.textBoxFx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXf = new System.Windows.Forms.TextBox();
            this.textBoxXi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process = new System.Windows.Forms.GroupBox();
            this.fx = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBoxF1x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fxF1xButton = new System.Windows.Forms.Button();
            this.input.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.process.SuspendLayout();
            this.output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Controls.Add(this.textBoxF1x);
            this.input.Controls.Add(this.label4);
            this.input.Controls.Add(this.textBoxFx);
            this.input.Controls.Add(this.label3);
            this.input.Controls.Add(this.textBoxXf);
            this.input.Controls.Add(this.textBoxXi);
            this.input.Controls.Add(this.label2);
            this.input.Controls.Add(this.label1);
            this.input.Location = new System.Drawing.Point(12, 189);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(138, 187);
            this.input.TabIndex = 0;
            this.input.TabStop = false;
            this.input.Text = "Entrada";
            // 
            // textBoxFx
            // 
            this.textBoxFx.Location = new System.Drawing.Point(46, 119);
            this.textBoxFx.Name = "textBoxFx";
            this.textBoxFx.Size = new System.Drawing.Size(65, 20);
            this.textBoxFx.TabIndex = 5;
            this.textBoxFx.Text = "x";
            this.textBoxFx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "f(x)";
            // 
            // textBoxXf
            // 
            this.textBoxXf.Location = new System.Drawing.Point(46, 72);
            this.textBoxXf.Name = "textBoxXf";
            this.textBoxXf.Size = new System.Drawing.Size(65, 20);
            this.textBoxXf.TabIndex = 3;
            this.textBoxXf.Text = "0";
            this.textBoxXf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxXi
            // 
            this.textBoxXi.Location = new System.Drawing.Point(46, 41);
            this.textBoxXi.Name = "textBoxXi";
            this.textBoxXi.Size = new System.Drawing.Size(65, 20);
            this.textBoxXi.TabIndex = 2;
            this.textBoxXi.Text = "0";
            this.textBoxXi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "xf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "xi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // process
            // 
            this.process.Controls.Add(this.fxF1xButton);
            this.process.Controls.Add(this.fx);
            this.process.Location = new System.Drawing.Point(156, 45);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(222, 508);
            this.process.TabIndex = 1;
            this.process.TabStop = false;
            this.process.Text = "Proceso";
            // 
            // fx
            // 
            this.fx.BackColor = System.Drawing.Color.SteelBlue;
            this.fx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fx.Location = new System.Drawing.Point(16, 31);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(90, 26);
            this.fx.TabIndex = 0;
            this.fx.Text = "Graficar y=f(x)";
            this.fx.UseVisualStyleBackColor = false;
            this.fx.Click += new System.EventHandler(this.fx_Click);
            // 
            // output
            // 
            this.output.Controls.Add(this.chart1);
            this.output.Controls.Add(this.listBoxOutput);
            this.output.Location = new System.Drawing.Point(393, 45);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(646, 508);
            this.output.TabIndex = 2;
            this.output.TabStop = false;
            this.output.Text = "Salida";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(309, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(313, 459);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Items.AddRange(new object[] {
            " "});
            this.listBoxOutput.Location = new System.Drawing.Point(17, 31);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(272, 459);
            this.listBoxOutput.TabIndex = 0;
            // 
            // textBoxF1x
            // 
            this.textBoxF1x.Location = new System.Drawing.Point(46, 145);
            this.textBoxF1x.Name = "textBoxF1x";
            this.textBoxF1x.Size = new System.Drawing.Size(65, 20);
            this.textBoxF1x.TabIndex = 7;
            this.textBoxF1x.Text = "x";
            this.textBoxF1x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "f1(x)";
            // 
            // fxF1xButton
            // 
            this.fxF1xButton.BackColor = System.Drawing.Color.SteelBlue;
            this.fxF1xButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fxF1xButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fxF1xButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fxF1xButton.Location = new System.Drawing.Point(16, 63);
            this.fxF1xButton.Margin = new System.Windows.Forms.Padding(0);
            this.fxF1xButton.Name = "fxF1xButton";
            this.fxF1xButton.Size = new System.Drawing.Size(90, 26);
            this.fxF1xButton.TabIndex = 1;
            this.fxF1xButton.Text = "Graficar y1, y2";
            this.fxF1xButton.UseVisualStyleBackColor = false;
            this.fxF1xButton.Click += new System.EventHandler(this.fxF1xButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 565);
            this.Controls.Add(this.output);
            this.Controls.Add(this.process);
            this.Controls.Add(this.input);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graficador de funciones";
            this.input.ResumeLayout(false);
            this.input.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.process.ResumeLayout(false);
            this.output.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox input;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox output;
        private System.Windows.Forms.TextBox textBoxXf;
        private System.Windows.Forms.TextBox textBoxXi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxFx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxF1x;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fxF1xButton;
    }
}

