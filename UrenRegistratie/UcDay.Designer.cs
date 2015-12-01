namespace UrenRegistratie
{
    partial class UcDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTotaal = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblTotaal);
            this.groupBox1.Controls.Add(this.lblOut);
            this.groupBox1.Controls.Add(this.lblIn);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDate.Location = new System.Drawing.Point(3, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(91, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotaal
            // 
            this.lblTotaal.AutoSize = true;
            this.lblTotaal.Location = new System.Drawing.Point(4, 54);
            this.lblTotaal.Name = "lblTotaal";
            this.lblTotaal.Size = new System.Drawing.Size(40, 13);
            this.lblTotaal.TabIndex = 2;
            this.lblTotaal.Text = "Totaal:";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(4, 37);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(47, 13);
            this.lblOut.TabIndex = 1;
            this.lblOut.Text = "Uit: 0:00";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(4, 20);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(43, 13);
            this.lblIn.TabIndex = 0;
            this.lblIn.Text = "In: 0:00";
            // 
            // UcDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UcDay";
            this.Size = new System.Drawing.Size(100, 150);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTotaal;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblIn;
    }
}
