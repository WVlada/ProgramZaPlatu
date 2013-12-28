using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramZaPlatu
{
	public partial class FormaPPPpd : Form
	{
		public FormaPPPpd()
		{
			InitializeComponent();
			
		}
		//ubacio sam da bih mogao da pratim status threada
		void FormaPPPpdFormClosing(object sender, FormClosingEventArgs e)
		{
		MainForm.isThreadAlive = false;	
		}
	}
}
