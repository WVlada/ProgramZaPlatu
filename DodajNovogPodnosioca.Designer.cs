namespace ProgramZaPlatu
{
    partial class DodajNovogPodnosioca
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
            this.txtImeiPrezime = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pctJMBG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctJMBG)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImeiPrezime
            // 
            this.txtImeiPrezime.Location = new System.Drawing.Point(12, 39);
            this.txtImeiPrezime.Name = "txtImeiPrezime";
            this.txtImeiPrezime.Size = new System.Drawing.Size(161, 20);
            this.txtImeiPrezime.TabIndex = 0;
            this.txtImeiPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImeiPrezime_KeyPress);
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(12, 97);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(161, 20);
            this.txtJMBG.TabIndex = 1;
            this.txtJMBG.TextChanged += new System.EventHandler(this.txtJMBG_TextChanged);
            this.txtJMBG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJMBG_KeyPress);
            this.txtJMBG.Leave += new System.EventHandler(this.txtJMBG_Leave);
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Location = new System.Drawing.Point(179, 42);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(85, 13);
            this.lblImeiPrezime.TabIndex = 2;
            this.lblImeiPrezime.Text = "Име и презиме";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ЈМБГ";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(295, 26);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 44);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pctJMBG
            // 
            this.pctJMBG.Location = new System.Drawing.Point(219, 97);
            this.pctJMBG.Name = "pctJMBG";
            this.pctJMBG.Size = new System.Drawing.Size(20, 20);
            this.pctJMBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctJMBG.TabIndex = 13;
            this.pctJMBG.TabStop = false;
            // 
            // DodajNovogPodnosioca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(414, 221);
            this.ControlBox = false;
            this.Controls.Add(this.pctJMBG);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblImeiPrezime);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.txtImeiPrezime);
            this.Name = "DodajNovogPodnosioca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавање новог подносиоца пријаве";
            ((System.ComponentModel.ISupportInitialize)(this.pctJMBG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeiPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtImeiPrezime;
        public System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.PictureBox pctJMBG;
    }
}