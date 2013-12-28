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
            this.dataGridFirme = new System.Windows.Forms.DataGridView();
            this.btnOdabirFirmeiPodnosiocaOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Podnosilac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFirme
            // 
            this.dataGridFirme.AllowUserToAddRows = false;
            this.dataGridFirme.AllowUserToDeleteRows = false;
            this.dataGridFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firma});
            this.dataGridFirme.Location = new System.Drawing.Point(12, 12);
            this.dataGridFirme.Name = "dataGridFirme";
            this.dataGridFirme.RowTemplate.Height = 24;
            this.dataGridFirme.Size = new System.Drawing.Size(253, 128);
            this.dataGridFirme.TabIndex = 0;
            // 
            // btnOdabirFirmeiPodnosiocaOK
            // 
            this.btnOdabirFirmeiPodnosiocaOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOdabirFirmeiPodnosiocaOK.Location = new System.Drawing.Point(338, 108);
            this.btnOdabirFirmeiPodnosiocaOK.Name = "btnOdabirFirmeiPodnosiocaOK";
            this.btnOdabirFirmeiPodnosiocaOK.Size = new System.Drawing.Size(90, 32);
            this.btnOdabirFirmeiPodnosiocaOK.TabIndex = 1;
            this.btnOdabirFirmeiPodnosiocaOK.Text = "OK";
            this.btnOdabirFirmeiPodnosiocaOK.UseVisualStyleBackColor = true;
            this.btnOdabirFirmeiPodnosiocaOK.Click += new System.EventHandler(this.btnOdabirFirmeiPodnosiocaOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Podnosilac});
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(253, 126);
            this.dataGridView1.TabIndex = 2;
            // 
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Firma.DividerWidth = 10;
            this.Firma.HeaderText = "Фирма";
            this.Firma.MinimumWidth = 200;
            this.Firma.Name = "Firma";
            this.Firma.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Firma.Width = 200;
            // 
            // Podnosilac
            // 
            this.Podnosilac.DividerWidth = 10;
            this.Podnosilac.HeaderText = "Подносилац";
            this.Podnosilac.MinimumWidth = 200;
            this.Podnosilac.Name = "Podnosilac";
            this.Podnosilac.Width = 200;
            // 
            // OdabirFirmeiPodnosioca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 284);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdabirFirmeiPodnosiocaOK);
            this.Controls.Add(this.dataGridFirme);
            this.Name = "OdabirFirmeiPodnosioca";
            this.Text = "OdabirFirmeiPodnosioca";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFirme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFirme;
        private System.Windows.Forms.Button btnOdabirFirmeiPodnosiocaOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Podnosilac;
    }
}