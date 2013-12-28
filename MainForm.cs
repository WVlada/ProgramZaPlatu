using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Linq;
using System.Data.SQLite;

namespace ProgramZaPlatu
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
            startujOdabir();
            InitializeComponent();
		}
        void startujOdabir()
        {
            OdabirFirmeiPodnosioca FormaZaOdabir = new OdabirFirmeiPodnosioca();
            FormaZaOdabir.ShowDialog();
        }
        void MainFormLoad(object sender, EventArgs e)
        {
            LoadTipDohotka();
            LoadImenaZaposlenih();
            LoadBazupodataka();
        }
		void LoadVrstaUgovora(string SelectovaniTipDohotka)//ovo trba on select za vrstuobracuna
			{	
			string selektovaniTIP = SelectovaniTipDohotka;
			string FajlTipObracunaPath = @"..\\..\\xml\Vrsteugovora.xml";
			XmlDocument docVrstaUgovora = new XmlDocument();
			docVrstaUgovora.Load(FajlTipObracunaPath);
			cboVrstaUgovora.Items.Clear(); // ovde dobijam error, jer je DataSource property vec SET, i sad izgleda ne mogu da ga menjam
			
			XmlNodeList ListaVrsta = docVrstaUgovora.SelectNodes("//Ugovor[@kategorija=\""+selektovaniTIP+"\"]");// jbt uspeo!
			
			List<string> selektovani = new List<string>();
			
			foreach (XmlNode tip in ListaVrsta) 
				{
				string tipVrste = tip["Tip"].InnerText;
				selektovani.Add(tipVrste);
				
				}
			//selektovani.ToArray();
			
			// morao sam da zamenim postupak ovom petljom
			for(int i = 0; i< selektovani.Count; i++)
			    {
				cboVrstaUgovora.Items.Add(selektovani[i]);
			    }
			// cboVrstaUgovora.Items.Add
		    // cboVrstaUgovora.DataSource = selektovani;	
			}
		void LoadTipDohotka()
		{
			string FajlTipObracunaPath = @"..\\..\\xml\Vrsteugovora.xml";
			XmlDocument docVrsteUgovora = new XmlDocument();
			docVrsteUgovora.Load(FajlTipObracunaPath);
			cboTipDohotka.Items.Clear();
			
			XmlNodeList ListaObracuna = docVrsteUgovora.SelectNodes("Vrsteugovora/Ugovor/@kategorija");
			
			List<string> ListaTipova = new List<string>();
			
			foreach (XmlNode tip in ListaObracuna) 
				{
				string yyy = tip.Value.ToString();
				ListaTipova.Add(yyy);
				}
				// string tipUgovora = tip["Ugovor"].Value.ToString(); //["Ugovor"].GetAttribute("kategorija");
				// ListaTipova.Add(tipUgovora);
			
			//	ListaTipova.Distinct().ToArray();
			//ListaTipova.ToArray();
			
		    cboTipDohotka.DataSource = ListaTipova.Distinct().ToArray();;	
		}
		void LoadImenaZaposlenih()
		{
		string FajlImenaZaposlenih = @"..\\..\\xml\Zaposleni.xml";
			XmlDocument docImenaZaposlenih = new XmlDocument();
			docImenaZaposlenih.Load(FajlImenaZaposlenih);
			cboImeZaposlenog.Items.Clear();
			
			XmlNodeList ListaZaposlenih = docImenaZaposlenih.SelectNodes("/Zaposleni/Profile");
			
			List<string> ListaProfila = new List<string>();
			
			foreach (XmlNode tip in ListaZaposlenih) 
				{
				string ImeiPrezime = tip["Ime"].InnerText + " " + tip["Prezime"].InnerText;
				ListaProfila.Add(ImeiPrezime);
				}
			ListaProfila.ToArray();
		    cboImeZaposlenog.DataSource = ListaProfila;
		}
//RAD SA BAZOM		
		void LoadBazupodataka()
			{//trebam napraviti formicu da menjam podatke u bazici
			SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
			konekcija.Open();
			string sql = "select * from Preduzeca where RedniBroj=2";
			SQLiteCommand komanda = new SQLiteCommand(sql,konekcija);
			SQLiteDataReader reader = komanda.ExecuteReader();
			lblFirma.Text = reader.GetValue(0).ToString();
			konekcija.Close();
			}
		void UcitajStopeSelektovanogUgovora(string selektovaniUgovor)
			{
			string VrstaUgovora = selektovaniUgovor;
			
			// zato sto po defaultu trazi u bin\debug folderu
			string FajlStopePath = @"..\\..\\xml\Vrsteugovora.xml";
			XmlDocument docStope = new XmlDocument();
			
			if (File.Exists(FajlStopePath))
				{
				docStope.Load(FajlStopePath);
				
				XmlNode Vrsta = docStope.SelectSingleNode("/Vrsteugovora/Ugovor[Tip=\""+VrstaUgovora+"\"]");
				
				//ucitavanje stopa u textboxove
				txtNajnizaOsnovicaLEVO.Text	 =	Vrsta.FirstChild.NextSibling.InnerText;
				txtNajvisaOsnovicaLEVO.Text	 =	Vrsta.FirstChild.NextSibling.NextSibling.InnerText;
				txtIznosPoreskogUmanjenjaLEVO.Text = Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaPorezaLEVO.Text 	 =  Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaPIOZaposlenogLEVO.Text 	 = 	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaZdravstvoZaposlenogLEVO.Text = 	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaNezaposlenostiZaposlenogLEVO.Text = 	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaPIOPoslodavacLEVO.Text 	 =	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaZdravstvoPoslodavacLEVO.Text 	 =	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				txtStopaNezaposlenostPoslodavacLEVO.Text 	 =	Vrsta.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText;
				}
			}
		void BtnIzracunajClick(object sender, EventArgs e)
		{
			//ovaj if je provera da radim sa NETO iznosom
			if (tabNetoBruto.SelectedIndex == 0)
				{
			decimal q1  = Convert.ToDecimal(txtNetoIznosLEVO.Text);
			decimal w1 	= Convert.ToDecimal(txtStopaPorezaLEVO.Text)		/Convert.ToDecimal(100);
			decimal e1 	= Convert.ToDecimal(txtStopaPIOZaposlenogLEVO.Text)		/Convert.ToDecimal(100);
			decimal r1 	= Convert.ToDecimal(txtStopaZdravstvoZaposlenogLEVO.Text)	/Convert.ToDecimal(100);
			decimal t1 	= Convert.ToDecimal(txtStopaNezaposlenostiZaposlenogLEVO.Text)	/Convert.ToDecimal(100);
			decimal y1 	= Convert.ToDecimal(txtStopaPIOPoslodavacLEVO.Text)		/Convert.ToDecimal(100);
			decimal u1 	= Convert.ToDecimal(txtStopaZdravstvoPoslodavacLEVO.Text)		/Convert.ToDecimal(100);
			decimal i1 	= Convert.ToDecimal(txtStopaNezaposlenostPoslodavacLEVO.Text)		/Convert.ToDecimal(100);
			decimal o1 	= Convert.ToDecimal(txtIznosPoreskogUmanjenjaLEVO.Text);
			decimal m1  = Convert.ToDecimal(txtNajnizaOsnovicaLEVO.Text);
			decimal n1  = Convert.ToDecimal(txtNajvisaOsnovicaLEVO.Text);
			Racunica Racun = new Racunica(q1,w1,e1,r1,t1,y1,u1,i1,o1,m1,n1);
			
			txtIznosPorezaDESNO.Text 		 = Racun.IznosPoreza.ToString();
			txtIznosPioZaposleniDESNO.Text 	 = Racun.IznosPIOZaposleni.ToString(); 
			txtIznosZdravstvoZaposleniDESNO.Text  = Racun.IznosZdravstvoZaposleni.ToString();
			txtIznosNezaposlenostZaposleniDESNO.Text  = Racun.IznosNezaposlenostZaposleni.ToString();
			
			txtIznosPIOPoslodavacDESNO.Text 	 = Racun.IznosPIOPoslodavac.ToString();
			txtIznosZdravstvoPoslodavacDESNO.Text = Racun.IznosZdravstvoPoslodavac.ToString();
			txtIznosNezaposlenostPoslodavacDESNO.Text = Racun.IznosNezaposlenostPoslodavac.ToString();
			
			txtBrutoIznosDESNO.Text = Racun.IznosBrutoIznos.ToString();
			txtNetoIznosDESNO.Text = Racun.IznosNetoIznos.ToString();

				}
			
			else if (tabNetoBruto.SelectedIndex == 1)
				{//IMPLREMENTIRATI
				}
		// IZVRSITI PRENOS U POLJE ZA PRIPREMU PRENOSA U PPD
		PripremiPodatke();
		}
		void btnSpisakZaposlenihClick(object sender, EventArgs e)
		{
			Spisakzaposlenih SpisakZaposlenihForm = new Spisakzaposlenih();
			SpisakZaposlenihForm.ShowDialog();
		}
// PODACI ZA PRENOS U PPD
        void PripremiPodatke()
        {
            txtBrutoPrihodZaPPD.Text = txtBrutoIznosDESNO.Text;
            txtOsnovicaZaPorezZaPPD.Text = (double.Parse(txtBrutoIznosDESNO.Text) - double.Parse(txtIznosPoreskogUmanjenjaLEVO.Text)).ToString();
            txtPorezZaPPD.Text = txtIznosPorezaDESNO.Text;
            //txtOsnovicaZaDoprinoseZaPPD
            txtPIOZaPPD.Text = (double.Parse(txtIznosPIOPoslodavacDESNO.Text) + double.Parse(txtIznosPioZaposleniDESNO.Text)).ToString();
            txtZdravstvoZaPPD.Text = (double.Parse(txtIznosZdravstvoPoslodavacDESNO.Text) + double.Parse(txtIznosZdravstvoZaposleniDESNO.Text)).ToString();
            txtNezaposlenostZaPPD.Text = (double.Parse(txtIznosNezaposlenostPoslodavacDESNO.Text) + double.Parse(txtIznosNezaposlenostZaposleniDESNO.Text)).ToString();
            List<TextBox> lista = new List<TextBox>();
            lista.Add(txtPIOZaPPD);
            lista.Add(txtZdravstvoZaPPD);
            FormatUmestoPojedinacnogTekstChangea(lista);
        }
        void CboImeZaposlenogSelectedIndexChanged(object sender, EventArgs e)
        {
            int brojzaposlenog = cboImeZaposlenog.SelectedIndex;
            string PathZaposlenog = @"..\\..\\xml\Zaposleni.xml";
            string PathVrsteUgovora = @"..\\..\\xml\VrsteUgovora.xml";
            XmlDocument docZaposleni = new XmlDocument();
            XmlDocument docVrstaUgovora = new XmlDocument();
            if (File.Exists(PathZaposlenog))
            {
                docZaposleni.Load(PathZaposlenog);
                XmlNodeList ListaZaposlenih = docZaposleni.SelectNodes("/Zaposleni/Profile");
                XmlNode Zaposleni = ListaZaposlenih.Item(brojzaposlenog);
                lblPrezime.Text = Zaposleni.FirstChild.InnerText;
                lblIme.Text = Zaposleni.FirstChild.NextSibling.InnerText;
            }
        }
		// ovde sam ubacio BOOL da bih pratio da li je THREAD vec pokrenut ili nije
		//nisam mogao da nadjem bolji nacin, jer se tredovi ne mogu drugacije ispitivati da li su pokrenuti
		public static bool isThreadAlive = false;
		void BtnUnesiUFormuClick(object sender, EventArgs e)
		{
			PokreniTabelu();
		}
		void PokreniTabelu()
		{
			if (isThreadAlive == false) {
			System.Threading.Thread Tred = new System.Threading.Thread(new System.Threading.ThreadStart(NovaForma));
			Tred.Start();
			isThreadAlive = true;	
			}
		}
		void NovaForma()
			{
			FormaPPPpd FormaPPDd = new FormaPPPpd();
			FormaPPDd.ShowDialog();
			}
        //ovo je pitanje da li valjda, stavio sam da bih zatvorio i PPD formu
        void MainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

// VALIDACIJA TEXTBOXOVA

// PRVO IDU LEVI
#region Levi
        void TxtNetoIznosLEVOKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 13 && ch != 44)//44 je zarez
            {
                e.Handled = true;
            }

            if (txtNetoIznosLEVO.Text.IndexOf(",") > -1 && ch == 44)//da nedam 2 zareza
            {
                e.Handled = true;
            }
                
            // ovaj uslov tretira ENTER kao TAB
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        void TxtNetoIznosLEVOLeave(object sender, EventArgs e)
        {
            // ovo sam morao da stavim, jer ako se klikne TAB
            // a box je prazan, program blokira
            if (this.txtNetoIznosLEVO.Text.Length == 0) return;

            // ovo sam uveo jer se program blokira kada se unese SAMO "."
            if (this.txtNetoIznosLEVO.Text == ",") { txtNetoIznosLEVO.Text = "0"; }

            // jeste da ne resava format dok se kuca, ali resava kad se odfokusira
            txtNetoIznosLEVO.Text = String.Format("{0:0,0.00}", double.Parse(txtNetoIznosLEVO.Text));
        }
        void TxtNetoIznosLEVOTextChanged(object sender, EventArgs e)
        {
            // ovime sam resio da ako unesem neki broj, obelezim ga misem i kliknem "delete"
            // u trenutku kad textboxbude prazan, program se blokira
            if (this.txtNetoIznosLEVO.Text.Length == 0) return;
        }
        void TxtNajvisaOsnovicaLEVOTextChanged(object sender, EventArgs e)
        {
            txtNajvisaOsnovicaLEVO.Text = String.Format("{0:0,0.00}", double.Parse(txtNajvisaOsnovicaLEVO.Text));
        }
        void TxtNajnizaOsnovicaLEVOTextChanged(object sender, EventArgs e)
        {
            txtNajnizaOsnovicaLEVO.Text = String.Format("{0:0,0.00}", double.Parse(txtNajnizaOsnovicaLEVO.Text));
        }
        void TxtIznosPoreskogUmanjenjaLEVOTextChanged(object sender, EventArgs e)
        {
            txtIznosPoreskogUmanjenjaLEVO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosPoreskogUmanjenjaLEVO.Text));
        }
		void CboTipDohotkaSelectedIndexChanged(object sender, EventArgs e)
		{
			cboVrstaUgovora.Text = "";
			cboVrstaUgovora.Items.Clear();
			string xxx = cboTipDohotka.SelectedItem.ToString();
			LoadVrstaUgovora(xxx);
		}
		void CboVrstaUgovoraSelectedIndexChanged(object sender, EventArgs e)
		{
			if(cboVrstaUgovora.Text.Length>3){
			UcitajStopeSelektovanogUgovora(cboVrstaUgovora.Text);//ovde treba neki argument
			}
		}
#endregion
// ODAVDE IDU DESNI
#region Desni
        void TxtIznosPioZaposleniDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosPioZaposleniDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosPioZaposleniDESNO.Text));
		}
		void TxtIznosZdravZaposleniDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosZdravstvoZaposleniDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosZdravstvoZaposleniDESNO.Text));
		}
		void TxtIznosNezapZaposleniDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosNezaposlenostZaposleniDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosNezaposlenostZaposleniDESNO.Text));
		}
		void TxtIznosPIOPoslodavacDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosPIOPoslodavacDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosPIOPoslodavacDESNO.Text));
		}
		void TxtIznosZdravPoslodavacDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosZdravstvoPoslodavacDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosZdravstvoPoslodavacDESNO.Text));
		}
		void TxtIznosNezapPoslodavacDESNOTextChanged(object sender, EventArgs e)
		{
		    txtIznosNezaposlenostPoslodavacDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosNezaposlenostPoslodavacDESNO.Text));	
		}
        void TxtBrutoIznosDESNOTextChanged(object sender, EventArgs e)
        {
            txtBrutoIznosDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtBrutoIznosDESNO.Text));
        }
		void TxtNetoIznosDESNOTextChanged(object sender, EventArgs e)
		{
		    txtNetoIznosDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtNetoIznosLEVO.Text));		
		}
		void TxtIznosPorezaDESNOTextChanged(object sender, EventArgs e)
        {
            txtIznosPorezaDESNO.Text = String.Format("{0:0,0.00}", double.Parse(txtIznosPorezaDESNO.Text));
        }
#endregion
// ODAVDE IDE PPD
#region PPD 
        private void txtBrutoPrihodZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void txtBrutoPrihodZaPPD_Leave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtOsnovicaZaPorezZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtOsnovicaZaPorezZaPPDLeave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtPorezZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtPorezZaPPDLeave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtOsnovicaZaDoprinoseZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtOsnovicaZaDoprinoseZaPPDLeave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtPIOZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtPIOZaPPDLeave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtZdravstvoZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtZdravstvoZaPPDLeave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtNezaposlenostZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtNezaposlenostZaPPDLeave(object sender, EventArgs e)
		{   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
		}
        private void txtBeneficiraniPIOZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void TxtBeneficiraniPIOZaPPDLeave(object sender, EventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        private void txtMFPZaPPD_KeyPress(object sender, KeyPressEventArgs e)
        {   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
		private void TxtMFPZaPPDLeave(object sender, EventArgs e)
		{   TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
#endregion
//ODAVDE IDE VALIDACIJA
#region VALIDACIJA
        void ValidacijaZaLeave(TextBox x, EventArgs e)
        {
            if (x.Text == ".") { x.Text = "0"; };
            if (x.Text != "" && Convert.ToDouble(x.Text) != 0)
            {x.Text = String.Format("{0:0,0.00}", double.Parse(x.Text));}
            if (x.Text == "") { x.Text = "0"; };
            if (x.Text.Length == 0 || Convert.ToDouble(x.Text) == 0)
            { x.Text = "0"; }
        }   
        void ValidacijaZaKeyPress(TextBox x, KeyPressEventArgs e)   
        {   char ch = e.KeyChar;
            //nedam 2 zareza
            if (x.Text.IndexOf(".") > -1 && ch == 46)
            {e.Handled = true;}
            if (x.Text.IndexOf(",") > -1 && ch == 44)
            { e.Handled = true; }
            //dopustam 13-enter, 8-backspace i 46-tacku
            if (!Char.IsDigit(ch) && ch != 8 && ch != 13 && ch != 46)
            {e.Handled = true;}
            // ovaj uslov tretira ENTER kao TAB - da li radi?!?!?
            if ((int)e.KeyChar == (int)Keys.Enter)

            {this.SelectNextControl(x, true, true, true, true);}
        }
        void ValidacijaZaTekstChanged(TextBox a)
            {
            // ovime sam resio da ako unesem neki broj, obelezim ga misem i kliknem "delete"
            // u trenutku kad textboxbude prazan, program se blokira, za razliku od neto iznosa, ovde sam stavio da default bude 0
                if (a.Text.Length == 0 || Convert.ToDouble(a.Text) == 0) 
            { a.Text = "0"; }
            if (a.Text != "")
            {
                a.Text = String.Format("{0:0,0.00}", double.Parse(a.Text));
            }
            //DA BIH IZBEGAO POJEDINACNI SLUCAJ< NAJBOLJEJE DA TEKSTCHANGUJEM NAKON RACUNICE
            }
        void FormatUmestoPojedinacnogTekstChangea(List<TextBox> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                ValidacijaZaTekstChanged(a[i]);
            }
        }
#endregion

    }
}
