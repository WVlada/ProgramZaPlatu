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
    public partial class OdabirFirmeiPodnosioca : Form
    {
        private int firma;
        private int podnosilac;
        private int[] arrayargumenti;
        
        public OdabirFirmeiPodnosioca()
        {
            InitializeComponent();
            UcitajFirmeIPodnosioce();
        }
        private void UcitajFirmeIPodnosioce()
        {
            
        }
        private void btnOdabirFirmeiPodnosiocaOK_Click(object sender, EventArgs e)
        {
        }

    }
}
