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
    public partial class DodajNovogPodnosioca : Form
    {
        public DodajNovogPodnosioca()
        {
            InitializeComponent();
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
             ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void txtJMBG_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
        
        
        void ValidacijaZaKeyPress(TextBox x, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //dopustam 13-enter, 8-backspace i 46-tacku
            if (!Char.IsDigit(ch) && ch != 8 && ch != 13 && ch != 46 && ch != 44)
            { e.Handled = true; }
            // ovaj uslov tretira ENTER kao TAB - da li radi?!?!?
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(x, true, true, true, true); }
        }
        void ValidacijaZaLeave(TextBox x, EventArgs e)
        {
            if (x.Text.Length != 13) 
            { 
                MessageBox.Show("ЈМБГ поље мора имати тачно 13 цифара");
                x.Text = "";
                //ovo je dobar nacin da fokus zadrzim na tom textboxu sve dok se ne ispuni uslov
                //this.SelectNextControl(txtImeiPrezime, true, true, true, true);
            }
        }
        private void txtImeiPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaKeyPress(nekiTextBox, e);
        }
        void ValidacijaKeyPress(TextBox x, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((int)e.KeyChar == (int)Keys.Enter)
            { this.SelectNextControl(x, true, true, true, true); }
        }

        private void txtJMBG_TextChanged(object sender, EventArgs e)
        {
            if (txtJMBG.Text.Length == 13)
            { pctJMBG.Image = Image.FromFile(@"..\\..\\Slike\OKChange.png"); }
            else
            {
              pctJMBG.Image = Image.FromFile(@"..\\..\\Slike\minus.png");
                
            }
            
        }
        
    }
}
