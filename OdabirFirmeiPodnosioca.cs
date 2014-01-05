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
            lstViewFirma.Items.Clear();
            lstViewPodnosioci.Items.Clear();
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
            {
                if (NovaFirma.ShowDialog() == DialogResult.OK)
                    {
                        if (NovaFirma.txtImeFirme.Text != "" && NovaFirma.txtGradFirme.Text != "" && NovaFirma.txtAdresaFirme.Text != "" && NovaFirma.txtPIBFirme.Text != "" && NovaFirma.txtEmailFirme.Text != "" && NovaFirma.txtMBFirme.Text != "")
                            {
                                SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
                                konekcija.Open();

                                string DodajNovuFirmu = "INSERT into Preduzeca(Naziv, Grad, Adresa, PIB, Email, MB) VALUES";
                                DodajNovuFirmu += "(@ImeFirme, @GradFirme, @AdresaFirme, @PIBFirme, @EmailFirme, @MBFirme)";

                                SQLiteCommand komandaDodajFirmu = new SQLiteCommand(DodajNovuFirmu, konekcija);

                                komandaDodajFirmu.Parameters.AddWithValue("@ImeFirme", NovaFirma.txtImeFirme.Text);
                                komandaDodajFirmu.Parameters.AddWithValue("@GradFirme", NovaFirma.txtGradFirme.Text);
                                komandaDodajFirmu.Parameters.AddWithValue("@AdresaFirme", NovaFirma.txtAdresaFirme.Text);
                                komandaDodajFirmu.Parameters.AddWithValue("@PIBFirme", NovaFirma.txtPIBFirme.Text);
                                komandaDodajFirmu.Parameters.AddWithValue("@EmailFirme", NovaFirma.txtEmailFirme.Text);
                                komandaDodajFirmu.Parameters.AddWithValue("@MBFirme", NovaFirma.txtMBFirme.Text);

                                komandaDodajFirmu.ExecuteNonQuery();
                                konekcija.Close();

                                UcitajFirmeIPodnosioce();
                            }
                        else
                        {
                            MessageBox.Show("Ne sme biti praznih polja prilikom unošenja nove firme");
                        }
                }

            }

        }

        private void btnIzbrisiFirmu_Click(object sender, EventArgs e)
        {
            // ovde se PRVI put pune podaci - SVIPodaci za PPD
            int indexFirma = lstViewFirma.SelectedIndices[0];
            string FirmaZaBrisanje  = lstViewFirma.Items[indexFirma].SubItems[1].Text;
            SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
            konekcija.Open();

            string IzbrisiSelektovanuFirmu = "DELETE FROM Preduzeca WHERE ";
            IzbrisiSelektovanuFirmu += "Naziv = @ImeFirme";

            SQLiteCommand komandaDodajFirmu = new SQLiteCommand(IzbrisiSelektovanuFirmu, konekcija);

            komandaDodajFirmu.Parameters.AddWithValue("@ImeFirme", FirmaZaBrisanje);

            komandaDodajFirmu.ExecuteNonQuery();
            konekcija.Close();

            UcitajFirmeIPodnosioce();
            }

        private void btnNoviPodnosilac_Click(object sender, EventArgs e)
        {
            DodajNovogPodnosioca NoviPodnosilac = new DodajNovogPodnosioca();
            {
                if (NoviPodnosilac.ShowDialog() == DialogResult.OK)
                {
                    if (NoviPodnosilac.txtImeiPrezime.Text != "" && NoviPodnosilac.txtJMBG.Text != "")
                    {
                        SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
                        konekcija.Open();

                        string DodajNovogPodnosioca = "INSERT into Podnosioci(ImeIPrezime, JMBG) VALUES";
                        DodajNovogPodnosioca += "(@ImeIPrezime, @JMBG)";

                        SQLiteCommand komandaDodajPodnosioca = new SQLiteCommand(DodajNovogPodnosioca, konekcija);

                        komandaDodajPodnosioca.Parameters.AddWithValue("@ImeIPrezime", NoviPodnosilac.txtImeiPrezime.Text);
                        komandaDodajPodnosioca.Parameters.AddWithValue("@JMBG", NoviPodnosilac.txtJMBG.Text);

                        komandaDodajPodnosioca.ExecuteNonQuery();
                        konekcija.Close();

                        UcitajFirmeIPodnosioce();
                    }
                    else
                    {
                        MessageBox.Show("Ne sme biti praznih polja prilikom unošenja novog podnosioca");
                    }
                }
            }
        }

        private void btnIzbrisiPodnosioca_Click(object sender, EventArgs e)
        {
            // ovde se PRVI put pune podaci - SVIPodaci za PPD
            int indexPodnosilac = lstViewPodnosioci.SelectedIndices[0];
            string PodnosilacZaBrisanje = lstViewPodnosioci.Items[indexPodnosilac].SubItems[1].Text;
            SQLiteConnection konekcija = new SQLiteConnection("Data Source=PreduzecaIPodnosioci.s3db;");
            konekcija.Open();

            string IzbrisiSelektovanogPodnosioca = "DELETE FROM Podnosioci WHERE ";
            IzbrisiSelektovanogPodnosioca += "ImeIPrezime = @ImeIPrezime";

            SQLiteCommand komandaDodajFirmu = new SQLiteCommand(IzbrisiSelektovanogPodnosioca, konekcija);

            komandaDodajFirmu.Parameters.AddWithValue("@ImeIPrezime", PodnosilacZaBrisanje);

            komandaDodajFirmu.ExecuteNonQuery();
            konekcija.Close();

            UcitajFirmeIPodnosioce();
        }
    }
}
