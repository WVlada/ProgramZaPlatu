/*
 * Created by SharpDevelop.
 * User: jelena
 * Date: 22.Oct.13
 * Time: 3:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramZaPlatu
{
	partial class IzmenaPodataka
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IzmenaPodataka));
			this.lblImeZaposlenog = new System.Windows.Forms.Label();
			this.btnIzmeni = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblImeZaposlenog
			// 
			this.lblImeZaposlenog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.lblImeZaposlenog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lblImeZaposlenog.Location = new System.Drawing.Point(95, 20);
			this.lblImeZaposlenog.Name = "lblImeZaposlenog";
			this.lblImeZaposlenog.Size = new System.Drawing.Size(330, 23);
			this.lblImeZaposlenog.TabIndex = 0;
			this.lblImeZaposlenog.Text = "label1";
			this.lblImeZaposlenog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnIzmeni
			// 
			this.btnIzmeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzmeni.BackgroundImage")));
			this.btnIzmeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIzmeni.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnIzmeni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnIzmeni.Location = new System.Drawing.Point(293, 191);
			this.btnIzmeni.Name = "btnIzmeni";
			this.btnIzmeni.Size = new System.Drawing.Size(70, 70);
			this.btnIzmeni.TabIndex = 1;
			this.btnIzmeni.Text = "Izmeni";
			this.btnIzmeni.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCancel.Location = new System.Drawing.Point(399, 191);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(70, 70);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// IzmenaPodataka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(522, 273);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnIzmeni);
			this.Controls.Add(this.lblImeZaposlenog);
			this.Name = "IzmenaPodataka";
			this.Text = "Izmena podataka o zaposlenom";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnIzmeni;
		public System.Windows.Forms.Label lblImeZaposlenog;
	}
}
