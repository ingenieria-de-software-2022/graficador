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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.input = new System.Windows.Forms.GroupBox();
            this.textBoxF1x = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.fxF1xButton = new System.Windows.Forms.Button();
            this.fx = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rga = new System.Windows.Forms.Button();
            this.fxFt = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.input.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.process.SuspendLayout();
            this.output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
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
            this.input.Location = new System.Drawing.Point(12, 35);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(138, 630);
            this.input.TabIndex = 0;
            this.input.TabStop = false;
            this.input.Text = "Entrada";
            // 
            // textBoxF1x
            // 
            this.textBoxF1x.Location = new System.Drawing.Point(46, 167);
            this.textBoxF1x.Name = "textBoxF1x";
            this.textBoxF1x.Size = new System.Drawing.Size(65, 20);
            this.textBoxF1x.TabIndex = 7;
            this.textBoxF1x.Text = "x";
            this.textBoxF1x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "f1(x),\r\ny(t)";
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
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "f(x),\r\ng(a),\r\nx(t)";
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
            this.menuStrip1.Size = new System.Drawing.Size(1378, 24);
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
            this.process.Controls.Add(this.fxFt);
            this.process.Controls.Add(this.rga);
            this.process.Controls.Add(this.fxF1xButton);
            this.process.Controls.Add(this.fx);
            this.process.Location = new System.Drawing.Point(156, 35);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(222, 630);
            this.process.TabIndex = 1;
            this.process.TabStop = false;
            this.process.Text = "Proceso";
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
            this.output.Controls.Add(this.chart4);
            this.output.Controls.Add(this.chart3);
            this.output.Controls.Add(this.chart2);
            this.output.Controls.Add(this.chart1);
            this.output.Controls.Add(this.listBoxOutput);
            this.output.Location = new System.Drawing.Point(393, 35);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(954, 630);
            this.output.TabIndex = 2;
            this.output.TabStop = false;
            this.output.Text = "Salida";
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(621, 31);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series2";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(313, 276);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.HorizontalScrollbar = true;
            this.listBoxOutput.Items.AddRange(new object[] {
            " "});
            this.listBoxOutput.Location = new System.Drawing.Point(17, 31);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(272, 576);
            this.listBoxOutput.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(306, 31);
            this.chart2.Name = "chart2";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.chart2.Series.Add(series13);
            this.chart2.Size = new System.Drawing.Size(300, 276);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea11.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chart3.Legends.Add(legend11);
            this.chart3.Location = new System.Drawing.Point(306, 326);
            this.chart3.Name = "chart3";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart3.Series.Add(series14);
            this.chart3.Size = new System.Drawing.Size(300, 281);
            this.chart3.TabIndex = 3;
            this.chart3.Text = "chart3";
            // 
            // rga
            // 
            this.rga.BackColor = System.Drawing.Color.SteelBlue;
            this.rga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rga.Location = new System.Drawing.Point(16, 98);
            this.rga.Margin = new System.Windows.Forms.Padding(0);
            this.rga.Name = "rga";
            this.rga.Size = new System.Drawing.Size(90, 26);
            this.rga.TabIndex = 2;
            this.rga.Text = "Graficar r=g(a)";
            this.rga.UseVisualStyleBackColor = false;
            this.rga.Click += new System.EventHandler(this.rga_Click);
            // 
            // fxFt
            // 
            this.fxFt.BackColor = System.Drawing.Color.SteelBlue;
            this.fxFt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fxFt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fxFt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fxFt.Location = new System.Drawing.Point(16, 135);
            this.fxFt.Margin = new System.Windows.Forms.Padding(0);
            this.fxFt.Name = "fxFt";
            this.fxFt.Size = new System.Drawing.Size(90, 38);
            this.fxFt.TabIndex = 3;
            this.fxFt.Text = "Graficar x=f(t),\r\ny=g(t)";
            this.fxFt.UseVisualStyleBackColor = false;
            this.fxFt.Click += new System.EventHandler(this.fxFt_Click);
            // 
            // chart4
            // 
            chartArea12.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart4.Legends.Add(legend12);
            this.chart4.Location = new System.Drawing.Point(621, 326);
            this.chart4.Name = "chart4";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart4.Series.Add(series15);
            this.chart4.Size = new System.Drawing.Size(313, 281);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 696);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button rga;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Button fxFt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

