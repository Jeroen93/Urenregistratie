namespace UrenRegistratie
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
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
            this.grpKlokken.SuspendLayout();
            this.grpTotalen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKlokken
            // 
            this.grpKlokken.Controls.Add(this.lblOnline);
            this.grpKlokken.Controls.Add(this.btnClockOut);
            this.grpKlokken.Controls.Add(this.btnClockIn);
            this.grpKlokken.Location = new System.Drawing.Point(13, 13);
            this.grpKlokken.Name = "grpKlokken";
            this.grpKlokken.Size = new System.Drawing.Size(221, 115);
            this.grpKlokken.TabIndex = 0;
            this.grpKlokken.TabStop = false;
            this.grpKlokken.Text = "In/uitklokken";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOnline.Location = new System.Drawing.Point(23, 85);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(35, 13);
            this.lblOnline.TabIndex = 2;
            this.lblOnline.Text = "label1";
            this.lblOnline.Click += new System.EventHandler(this.lblOnline_Click);
            // 
            // btnClockOut
            // 
            this.btnClockOut.Location = new System.Drawing.Point(104, 45);
            this.btnClockOut.Name = "btnClockOut";
            this.btnClockOut.Size = new System.Drawing.Size(75, 23);
            this.btnClockOut.TabIndex = 1;
            this.btnClockOut.Text = "Uitklokken";
            this.btnClockOut.UseVisualStyleBackColor = true;
            this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
            // 
            // btnClockIn
            // 
            this.btnClockIn.Location = new System.Drawing.Point(23, 45);
            this.btnClockIn.Name = "btnClockIn";
            this.btnClockIn.Size = new System.Drawing.Size(75, 23);
            this.btnClockIn.TabIndex = 0;
            this.btnClockIn.Text = "Inklokken";
            this.btnClockIn.UseVisualStyleBackColor = true;
            this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
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
            this.grpTotalen.Location = new System.Drawing.Point(240, 13);
            this.grpTotalen.Name = "grpTotalen";
            this.grpTotalen.Size = new System.Drawing.Size(227, 115);
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
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Verschil";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 393);
            this.Controls.Add(this.grpTotalen);
            this.Controls.Add(this.grpKlokken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UrenRegistratie";
            this.grpKlokken.ResumeLayout(false);
            this.grpKlokken.PerformLayout();
            this.grpTotalen.ResumeLayout(false);
            this.grpTotalen.PerformLayout();
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
    }
}

