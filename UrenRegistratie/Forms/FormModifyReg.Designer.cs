namespace UrenRegistratie.Forms
{
    partial class FormModifyReg
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
            this.lbRegs = new System.Windows.Forms.ListBox();
            this.gbRegData = new System.Windows.Forms.GroupBox();
            this.dtCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTransportValue = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.lblTransport = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbRegData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbRegs
            // 
            this.lbRegs.FormattingEnabled = true;
            this.lbRegs.Location = new System.Drawing.Point(191, 10);
            this.lbRegs.Name = "lbRegs";
            this.lbRegs.Size = new System.Drawing.Size(164, 134);
            this.lbRegs.TabIndex = 0;
            // 
            // gbRegData
            // 
            this.gbRegData.Controls.Add(this.dtCheckOut);
            this.gbRegData.Controls.Add(this.dtCheckIn);
            this.gbRegData.Controls.Add(this.btnAdd);
            this.gbRegData.Controls.Add(this.lblTransportValue);
            this.gbRegData.Controls.Add(this.lblLocation);
            this.gbRegData.Controls.Add(this.btnEditDelete);
            this.gbRegData.Controls.Add(this.lblTransport);
            this.gbRegData.Controls.Add(this.label3);
            this.gbRegData.Controls.Add(this.label2);
            this.gbRegData.Controls.Add(this.label1);
            this.gbRegData.Location = new System.Drawing.Point(12, 4);
            this.gbRegData.Name = "gbRegData";
            this.gbRegData.Size = new System.Drawing.Size(173, 143);
            this.gbRegData.TabIndex = 1;
            this.gbRegData.TabStop = false;
            this.gbRegData.Text = "gbRegData";
            // 
            // dtCheckOut
            // 
            this.dtCheckOut.CustomFormat = "HH:mm";
            this.dtCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckOut.Location = new System.Drawing.Point(86, 45);
            this.dtCheckOut.Name = "dtCheckOut";
            this.dtCheckOut.ShowUpDown = true;
            this.dtCheckOut.Size = new System.Drawing.Size(55, 20);
            this.dtCheckOut.TabIndex = 4;
            this.dtCheckOut.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // dtCheckIn
            // 
            this.dtCheckIn.CustomFormat = "HH:mm";
            this.dtCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckIn.Location = new System.Drawing.Point(86, 21);
            this.dtCheckIn.Name = "dtCheckIn";
            this.dtCheckIn.ShowUpDown = true;
            this.dtCheckIn.Size = new System.Drawing.Size(55, 20);
            this.dtCheckIn.TabIndex = 3;
            this.dtCheckIn.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(88, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Toevoegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTransportValue
            // 
            this.lblTransportValue.AutoSize = true;
            this.lblTransportValue.Location = new System.Drawing.Point(83, 94);
            this.lblTransportValue.Name = "lblTransportValue";
            this.lblTransportValue.Size = new System.Drawing.Size(29, 13);
            this.lblTransportValue.TabIndex = 8;
            this.lblTransportValue.Text = "Auto";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(83, 71);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 13);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "CareServant";
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.Location = new System.Drawing.Point(6, 114);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(79, 23);
            this.btnEditDelete.TabIndex = 4;
            this.btnEditDelete.Text = "Aanpassen";
            this.btnEditDelete.UseVisualStyleBackColor = true;
            this.btnEditDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(6, 94);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(47, 13);
            this.lblTransport.TabIndex = 3;
            this.lblTransport.Text = "Vervoer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locatie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Klok uit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klok in:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(280, 167);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // FormModifyReg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 202);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbRegData);
            this.Controls.Add(this.lbRegs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModifyReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registraties aanpassen";
            this.gbRegData.ResumeLayout(false);
            this.gbRegData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbRegs;
        private System.Windows.Forms.GroupBox gbRegData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Label lblTransportValue;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtCheckIn;
        private System.Windows.Forms.DateTimePicker dtCheckOut;
    }
}