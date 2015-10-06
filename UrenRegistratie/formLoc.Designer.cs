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
            this.radioThuis = new System.Windows.Forms.RadioButton();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.grpVervoer = new System.Windows.Forms.GroupBox();
            this.tbKm = new System.Windows.Forms.TextBox();
            this.lblKm = new System.Windows.Forms.Label();
            this.radioOV = new System.Windows.Forms.RadioButton();
            this.radioAuto = new System.Windows.Forms.RadioButton();
            this.radioFiets = new System.Windows.Forms.RadioButton();
            this.grpLoc.SuspendLayout();
            this.grpVervoer.SuspendLayout();
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
            this.radioCareServant.Location = new System.Drawing.Point(6, 24);
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
            this.radioRecornect.Location = new System.Drawing.Point(6, 47);
            this.radioRecornect.Name = "radioRecornect";
            this.radioRecornect.Size = new System.Drawing.Size(75, 17);
            this.radioRecornect.TabIndex = 2;
            this.radioRecornect.Text = "Recornect";
            this.radioRecornect.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 168);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // radioThuis
            // 
            this.radioThuis.AutoSize = true;
            this.radioThuis.Location = new System.Drawing.Point(6, 70);
            this.radioThuis.Name = "radioThuis";
            this.radioThuis.Size = new System.Drawing.Size(51, 17);
            this.radioThuis.TabIndex = 4;
            this.radioThuis.TabStop = true;
            this.radioThuis.Text = "Thuis";
            this.radioThuis.UseVisualStyleBackColor = true;
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.radioCareServant);
            this.grpLoc.Controls.Add(this.radioThuis);
            this.grpLoc.Controls.Add(this.radioRecornect);
            this.grpLoc.Location = new System.Drawing.Point(16, 43);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Size = new System.Drawing.Size(123, 119);
            this.grpLoc.TabIndex = 5;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "Locatie";
            // 
            // grpVervoer
            // 
            this.grpVervoer.Controls.Add(this.tbKm);
            this.grpVervoer.Controls.Add(this.lblKm);
            this.grpVervoer.Controls.Add(this.radioOV);
            this.grpVervoer.Controls.Add(this.radioAuto);
            this.grpVervoer.Controls.Add(this.radioFiets);
            this.grpVervoer.Location = new System.Drawing.Point(145, 43);
            this.grpVervoer.Name = "grpVervoer";
            this.grpVervoer.Size = new System.Drawing.Size(123, 119);
            this.grpVervoer.TabIndex = 6;
            this.grpVervoer.TabStop = false;
            this.grpVervoer.Text = "Vervoer";
            // 
            // tbKm
            // 
            this.tbKm.Location = new System.Drawing.Point(68, 87);
            this.tbKm.MaxLength = 4;
            this.tbKm.Name = "tbKm";
            this.tbKm.Size = new System.Drawing.Size(33, 20);
            this.tbKm.TabIndex = 4;
            this.tbKm.Text = "4,4";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(6, 90);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(56, 13);
            this.lblKm.TabIndex = 3;
            this.lblKm.Text = "Aantal KM";
            // 
            // radioOV
            // 
            this.radioOV.AutoSize = true;
            this.radioOV.Location = new System.Drawing.Point(6, 70);
            this.radioOV.Name = "radioOV";
            this.radioOV.Size = new System.Drawing.Size(43, 17);
            this.radioOV.TabIndex = 2;
            this.radioOV.Text = "Bus";
            this.radioOV.UseVisualStyleBackColor = true;
            // 
            // radioAuto
            // 
            this.radioAuto.AutoSize = true;
            this.radioAuto.Location = new System.Drawing.Point(6, 47);
            this.radioAuto.Name = "radioAuto";
            this.radioAuto.Size = new System.Drawing.Size(47, 17);
            this.radioAuto.TabIndex = 1;
            this.radioAuto.Text = "Auto";
            this.radioAuto.UseVisualStyleBackColor = true;
            // 
            // radioFiets
            // 
            this.radioFiets.AutoSize = true;
            this.radioFiets.Checked = true;
            this.radioFiets.Location = new System.Drawing.Point(6, 24);
            this.radioFiets.Name = "radioFiets";
            this.radioFiets.Size = new System.Drawing.Size(47, 17);
            this.radioFiets.TabIndex = 0;
            this.radioFiets.TabStop = true;
            this.radioFiets.Text = "Fiets";
            this.radioFiets.UseVisualStyleBackColor = true;
            // 
            // formLoc
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 198);
            this.Controls.Add(this.grpVervoer);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formLoc";
            this.Text = "Locatie";
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpVervoer.ResumeLayout(false);
            this.grpVervoer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCareServant;
        private System.Windows.Forms.RadioButton radioRecornect;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton radioThuis;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.GroupBox grpVervoer;
        private System.Windows.Forms.TextBox tbKm;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.RadioButton radioOV;
        private System.Windows.Forms.RadioButton radioAuto;
        private System.Windows.Forms.RadioButton radioFiets;
    }
}