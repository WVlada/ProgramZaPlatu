/*
 * Created by SharpDevelop.
 * User: jelena
 * Date: 17.Oct.13
 * Time: 10:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramZaPlatu
{
	partial class DodajNovogForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajNovogForm));
			this.txtPrezime = new System.Windows.Forms.TextBox();
			this.lblPrezime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOpstina = new System.Windows.Forms.TextBox();
			this.lblOpstina = new System.Windows.Forms.Label();
			this.txtIDBroj = new System.Windows.Forms.TextBox();
			this.lblPoreskiBroj = new System.Windows.Forms.Label();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.btnOdustani = new System.Windows.Forms.Button();
			this.txtIme = new System.Windows.Forms.TextBox();
			this.lblIme = new System.Windows.Forms.Label();
			this.cboTipDokumenta = new System.Windows.Forms.ComboBox();
			this.txtBrojOpstine = new System.Windows.Forms.TextBox();
			this.lblBrojOpstine = new System.Windows.Forms.Label();
			this.lblTekstOdustani = new System.Windows.Forms.Label();
			this.lblTekstDodaj = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPrezime
			// 
			this.txtPrezime.Location = new System.Drawing.Point(12, 25);
			this.txtPrezime.Name = "txtPrezime";
			this.txtPrezime.Size = new System.Drawing.Size(158, 20);
			this.txtPrezime.TabIndex = 0;
			// 
			// lblPrezime
			// 
			this.lblPrezime.BackColor = System.Drawing.Color.Transparent;
			this.lblPrezime.Font = new System.Drawing.Font("Arial", 10F);
			this.lblPrezime.Location = new System.Drawing.Point(12, 48);
			this.lblPrezime.Name = "lblPrezime";
			this.lblPrezime.Size = new System.Drawing.Size(66, 23);
			this.lblPrezime.TabIndex = 1;
			this.lblPrezime.Text = "Презиме";
			this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 10F);
			this.label2.Location = new System.Drawing.Point(11, 110);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(122, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Тип документа";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtOpstina
			// 
			this.txtOpstina.Location = new System.Drawing.Point(12, 159);
			this.txtOpstina.Name = "txtOpstina";
			this.txtOpstina.Size = new System.Drawing.Size(121, 20);
			this.txtOpstina.TabIndex = 4;
			// 
			// lblOpstina
			// 
			this.lblOpstina.BackColor = System.Drawing.Color.Transparent;
			this.lblOpstina.Font = new System.Drawing.Font("Arial", 10F);
			this.lblOpstina.Location = new System.Drawing.Point(12, 185);
			this.lblOpstina.Name = "lblOpstina";
			this.lblOpstina.Size = new System.Drawing.Size(82, 23);
			this.lblOpstina.TabIndex = 5;
			this.lblOpstina.Text = "Општина";
			this.lblOpstina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtIDBroj
			// 
			this.txtIDBroj.Location = new System.Drawing.Point(200, 86);
			this.txtIDBroj.Name = "txtIDBroj";
			this.txtIDBroj.Size = new System.Drawing.Size(144, 20);
			this.txtIDBroj.TabIndex = 3;
			// 
			// lblPoreskiBroj
			// 
			this.lblPoreskiBroj.BackColor = System.Drawing.Color.Transparent;
			this.lblPoreskiBroj.Font = new System.Drawing.Font("Arial", 10F);
			this.lblPoreskiBroj.Location = new System.Drawing.Point(200, 110);
			this.lblPoreskiBroj.Name = "lblPoreskiBroj";
			this.lblPoreskiBroj.Size = new System.Drawing.Size(179, 23);
			this.lblPoreskiBroj.TabIndex = 7;
			this.lblPoreskiBroj.Text = "Идентификациони број";
			this.lblPoreskiBroj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDodaj
			// 
			this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
			this.btnDodaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDodaj.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDodaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDodaj.Location = new System.Drawing.Point(420, 25);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(70, 70);
			this.btnDodaj.TabIndex = 6;
			this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.BtnDodajClick);
			// 
			// btnOdustani
			// 
			this.btnOdustani.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOdustani.BackgroundImage")));
			this.btnOdustani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOdustani.Location = new System.Drawing.Point(420, 141);
			this.btnOdustani.Name = "btnOdustani";
			this.btnOdustani.Size = new System.Drawing.Size(70, 67);
			this.btnOdustani.TabIndex = 7;
			this.btnOdustani.UseVisualStyleBackColor = true;
			// 
			// txtIme
			// 
			this.txtIme.Location = new System.Drawing.Point(200, 25);
			this.txtIme.Name = "txtIme";
			this.txtIme.Size = new System.Drawing.Size(144, 20);
			this.txtIme.TabIndex = 1;
			// 
			// lblIme
			// 
			this.lblIme.BackColor = System.Drawing.Color.Transparent;
			this.lblIme.Font = new System.Drawing.Font("Arial", 10F);
			this.lblIme.Location = new System.Drawing.Point(200, 48);
			this.lblIme.Name = "lblIme";
			this.lblIme.Size = new System.Drawing.Size(52, 23);
			this.lblIme.TabIndex = 11;
			this.lblIme.Text = "Име";
			this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboTipDokumenta
			// 
			this.cboTipDokumenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipDokumenta.FormattingEnabled = true;
			this.cboTipDokumenta.Location = new System.Drawing.Point(11, 86);
			this.cboTipDokumenta.Name = "cboTipDokumenta";
			this.cboTipDokumenta.Size = new System.Drawing.Size(159, 21);
			this.cboTipDokumenta.TabIndex = 2;
			// 
			// txtBrojOpstine
			// 
			this.txtBrojOpstine.Location = new System.Drawing.Point(200, 159);
			this.txtBrojOpstine.Name = "txtBrojOpstine";
			this.txtBrojOpstine.Size = new System.Drawing.Size(111, 20);
			this.txtBrojOpstine.TabIndex = 5;
			this.txtBrojOpstine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBrojOpstineKeyPress);
			// 
			// lblBrojOpstine
			// 
			this.lblBrojOpstine.BackColor = System.Drawing.Color.Transparent;
			this.lblBrojOpstine.Font = new System.Drawing.Font("Arial", 10F);
			this.lblBrojOpstine.Location = new System.Drawing.Point(200, 185);
			this.lblBrojOpstine.Name = "lblBrojOpstine";
			this.lblBrojOpstine.Size = new System.Drawing.Size(100, 23);
			this.lblBrojOpstine.TabIndex = 13;
			this.lblBrojOpstine.Text = "Број општине";
			this.lblBrojOpstine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblTekstOdustani
			// 
			this.lblTekstOdustani.BackColor = System.Drawing.Color.Transparent;
			this.lblTekstOdustani.Font = new System.Drawing.Font("Arial", 10F);
			this.lblTekstOdustani.Location = new System.Drawing.Point(406, 211);
			this.lblTekstOdustani.Name = "lblTekstOdustani";
			this.lblTekstOdustani.Size = new System.Drawing.Size(100, 23);
			this.lblTekstOdustani.TabIndex = 14;
			this.lblTekstOdustani.Text = "Одустани";
			this.lblTekstOdustani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblTekstDodaj
			// 
			this.lblTekstDodaj.BackColor = System.Drawing.Color.Transparent;
			this.lblTekstDodaj.Font = new System.Drawing.Font("Arial", 10F);
			this.lblTekstDodaj.Location = new System.Drawing.Point(406, 98);
			this.lblTekstDodaj.Name = "lblTekstDodaj";
			this.lblTekstDodaj.Size = new System.Drawing.Size(100, 23);
			this.lblTekstDodaj.TabIndex = 15;
			this.lblTekstDodaj.Text = "Додај";
			this.lblTekstDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DodajNovogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(544, 250);
			this.Controls.Add(this.lblTekstDodaj);
			this.Controls.Add(this.lblTekstOdustani);
			this.Controls.Add(this.lblBrojOpstine);
			this.Controls.Add(this.txtBrojOpstine);
			this.Controls.Add(this.lblIme);
			this.Controls.Add(this.txtIme);
			this.Controls.Add(this.btnOdustani);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.lblPoreskiBroj);
			this.Controls.Add(this.txtIDBroj);
			this.Controls.Add(this.lblOpstina);
			this.Controls.Add(this.txtOpstina);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTipDokumenta);
			this.Controls.Add(this.lblPrezime);
			this.Controls.Add(this.txtPrezime);
			this.Name = "DodajNovogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "iPayRoll - Dodavanje novog zaposlenog";
			this.Load += new System.EventHandler(this.DodajNovogFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblTekstDodaj;
		private System.Windows.Forms.Label lblTekstOdustani;
		private System.Windows.Forms.Label lblBrojOpstine;
		public System.Windows.Forms.TextBox txtBrojOpstine;
		private System.Windows.Forms.Label lblIme;
		public System.Windows.Forms.TextBox txtIme;
		private System.Windows.Forms.Button btnOdustani;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.Label lblPoreskiBroj;
		public System.Windows.Forms.TextBox txtIDBroj;
		private System.Windows.Forms.Label lblOpstina;
		public System.Windows.Forms.TextBox txtOpstina;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox cboTipDokumenta;
		private System.Windows.Forms.Label lblPrezime;
		public System.Windows.Forms.TextBox txtPrezime;
	}
}
