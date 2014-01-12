namespace ProgramZaPlatu
{
    partial class DodajNovuFirmu
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
            this.txtImeFirme = new System.Windows.Forms.TextBox();
            this.txtGradFirme = new System.Windows.Forms.TextBox();
            this.txtAdresaFirme = new System.Windows.Forms.TextBox();
            this.txtPIBFirme = new System.Windows.Forms.TextBox();
            this.txtMBFirme = new System.Windows.Forms.TextBox();
            this.txtEmailFirme = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblPIB = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.btnОК = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctMB = new System.Windows.Forms.PictureBox();
            this.pctPIB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPIB)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImeFirme
            // 
            this.txtImeFirme.Location = new System.Drawing.Point(12, 12);
            this.txtImeFirme.Name = "txtImeFirme";
            this.txtImeFirme.Size = new System.Drawing.Size(166, 20);
            this.txtImeFirme.TabIndex = 0;
            this.txtImeFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeFirme_KeyPress);
            // 
            // txtGradFirme
            // 
            this.txtGradFirme.Location = new System.Drawing.Point(12, 38);
            this.txtGradFirme.Name = "txtGradFirme";
            this.txtGradFirme.Size = new System.Drawing.Size(166, 20);
            this.txtGradFirme.TabIndex = 1;
            this.txtGradFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradFirme_KeyPress);
            // 
            // txtAdresaFirme
            // 
            this.txtAdresaFirme.Location = new System.Drawing.Point(12, 64);
            this.txtAdresaFirme.Name = "txtAdresaFirme";
            this.txtAdresaFirme.Size = new System.Drawing.Size(166, 20);
            this.txtAdresaFirme.TabIndex = 2;
            this.txtAdresaFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdresaFirme_KeyPress);
            // 
            // txtPIBFirme
            // 
            this.txtPIBFirme.Location = new System.Drawing.Point(12, 90);
            this.txtPIBFirme.Name = "txtPIBFirme";
            this.txtPIBFirme.Size = new System.Drawing.Size(166, 20);
            this.txtPIBFirme.TabIndex = 3;
            this.txtPIBFirme.TextChanged += new System.EventHandler(this.txtPIBFirme_TextChanged);
            this.txtPIBFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIBFirme_KeyPress);
            this.txtPIBFirme.Leave += new System.EventHandler(this.txtPIBFirme_Leave);
            // 
            // txtMBFirme
            // 
            this.txtMBFirme.Location = new System.Drawing.Point(12, 142);
            this.txtMBFirme.Name = "txtMBFirme";
            this.txtMBFirme.Size = new System.Drawing.Size(166, 20);
            this.txtMBFirme.TabIndex = 5;
            this.txtMBFirme.TextChanged += new System.EventHandler(this.txtMBFirme_TextChanged);
            this.txtMBFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMBFirme_KeyPress);
            this.txtMBFirme.Leave += new System.EventHandler(this.txtMBFirme_Leave);
            // 
            // txtEmailFirme
            // 
            this.txtEmailFirme.Location = new System.Drawing.Point(12, 116);
            this.txtEmailFirme.Name = "txtEmailFirme";
            this.txtEmailFirme.Size = new System.Drawing.Size(166, 20);
            this.txtEmailFirme.TabIndex = 4;
            this.txtEmailFirme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmailFirme_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(184, 119);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Е - маил";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(184, 15);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(76, 13);
            this.lblFirma.TabIndex = 7;
            this.lblFirma.Text = "Назив фирме";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Location = new System.Drawing.Point(184, 41);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(31, 13);
            this.lblGrad.TabIndex = 8;
            this.lblGrad.Text = "Град";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(184, 67);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(44, 13);
            this.lblAdresa.TabIndex = 9;
            this.lblAdresa.Text = "Адреса";
            // 
            // lblPIB
            // 
            this.lblPIB.AutoSize = true;
            this.lblPIB.Location = new System.Drawing.Point(184, 93);
            this.lblPIB.Name = "lblPIB";
            this.lblPIB.Size = new System.Drawing.Size(30, 13);
            this.lblPIB.TabIndex = 10;
            this.lblPIB.Text = "ПИБ";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(185, 145);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 11;
            this.lblMB.Text = "МБ";
            // 
            // btnОК
            // 
            this.btnОК.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnОК.Location = new System.Drawing.Point(334, 31);
            this.btnОК.Name = "btnОК";
            this.btnОК.Size = new System.Drawing.Size(75, 49);
            this.btnОК.TabIndex = 6;
            this.btnОК.Text = "ОК";
            this.btnОК.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(334, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pctMB
            // 
            this.pctMB.Location = new System.Drawing.Point(214, 142);
            this.pctMB.Name = "pctMB";
            this.pctMB.Size = new System.Drawing.Size(20, 20);
            this.pctMB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMB.TabIndex = 12;
            this.pctMB.TabStop = false;
            // 
            // pctPIB
            // 
            this.pctPIB.Location = new System.Drawing.Point(220, 90);
            this.pctPIB.Name = "pctPIB";
            this.pctPIB.Size = new System.Drawing.Size(20, 20);
            this.pctPIB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPIB.TabIndex = 13;
            this.pctPIB.TabStop = false;
            // 
            // DodajNovuFirmu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(469, 202);
            this.ControlBox = false;
            this.Controls.Add(this.pctPIB);
            this.Controls.Add(this.pctMB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnОК);
            this.Controls.Add(this.lblMB);
            this.Controls.Add(this.lblPIB);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmailFirme);
            this.Controls.Add(this.txtMBFirme);
            this.Controls.Add(this.txtPIBFirme);
            this.Controls.Add(this.txtAdresaFirme);
            this.Controls.Add(this.txtGradFirme);
            this.Controls.Add(this.txtImeFirme);
            this.Name = "DodajNovuFirmu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавање нове фирме у базу података";
            ((System.ComponentModel.ISupportInitialize)(this.pctMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPIB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblPIB;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Button btnОК;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtImeFirme;
        public System.Windows.Forms.TextBox txtGradFirme;
        public System.Windows.Forms.TextBox txtAdresaFirme;
        public System.Windows.Forms.TextBox txtPIBFirme;
        public System.Windows.Forms.TextBox txtMBFirme;
        public System.Windows.Forms.TextBox txtEmailFirme;
        private System.Windows.Forms.PictureBox pctMB;
        private System.Windows.Forms.PictureBox pctPIB;
    }
}