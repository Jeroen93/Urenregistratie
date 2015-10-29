namespace UrenRegistratie
{
    partial class FormEditTime
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
            this.lblHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.btnHourDown = new System.Windows.Forms.Button();
            this.btnMinDown = new System.Windows.Forms.Button();
            this.btnHourUp = new System.Windows.Forms.Button();
            this.btnMinUp = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(39, 53);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(44, 31);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(117, 53);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(44, 31);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "00";
            // 
            // btnHourDown
            // 
            this.btnHourDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourDown.Location = new System.Drawing.Point(45, 101);
            this.btnHourDown.Name = "btnHourDown";
            this.btnHourDown.Size = new System.Drawing.Size(38, 23);
            this.btnHourDown.TabIndex = 3;
            this.btnHourDown.Text = "˅";
            this.btnHourDown.UseVisualStyleBackColor = true;
            // 
            // btnMinDown
            // 
            this.btnMinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinDown.Location = new System.Drawing.Point(123, 101);
            this.btnMinDown.Name = "btnMinDown";
            this.btnMinDown.Size = new System.Drawing.Size(38, 23);
            this.btnMinDown.TabIndex = 4;
            this.btnMinDown.Text = "˅";
            this.btnMinDown.UseVisualStyleBackColor = true;
            // 
            // btnHourUp
            // 
            this.btnHourUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHourUp.Location = new System.Drawing.Point(45, 12);
            this.btnHourUp.Name = "btnHourUp";
            this.btnHourUp.Size = new System.Drawing.Size(38, 23);
            this.btnHourUp.TabIndex = 5;
            this.btnHourUp.Text = "˄";
            this.btnHourUp.UseVisualStyleBackColor = true;
            // 
            // btnMinUp
            // 
            this.btnMinUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinUp.Location = new System.Drawing.Point(123, 12);
            this.btnMinUp.Name = "btnMinUp";
            this.btnMinUp.Size = new System.Drawing.Size(38, 23);
            this.btnMinUp.TabIndex = 6;
            this.btnMinUp.Text = "˄";
            this.btnMinUp.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(136, 152);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(52, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(200, 187);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnMinUp);
            this.Controls.Add(this.btnHourUp);
            this.Controls.Add(this.btnMinDown);
            this.Controls.Add(this.btnHourDown);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Tijd Aanpassen";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Button btnHourDown;
        private System.Windows.Forms.Button btnMinDown;
        private System.Windows.Forms.Button btnHourUp;
        private System.Windows.Forms.Button btnMinUp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}