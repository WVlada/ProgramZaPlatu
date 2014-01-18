/*
 * Created by SharpDevelop.
 * User: jelena
 * Date: 16.Oct.13
 * Time: 11:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramZaPlatu
{
	partial class Spisakzaposlenih
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spisakzaposlenih));
            this.lstSpisakZaposlenih = new System.Windows.Forms.ListView();
            this.colBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTipDokumenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOpstina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoreskiBroj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPromeniPodatkeSelektovanog = new System.Windows.Forms.Button();
            this.btnIzbrisiOznacenog = new System.Windows.Forms.Button();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnDodajNovog = new System.Windows.Forms.Button();
            this.lblDodajNovog = new System.Windows.Forms.Label();
            this.lblObrisiOznacenog = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStripZaposleni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.измениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.обришиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripZaposleni.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSpisakZaposlenih
            // 
            this.lstSpisakZaposlenih.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBroj,
            this.colPrezime,
            this.colIme,
            this.colTipDokumenta,
            this.colIDBroj,
            this.colOpstina,
            this.colPoreskiBroj});
            this.lstSpisakZaposlenih.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSpisakZaposlenih.FullRowSelect = true;
            this.lstSpisakZaposlenih.GridLines = true;
            this.lstSpisakZaposlenih.Location = new System.Drawing.Point(13, 79);
            this.lstSpisakZaposlenih.Name = "lstSpisakZaposlenih";
            this.lstSpisakZaposlenih.Size = new System.Drawing.Size(705, 222);
            this.lstSpisakZaposlenih.TabIndex = 0;
            this.lstSpisakZaposlenih.UseCompatibleStateImageBehavior = false;
            this.lstSpisakZaposlenih.View = System.Windows.Forms.View.Details;
            this.lstSpisakZaposlenih.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstSpisakZaposlenihMouseClick);
            // 
            // colBroj
            // 
            this.colBroj.Text = "Број";
            this.colBroj.Width = 51;
            // 
            // colPrezime
            // 
            this.colPrezime.Text = "Презиме";
            this.colPrezime.Width = 98;
            // 
            // colIme
            // 
            this.colIme.Text = "Име";
            this.colIme.Width = 102;
            // 
            // colTipDokumenta
            // 
            this.colTipDokumenta.Text = "Тип документа";
            this.colTipDokumenta.Width = 96;
            // 
            // colIDBroj
            // 
            this.colIDBroj.Text = "Идентификациони број";
            this.colIDBroj.Width = 142;
            // 
            // colOpstina
            // 
            this.colOpstina.Text = "Општина";
            this.colOpstina.Width = 106;
            // 
            // colPoreskiBroj
            // 
            this.colPoreskiBroj.Text = "Број општине";
            this.colPoreskiBroj.Width = 92;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Списак запослених";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPromeniPodatkeSelektovanog
            // 
            this.btnPromeniPodatkeSelektovanog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPromeniPodatkeSelektovanog.BackgroundImage")));
            this.btnPromeniPodatkeSelektovanog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPromeniPodatkeSelektovanog.Location = new System.Drawing.Point(13, 388);
            this.btnPromeniPodatkeSelektovanog.Name = "btnPromeniPodatkeSelektovanog";
            this.btnPromeniPodatkeSelektovanog.Size = new System.Drawing.Size(50, 50);
            this.btnPromeniPodatkeSelektovanog.TabIndex = 2;
            this.btnPromeniPodatkeSelektovanog.UseVisualStyleBackColor = true;
            this.btnPromeniPodatkeSelektovanog.Click += new System.EventHandler(this.BtnPromeniPodatkeSelektovanogClick);
            // 
            // btnIzbrisiOznacenog
            // 
            this.btnIzbrisiOznacenog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzbrisiOznacenog.BackgroundImage")));
            this.btnIzbrisiOznacenog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzbrisiOznacenog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbrisiOznacenog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzbrisiOznacenog.Location = new System.Drawing.Point(248, 324);
            this.btnIzbrisiOznacenog.Name = "btnIzbrisiOznacenog";
            this.btnIzbrisiOznacenog.Size = new System.Drawing.Size(50, 50);
            this.btnIzbrisiOznacenog.TabIndex = 4;
            this.btnIzbrisiOznacenog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIzbrisiOznacenog.UseVisualStyleBackColor = true;
            this.btnIzbrisiOznacenog.Click += new System.EventHandler(this.BtnIzbrisiOznacenogClick);
            // 
            // btnNazad
            // 
            this.btnNazad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNazad.BackgroundImage")));
            this.btnNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNazad.Location = new System.Drawing.Point(667, 345);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(50, 50);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.BtnNazadClick);
            // 
            // btnDodajNovog
            // 
            this.btnDodajNovog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodajNovog.BackgroundImage")));
            this.btnDodajNovog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDodajNovog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajNovog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDodajNovog.Location = new System.Drawing.Point(13, 324);
            this.btnDodajNovog.Name = "btnDodajNovog";
            this.btnDodajNovog.Size = new System.Drawing.Size(50, 50);
            this.btnDodajNovog.TabIndex = 3;
            this.btnDodajNovog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDodajNovog.UseVisualStyleBackColor = true;
            this.btnDodajNovog.Click += new System.EventHandler(this.BtnDodajNovogClick);
            // 
            // lblDodajNovog
            // 
            this.lblDodajNovog.BackColor = System.Drawing.Color.Transparent;
            this.lblDodajNovog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDodajNovog.ForeColor = System.Drawing.Color.Black;
            this.lblDodajNovog.Location = new System.Drawing.Point(69, 336);
            this.lblDodajNovog.Name = "lblDodajNovog";
            this.lblDodajNovog.Size = new System.Drawing.Size(100, 23);
            this.lblDodajNovog.TabIndex = 6;
            this.lblDodajNovog.Text = "Додај новог";
            this.lblDodajNovog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblObrisiOznacenog
            // 
            this.lblObrisiOznacenog.BackColor = System.Drawing.Color.Transparent;
            this.lblObrisiOznacenog.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblObrisiOznacenog.Location = new System.Drawing.Point(304, 336);
            this.lblObrisiOznacenog.Name = "lblObrisiOznacenog";
            this.lblObrisiOznacenog.Size = new System.Drawing.Size(152, 23);
            this.lblObrisiOznacenog.TabIndex = 7;
            this.lblObrisiOznacenog.Text = "Обриши означеног";
            this.lblObrisiOznacenog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(69, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Измени податке означеном";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(665, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Назад";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStripZaposleni
            // 
            this.contextMenuStripZaposleni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.измениToolStripMenuItem,
            this.toolStripSeparator1,
            this.обришиToolStripMenuItem});
            this.contextMenuStripZaposleni.Name = "contextMenuStrip1";
            this.contextMenuStripZaposleni.Size = new System.Drawing.Size(123, 54);
            this.contextMenuStripZaposleni.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ContextMenuStripZaposleniItemClicked);
            // 
            // измениToolStripMenuItem
            // 
            this.измениToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.измениToolStripMenuItem.Name = "измениToolStripMenuItem";
            this.измениToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.измениToolStripMenuItem.Text = "Измени";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // обришиToolStripMenuItem
            // 
            this.обришиToolStripMenuItem.Name = "обришиToolStripMenuItem";
            this.обришиToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.обришиToolStripMenuItem.Text = "Обриши";
            // 
            // Spisakzaposlenih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramZaPlatu.Properties.Resources._6685_image_2599AB36;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 445);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblObrisiOznacenog);
            this.Controls.Add(this.lblDodajNovog);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.btnIzbrisiOznacenog);
            this.Controls.Add(this.btnDodajNovog);
            this.Controls.Add(this.btnPromeniPodatkeSelektovanog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSpisakZaposlenih);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Spisakzaposlenih";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "iPayRoll - Spisak zaposlenih";
            this.Load += new System.EventHandler(this.SpisakZaposlenihLoad);
            this.contextMenuStripZaposleni.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem обришиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem измениToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripZaposleni;
		private System.Windows.Forms.ColumnHeader colIDBroj;
		private System.Windows.Forms.ColumnHeader colTipDokumenta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblObrisiOznacenog;
		private System.Windows.Forms.Label lblDodajNovog;
		private System.Windows.Forms.Button btnNazad;
		private System.Windows.Forms.Button btnIzbrisiOznacenog;
		private System.Windows.Forms.Button btnDodajNovog;
		private System.Windows.Forms.Button btnPromeniPodatkeSelektovanog;
		private System.Windows.Forms.ColumnHeader colBroj;
		private System.Windows.Forms.ColumnHeader colPoreskiBroj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader colOpstina;
		private System.Windows.Forms.ColumnHeader colIme;
		private System.Windows.Forms.ColumnHeader colPrezime;
		public System.Windows.Forms.ListView lstSpisakZaposlenih;
	}
}
