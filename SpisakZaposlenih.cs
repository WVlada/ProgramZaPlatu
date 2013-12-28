using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace ProgramZaPlatu
{
	public partial class Spisakzaposlenih : Form
	{
		public Spisakzaposlenih()
		{
			InitializeComponent();
		}
		
		void PrikaziZaposlene()
		{
			string PathFajlaZaposleni = @"..\\..\\xml\Zaposleni.xml";
			XmlDocument docZaposleni = new XmlDocument();
			
			if (File.Exists(PathFajlaZaposleni))
				lstSpisakZaposlenih.Items.Clear();
			
			docZaposleni.Load(PathFajlaZaposleni);
			XmlElement elmZaposleni = docZaposleni.DocumentElement;
			XmlNodeList lstZaposleni = elmZaposleni.ChildNodes;
			
			//ovo je moj brojcanik za broj zaposlenih
			int i = 1;
			foreach (XmlNode element in lstZaposleni) 
			{
				ListViewItem Zaposleni = new ListViewItem(i.ToString());
								
				Zaposleni.SubItems.Add(element.FirstChild.InnerText);
				Zaposleni.SubItems.Add(element.FirstChild.NextSibling.InnerText);
				Zaposleni.SubItems.Add(element.FirstChild.NextSibling.NextSibling.InnerText);
				Zaposleni.SubItems.Add(element.FirstChild.NextSibling.NextSibling.NextSibling.InnerText);
				Zaposleni.SubItems.Add(element.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.InnerText);
				Zaposleni.SubItems.Add(element.FirstChild.NextSibling.NextSibling.NextSibling.NextSibling.NextSibling.InnerText);
				
				lstSpisakZaposlenih.Items.Add(Zaposleni);
				i++;
		}	}
		
		void SpisakZaposlenihLoad(object sender, EventArgs e)
		{
			PrikaziZaposlene();
		}
		
		void BtnNazadClick(object sender, EventArgs e)
		{
		this.DialogResult = DialogResult.Cancel;			
		}
		
		void BtnDodajNovogClick(object sender, EventArgs e)
		{
			DodajNovogForm DodajForm = new DodajNovogForm();
			
			// Display Formu i saznaj da li je user kliknuo OK
			if (DodajForm.ShowDialog() == DialogResult.OK)
			{
				string pathdonovogzaposlenog = @"..\\..\\xml\Zaposleni.xml";
				XmlDocument noviZaposleniDoc = new XmlDocument();
				noviZaposleniDoc.Load(pathdonovogzaposlenog);
				
				// stavicu tekst da bi se razlikovali od drugih
				string NoviPrezimeText, NoviImetxt, NoviTipDokumenta, NoviIDBrojtxt, NoviOpstinatxt, NoviOpstinaBrojtxt;;
				
				NoviPrezimeText = DodajForm.txtPrezime.Text;
				NoviImetxt = DodajForm.txtIme.Text;
				NoviTipDokumenta = DodajForm.cboTipDokumenta.Text;
				NoviIDBrojtxt = DodajForm.txtIDBroj.Text;
				NoviOpstinatxt = DodajForm.txtOpstina.Text;
				NoviOpstinaBrojtxt = DodajForm.txtBrojOpstine.Text;
				
				XmlElement element = noviZaposleniDoc.CreateElement("Profile");
				string strNoviZaposleni = 	"<Prezime>" + NoviPrezimeText + "</Prezime>" +
											"<Ime>" + NoviImetxt + "</Ime>" +
											"<TipDokumenta>" + NoviTipDokumenta + "</TipDokumenta>" +
											"<IDBroj>" + NoviIDBrojtxt + "</IDBroj>" +
											"<Opstina>" + NoviOpstinatxt + "</Opstina>" +
											"<BrojOpstine>"	+ NoviOpstinaBrojtxt + "</BrojOpstine>";
				
				element.InnerXml = strNoviZaposleni;
				noviZaposleniDoc.DocumentElement.AppendChild(element);
				
				noviZaposleniDoc.Save(@"..\\..\\xml\Zaposleni.xml");
				PrikaziZaposlene();
			}
			
		}
		void BtnIzbrisiOznacenogClick(object sender, EventArgs e)
		{
			if (lstSpisakZaposlenih.SelectedItems.Count > 0)
			{
			int index = lstSpisakZaposlenih.SelectedIndices[0];
			string poruka = lstSpisakZaposlenih.Items[index].SubItems[1].Text + " " + lstSpisakZaposlenih.Items[index].SubItems[2].Text;
			string IDzaBrisanje = lstSpisakZaposlenih.Items[index].SubItems[4].Text;
			
			DialogResult dialogResult = MessageBox.Show("Izbrisati zaposlenog:\n\n" + poruka + "\n\nDa li ste sigurni?", "Provera zahteva za brisanje", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
				{
				string PathZabrisanje = @"..\\..\\xml\Zaposleni.xml";
				XmlDocument docZaBrisanje = new XmlDocument();
				docZaBrisanje.Load(PathZabrisanje);
				
				XmlNode NodeZaBrisanje;
				XmlNode root = docZaBrisanje.DocumentElement;
				
				string xpath = string.Format("descendant::Profile[IDBroj='" + IDzaBrisanje + "']");
				NodeZaBrisanje = root.SelectSingleNode(xpath);
				XmlNode parent = NodeZaBrisanje.ParentNode;
				//OMG OVO SVE BRISE
				//parent.RemoveAll();
				parent.RemoveChild(NodeZaBrisanje);
				
				docZaBrisanje.Save(PathZabrisanje);
				
				PrikaziZaposlene();
				}
		}	}
		
		void BtnPromeniPodatkeSelektovanogClick(object sender, EventArgs e)
		{
			if (lstSpisakZaposlenih.SelectedItems.Count > 0)
			{
			int index = this.lstSpisakZaposlenih.SelectedIndices[0];
			IzmeniOznacenog frmIzmeni = new IzmeniOznacenog(lstSpisakZaposlenih.Items[index].SubItems[1].Text, lstSpisakZaposlenih.Items[index].SubItems[2].Text, lstSpisakZaposlenih.Items[index].SubItems[3].Text, lstSpisakZaposlenih.Items[index].SubItems[4].Text, lstSpisakZaposlenih.Items[index].SubItems[5].Text, lstSpisakZaposlenih.Items[index].SubItems[6].Text);
			
			//ovime identifikujem koga brisem
			string KogaBrisem = lstSpisakZaposlenih.Items[index].SubItems[4].Text;
						
			if (frmIzmeni.ShowDialog() == DialogResult.OK)
					{
						string pathdozaposlenih = @"..\\..\\xml\Zaposleni.xml";
						XmlDocument PromeniZaposlenogDoc = new XmlDocument();
						PromeniZaposlenogDoc.Load(pathdozaposlenih);
						
						string TipDokumenta = "";//implementirati radio buttone - ma mora da moze i bolje
						
						if (frmIzmeni.radioButJMBG.Checked == true)
							{
							TipDokumenta = frmIzmeni.radioButJMBG.Text;
							}
						else if (frmIzmeni.radioButPasos.Checked == true)
							{
							TipDokumenta = frmIzmeni.radioButPasos.Text;
							}
						else if (frmIzmeni.radioButIzbeglicka.Checked == true)
							{
							TipDokumenta = frmIzmeni.radioButIzbeglicka.Text;
							}
						else if (frmIzmeni.radioButOstalo.Checked == true)
							{
							TipDokumenta = frmIzmeni.radioButOstalo.Text;
							}
						
						// ustvari cu ga izbriasti i ponovo upisati, sto bi se cimao?
						XmlNode NodeZaBrisanje;
						XmlNode root = PromeniZaposlenogDoc.DocumentElement;
				
						string xpath = string.Format("descendant::Profile[IDBroj='" + KogaBrisem + "']");
						NodeZaBrisanje = root.SelectSingleNode(xpath);
						XmlNode parent = NodeZaBrisanje.ParentNode;
						
						parent.RemoveChild(NodeZaBrisanje);
				
						XmlElement element = PromeniZaposlenogDoc.CreateElement("Profile");
						string strNoviZaposleni = 	"<Prezime>" + frmIzmeni.txtPrezimePromena.Text + "</Prezime>" +
											"<Ime>" + frmIzmeni.txtImePromena.Text + "</Ime>" +
											"<TipDokumenta>" + TipDokumenta + "</TipDokumenta>" +
											"<IDBroj>" + frmIzmeni.txtIDBrojPromena.Text + "</IDBroj>" +
											"<Opstina>" + frmIzmeni.txtOpstinaPromena.Text + "</Opstina>" +
											"<BrojOpstine>"	+ frmIzmeni.txtBrojOpstinePromena.Text + "</BrojOpstine>";
						
						element.InnerXml = strNoviZaposleni;
						PromeniZaposlenogDoc.DocumentElement.AppendChild(element);
				
						PromeniZaposlenogDoc.Save(pathdozaposlenih);
						PrikaziZaposlene();
					}
			}		
		}
		
		void LstSpisakZaposlenihMouseClick(object sender, MouseEventArgs e)
		{
		if (e.Button == MouseButtons.Right)
        		{
        if (lstSpisakZaposlenih.FocusedItem.Bounds.Contains(e.Location) == true)
            	{
            	contextMenuStripZaposleni.Show(Cursor.Position);
            	}
        	}
		}
		void ContextMenuStripZaposleniItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			if ( e.ClickedItem.Name == "обришиToolStripMenuItem")
				{
				contextMenuStripZaposleni.Hide();
				btnIzbrisiOznacenog.PerformClick();
				}
			if ( e.ClickedItem.Name == "измениToolStripMenuItem")
				{
				contextMenuStripZaposleni.Hide();
				btnPromeniPodatkeSelektovanog.PerformClick();
				}
		}
		
	}
}
