namespace UrenRegistratie
{
    sealed partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.grpKlokken = new System.Windows.Forms.GroupBox();
            this.lblOnline = new System.Windows.Forms.Label();
            this.btnClockOut = new System.Windows.Forms.Button();
            this.btnClockIn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpTotalen = new System.Windows.Forms.GroupBox();
            this.lblUrenDiff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUrenTotaal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUrenWeek = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOverzicht = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtOverzicht = new System.Windows.Forms.DateTimePicker();
            this.sfdOverview = new System.Windows.Forms.SaveFileDialog();
            this.chrtUren = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpChart = new System.Windows.Forms.TabPage();
            this.tpUren = new System.Windows.Forms.TabPage();
            this.ucWeek = new UrenRegistratie.UcWeek();
            this.grpKlokken.SuspendLayout();
            this.grpTotalen.SuspendLayout();
            this.grpOverzicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUren)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKlokken
            // 
            this.grpKlokken.Controls.Add(this.lblOnline);
            this.grpKlokken.Controls.Add(this.btnClockOut);
            this.grpKlokken.Controls.Add(this.btnClockIn);
            this.grpKlokken.Location = new System.Drawing.Point(13, 13);
            this.grpKlokken.Name = "grpKlokken";
            this.grpKlokken.Size = new System.Drawing.Size(243, 115);
            this.grpKlokken.TabIndex = 0;
            this.grpKlokken.TabStop = false;
            this.grpKlokken.Text = "In/uitklokken";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOnline.Location = new System.Drawing.Point(20, 77);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(110, 13);
            this.lblOnline.TabIndex = 2;
            this.lblOnline.Text = "Aanwezig sinds 00:00";
            // 
            // btnClockOut
            // 
            this.btnClockOut.Location = new System.Drawing.Point(104, 45);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(75, 23);
            this.btnClockOut.TabIndex = 1;
            this.btnClockOut.Text = "Uitklokken";
            this.btnClockOut.UseVisualStyleBackColor = true;
            // 
            // btnClockIn
            // 
            this.btnClockIn.Location = new System.Drawing.Point(23, 45);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(75, 23);
            this.btnClockIn.TabIndex = 0;
            this.btnClockIn.Text = "Inklokken";
            this.btnClockIn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            // 
            // grpTotalen
            // 
            this.grpTotalen.Controls.Add(this.lblUrenDiff);
            this.grpTotalen.Controls.Add(this.label3);
            this.grpTotalen.Controls.Add(this.lblUrenTotaal);
            this.grpTotalen.Controls.Add(this.label2);
            this.grpTotalen.Controls.Add(this.lblUrenWeek);
            this.grpTotalen.Controls.Add(this.label1);
            this.grpTotalen.Location = new System.Drawing.Point(262, 13);
            this.grpTotalen.Name = "grpTotalen";
            this.grpTotalen.Size = new System.Drawing.Size(221, 115);
            this.grpTotalen.TabIndex = 1;
            this.grpTotalen.TabStop = false;
            this.grpTotalen.Text = "Totalen";
            // 
            // lblUrenDiff
            // 
            this.lblUrenDiff.AutoSize = true;
            this.lblUrenDiff.Location = new System.Drawing.Point(166, 77);
            this.lblUrenDiff.Name = "lblUrenDiff";
            this.lblUrenDiff.Size = new System.Drawing.Size(13, 13);
            this.lblUrenDiff.TabIndex = 5;
            this.lblUrenDiff.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verschil:";
            // 
            // lblUrenTotaal
            // 
            this.lblUrenTotaal.AutoSize = true;
            this.lblUrenTotaal.Location = new System.Drawing.Point(166, 55);
            this.lblUrenTotaal.Name = "lblUrenTotaal";
            this.lblUrenTotaal.Size = new System.Drawing.Size(13, 13);
            this.lblUrenTotaal.TabIndex = 3;
            this.lblUrenTotaal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Totaal gewerkt:";
            // 
            // lblUrenWeek
            // 
            this.lblUrenWeek.AutoSize = true;
            this.lblUrenWeek.Location = new System.Drawing.Point(166, 33);
            this.lblUrenWeek.Name = "lblUrenWeek";
            this.lblUrenWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUrenWeek.Size = new System.Drawing.Size(13, 13);
            this.lblUrenWeek.TabIndex = 1;
            this.lblUrenWeek.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal uur deze week:";
            // 
            // grpOverzicht
            // 
            this.grpOverzicht.Controls.Add(this.btnGenerate);
            this.grpOverzicht.Controls.Add(this.dtOverzicht);
            this.grpOverzicht.Location = new System.Drawing.Point(489, 13);
            this.grpOverzicht.Name = "grpOverzicht";
            this.grpOverzicht.Size = new System.Drawing.Size(221, 115);
            this.grpOverzicht.TabIndex = 2;
            this.grpOverzicht.TabStop = false;
            this.grpOverzicht.Text = "Overzicht uitdraaien";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(23, 79);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(156, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Genereren";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtOverzicht
            // 
            this.dtOverzicht.CustomFormat = "MMMM yyyy";
            this.dtOverzicht.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOverzicht.Location = new System.Drawing.Point(7, 45);
            this.dtOverzicht.Name = "dtOverzicht";
            this.dtOverzicht.Size = new System.Drawing.Size(200, 20);
            this.dtOverzicht.TabIndex = 0;
            // 
            // sfdOverview
            // 
            this.sfdOverview.DefaultExt = "csv";
            this.sfdOverview.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            // 
            // chrtUren
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtUren.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtUren.Legends.Add(legend1);
            this.chrtUren.Location = new System.Drawing.Point(23, 163);
            this.chrtUren.Name = "chrtUren";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.Points.Add(dataPoint1);
            this.chrtUren.Series.Add(series1);
            this.chrtUren.Series.Add(series2);
            this.chrtUren.Size = new System.Drawing.Size(756, 286);
            this.chrtUren.TabIndex = 3;
            this.chrtUren.Text = "chart1";
            this.chrtUren.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpChart);
            this.tabControl.Controls.Add(this.tpUren);
            this.tabControl.Location = new System.Drawing.Point(13, 135);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 324);
            this.tabControl.TabIndex = 4;
            // 
            // tpChart
            // 
            this.tpChart.Controls.Add(this.ucWeek);
            this.tpChart.Location = new System.Drawing.Point(4, 22);
            this.tpChart.Name = "tpChart";
            this.tpChart.Padding = new System.Windows.Forms.Padding(3);
            this.tpChart.Size = new System.Drawing.Size(768, 298);
            this.tpChart.TabIndex = 0;
            this.tpChart.Text = "Grafiek";
            this.tpChart.UseVisualStyleBackColor = true;
            // 
            // tpUren
            // 
            this.tpUren.Location = new System.Drawing.Point(4, 22);
            this.tpUren.Name = "tpUren";
            this.tpUren.Padding = new System.Windows.Forms.Padding(3);
            this.tpUren.Size = new System.Drawing.Size(768, 298);
            this.tpUren.TabIndex = 1;
            this.tpUren.Text = "Uren";
            this.tpUren.UseVisualStyleBackColor = true;
            // 
            // ucWeek
            // 
            this.ucWeek.Location = new System.Drawing.Point(7, 6);
            this.ucWeek.Name = "ucWeek";
            this.ucWeek.Size = new System.Drawing.Size(756, 286);
            this.ucWeek.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 471);
            this.Controls.Add(this.chrtUren);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.grpOverzicht);
            this.Controls.Add(this.grpTotalen);
            this.Controls.Add(this.grpKlokken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "UrenRegistratie";
            this.grpKlokken.ResumeLayout(false);
            this.grpKlokken.PerformLayout();
            this.grpTotalen.ResumeLayout(false);
            this.grpTotalen.PerformLayout();
            this.grpOverzicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtUren)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKlokken;
        private System.Windows.Forms.Button btnClockOut;
        private System.Windows.Forms.Button btnClockIn;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpTotalen;
        private System.Windows.Forms.Label lblUrenWeek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrenTotaal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUrenDiff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpOverzicht;
        private System.Windows.Forms.DateTimePicker dtOverzicht;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.SaveFileDialog sfdOverview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUren;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpChart;
        private System.Windows.Forms.TabPage tpUren;
        private UcWeek ucWeek;
    }
}

