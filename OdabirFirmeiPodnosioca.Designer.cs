namespace ProgramZaPlatu
{
    partial class OdabirFirmeiPodnosioca
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
            this.btnOdabirFirmeiPodnosiocaOK = new System.Windows.Forms.Button();
            this.lstViewFirma = new System.Windows.Forms.ListView();
            this.broj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imefirme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstViewPodnosioci = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovaFirma = new System.Windows.Forms.Button();
            this.btnIzbrisiFirmu = new System.Windows.Forms.Button();
            this.btnNoviPodnosilac = new System.Windows.Forms.Button();
            this.btnIzbrisiPodnosioca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOdabirFirmeiPodnosiocaOK
            // 
            this.btnOdabirFirmeiPodnosiocaOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOdabirFirmeiPodnosiocaOK.Location = new System.Drawing.Point(364, 114);
            this.btnOdabirFirmeiPodnosiocaOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdabirFirmeiPodnosiocaOK.Name = "btnOdabirFirmeiPodnosiocaOK";
            this.btnOdabirFirmeiPodnosiocaOK.Size = new System.Drawing.Size(68, 57);
            this.btnOdabirFirmeiPodnosiocaOK.TabIndex = 1;
            this.btnOdabirFirmeiPodnosiocaOK.Text = "Настави даље";
            this.btnOdabirFirmeiPodnosiocaOK.UseVisualStyleBackColor = true;
            this.btnOdabirFirmeiPodnosiocaOK.Click += new System.EventHandler(this.btnOdabirFirmeiPodnosiocaOK_Click);
            // 
            // lstViewFirma
            // 
            this.lstViewFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewFirma.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.broj,
            this.Imefirme,
            this.columnHeader4,
            this.columnHeader5});
            this.lstViewFirma.FullRowSelect = true;
            this.lstViewFirma.GridLines = true;
            this.lstViewFirma.HideSelection = false;
            this.lstViewFirma.Location = new System.Drawing.Point(12, 12);
            this.lstViewFirma.MultiSelect = false;
            this.lstViewFirma.Name = "lstViewFirma";
            this.lstViewFirma.Size = new System.Drawing.Size(245, 102);
            this.lstViewFirma.TabIndex = 2;
            this.lstViewFirma.UseCompatibleStateImageBehavior = false;
            this.lstViewFirma.View = System.Windows.Forms.View.Details;
            // 
            // broj
            // 
            this.broj.Text = "Бр";
            this.broj.Width = 35;
            // 
            // Imefirme
            // 
            this.Imefirme.Text = "Име фирме";
            this.Imefirme.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ПИБ";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "МБ";
            this.columnHeader5.Width = 75;
            // 
            // lstViewPodnosioci
            // 
            this.lstViewPodnosioci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewPodnosioci.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewPodnosioci.FullRowSelect = true;
            this.lstViewPodnosioci.GridLines = true;
            this.lstViewPodnosioci.HideSelection = false;
            this.lstViewPodnosioci.Location = new System.Drawing.Point(12, 168);
            this.lstViewPodnosioci.MultiSelect = false;
            this.lstViewPodnosioci.Name = "lstViewPodnosioci";
            this.lstViewPodnosioci.Size = new System.Drawing.Size(245, 102);
            this.lstViewPodnosioci.TabIndex = 3;
            this.lstViewPodnosioci.UseCompatibleStateImageBehavior = false;
            this.lstViewPodnosioci.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Бр";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Име подносиоца";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ЈМБГ";
            this.columnHeader3.Width = 90;
            // 
            // btnNovaFirma
            // 
            this.btnNovaFirma.Location = new System.Drawing.Point(263, 12);
            this.btnNovaFirma.Name = "btnNovaFirma";
            this.btnNovaFirma.Size = new System.Drawing.Size(75, 51);
            this.btnNovaFirma.TabIndex = 4;
            this.btnNovaFirma.Text = "Додај нову фирму";
            this.btnNovaFirma.UseVisualStyleBackColor = true;
            this.btnNovaFirma.Click += new System.EventHandler(this.btnNovaFirma_Click);
            // 
            // btnIzbrisiFirmu
            // 
            this.btnIzbrisiFirmu.Location = new System.Drawing.Point(263, 69);
            this.btnIzbrisiFirmu.Name = "btnIzbrisiFirmu";
            this.btnIzbrisiFirmu.Size = new System.Drawing.Size(75, 45);
            this.btnIzbrisiFirmu.TabIndex = 5;
            this.btnIzbrisiFirmu.Text = "Избриши фирму";
            this.btnIzbrisiFirmu.UseVisualStyleBackColor = true;
            this.btnIzbrisiFirmu.Click += new System.EventHandler(this.btnIzbrisiFirmu_Click);
            // 
            // btnNoviPodnosilac
            // 
            this.btnNoviPodnosilac.Location = new System.Drawing.Point(263, 168);
            this.btnNoviPodnosilac.Name = "btnNoviPodnosilac";
            this.btnNoviPodnosilac.Size = new System.Drawing.Size(75, 51);
            this.btnNoviPodnosilac.TabIndex = 6;
            this.btnNoviPodnosilac.Text = "Додај новог подносиоца";
            this.btnNoviPodnosilac.UseVisualStyleBackColor = true;
            this.btnNoviPodnosilac.Click += new System.EventHandler(this.btnNoviPodnosilac_Click);
            // 
            // btnIzbrisiPodnosioca
            // 
            this.btnIzbrisiPodnosioca.Location = new System.Drawing.Point(263, 228);
            this.btnIzbrisiPodnosioca.Name = "btnIzbrisiPodnosioca";
            this.btnIzbrisiPodnosioca.Size = new System.Drawing.Size(75, 42);
            this.btnIzbrisiPodnosioca.TabIndex = 7;
            this.btnIzbrisiPodnosioca.Text = "Избриши подносиоца";
            this.btnIzbrisiPodnosioca.UseVisualStyleBackColor = true;
            this.btnIzbrisiPodnosioca.Click += new System.EventHandler(this.btnIzbrisiPodnosioca_Click);
            // 
            // OdabirFirmeiPodnosioca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramZaPlatu.Properties.Resources.podnosilac;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 282);
            this.ControlBox = false;
            this.Controls.Add(this.btnIzbrisiPodnosioca);
            this.Controls.Add(this.btnNoviPodnosilac);
            this.Controls.Add(this.btnIzbrisiFirmu);
            this.Controls.Add(this.btnNovaFirma);
            this.Controls.Add(this.lstViewPodnosioci);
            this.Controls.Add(this.lstViewFirma);
            this.Controls.Add(this.btnOdabirFirmeiPodnosiocaOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OdabirFirmeiPodnosioca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Одабир фирме и подносиоца пријаве";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdabirFirmeiPodnosiocaOK;
        private System.Windows.Forms.ListView lstViewFirma;
        private System.Windows.Forms.ColumnHeader broj;
        private System.Windows.Forms.ColumnHeader Imefirme;
        private System.Windows.Forms.ListView lstViewPodnosioci;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnNovaFirma;
        private System.Windows.Forms.Button btnIzbrisiFirmu;
        private System.Windows.Forms.Button btnNoviPodnosilac;
        private System.Windows.Forms.Button btnIzbrisiPodnosioca;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}