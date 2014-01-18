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
    public partial class PromeniStope : Form
    {
        public PromeniStope()
        {
            InitializeComponent();
        }

        void ValidacijaZaLeave(TextBox x, EventArgs e)
        {
            if (x.Text == ".") { x.Text = "0.00"; };
            if (x.Text != "")
            { x.Text = String.Format("{0:,0.00}", double.Parse(x.Text)); }
            if (x.Text == "") { x.Text = "0.00"; };
            if (Convert.ToDouble(x.Text) == 0)
            { x.Text = "0.00"; }
        }
        void ValidacijaZaKeyPress(TextBox x, KeyPressEventArgs e)
            {
                char ch = e.KeyChar;
                //nedam 2 zareza
                if (x.Text.IndexOf(".") > -1 && ch == 46)
                { e.Handled = true; }
                if (x.Text.IndexOf(",") > -1 && ch == 44)
                { e.Handled = true; }
                //dopustam 13-enter, 8-backspace i 46-tacku
                if (!Char.IsDigit(ch) && ch != 8 && ch != 13 && ch != 46)
                { e.Handled = true; }
                // ovaj uslov tretira ENTER kao TAB - da li radi?!?!?
                if ((int)e.KeyChar == (int)Keys.Enter)
                { this.SelectNextControl(x, true, true, true, true); }
            }
        
        
        // KEYPRESS
        private void txtStopaPIOZaposlenogIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void txtStopaZdravstvoZaposlenogIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }
        private void txtStopaNezaposlenostiZaposlenogIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtStopaPIOPoslodavacIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtStopaZdravstvoPoslodavacIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtStopaNezaposlenostPoslodavacIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtOznakaTipaZaradeIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtStopaPorezaIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtPoreskoOslobodjenjeIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtNajvisaOsnovicaIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        private void txtNajnizaOsnovicaIZMENA_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaKeyPress(nekiTextBox, e);
        }

        // ZA ODFOKUS
        private void txtStopaPIOZaposlenogIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaZdravstvoZaposlenogIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaNezaposlenostiZaposlenogIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaPIOPoslodavacIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaZdravstvoPoslodavacIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaNezaposlenostPoslodavacIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtStopaPorezaIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtPoreskoOslobodjenjeIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtNajvisaOsnovicaIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }

        private void txtNajnizaOsnovicaIZMENA_Leave(object sender, EventArgs e)
        {
            TextBox nekiTextBox = sender as TextBox;
            ValidacijaZaLeave(nekiTextBox, e);
        }
    }
}
