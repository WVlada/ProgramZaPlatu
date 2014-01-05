using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ProgramZaPlatu
{
    public partial class OdabirFirmeiPodnosioca : Form
    {
        string OdabranaFirma;
        string OdabraniPodnosilac;

        

        public OdabirFirmeiPodnosioca()
        {
            InitializeComponent();
            UcitajFirmeIPodnosioce();
        }
        private void UcitajFirmeIPodnosioce()
        {
         
            SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
            konekcija.Open();
            string sqlPreduzeca = "select * from Preduzeca";
            string sqlPodnosioci = "select * from Podnosioci";

            SQLiteCommand komandaPreduzeca = new SQLiteCommand(sqlPreduzeca, konekcija);
            SQLiteCommand komandaPodnosioci = new SQLiteCommand(sqlPodnosioci, konekcija);

            SQLiteDataReader readerPreduzeca = komandaPreduzeca.ExecuteReader();
            SQLiteDataReader readerPodnosioci = komandaPodnosioci.ExecuteReader();
         
            int i = 1;
            foreach (IDataRecord red in readerPreduzeca) 
                    {
                        ListViewItem firmice = new ListViewItem(i.ToString());
					    firmice.SubItems.Add(red.GetValue(0).ToString());
                        lstViewFirma.Items.Add(firmice);
                        i++;
                    }
            int j = 1;
            foreach (IDataRecord red in readerPodnosioci)
                {
                        ListViewItem podnosioci = new ListViewItem(j.ToString());
                        podnosioci.SubItems.Add(red.GetValue(1).ToString());
                        lstViewPodnosioci.Items.Add(podnosioci);
                        j++;
                }
            konekcija.Close(); 
                 }
        private void btnOdabirFirmeiPodnosiocaOK_Click(object sender, EventArgs e)
        {
            if (lstViewFirma.SelectedIndices.Count != 0 && lstViewPodnosioci.SelectedIndices.Count != 0)
            {
                // ovde se PRVI put pune podaci - SVIPodaci za PPD
                int indexFirma = lstViewFirma.SelectedIndices[0];
                int indexPodnosilac = lstViewFirma.SelectedIndices[0]; 
                SviPodaci.Firma = lstViewFirma.Items[indexFirma].SubItems[1].Text;
                SviPodaci.Podnosilac = lstViewPodnosioci.Items[indexPodnosilac].SubItems[1].Text;

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Moraju biti odabrani i podnosilac forme i firma!");
            }
        }

        private void btnNovaFirma_Click(object sender, EventArgs e)
        {
            DodajNovuFirmu NovaFirma = new DodajNovuFirmu();
            if (NovaFirma.ShowDialog() == DialogResult.OK)
            {
                SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
                konekcija.Open();
                string DodajNovuFirmu = "INSERT into Preduzeca(Naziv, Grad, Adresa, PIB, Email, MB) VALUES(" + NovaFirma.txtImeFirme.Text + "," + NovaFirma.txtGradFirme.Text + "," + NovaFirma.txtAdresaFirme.Text + "," + NovaFirma.txtPIBFirme.Text + "," + NovaFirma.txtEmailFirme.Text + "," + NovaFirma.txtMBFirme.Text + ")";
                SQLiteCommand komandaDodajFirmu = new SQLiteCommand(DodajNovuFirmu, konekcija);
                komandaDodajFirmu.ExecuteNonQuery();
                konekcija.Close();
                UcitajFirmeIPodnosioce();

            //    SQLiteDataReader readerPreduzeca = komandaPreduzeca.ExecuteReader();
                //        string pathdonovogzaposlenog = @"..\\..\\xml\Zaposleni.xml";
            //        XmlDocument noviZaposleniDoc = new XmlDocument();
            //        noviZaposleniDoc.Load(pathdonovogzaposlenog);

            //        // stavicu tekst da bi se razlikovali od drugih
            //        string NoviPrezimeText, NoviImetxt, NoviTipDokumenta, NoviIDBrojtxt, NoviOpstinatxt, NoviOpstinaBrojtxt; ;

            //        NoviPrezimeText = DodajForm.txtPrezime.Text;
            //        NoviImetxt = DodajForm.txtIme.Text;
            //        NoviTipDokumenta = DodajForm.cboTipDokumenta.Text;
            //        NoviIDBrojtxt = DodajForm.txtIDBroj.Text;
            //        NoviOpstinatxt = DodajForm.txtOpstina.Text;
            //        NoviOpstinaBrojtxt = DodajForm.txtBrojOpstine.Text;

            //        XmlElement element = noviZaposleniDoc.CreateElement("Profile");
            //        string strNoviZaposleni = "<Prezime>" + NoviPrezimeText + "</Prezime>" +
            //                                    "<Ime>" + NoviImetxt + "</Ime>" +
            //                                    "<TipDokumenta>" + NoviTipDokumenta + "</TipDokumenta>" +
            //                                    "<IDBroj>" + NoviIDBrojtxt + "</IDBroj>" +
            //                                    "<Opstina>" + NoviOpstinatxt + "</Opstina>" +
            //                                    "<BrojOpstine>" + NoviOpstinaBrojtxt + "</BrojOpstine>";

            //        element.InnerXml = strNoviZaposleni;
            //        noviZaposleniDoc.DocumentElement.AppendChild(element);

            //        noviZaposleniDoc.Save(@"..\\..\\xml\Zaposleni.xml");
            //        PrikaziZaposlene();
            //    }

           }
        }

    }
}
