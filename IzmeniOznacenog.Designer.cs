/*
 * Created by SharpDevelop.
 * User: jelena
 * Date: 24.Oct.13
 * Time: 10:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramZaPlatu
{
	partial class IzmeniOznacenog
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmeniOznacenog));
			this.lblTekst = new System.Windows.Forms.Label();
			this.lblImekojeseMenja = new System.Windows.Forms.Label();
			this.txtPrezimePromena = new System.Windows.Forms.TextBox();
			this.lblPrezimePromena = new System.Windows.Forms.Label();
			this.txtImePromena = new System.Windows.Forms.TextBox();
			this.lblImepromena = new System.Windows.Forms.Label();
			this.txtOpstinaPromena = new System.Windows.Forms.TextBox();
			this.lblOpstinaPromena = new System.Windows.Forms.Label();
			this.txtIDBrojPromena = new System.Windows.Forms.TextBox();
			this.lblIDBrojPromena = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.btnPonisti = new System.Windows.Forms.Button();
			this.radioButJMBG = new System.Windows.Forms.RadioButton();
			this.radioButIzbeglicka = new System.Windows.Forms.RadioButton();
			this.radioButPasos = new System.Windows.Forms.RadioButton();
			this.radioButPosebna = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButOstalo = new System.Windows.Forms.RadioButton();
			this.txtBrojOpstinePromena = new System.Windows.Forms.TextBox();
			this.lblBrojOpstine = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTekst
			// 
			this.lblTekst.BackColor = System.Drawing.Color.Transparent;
			this.lblTekst.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblTekst.Location = new System.Drawing.Point(12, 20);
			this.lblTekst.Name = "lblTekst";
			this.lblTekst.Size = new System.Drawing.Size(218, 23);
			this.lblTekst.TabIndex = 0;
			this.lblTekst.Text = "Измена података за:";
			// 
			// lblImekojeseMenja
			// 
			this.lblImekojeseMenja.BackColor = System.Drawing.Color.Transparent;
			this.lblImekojeseMenja.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblImekojeseMenja.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblImekojeseMenja.Location = new System.Drawing.Point(236, 20);
			this.lblImekojeseMenja.Name = "lblImekojeseMenja";
			this.lblImekojeseMenja.Size = new System.Drawing.Size(205, 23);
			this.lblImekojeseMenja.TabIndex = 1;
			this.lblImekojeseMenja.Text = "//ovde dodje ime//";
			this.lblImekojeseMenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPrezimePromena
			// 
			this.txtPrezimePromena.Location = new System.Drawing.Point(12, 69);
			this.txtPrezimePromena.Name = "txtPrezimePromena";
			this.txtPrezimePromena.Size = new System.Drawing.Size(166, 20);
			this.txtPrezimePromena.TabIndex = 2;
			// 
			// lblPrezimePromena
			// 
			this.lblPrezimePromena.BackColor = System.Drawing.Color.Transparent;
			this.lblPrezimePromena.Font = new System.Drawing.Font("Arial", 10F);
			this.lblPrezimePromena.Location = new System.Drawing.Point(12, 92);
			this.lblPrezimePromena.Name = "lblPrezimePromena";
			this.lblPrezimePromena.Size = new System.Drawing.Size(100, 23);
			this.lblPrezimePromena.TabIndex = 3;
			this.lblPrezimePromena.Text = "Презиме";
			this.lblPrezimePromena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtImePromena
			// 
			this.txtImePromena.Location = new System.Drawing.Point(212, 69);
			this.txtImePromena.Name = "txtImePromena";
			this.txtImePromena.Size = new System.Drawing.Size(166, 20);
			this.txtImePromena.TabIndex = 4;
			// 
			// lblImepromena
			// 
			this.lblImepromena.BackColor = System.Drawing.Color.Transparent;
			this.lblImepromena.Font = new System.Drawing.Font("Arial", 10F);
			this.lblImepromena.Location = new System.Drawing.Point(212, 92);
			this.lblImepromena.Name = "lblImepromena";
			this.lblImepromena.Size = new System.Drawing.Size(63, 23);
			this.lblImepromena.TabIndex = 5;
			this.lblImepromena.Text = "Име";
			this.lblImepromena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtOpstinaPromena
			// 
			this.txtOpstinaPromena.Location = new System.Drawing.Point(12, 128);
			this.txtOpstinaPromena.Name = "txtOpstinaPromena";
			this.txtOpstinaPromena.Size = new System.Drawing.Size(166, 20);
			this.txtOpstinaPromena.TabIndex = 6;
			// 
			// lblOpstinaPromena
			// 
			this.lblOpstinaPromena.BackColor = System.Drawing.Color.Transparent;
			this.lblOpstinaPromena.Font = new System.Drawing.Font("Arial", 10F);
			this.lblOpstinaPromena.Location = new System.Drawing.Point(12, 151);
			this.lblOpstinaPromena.Name = "lblOpstinaPromena";
			this.lblOpstinaPromena.Size = new System.Drawing.Size(100, 23);
			this.lblOpstinaPromena.TabIndex = 7;
			this.lblOpstinaPromena.Text = "Општина";
			this.lblOpstinaPromena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtIDBrojPromena
			// 
			this.txtIDBrojPromena.Location = new System.Drawing.Point(212, 128);
			this.txtIDBrojPromena.Name = "txtIDBrojPromena";
			this.txtIDBrojPromena.Size = new System.Drawing.Size(166, 20);
			this.txtIDBrojPromena.TabIndex = 8;
			// 
			// lblIDBrojPromena
			// 
			this.lblIDBrojPromena.BackColor = System.Drawing.Color.Transparent;
			this.lblIDBrojPromena.Font = new System.Drawing.Font("Arial", 10F);
			this.lblIDBrojPromena.Location = new System.Drawing.Point(212, 154);
			this.lblIDBrojPromena.Name = "lblIDBrojPromena";
			this.lblIDBrojPromena.Size = new System.Drawing.Size(166, 23);
			this.lblIDBrojPromena.TabIndex = 9;
			this.lblIDBrojPromena.Text = "Идентификациони број";
			this.lblIDBrojPromena.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeni.BackgroundImage")));
			this.btnIzmeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIzmeni.Font = new System.Drawing.Font("Arial", 14F);
			this.btnIzmeni.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.btnIzmeni.Location = new System.Drawing.Point(200, 263);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(100, 100);
			this.btnIzmeni.TabIndex = 10;
			this.btnIzmeni.Text = "У реду";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeniClick);
			// 
			// btnPonisti
			// 
			this.btnPonisti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPonisti.BackgroundImage")));
			this.btnPonisti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPonisti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnPonisti.Font = new System.Drawing.Font("Arial", 14F);
			this.btnPonisti.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.btnPonisti.Location = new System.Drawing.Point(355, 263);
			this.btnPonisti.Name = "btnPonisti";
			this.btnPonisti.Size = new System.Drawing.Size(100, 100);
			this.btnPonisti.TabIndex = 11;
			this.btnPonisti.Text = "Поништи";
			this.btnPonisti.UseVisualStyleBackColor = true;
			// 
			// radioButJMBG
			// 
			this.radioButJMBG.Font = new System.Drawing.Font("Arial", 10F);
			this.radioButJMBG.Location = new System.Drawing.Point(6, 31);
			this.radioButJMBG.Name = "radioButJMBG";
			this.radioButJMBG.Size = new System.Drawing.Size(172, 24);
			this.radioButJMBG.TabIndex = 12;
			this.radioButJMBG.TabStop = true;
			this.radioButJMBG.Text = "ЈМБГ";
			this.radioButJMBG.UseVisualStyleBackColor = true;
			// 
			// radioButIzbeglicka
			// 
			this.radioButIzbeglicka.Font = new System.Drawing.Font("Arial", 10F);
			this.radioButIzbeglicka.Location = new System.Drawing.Point(6, 60);
			this.radioButIzbeglicka.Name = "radioButIzbeglicka";
			this.radioButIzbeglicka.Size = new System.Drawing.Size(188, 24);
			this.radioButIzbeglicka.TabIndex = 13;
			this.radioButIzbeglicka.TabStop = true;
			this.radioButIzbeglicka.Text = "Избегличка легитимација";
			this.radioButIzbeglicka.UseVisualStyleBackColor = true;
			// 
			// radioButPasos
			// 
			this.radioButPasos.Font = new System.Drawing.Font("Arial", 10F);
			this.radioButPasos.Location = new System.Drawing.Point(6, 90);
			this.radioButPasos.Name = "radioButPasos";
			this.radioButPasos.Size = new System.Drawing.Size(80, 24);
			this.radioButPasos.TabIndex = 14;
			this.radioButPasos.TabStop = true;
			this.radioButPasos.Text = "Пасош";
			this.radioButPasos.UseVisualStyleBackColor = true;
			// 
			// radioButPosebna
			// 
			this.radioButPosebna.Font = new System.Drawing.Font("Arial", 10F);
			this.radioButPosebna.Location = new System.Drawing.Point(6, 109);
			this.radioButPosebna.Name = "radioButPosebna";
			this.radioButPosebna.Size = new System.Drawing.Size(210, 55);
			this.radioButPosebna.TabIndex = 15;
			this.radioButPosebna.TabStop = true;
			this.radioButPosebna.Text = "Посебна ознака за случајеве одобрене од ПУ";
			this.radioButPosebna.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.radioButOstalo);
			this.groupBox1.Controls.Add(this.radioButJMBG);
			this.groupBox1.Controls.Add(this.radioButPosebna);
			this.groupBox1.Controls.Add(this.radioButIzbeglicka);
			this.groupBox1.Controls.Add(this.radioButPasos);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Arial", 10F);
			this.groupBox1.Location = new System.Drawing.Point(455, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 200);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип документа";
			// 
			// radioButOstalo
			// 
			this.radioButOstalo.Font = new System.Drawing.Font("Arial", 10F);
			this.radioButOstalo.Location = new System.Drawing.Point(6, 161);
			this.radioButOstalo.Name = "radioButOstalo";
			this.radioButOstalo.Size = new System.Drawing.Size(172, 24);
			this.radioButOstalo.TabIndex = 16;
			this.radioButOstalo.TabStop = true;
			this.radioButOstalo.Text = "Остало";
			this.radioButOstalo.UseVisualStyleBackColor = true;
			// 
			// txtBrojOpstinePromena
			// 
			this.txtBrojOpstinePromena.Location = new System.Drawing.Point(12, 187);
			this.txtBrojOpstinePromena.Name = "txtBrojOpstinePromena";
			this.txtBrojOpstinePromena.Size = new System.Drawing.Size(100, 20);
			this.txtBrojOpstinePromena.TabIndex = 17;
			// 
			// lblBrojOpstine
			// 
			this.lblBrojOpstine.BackColor = System.Drawing.Color.Transparent;
			this.lblBrojOpstine.Font = new System.Drawing.Font("Arial", 10F);
			this.lblBrojOpstine.Location = new System.Drawing.Point(12, 210);
			this.lblBrojOpstine.Name = "lblBrojOpstine";
			this.lblBrojOpstine.Size = new System.Drawing.Size(106, 23);
			this.lblBrojOpstine.TabIndex = 18;
			this.lblBrojOpstine.Text = "Број oпштине";
			this.lblBrojOpstine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// IzmeniOznacenog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(708, 403);
			this.Controls.Add(this.lblBrojOpstine);
			this.Controls.Add(this.txtBrojOpstinePromena);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnPonisti);
			this.Controls.Add(this.btnIzmeni);
			this.Controls.Add(this.lblIDBrojPromena);
			this.Controls.Add(this.txtIDBrojPromena);
			this.Controls.Add(this.lblOpstinaPromena);
			this.Controls.Add(this.txtOpstinaPromena);
			this.Controls.Add(this.lblImepromena);
			this.Controls.Add(this.txtImePromena);
			this.Controls.Add(this.lblPrezimePromena);
			this.Controls.Add(this.txtPrezimePromena);
			this.Controls.Add(this.lblImekojeseMenja);
			this.Controls.Add(this.lblTekst);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "IzmeniOznacenog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "IzmeniOznacenog";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblBrojOpstine;
		public System.Windows.Forms.TextBox txtBrojOpstinePromena;
		public System.Windows.Forms.RadioButton radioButOstalo;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.RadioButton radioButPosebna;
		public System.Windows.Forms.RadioButton radioButPasos;
		public System.Windows.Forms.RadioButton radioButIzbeglicka;
		public System.Windows.Forms.RadioButton radioButJMBG;
		private System.Windows.Forms.Button btnPonisti;
		private System.Windows.Forms.Button btnIzmeni;
		private System.Windows.Forms.Label lblIDBrojPromena;
		public System.Windows.Forms.TextBox txtIDBrojPromena;
		private System.Windows.Forms.Label lblOpstinaPromena;
		public System.Windows.Forms.TextBox txtOpstinaPromena;
		private System.Windows.Forms.Label lblImepromena;
		public System.Windows.Forms.TextBox txtImePromena;
		private System.Windows.Forms.Label lblPrezimePromena;
		public System.Windows.Forms.TextBox txtPrezimePromena;
		public System.Windows.Forms.Label lblImekojeseMenja;
		private System.Windows.Forms.Label lblTekst;
	}
}
