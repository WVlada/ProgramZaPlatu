using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace ProgramZaPlatu
{
	public partial class DodajNovogForm : Form
	{
		public DodajNovogForm()
		{
			InitializeComponent();
		}
		
		void DodajNovogFormLoad(object sender, EventArgs e)
		{
			string PathdoSpiska = @"..\\..\\xml\tipdokumenta.xml";
			XmlDocument FajlTipDokumenta = new XmlDocument();
			FajlTipDokumenta.Load(PathdoSpiska);
			cboTipDokumenta.Items.Clear();
			
			// "/ListaDokumenta - je root node. SelectNodes vraca listu "Dokument" Nodeova
			XmlNodeList ListaDokumenata = FajlTipDokumenta.SelectNodes("/TipoviDokumenta/Dokument");
			
			// pravicu listu jer array bi morao biti fiksan. - posle prebacujem u array cisto jer mogu :)
			List<string> ListaTipova = new List<string>();
			
			foreach (XmlNode tip in ListaDokumenata) 
			{
				string tipDokumenta = tip["Tip"].InnerText;
				ListaTipova.Add(tipDokumenta);
			}
			
			ListaTipova.ToArray();
		    cboTipDokumenta.DataSource = ListaTipova;	
		}
		
		void TxtBrojOpstineKeyPress(object sender, KeyPressEventArgs e)
		{
			char ch = e.KeyChar; // 8 je backspace, 13 je ENTER , 46 je Tackica 
			if (!Char.IsDigit(ch) && ch !=8 && ch !=13)
				{
			e.Handled = true;
				}
		
			// ovaj uslov tretira ENTER kao TAB
		if ((int)e.KeyChar == (int)Keys.Enter)
				{
				this.SelectNextControl((Control)sender, true, true, true, true);
				}	
		}
		// ovo sam uneo da ne bih dozvolio polovican unos podataka
		void BtnDodajClick(object sender, EventArgs e)
		{
			if (this.txtIme.Text == ""
			   	|| this.txtPrezime.Text == ""
			   	|| this.cboTipDokumenta.Text == ""
			    || this.txtIDBroj.Text == ""
			   	|| this.txtOpstina.Text == ""
			   	|| this.txtBrojOpstine.Text == "")
			{MessageBox.Show("Нисте унели све захтеване податке, унос неће бити реализован.");}
				else
				{
				DialogResult = DialogResult.OK;
				}
			
		}
	}
}
