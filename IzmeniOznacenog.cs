using System;
using System.Drawing;
using System.Windows.Forms;
using ProgramZaPlatu;


namespace ProgramZaPlatu
{
	public partial class IzmeniOznacenog : Form
	{
		public IzmeniOznacenog(string Prezime, string Ime, string TipDokumenta, string IDBroj, string Opstina, string BrojOpstine)
		{
			InitializeComponent();
			lblImekojeseMenja.Text = Prezime +"  " + Ime;
			txtPrezimePromena.Text = Prezime;
			txtImePromena.Text = Ime;
			txtIDBrojPromena.Text = IDBroj;
			txtOpstinaPromena.Text = Opstina;
			txtBrojOpstinePromena.Text = BrojOpstine;
		}
		
		void BtnIzmeniClick(object sender, EventArgs e)
		{
			if   ( this.txtPrezimePromena.Text == ""
			   	|| this.txtImePromena.Text == ""
			   	|| this.txtOpstinaPromena.Text == ""
			    || this.txtIDBrojPromena.Text == ""
			   	|| this.txtBrojOpstinePromena.Text == ""
			   	
			   	&& (this.radioButIzbeglicka.Focused == false 
			   	    && this.radioButJMBG.Focused == false
			   	    && this.radioButOstalo.Focused == false
			   	    && this.radioButPasos.Focused == false
			   	    && this.radioButPosebna.Focused == false))
			   	
			{MessageBox.Show("Нисте унели све захтеване податке, промена неће бити реализована.");}
				else
				{
				DialogResult = DialogResult.OK;
				}
				
		}
	}
}
