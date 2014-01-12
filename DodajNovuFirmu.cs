using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgramZaPlatu
{
    public partial class DodajNovuFirmu : Form
    {
        public DodajNovuFirmu()
        {
            InitializeComponent();
        }

        private void txtMBFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaKeyPress(nekiTextBox, e);
            
            
        }
        private void txtPIBFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaKeyPress(nekiTextBox, e);
        }
        void ValidacijaKeyPress(TextBox x, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 13)
            { e.Handled = true; }
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(x, true, true, true, true); }
        }
        private void txtMBFirme_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeaveMB(nekiTextBox, e);
        }
        private void txtPIBFirme_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeavePIB(nekiTextBox, e);
        }
        private void ValidacijaZaLeaveMB(TextBox x, EventArgs e)
        {
            if (x.Text.Length != 8) 
            { 
                MessageBox.Show("Матични број фирме мора имати тачно осам цифара");
                x.Text = "";
               //ovo je dobar nacin da fokus zadrzim na tom textboxu sve dok se ne ispuni uslov
               this.SelectNextControl(txtMBFirme, true, true, true, true);
            }
        }
        private void ValidacijaZaLeavePIB(TextBox x, EventArgs e)
        {
            if (x.Text.Length != 9)
            {
                MessageBox.Show("ПИБ мора имати тачно девет цифара");
                x.Text = "";
                //ovo je dobar nacin da fokus zadrzim na tom textboxu sve dok se ne ispuni uslov
                this.SelectNextControl(txtPIBFirme, true, true, true, true);
            }
        }
        private void txtImeFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(txtImeFirme, true, true, true, true); }
        }
        private void txtGradFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(txtGradFirme, true, true, true, true); }
        }
        private void txtAdresaFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(txtAdresaFirme, true, true, true, true); }
        }
        private void txtEmailFirme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(txtEmailFirme, true, true, true, true); }
        }
        private void txtMBFirme_TextChanged(object sender, EventArgs e)
        {
            if (txtMBFirme.Text.Length == 8)
            {pctMB.Image = Image.FromFile(@"..\\..\\Slike\OKChange.png");}
            else
            {pctMB.Image = Image.FromFile(@"..\\..\\Slike\minus.png");}
        }

        private void txtPIBFirme_TextChanged(object sender, EventArgs e)
        {
            if (txtPIBFirme.Text.Length == 9)
            { pctPIB.Image = Image.FromFile(@"..\\..\\Slike\OKChange.png"); }
            else
            { pctPIB.Image = Image.FromFile(@"..\\..\\Slike\minus.png"); }
        }
    }

}
