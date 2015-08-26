namespace UrenRegistratie
{
    partial class formLoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioCareServant = new System.Windows.Forms.RadioButton();
            this.radioRecornect = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.Thuis = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Waar werk je vandaag?";
            // 
            // radioCareServant
            // 
            this.radioCareServant.AutoSize = true;
            this.radioCareServant.Checked = true;
            this.radioCareServant.Location = new System.Drawing.Point(16, 42);
            this.radioCareServant.Name = "radioCareServant";
            this.radioCareServant.Size = new System.Drawing.Size(84, 17);
            this.radioCareServant.TabIndex = 1;
            this.radioCareServant.TabStop = true;
            this.radioCareServant.Text = "CareServant";
            this.radioCareServant.UseVisualStyleBackColor = true;
            // 
            // radioRecornect
            // 
            this.radioRecornect.AutoSize = true;
            this.radioRecornect.Location = new System.Drawing.Point(16, 66);
            this.radioRecornect.Name = "radioRecornect";
            this.radioRecornect.Size = new System.Drawing.Size(75, 17);
            this.radioRecornect.TabIndex = 2;
            this.radioRecornect.Text = "Recornect";
            this.radioRecornect.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 111);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Thuis
            // 
            this.Thuis.AutoSize = true;
            this.Thuis.Location = new System.Drawing.Point(16, 90);
            this.Thuis.Name = "Thuis";
            this.Thuis.Size = new System.Drawing.Size(51, 17);
            this.Thuis.TabIndex = 4;
            this.Thuis.TabStop = true;
            this.Thuis.Text = "Thuis";
            this.Thuis.UseVisualStyleBackColor = true;
            // 
            // formLoc
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 146);
            this.Controls.Add(this.Thuis);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.radioRecornect);
            this.Controls.Add(this.radioCareServant);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoc";
            this.Text = "Locatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCareServant;
        private System.Windows.Forms.RadioButton radioRecornect;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton Thuis;
    }
}