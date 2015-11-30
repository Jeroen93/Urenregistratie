namespace UrenRegistratie
{
    partial class UcWeek
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
            this.btnPrevWeek = new System.Windows.Forms.Button();
            this.ucDay6 = new UrenRegistratie.UcDay();
            this.ucDay5 = new UrenRegistratie.UcDay();
            this.ucDay4 = new UrenRegistratie.UcDay();
            this.ucDay3 = new UrenRegistratie.UcDay();
            this.ucDay2 = new UrenRegistratie.UcDay();
            this.ucDay1 = new UrenRegistratie.UcDay();
            this.ucDay0 = new UrenRegistratie.UcDay();
            this.btnNextWeek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrevWeek
            // 
            this.btnPrevWeek.Location = new System.Drawing.Point(9, 216);
            this.btnPrevWeek.Name = "btnPrevWeek";
            this.btnPrevWeek.Size = new System.Drawing.Size(23, 23);
            this.btnPrevWeek.TabIndex = 0;
            this.btnPrevWeek.Text = "<";
            this.btnPrevWeek.UseVisualStyleBackColor = true;
            // 
            // ucDay6
            // 
            this.ucDay6.Location = new System.Drawing.Point(645, 60);
            this.ucDay6.Name = "ucDay6";
            this.ucDay6.Size = new System.Drawing.Size(100, 150);
            this.ucDay6.TabIndex = 7;
            // 
            // ucDay5
            // 
            this.ucDay5.Location = new System.Drawing.Point(539, 60);
            this.ucDay5.Name = "ucDay5";
            this.ucDay5.Size = new System.Drawing.Size(100, 150);
            this.ucDay5.TabIndex = 6;
            // 
            // ucDay4
            // 
            this.ucDay4.Location = new System.Drawing.Point(433, 60);
            this.ucDay4.Name = "ucDay4";
            this.ucDay4.Size = new System.Drawing.Size(100, 150);
            this.ucDay4.TabIndex = 5;
            // 
            // ucDay3
            // 
            this.ucDay3.Location = new System.Drawing.Point(327, 60);
            this.ucDay3.Name = "ucDay3";
            this.ucDay3.Size = new System.Drawing.Size(100, 150);
            this.ucDay3.TabIndex = 4;
            // 
            // ucDay2
            // 
            this.ucDay2.Location = new System.Drawing.Point(221, 60);
            this.ucDay2.Name = "ucDay2";
            this.ucDay2.Size = new System.Drawing.Size(100, 150);
            this.ucDay2.TabIndex = 3;
            // 
            // ucDay1
            // 
            this.ucDay1.Location = new System.Drawing.Point(115, 60);
            this.ucDay1.Name = "ucDay1";
            this.ucDay1.Size = new System.Drawing.Size(100, 150);
            this.ucDay1.TabIndex = 2;
            // 
            // ucDay0
            // 
            this.ucDay0.Location = new System.Drawing.Point(9, 60);
            this.ucDay0.Name = "ucDay0";
            this.ucDay0.Size = new System.Drawing.Size(100, 150);
            this.ucDay0.TabIndex = 1;
            // 
            // btnNextWeek
            // 
            this.btnNextWeek.Location = new System.Drawing.Point(722, 216);
            this.btnNextWeek.Name = "btnNextWeek";
            this.btnNextWeek.Size = new System.Drawing.Size(23, 23);
            this.btnNextWeek.TabIndex = 8;
            this.btnNextWeek.Text = ">";
            this.btnNextWeek.UseVisualStyleBackColor = true;
            // 
            // UcWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNextWeek);
            this.Controls.Add(this.ucDay6);
            this.Controls.Add(this.ucDay5);
            this.Controls.Add(this.ucDay4);
            this.Controls.Add(this.ucDay3);
            this.Controls.Add(this.ucDay2);
            this.Controls.Add(this.ucDay1);
            this.Controls.Add(this.ucDay0);
            this.Controls.Add(this.btnPrevWeek);
            this.Name = "UcWeek";
            this.Size = new System.Drawing.Size(756, 286);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrevWeek;
        private UcDay ucDay0;
        private UcDay ucDay1;
        private UcDay ucDay2;
        private UcDay ucDay3;
        private UcDay ucDay4;
        private UcDay ucDay5;
        private UcDay ucDay6;
        private System.Windows.Forms.Button btnNextWeek;
    }
}
