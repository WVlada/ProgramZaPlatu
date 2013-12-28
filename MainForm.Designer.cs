/*
 * Created by SharpDevelop.
 * User: jelena
 * Date: 10/14/2013
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProgramZaPlatu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtNetoIznosLEVO = new System.Windows.Forms.TextBox();
            this.lblNetoIznosTab = new System.Windows.Forms.Label();
            this.txtStopaPorezaLEVO = new System.Windows.Forms.TextBox();
            this.lblStopaPoreza = new System.Windows.Forms.Label();
            this.txtBrutoIznosDESNO = new System.Windows.Forms.TextBox();
            this.lblBrutoIznos = new System.Windows.Forms.Label();
            this.txtStopaPIOZaposlenogLEVO = new System.Windows.Forms.TextBox();
            this.lblPIOZaposl = new System.Windows.Forms.Label();
            this.txtStopaZdravstvoZaposlenogLEVO = new System.Windows.Forms.TextBox();
            this.lblZdravsZaposl = new System.Windows.Forms.Label();
            this.txtStopaNezaposlenostiZaposlenogLEVO = new System.Windows.Forms.TextBox();
            this.lblNezapZaposl = new System.Windows.Forms.Label();
            this.txtStopaPIOPoslodavacLEVO = new System.Windows.Forms.TextBox();
            this.lblPIOPosl = new System.Windows.Forms.Label();
            this.txtStopaZdravstvoPoslodavacLEVO = new System.Windows.Forms.TextBox();
            this.lblZdravPosl = new System.Windows.Forms.Label();
            this.txtStopaNezaposlenostPoslodavacLEVO = new System.Windows.Forms.TextBox();
            this.lblNezapPosl = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnOtvoriFormu = new System.Windows.Forms.Button();
            this.btnSnimiStope = new System.Windows.Forms.Button();
            this.txtIznosPorezaDESNO = new System.Windows.Forms.TextBox();
            this.lblIznosporeza = new System.Windows.Forms.Label();
            this.txtIznosPioZaposleniDESNO = new System.Windows.Forms.TextBox();
            this.lblIznosPIOZap = new System.Windows.Forms.Label();
            this.txtIznosZdravstvoZaposleniDESNO = new System.Windows.Forms.TextBox();
            this.lblIznosZdravZap = new System.Windows.Forms.Label();
            this.txtIznosNezaposlenostZaposleniDESNO = new System.Windows.Forms.TextBox();
            this.lblIznosNezapZap = new System.Windows.Forms.Label();
            this.txtIznosPIOPoslodavacDESNO = new System.Windows.Forms.TextBox();
            this.txtIznosZdravstvoPoslodavacDESNO = new System.Windows.Forms.TextBox();
            this.txtIznosNezaposlenostPoslodavacDESNO = new System.Windows.Forms.TextBox();
            this.lblIznosPIOPosl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImeIPrezime = new System.Windows.Forms.Label();
            this.txtIznosPoreskogUmanjenjaLEVO = new System.Windows.Forms.TextBox();
            this.lblIznosPoreskogUmanjenja = new System.Windows.Forms.Label();
            this.lblTipObracuna = new System.Windows.Forms.Label();
            this.cboTipDohotka = new System.Windows.Forms.ComboBox();
            this.cboImeZaposlenog = new System.Windows.Forms.ComboBox();
            this.btnSpisakZaposlenih = new System.Windows.Forms.Button();
            this.txtNajnizaOsnovicaLEVO = new System.Windows.Forms.TextBox();
            this.lblNajnizaOsnovica = new System.Windows.Forms.Label();
            this.txtNajvisaOsnovicaLEVO = new System.Windows.Forms.TextBox();
            this.lblNajvisaOsnovica = new System.Windows.Forms.Label();
            this.lblBazaZaposlenih = new System.Windows.Forms.Label();
            this.cboVrstaUgovora = new System.Windows.Forms.ComboBox();
            this.lblVrstaUgovora = new System.Windows.Forms.Label();
            this.tabNetoBruto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBrutoIznosLEVO = new System.Windows.Forms.TextBox();
            this.lblBrutoIznosTab = new System.Windows.Forms.Label();
            this.txtNetoIznosDESNO = new System.Windows.Forms.TextBox();
            this.lblNetoIznos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupZaUnos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMFP = new System.Windows.Forms.Label();
            this.lblBeneficiraniPIO = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZdravstvo = new System.Windows.Forms.Label();
            this.lblPIO = new System.Windows.Forms.Label();
            this.lblOsnovicazaDoprinose = new System.Windows.Forms.Label();
            this.lblPorez = new System.Windows.Forms.Label();
            this.lblOsnovicazaPorez = new System.Windows.Forms.Label();
            this.lblBrutoPrihod = new System.Windows.Forms.Label();
            this.lblBrojSati = new System.Windows.Forms.Label();
            this.lblBrojDana = new System.Windows.Forms.Label();
            this.txtBeneficiraniPIOZaPPD = new System.Windows.Forms.TextBox();
            this.txtNezaposlenostZaPPD = new System.Windows.Forms.TextBox();
            this.txtZdravstvoZaPPD = new System.Windows.Forms.TextBox();
            this.txtPIOZaPPD = new System.Windows.Forms.TextBox();
            this.txtMFPZaPPD = new System.Windows.Forms.TextBox();
            this.txtOsnovicaZaDoprinoseZaPPD = new System.Windows.Forms.TextBox();
            this.txtPorezZaPPD = new System.Windows.Forms.TextBox();
            this.txtOsnovicaZaPorezZaPPD = new System.Windows.Forms.TextBox();
            this.txtBrutoPrihodZaPPD = new System.Windows.Forms.TextBox();
            this.txtBrojSati = new System.Windows.Forms.TextBox();
            this.txtBrojDana = new System.Windows.Forms.TextBox();
            this.txtSifraVrstePrihoda = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.groupPoslodavac = new System.Windows.Forms.GroupBox();
            this.groupZaposleni = new System.Windows.Forms.GroupBox();
            this.groupIznosZaposleni = new System.Windows.Forms.GroupBox();
            this.groupIznosPoslodavac = new System.Windows.Forms.GroupBox();
            this.btnUnesiUFormu = new System.Windows.Forms.Button();
            this.tabNetoBruto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupZaUnos.SuspendLayout();
            this.groupPoslodavac.SuspendLayout();
            this.groupZaposleni.SuspendLayout();
            this.groupIznosZaposleni.SuspendLayout();
            this.groupIznosPoslodavac.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNetoIznosLEVO
            // 
            this.txtNetoIznosLEVO.Location = new System.Drawing.Point(161, 18);
            this.txtNetoIznosLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetoIznosLEVO.Name = "txtNetoIznosLEVO";
            this.txtNetoIznosLEVO.Size = new System.Drawing.Size(117, 27);
            this.txtNetoIznosLEVO.TabIndex = 0;
            this.txtNetoIznosLEVO.Text = "0";
            this.txtNetoIznosLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetoIznosLEVO.TextChanged += new System.EventHandler(this.TxtNetoIznosLEVOTextChanged);
            this.txtNetoIznosLEVO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNetoIznosLEVOKeyPress);
            this.txtNetoIznosLEVO.Leave += new System.EventHandler(this.TxtNetoIznosLEVOLeave);
            // 
            // lblNetoIznosTab
            // 
            this.lblNetoIznosTab.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNetoIznosTab.Location = new System.Drawing.Point(2, 18);
            this.lblNetoIznosTab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetoIznosTab.Name = "lblNetoIznosTab";
            this.lblNetoIznosTab.Size = new System.Drawing.Size(123, 22);
            this.lblNetoIznosTab.TabIndex = 1;
            this.lblNetoIznosTab.Text = "Нето износ";
            this.lblNetoIznosTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaPorezaLEVO
            // 
            this.txtStopaPorezaLEVO.Location = new System.Drawing.Point(35, 220);
            this.txtStopaPorezaLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaPorezaLEVO.Name = "txtStopaPorezaLEVO";
            this.txtStopaPorezaLEVO.ReadOnly = true;
            this.txtStopaPorezaLEVO.Size = new System.Drawing.Size(50, 27);
            this.txtStopaPorezaLEVO.TabIndex = 2;
            this.txtStopaPorezaLEVO.Text = "0";
            this.txtStopaPorezaLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStopaPoreza
            // 
            this.lblStopaPoreza.BackColor = System.Drawing.Color.Transparent;
            this.lblStopaPoreza.Font = new System.Drawing.Font("Arial", 10F);
            this.lblStopaPoreza.Location = new System.Drawing.Point(12, 247);
            this.lblStopaPoreza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStopaPoreza.Name = "lblStopaPoreza";
            this.lblStopaPoreza.Size = new System.Drawing.Size(102, 23);
            this.lblStopaPoreza.TabIndex = 3;
            this.lblStopaPoreza.Text = "Стопа пореза";
            this.lblStopaPoreza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBrutoIznosDESNO
            // 
            this.txtBrutoIznosDESNO.Location = new System.Drawing.Point(716, 13);
            this.txtBrutoIznosDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtBrutoIznosDESNO.Name = "txtBrutoIznosDESNO";
            this.txtBrutoIznosDESNO.ReadOnly = true;
            this.txtBrutoIznosDESNO.Size = new System.Drawing.Size(103, 27);
            this.txtBrutoIznosDESNO.TabIndex = 5;
            this.txtBrutoIznosDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrutoIznosDESNO.TextChanged += new System.EventHandler(this.TxtBrutoIznosDESNOTextChanged);
            // 
            // lblBrutoIznos
            // 
            this.lblBrutoIznos.BackColor = System.Drawing.Color.Transparent;
            this.lblBrutoIznos.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBrutoIznos.Location = new System.Drawing.Point(827, 13);
            this.lblBrutoIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrutoIznos.Name = "lblBrutoIznos";
            this.lblBrutoIznos.Size = new System.Drawing.Size(106, 22);
            this.lblBrutoIznos.TabIndex = 6;
            this.lblBrutoIznos.Text = "Бруто износ";
            this.lblBrutoIznos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaPIOZaposlenogLEVO
            // 
            this.txtStopaPIOZaposlenogLEVO.Location = new System.Drawing.Point(5, 21);
            this.txtStopaPIOZaposlenogLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaPIOZaposlenogLEVO.Name = "txtStopaPIOZaposlenogLEVO";
            this.txtStopaPIOZaposlenogLEVO.ReadOnly = true;
            this.txtStopaPIOZaposlenogLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaPIOZaposlenogLEVO.TabIndex = 8;
            this.txtStopaPIOZaposlenogLEVO.Text = "0";
            this.txtStopaPIOZaposlenogLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPIOZaposl
            // 
            this.lblPIOZaposl.BackColor = System.Drawing.Color.Transparent;
            this.lblPIOZaposl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPIOZaposl.Location = new System.Drawing.Point(59, 21);
            this.lblPIOZaposl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIOZaposl.Name = "lblPIOZaposl";
            this.lblPIOZaposl.Size = new System.Drawing.Size(46, 23);
            this.lblPIOZaposl.TabIndex = 9;
            this.lblPIOZaposl.Text = "ПИО";
            this.lblPIOZaposl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaZdravstvoZaposlenogLEVO
            // 
            this.txtStopaZdravstvoZaposlenogLEVO.Location = new System.Drawing.Point(5, 48);
            this.txtStopaZdravstvoZaposlenogLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaZdravstvoZaposlenogLEVO.Name = "txtStopaZdravstvoZaposlenogLEVO";
            this.txtStopaZdravstvoZaposlenogLEVO.ReadOnly = true;
            this.txtStopaZdravstvoZaposlenogLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaZdravstvoZaposlenogLEVO.TabIndex = 11;
            this.txtStopaZdravstvoZaposlenogLEVO.Text = "0";
            this.txtStopaZdravstvoZaposlenogLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblZdravsZaposl
            // 
            this.lblZdravsZaposl.BackColor = System.Drawing.Color.Transparent;
            this.lblZdravsZaposl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblZdravsZaposl.Location = new System.Drawing.Point(59, 48);
            this.lblZdravsZaposl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZdravsZaposl.Name = "lblZdravsZaposl";
            this.lblZdravsZaposl.Size = new System.Drawing.Size(77, 23);
            this.lblZdravsZaposl.TabIndex = 12;
            this.lblZdravsZaposl.Text = "Здравство";
            this.lblZdravsZaposl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaNezaposlenostiZaposlenogLEVO
            // 
            this.txtStopaNezaposlenostiZaposlenogLEVO.Location = new System.Drawing.Point(5, 75);
            this.txtStopaNezaposlenostiZaposlenogLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaNezaposlenostiZaposlenogLEVO.Name = "txtStopaNezaposlenostiZaposlenogLEVO";
            this.txtStopaNezaposlenostiZaposlenogLEVO.ReadOnly = true;
            this.txtStopaNezaposlenostiZaposlenogLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaNezaposlenostiZaposlenogLEVO.TabIndex = 14;
            this.txtStopaNezaposlenostiZaposlenogLEVO.Text = "0";
            this.txtStopaNezaposlenostiZaposlenogLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNezapZaposl
            // 
            this.lblNezapZaposl.BackColor = System.Drawing.Color.Transparent;
            this.lblNezapZaposl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNezapZaposl.Location = new System.Drawing.Point(59, 75);
            this.lblNezapZaposl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNezapZaposl.Name = "lblNezapZaposl";
            this.lblNezapZaposl.Size = new System.Drawing.Size(115, 23);
            this.lblNezapZaposl.TabIndex = 15;
            this.lblNezapZaposl.Text = "Незапосленост";
            this.lblNezapZaposl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaPIOPoslodavacLEVO
            // 
            this.txtStopaPIOPoslodavacLEVO.Location = new System.Drawing.Point(5, 21);
            this.txtStopaPIOPoslodavacLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaPIOPoslodavacLEVO.Name = "txtStopaPIOPoslodavacLEVO";
            this.txtStopaPIOPoslodavacLEVO.ReadOnly = true;
            this.txtStopaPIOPoslodavacLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaPIOPoslodavacLEVO.TabIndex = 17;
            this.txtStopaPIOPoslodavacLEVO.Text = "0";
            this.txtStopaPIOPoslodavacLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPIOPosl
            // 
            this.lblPIOPosl.BackColor = System.Drawing.Color.Transparent;
            this.lblPIOPosl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPIOPosl.Location = new System.Drawing.Point(61, 21);
            this.lblPIOPosl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIOPosl.Name = "lblPIOPosl";
            this.lblPIOPosl.Size = new System.Drawing.Size(45, 23);
            this.lblPIOPosl.TabIndex = 18;
            this.lblPIOPosl.Text = "ПИО";
            this.lblPIOPosl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaZdravstvoPoslodavacLEVO
            // 
            this.txtStopaZdravstvoPoslodavacLEVO.Location = new System.Drawing.Point(5, 48);
            this.txtStopaZdravstvoPoslodavacLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaZdravstvoPoslodavacLEVO.Name = "txtStopaZdravstvoPoslodavacLEVO";
            this.txtStopaZdravstvoPoslodavacLEVO.ReadOnly = true;
            this.txtStopaZdravstvoPoslodavacLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaZdravstvoPoslodavacLEVO.TabIndex = 20;
            this.txtStopaZdravstvoPoslodavacLEVO.Text = "0";
            this.txtStopaZdravstvoPoslodavacLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblZdravPosl
            // 
            this.lblZdravPosl.BackColor = System.Drawing.Color.Transparent;
            this.lblZdravPosl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblZdravPosl.Location = new System.Drawing.Point(61, 48);
            this.lblZdravPosl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZdravPosl.Name = "lblZdravPosl";
            this.lblZdravPosl.Size = new System.Drawing.Size(80, 23);
            this.lblZdravPosl.TabIndex = 21;
            this.lblZdravPosl.Text = "Здравство";
            this.lblZdravPosl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStopaNezaposlenostPoslodavacLEVO
            // 
            this.txtStopaNezaposlenostPoslodavacLEVO.Location = new System.Drawing.Point(5, 76);
            this.txtStopaNezaposlenostPoslodavacLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtStopaNezaposlenostPoslodavacLEVO.Name = "txtStopaNezaposlenostPoslodavacLEVO";
            this.txtStopaNezaposlenostPoslodavacLEVO.ReadOnly = true;
            this.txtStopaNezaposlenostPoslodavacLEVO.Size = new System.Drawing.Size(50, 23);
            this.txtStopaNezaposlenostPoslodavacLEVO.TabIndex = 23;
            this.txtStopaNezaposlenostPoslodavacLEVO.Text = "0";
            this.txtStopaNezaposlenostPoslodavacLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNezapPosl
            // 
            this.lblNezapPosl.BackColor = System.Drawing.Color.Transparent;
            this.lblNezapPosl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNezapPosl.Location = new System.Drawing.Point(61, 76);
            this.lblNezapPosl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNezapPosl.Name = "lblNezapPosl";
            this.lblNezapPosl.Size = new System.Drawing.Size(118, 23);
            this.lblNezapPosl.TabIndex = 24;
            this.lblNezapPosl.Text = "Незапосленост";
            this.lblNezapPosl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.Color.Transparent;
            this.btnIzracunaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIzracunaj.BackgroundImage")));
            this.btnIzracunaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzracunaj.FlatAppearance.BorderSize = 2;
            this.btnIzracunaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzracunaj.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzracunaj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIzracunaj.Location = new System.Drawing.Point(358, 133);
            this.btnIzracunaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(138, 84);
            this.btnIzracunaj.TabIndex = 25;
            this.btnIzracunaj.Text = "Израчунај";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.BtnIzracunajClick);
            // 
            // btnOtvoriFormu
            // 
            this.btnOtvoriFormu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOtvoriFormu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOtvoriFormu.FlatAppearance.BorderSize = 2;
            this.btnOtvoriFormu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOtvoriFormu.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnOtvoriFormu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOtvoriFormu.Location = new System.Drawing.Point(472, 157);
            this.btnOtvoriFormu.Margin = new System.Windows.Forms.Padding(2);
            this.btnOtvoriFormu.Name = "btnOtvoriFormu";
            this.btnOtvoriFormu.Size = new System.Drawing.Size(119, 69);
            this.btnOtvoriFormu.TabIndex = 26;
            this.btnOtvoriFormu.Text = "Отвори ППД";
            this.btnOtvoriFormu.UseVisualStyleBackColor = false;
            this.btnOtvoriFormu.Click += new System.EventHandler(this.BtnUnesiUFormuClick);
            // 
            // btnSnimiStope
            // 
            this.btnSnimiStope.BackColor = System.Drawing.Color.Transparent;
            this.btnSnimiStope.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSnimiStope.BackgroundImage")));
            this.btnSnimiStope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSnimiStope.FlatAppearance.BorderSize = 2;
            this.btnSnimiStope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnimiStope.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSnimiStope.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSnimiStope.Location = new System.Drawing.Point(5, 431);
            this.btnSnimiStope.Margin = new System.Windows.Forms.Padding(2);
            this.btnSnimiStope.Name = "btnSnimiStope";
            this.btnSnimiStope.Size = new System.Drawing.Size(80, 40);
            this.btnSnimiStope.TabIndex = 27;
            this.btnSnimiStope.Text = "Промени стопе";
            this.btnSnimiStope.UseVisualStyleBackColor = false;
            // 
            // txtIznosPorezaDESNO
            // 
            this.txtIznosPorezaDESNO.Location = new System.Drawing.Point(716, 72);
            this.txtIznosPorezaDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosPorezaDESNO.Name = "txtIznosPorezaDESNO";
            this.txtIznosPorezaDESNO.ReadOnly = true;
            this.txtIznosPorezaDESNO.Size = new System.Drawing.Size(103, 27);
            this.txtIznosPorezaDESNO.TabIndex = 28;
            this.txtIznosPorezaDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosPorezaDESNO.TextChanged += new System.EventHandler(this.TxtIznosPorezaDESNOTextChanged);
            // 
            // lblIznosporeza
            // 
            this.lblIznosporeza.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosporeza.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosporeza.Location = new System.Drawing.Point(827, 72);
            this.lblIznosporeza.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosporeza.Name = "lblIznosporeza";
            this.lblIznosporeza.Size = new System.Drawing.Size(106, 20);
            this.lblIznosporeza.TabIndex = 29;
            this.lblIznosporeza.Text = "Износ пореза";
            this.lblIznosporeza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIznosPioZaposleniDESNO
            // 
            this.txtIznosPioZaposleniDESNO.Location = new System.Drawing.Point(5, 21);
            this.txtIznosPioZaposleniDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosPioZaposleniDESNO.Name = "txtIznosPioZaposleniDESNO";
            this.txtIznosPioZaposleniDESNO.ReadOnly = true;
            this.txtIznosPioZaposleniDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosPioZaposleniDESNO.TabIndex = 30;
            this.txtIznosPioZaposleniDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosPioZaposleniDESNO.TextChanged += new System.EventHandler(this.TxtIznosPioZaposleniDESNOTextChanged);
            // 
            // lblIznosPIOZap
            // 
            this.lblIznosPIOZap.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosPIOZap.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosPIOZap.Location = new System.Drawing.Point(90, 21);
            this.lblIznosPIOZap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosPIOZap.Name = "lblIznosPIOZap";
            this.lblIznosPIOZap.Size = new System.Drawing.Size(46, 22);
            this.lblIznosPIOZap.TabIndex = 31;
            this.lblIznosPIOZap.Text = "ПИО";
            this.lblIznosPIOZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIznosZdravstvoZaposleniDESNO
            // 
            this.txtIznosZdravstvoZaposleniDESNO.Location = new System.Drawing.Point(5, 46);
            this.txtIznosZdravstvoZaposleniDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosZdravstvoZaposleniDESNO.Name = "txtIznosZdravstvoZaposleniDESNO";
            this.txtIznosZdravstvoZaposleniDESNO.ReadOnly = true;
            this.txtIznosZdravstvoZaposleniDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosZdravstvoZaposleniDESNO.TabIndex = 32;
            this.txtIznosZdravstvoZaposleniDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosZdravstvoZaposleniDESNO.TextChanged += new System.EventHandler(this.TxtIznosZdravZaposleniDESNOTextChanged);
            // 
            // lblIznosZdravZap
            // 
            this.lblIznosZdravZap.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosZdravZap.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosZdravZap.Location = new System.Drawing.Point(90, 46);
            this.lblIznosZdravZap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosZdravZap.Name = "lblIznosZdravZap";
            this.lblIznosZdravZap.Size = new System.Drawing.Size(88, 22);
            this.lblIznosZdravZap.TabIndex = 33;
            this.lblIznosZdravZap.Text = "Здравство";
            this.lblIznosZdravZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIznosNezaposlenostZaposleniDESNO
            // 
            this.txtIznosNezaposlenostZaposleniDESNO.Location = new System.Drawing.Point(5, 71);
            this.txtIznosNezaposlenostZaposleniDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosNezaposlenostZaposleniDESNO.Name = "txtIznosNezaposlenostZaposleniDESNO";
            this.txtIznosNezaposlenostZaposleniDESNO.ReadOnly = true;
            this.txtIznosNezaposlenostZaposleniDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosNezaposlenostZaposleniDESNO.TabIndex = 34;
            this.txtIznosNezaposlenostZaposleniDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosNezaposlenostZaposleniDESNO.TextChanged += new System.EventHandler(this.TxtIznosNezapZaposleniDESNOTextChanged);
            // 
            // lblIznosNezapZap
            // 
            this.lblIznosNezapZap.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosNezapZap.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosNezapZap.Location = new System.Drawing.Point(90, 69);
            this.lblIznosNezapZap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosNezapZap.Name = "lblIznosNezapZap";
            this.lblIznosNezapZap.Size = new System.Drawing.Size(111, 26);
            this.lblIznosNezapZap.TabIndex = 35;
            this.lblIznosNezapZap.Text = "Незапосленост";
            this.lblIznosNezapZap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIznosPIOPoslodavacDESNO
            // 
            this.txtIznosPIOPoslodavacDESNO.Location = new System.Drawing.Point(5, 21);
            this.txtIznosPIOPoslodavacDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosPIOPoslodavacDESNO.Name = "txtIznosPIOPoslodavacDESNO";
            this.txtIznosPIOPoslodavacDESNO.ReadOnly = true;
            this.txtIznosPIOPoslodavacDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosPIOPoslodavacDESNO.TabIndex = 36;
            this.txtIznosPIOPoslodavacDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosPIOPoslodavacDESNO.TextChanged += new System.EventHandler(this.TxtIznosPIOPoslodavacDESNOTextChanged);
            // 
            // txtIznosZdravstvoPoslodavacDESNO
            // 
            this.txtIznosZdravstvoPoslodavacDESNO.Location = new System.Drawing.Point(5, 46);
            this.txtIznosZdravstvoPoslodavacDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosZdravstvoPoslodavacDESNO.Name = "txtIznosZdravstvoPoslodavacDESNO";
            this.txtIznosZdravstvoPoslodavacDESNO.ReadOnly = true;
            this.txtIznosZdravstvoPoslodavacDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosZdravstvoPoslodavacDESNO.TabIndex = 37;
            this.txtIznosZdravstvoPoslodavacDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosZdravstvoPoslodavacDESNO.TextChanged += new System.EventHandler(this.TxtIznosZdravPoslodavacDESNOTextChanged);
            // 
            // txtIznosNezaposlenostPoslodavacDESNO
            // 
            this.txtIznosNezaposlenostPoslodavacDESNO.Location = new System.Drawing.Point(5, 71);
            this.txtIznosNezaposlenostPoslodavacDESNO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosNezaposlenostPoslodavacDESNO.Name = "txtIznosNezaposlenostPoslodavacDESNO";
            this.txtIznosNezaposlenostPoslodavacDESNO.ReadOnly = true;
            this.txtIznosNezaposlenostPoslodavacDESNO.Size = new System.Drawing.Size(81, 27);
            this.txtIznosNezaposlenostPoslodavacDESNO.TabIndex = 38;
            this.txtIznosNezaposlenostPoslodavacDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosNezaposlenostPoslodavacDESNO.TextChanged += new System.EventHandler(this.TxtIznosNezapPoslodavacDESNOTextChanged);
            // 
            // lblIznosPIOPosl
            // 
            this.lblIznosPIOPosl.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosPIOPosl.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosPIOPosl.Location = new System.Drawing.Point(90, 22);
            this.lblIznosPIOPosl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosPIOPosl.Name = "lblIznosPIOPosl";
            this.lblIznosPIOPosl.Size = new System.Drawing.Size(45, 22);
            this.lblIznosPIOPosl.TabIndex = 39;
            this.lblIznosPIOPosl.Text = "ПИО";
            this.lblIznosPIOPosl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(90, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Здравство";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(90, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 41;
            this.label2.Text = "Незапосленост";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblImeIPrezime
            // 
            this.lblImeIPrezime.BackColor = System.Drawing.Color.Transparent;
            this.lblImeIPrezime.Font = new System.Drawing.Font("Arial", 10F);
            this.lblImeIPrezime.Location = new System.Drawing.Point(257, 12);
            this.lblImeIPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImeIPrezime.Name = "lblImeIPrezime";
            this.lblImeIPrezime.Size = new System.Drawing.Size(126, 24);
            this.lblImeIPrezime.TabIndex = 43;
            this.lblImeIPrezime.Text = "Име и презиме";
            this.lblImeIPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIznosPoreskogUmanjenjaLEVO
            // 
            this.txtIznosPoreskogUmanjenjaLEVO.Location = new System.Drawing.Point(140, 282);
            this.txtIznosPoreskogUmanjenjaLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtIznosPoreskogUmanjenjaLEVO.Name = "txtIznosPoreskogUmanjenjaLEVO";
            this.txtIznosPoreskogUmanjenjaLEVO.ReadOnly = true;
            this.txtIznosPoreskogUmanjenjaLEVO.Size = new System.Drawing.Size(75, 27);
            this.txtIznosPoreskogUmanjenjaLEVO.TabIndex = 44;
            this.txtIznosPoreskogUmanjenjaLEVO.Text = "0";
            this.txtIznosPoreskogUmanjenjaLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIznosPoreskogUmanjenjaLEVO.TextChanged += new System.EventHandler(this.TxtIznosPoreskogUmanjenjaLEVOTextChanged);
            // 
            // lblIznosPoreskogUmanjenja
            // 
            this.lblIznosPoreskogUmanjenja.BackColor = System.Drawing.Color.Transparent;
            this.lblIznosPoreskogUmanjenja.Font = new System.Drawing.Font("Arial", 10F);
            this.lblIznosPoreskogUmanjenja.Location = new System.Drawing.Point(219, 282);
            this.lblIznosPoreskogUmanjenja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIznosPoreskogUmanjenja.Name = "lblIznosPoreskogUmanjenja";
            this.lblIznosPoreskogUmanjenja.Size = new System.Drawing.Size(165, 23);
            this.lblIznosPoreskogUmanjenja.TabIndex = 45;
            this.lblIznosPoreskogUmanjenja.Text = "Пореско умањење";
            this.lblIznosPoreskogUmanjenja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipObracuna
            // 
            this.lblTipObracuna.BackColor = System.Drawing.Color.Transparent;
            this.lblTipObracuna.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipObracuna.Location = new System.Drawing.Point(257, 43);
            this.lblTipObracuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipObracuna.Name = "lblTipObracuna";
            this.lblTipObracuna.Size = new System.Drawing.Size(126, 17);
            this.lblTipObracuna.TabIndex = 46;
            this.lblTipObracuna.Text = "Тип дохотка";
            this.lblTipObracuna.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTipDohotka
            // 
            this.cboTipDohotka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipDohotka.FormattingEnabled = true;
            this.cboTipDohotka.Location = new System.Drawing.Point(28, 40);
            this.cboTipDohotka.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipDohotka.Name = "cboTipDohotka";
            this.cboTipDohotka.Size = new System.Drawing.Size(217, 27);
            this.cboTipDohotka.TabIndex = 47;
            this.cboTipDohotka.SelectedIndexChanged += new System.EventHandler(this.CboTipDohotkaSelectedIndexChanged);
            // 
            // cboImeZaposlenog
            // 
            this.cboImeZaposlenog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImeZaposlenog.FormattingEnabled = true;
            this.cboImeZaposlenog.Location = new System.Drawing.Point(28, 12);
            this.cboImeZaposlenog.Margin = new System.Windows.Forms.Padding(2);
            this.cboImeZaposlenog.Name = "cboImeZaposlenog";
            this.cboImeZaposlenog.Size = new System.Drawing.Size(215, 27);
            this.cboImeZaposlenog.TabIndex = 48;
            this.cboImeZaposlenog.SelectedIndexChanged += new System.EventHandler(this.CboImeZaposlenogSelectedIndexChanged);
            // 
            // btnSpisakZaposlenih
            // 
            this.btnSpisakZaposlenih.BackColor = System.Drawing.Color.Transparent;
            this.btnSpisakZaposlenih.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpisakZaposlenih.BackgroundImage")));
            this.btnSpisakZaposlenih.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpisakZaposlenih.FlatAppearance.BorderSize = 2;
            this.btnSpisakZaposlenih.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpisakZaposlenih.Location = new System.Drawing.Point(546, 11);
            this.btnSpisakZaposlenih.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpisakZaposlenih.Name = "btnSpisakZaposlenih";
            this.btnSpisakZaposlenih.Size = new System.Drawing.Size(80, 70);
            this.btnSpisakZaposlenih.TabIndex = 49;
            this.btnSpisakZaposlenih.UseVisualStyleBackColor = false;
            this.btnSpisakZaposlenih.Click += new System.EventHandler(this.btnSpisakZaposlenihClick);
            // 
            // txtNajnizaOsnovicaLEVO
            // 
            this.txtNajnizaOsnovicaLEVO.Location = new System.Drawing.Point(140, 247);
            this.txtNajnizaOsnovicaLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtNajnizaOsnovicaLEVO.Name = "txtNajnizaOsnovicaLEVO";
            this.txtNajnizaOsnovicaLEVO.ReadOnly = true;
            this.txtNajnizaOsnovicaLEVO.Size = new System.Drawing.Size(75, 27);
            this.txtNajnizaOsnovicaLEVO.TabIndex = 50;
            this.txtNajnizaOsnovicaLEVO.Text = "0";
            this.txtNajnizaOsnovicaLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNajnizaOsnovicaLEVO.TextChanged += new System.EventHandler(this.TxtNajnizaOsnovicaLEVOTextChanged);
            // 
            // lblNajnizaOsnovica
            // 
            this.lblNajnizaOsnovica.BackColor = System.Drawing.Color.Transparent;
            this.lblNajnizaOsnovica.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNajnizaOsnovica.Location = new System.Drawing.Point(219, 247);
            this.lblNajnizaOsnovica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNajnizaOsnovica.Name = "lblNajnizaOsnovica";
            this.lblNajnizaOsnovica.Size = new System.Drawing.Size(172, 23);
            this.lblNajnizaOsnovica.TabIndex = 51;
            this.lblNajnizaOsnovica.Text = "Најнижа  основица";
            this.lblNajnizaOsnovica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNajvisaOsnovicaLEVO
            // 
            this.txtNajvisaOsnovicaLEVO.Location = new System.Drawing.Point(140, 220);
            this.txtNajvisaOsnovicaLEVO.Margin = new System.Windows.Forms.Padding(2);
            this.txtNajvisaOsnovicaLEVO.Name = "txtNajvisaOsnovicaLEVO";
            this.txtNajvisaOsnovicaLEVO.ReadOnly = true;
            this.txtNajvisaOsnovicaLEVO.Size = new System.Drawing.Size(75, 27);
            this.txtNajvisaOsnovicaLEVO.TabIndex = 52;
            this.txtNajvisaOsnovicaLEVO.Text = "0";
            this.txtNajvisaOsnovicaLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNajvisaOsnovicaLEVO.TextChanged += new System.EventHandler(this.TxtNajvisaOsnovicaLEVOTextChanged);
            // 
            // lblNajvisaOsnovica
            // 
            this.lblNajvisaOsnovica.BackColor = System.Drawing.Color.Transparent;
            this.lblNajvisaOsnovica.Font = new System.Drawing.Font("Arial", 10F);
            this.lblNajvisaOsnovica.Location = new System.Drawing.Point(219, 220);
            this.lblNajvisaOsnovica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNajvisaOsnovica.Name = "lblNajvisaOsnovica";
            this.lblNajvisaOsnovica.Size = new System.Drawing.Size(157, 23);
            this.lblNajvisaOsnovica.TabIndex = 53;
            this.lblNajvisaOsnovica.Text = "Највиша основица";
            this.lblNajvisaOsnovica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBazaZaposlenih
            // 
            this.lblBazaZaposlenih.BackColor = System.Drawing.Color.Transparent;
            this.lblBazaZaposlenih.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBazaZaposlenih.Location = new System.Drawing.Point(530, 83);
            this.lblBazaZaposlenih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBazaZaposlenih.Name = "lblBazaZaposlenih";
            this.lblBazaZaposlenih.Size = new System.Drawing.Size(109, 21);
            this.lblBazaZaposlenih.TabIndex = 54;
            this.lblBazaZaposlenih.Text = "База података запослених";
            // 
            // cboVrstaUgovora
            // 
            this.cboVrstaUgovora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVrstaUgovora.FormattingEnabled = true;
            this.cboVrstaUgovora.Location = new System.Drawing.Point(28, 71);
            this.cboVrstaUgovora.Margin = new System.Windows.Forms.Padding(2);
            this.cboVrstaUgovora.Name = "cboVrstaUgovora";
            this.cboVrstaUgovora.Size = new System.Drawing.Size(455, 27);
            this.cboVrstaUgovora.TabIndex = 55;
            this.cboVrstaUgovora.SelectedIndexChanged += new System.EventHandler(this.CboVrstaUgovoraSelectedIndexChanged);
            // 
            // lblVrstaUgovora
            // 
            this.lblVrstaUgovora.BackColor = System.Drawing.Color.Transparent;
            this.lblVrstaUgovora.Font = new System.Drawing.Font("Arial", 10F);
            this.lblVrstaUgovora.Location = new System.Drawing.Point(196, 97);
            this.lblVrstaUgovora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrstaUgovora.Name = "lblVrstaUgovora";
            this.lblVrstaUgovora.Size = new System.Drawing.Size(124, 21);
            this.lblVrstaUgovora.TabIndex = 56;
            this.lblVrstaUgovora.Text = "Врста уговора";
            this.lblVrstaUgovora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabNetoBruto
            // 
            this.tabNetoBruto.Controls.Add(this.tabPage1);
            this.tabNetoBruto.Controls.Add(this.tabPage2);
            this.tabNetoBruto.Location = new System.Drawing.Point(12, 129);
            this.tabNetoBruto.Name = "tabNetoBruto";
            this.tabNetoBruto.SelectedIndex = 0;
            this.tabNetoBruto.Size = new System.Drawing.Size(326, 86);
            this.tabNetoBruto.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.txtNetoIznosLEVO);
            this.tabPage1.Controls.Add(this.lblNetoIznosTab);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(283, 54);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "За познат НЕТО";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.txtBrutoIznosLEVO);
            this.tabPage2.Controls.Add(this.lblBrutoIznosTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 54);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "За познат БРУТО";
            // 
            // txtBrutoIznosLEVO
            // 
            this.txtBrutoIznosLEVO.Location = new System.Drawing.Point(160, 18);
            this.txtBrutoIznosLEVO.Name = "txtBrutoIznosLEVO";
            this.txtBrutoIznosLEVO.Size = new System.Drawing.Size(117, 27);
            this.txtBrutoIznosLEVO.TabIndex = 1;
            this.txtBrutoIznosLEVO.Text = "0.00";
            this.txtBrutoIznosLEVO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBrutoIznosTab
            // 
            this.lblBrutoIznosTab.BackColor = System.Drawing.Color.Transparent;
            this.lblBrutoIznosTab.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrutoIznosTab.Location = new System.Drawing.Point(2, 18);
            this.lblBrutoIznosTab.Name = "lblBrutoIznosTab";
            this.lblBrutoIznosTab.Size = new System.Drawing.Size(140, 23);
            this.lblBrutoIznosTab.TabIndex = 0;
            this.lblBrutoIznosTab.Text = "Бруто износ";
            this.lblBrutoIznosTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNetoIznosDESNO
            // 
            this.txtNetoIznosDESNO.Location = new System.Drawing.Point(716, 37);
            this.txtNetoIznosDESNO.Name = "txtNetoIznosDESNO";
            this.txtNetoIznosDESNO.ReadOnly = true;
            this.txtNetoIznosDESNO.Size = new System.Drawing.Size(103, 27);
            this.txtNetoIznosDESNO.TabIndex = 58;
            this.txtNetoIznosDESNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNetoIznosDESNO.TextChanged += new System.EventHandler(this.TxtNetoIznosDESNOTextChanged);
            // 
            // lblNetoIznos
            // 
            this.lblNetoIznos.BackColor = System.Drawing.Color.Transparent;
            this.lblNetoIznos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetoIznos.Location = new System.Drawing.Point(827, 35);
            this.lblNetoIznos.Name = "lblNetoIznos";
            this.lblNetoIznos.Size = new System.Drawing.Size(90, 23);
            this.lblNetoIznos.TabIndex = 59;
            this.lblNetoIznos.Text = "Нето износ";
            this.lblNetoIznos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cboImeZaposlenog);
            this.panel1.Controls.Add(this.lblImeIPrezime);
            this.panel1.Controls.Add(this.lblTipObracuna);
            this.panel1.Controls.Add(this.lblNetoIznos);
            this.panel1.Controls.Add(this.cboTipDohotka);
            this.panel1.Controls.Add(this.cboVrstaUgovora);
            this.panel1.Controls.Add(this.txtNetoIznosDESNO);
            this.panel1.Controls.Add(this.lblVrstaUgovora);
            this.panel1.Controls.Add(this.lblBazaZaposlenih);
            this.panel1.Controls.Add(this.txtBrutoIznosDESNO);
            this.panel1.Controls.Add(this.btnSpisakZaposlenih);
            this.panel1.Controls.Add(this.lblBrutoIznos);
            this.panel1.Controls.Add(this.txtIznosPorezaDESNO);
            this.panel1.Controls.Add(this.lblIznosporeza);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 121);
            this.panel1.TabIndex = 60;
            // 
            // groupZaUnos
            // 
            this.groupZaUnos.BackColor = System.Drawing.Color.Transparent;
            this.groupZaUnos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupZaUnos.BackgroundImage")));
            this.groupZaUnos.Controls.Add(this.btnUnesiUFormu);
            this.groupZaUnos.Controls.Add(this.label4);
            this.groupZaUnos.Controls.Add(this.lblMFP);
            this.groupZaUnos.Controls.Add(this.lblBeneficiraniPIO);
            this.groupZaUnos.Controls.Add(this.label3);
            this.groupZaUnos.Controls.Add(this.lblZdravstvo);
            this.groupZaUnos.Controls.Add(this.lblPIO);
            this.groupZaUnos.Controls.Add(this.lblOsnovicazaDoprinose);
            this.groupZaUnos.Controls.Add(this.lblPorez);
            this.groupZaUnos.Controls.Add(this.lblOsnovicazaPorez);
            this.groupZaUnos.Controls.Add(this.lblBrutoPrihod);
            this.groupZaUnos.Controls.Add(this.lblBrojSati);
            this.groupZaUnos.Controls.Add(this.lblBrojDana);
            this.groupZaUnos.Controls.Add(this.txtBeneficiraniPIOZaPPD);
            this.groupZaUnos.Controls.Add(this.txtNezaposlenostZaPPD);
            this.groupZaUnos.Controls.Add(this.txtZdravstvoZaPPD);
            this.groupZaUnos.Controls.Add(this.txtPIOZaPPD);
            this.groupZaUnos.Controls.Add(this.txtMFPZaPPD);
            this.groupZaUnos.Controls.Add(this.txtOsnovicaZaDoprinoseZaPPD);
            this.groupZaUnos.Controls.Add(this.txtPorezZaPPD);
            this.groupZaUnos.Controls.Add(this.txtOsnovicaZaPorezZaPPD);
            this.groupZaUnos.Controls.Add(this.txtBrutoPrihodZaPPD);
            this.groupZaUnos.Controls.Add(this.txtBrojSati);
            this.groupZaUnos.Controls.Add(this.txtBrojDana);
            this.groupZaUnos.Controls.Add(this.txtSifraVrstePrihoda);
            this.groupZaUnos.Controls.Add(this.lblPrezime);
            this.groupZaUnos.Controls.Add(this.lblIme);
            this.groupZaUnos.Controls.Add(this.lblFirma);
            this.groupZaUnos.Controls.Add(this.btnOtvoriFormu);
            this.groupZaUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupZaUnos.Location = new System.Drawing.Point(399, 238);
            this.groupZaUnos.Margin = new System.Windows.Forms.Padding(6);
            this.groupZaUnos.Name = "groupZaUnos";
            this.groupZaUnos.Size = new System.Drawing.Size(599, 233);
            this.groupZaUnos.TabIndex = 61;
            this.groupZaUnos.TabStop = false;
            this.groupZaUnos.Text = "Подаци за унос у пријаву";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(13, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Шифра врсте прихода";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMFP
            // 
            this.lblMFP.BackColor = System.Drawing.Color.Transparent;
            this.lblMFP.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMFP.Location = new System.Drawing.Point(83, 193);
            this.lblMFP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMFP.Name = "lblMFP";
            this.lblMFP.Size = new System.Drawing.Size(51, 23);
            this.lblMFP.TabIndex = 74;
            this.lblMFP.Text = "МФП";
            this.lblMFP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBeneficiraniPIO
            // 
            this.lblBeneficiraniPIO.BackColor = System.Drawing.Color.Transparent;
            this.lblBeneficiraniPIO.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBeneficiraniPIO.Location = new System.Drawing.Point(328, 204);
            this.lblBeneficiraniPIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBeneficiraniPIO.Name = "lblBeneficiraniPIO";
            this.lblBeneficiraniPIO.Size = new System.Drawing.Size(144, 22);
            this.lblBeneficiraniPIO.TabIndex = 73;
            this.lblBeneficiraniPIO.Text = "Бенефицирани ПИО";
            this.lblBeneficiraniPIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(334, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 72;
            this.label3.Text = "Незапосленост";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZdravstvo
            // 
            this.lblZdravstvo.BackColor = System.Drawing.Color.Transparent;
            this.lblZdravstvo.Font = new System.Drawing.Font("Arial", 10F);
            this.lblZdravstvo.Location = new System.Drawing.Point(345, 98);
            this.lblZdravstvo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZdravstvo.Name = "lblZdravstvo";
            this.lblZdravstvo.Size = new System.Drawing.Size(100, 22);
            this.lblZdravstvo.TabIndex = 71;
            this.lblZdravstvo.Text = "Здравство";
            this.lblZdravstvo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPIO
            // 
            this.lblPIO.BackColor = System.Drawing.Color.Transparent;
            this.lblPIO.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPIO.Location = new System.Drawing.Point(345, 44);
            this.lblPIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPIO.Name = "lblPIO";
            this.lblPIO.Size = new System.Drawing.Size(100, 22);
            this.lblPIO.TabIndex = 70;
            this.lblPIO.Text = "ПИО";
            this.lblPIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOsnovicazaDoprinose
            // 
            this.lblOsnovicazaDoprinose.BackColor = System.Drawing.Color.Transparent;
            this.lblOsnovicazaDoprinose.Font = new System.Drawing.Font("Arial", 10F);
            this.lblOsnovicazaDoprinose.Location = new System.Drawing.Point(148, 204);
            this.lblOsnovicazaDoprinose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOsnovicazaDoprinose.Name = "lblOsnovicazaDoprinose";
            this.lblOsnovicazaDoprinose.Size = new System.Drawing.Size(176, 22);
            this.lblOsnovicazaDoprinose.TabIndex = 69;
            this.lblOsnovicazaDoprinose.Text = "Основица за доприносе";
            this.lblOsnovicazaDoprinose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPorez
            // 
            this.lblPorez.BackColor = System.Drawing.Color.Transparent;
            this.lblPorez.Font = new System.Drawing.Font("Arial", 10F);
            this.lblPorez.Location = new System.Drawing.Point(202, 151);
            this.lblPorez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPorez.Name = "lblPorez";
            this.lblPorez.Size = new System.Drawing.Size(100, 22);
            this.lblPorez.TabIndex = 68;
            this.lblPorez.Text = "Порез";
            this.lblPorez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOsnovicazaPorez
            // 
            this.lblOsnovicazaPorez.BackColor = System.Drawing.Color.Transparent;
            this.lblOsnovicazaPorez.Font = new System.Drawing.Font("Arial", 10F);
            this.lblOsnovicazaPorez.Location = new System.Drawing.Point(183, 98);
            this.lblOsnovicazaPorez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOsnovicazaPorez.Name = "lblOsnovicazaPorez";
            this.lblOsnovicazaPorez.Size = new System.Drawing.Size(141, 22);
            this.lblOsnovicazaPorez.TabIndex = 67;
            this.lblOsnovicazaPorez.Text = "Основица за порез";
            this.lblOsnovicazaPorez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrutoPrihod
            // 
            this.lblBrutoPrihod.BackColor = System.Drawing.Color.Transparent;
            this.lblBrutoPrihod.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBrutoPrihod.Location = new System.Drawing.Point(202, 44);
            this.lblBrutoPrihod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrutoPrihod.Name = "lblBrutoPrihod";
            this.lblBrutoPrihod.Size = new System.Drawing.Size(100, 22);
            this.lblBrutoPrihod.TabIndex = 66;
            this.lblBrutoPrihod.Text = "Бруто приход";
            this.lblBrutoPrihod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrojSati
            // 
            this.lblBrojSati.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojSati.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBrojSati.Location = new System.Drawing.Point(46, 160);
            this.lblBrojSati.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojSati.Name = "lblBrojSati";
            this.lblBrojSati.Size = new System.Drawing.Size(80, 23);
            this.lblBrojSati.TabIndex = 65;
            this.lblBrojSati.Text = "Број сати";
            this.lblBrojSati.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBrojDana
            // 
            this.lblBrojDana.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojDana.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBrojDana.Location = new System.Drawing.Point(46, 128);
            this.lblBrojDana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBrojDana.Name = "lblBrojDana";
            this.lblBrojDana.Size = new System.Drawing.Size(80, 23);
            this.lblBrojDana.TabIndex = 64;
            this.lblBrojDana.Text = "Број дана";
            this.lblBrojDana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBeneficiraniPIOZaPPD
            // 
            this.txtBeneficiraniPIOZaPPD.Location = new System.Drawing.Point(345, 178);
            this.txtBeneficiraniPIOZaPPD.Name = "txtBeneficiraniPIOZaPPD";
            this.txtBeneficiraniPIOZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtBeneficiraniPIOZaPPD.TabIndex = 41;
            this.txtBeneficiraniPIOZaPPD.Text = "0";
            this.txtBeneficiraniPIOZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBeneficiraniPIOZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeneficiraniPIOZaPPD_KeyPress);
            this.txtBeneficiraniPIOZaPPD.Leave += new System.EventHandler(this.TxtBeneficiraniPIOZaPPDLeave);
            // 
            // txtNezaposlenostZaPPD
            // 
            this.txtNezaposlenostZaPPD.Location = new System.Drawing.Point(345, 125);
            this.txtNezaposlenostZaPPD.Name = "txtNezaposlenostZaPPD";
            this.txtNezaposlenostZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtNezaposlenostZaPPD.TabIndex = 40;
            this.txtNezaposlenostZaPPD.Text = "0";
            this.txtNezaposlenostZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNezaposlenostZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNezaposlenostZaPPD_KeyPress);
            this.txtNezaposlenostZaPPD.Leave += new System.EventHandler(this.TxtNezaposlenostZaPPDLeave);
            // 
            // txtZdravstvoZaPPD
            // 
            this.txtZdravstvoZaPPD.Location = new System.Drawing.Point(345, 72);
            this.txtZdravstvoZaPPD.Name = "txtZdravstvoZaPPD";
            this.txtZdravstvoZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtZdravstvoZaPPD.TabIndex = 39;
            this.txtZdravstvoZaPPD.Text = "0";
            this.txtZdravstvoZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZdravstvoZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZdravstvoZaPPD_KeyPress);
            this.txtZdravstvoZaPPD.Leave += new System.EventHandler(this.TxtZdravstvoZaPPDLeave);
            // 
            // txtPIOZaPPD
            // 
            this.txtPIOZaPPD.Location = new System.Drawing.Point(345, 19);
            this.txtPIOZaPPD.Name = "txtPIOZaPPD";
            this.txtPIOZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtPIOZaPPD.TabIndex = 38;
            this.txtPIOZaPPD.Text = "0";
            this.txtPIOZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPIOZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPIOZaPPD_KeyPress);
            this.txtPIOZaPPD.Leave += new System.EventHandler(this.TxtPIOZaPPDLeave);
            // 
            // txtMFPZaPPD
            // 
            this.txtMFPZaPPD.Location = new System.Drawing.Point(6, 193);
            this.txtMFPZaPPD.Name = "txtMFPZaPPD";
            this.txtMFPZaPPD.Size = new System.Drawing.Size(72, 27);
            this.txtMFPZaPPD.TabIndex = 37;
            this.txtMFPZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMFPZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMFPZaPPD_KeyPress);
            this.txtMFPZaPPD.Leave += new System.EventHandler(this.TxtMFPZaPPDLeave);
            // 
            // txtOsnovicaZaDoprinoseZaPPD
            // 
            this.txtOsnovicaZaDoprinoseZaPPD.Location = new System.Drawing.Point(202, 178);
            this.txtOsnovicaZaDoprinoseZaPPD.Name = "txtOsnovicaZaDoprinoseZaPPD";
            this.txtOsnovicaZaDoprinoseZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtOsnovicaZaDoprinoseZaPPD.TabIndex = 36;
            this.txtOsnovicaZaDoprinoseZaPPD.Text = "0";
            this.txtOsnovicaZaDoprinoseZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOsnovicaZaDoprinoseZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOsnovicaZaDoprinoseZaPPD_KeyPress);
            this.txtOsnovicaZaDoprinoseZaPPD.Leave += new System.EventHandler(this.TxtOsnovicaZaDoprinoseZaPPDLeave);
            // 
            // txtPorezZaPPD
            // 
            this.txtPorezZaPPD.Location = new System.Drawing.Point(202, 125);
            this.txtPorezZaPPD.Name = "txtPorezZaPPD";
            this.txtPorezZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtPorezZaPPD.TabIndex = 35;
            this.txtPorezZaPPD.Text = "0";
            this.txtPorezZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorezZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorezZaPPD_KeyPress);
            this.txtPorezZaPPD.Leave += new System.EventHandler(this.TxtPorezZaPPDLeave);
            // 
            // txtOsnovicaZaPorezZaPPD
            // 
            this.txtOsnovicaZaPorezZaPPD.Location = new System.Drawing.Point(202, 72);
            this.txtOsnovicaZaPorezZaPPD.Name = "txtOsnovicaZaPorezZaPPD";
            this.txtOsnovicaZaPorezZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtOsnovicaZaPorezZaPPD.TabIndex = 34;
            this.txtOsnovicaZaPorezZaPPD.Text = "0";
            this.txtOsnovicaZaPorezZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOsnovicaZaPorezZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOsnovicaZaPorezZaPPD_KeyPress);
            this.txtOsnovicaZaPorezZaPPD.Leave += new System.EventHandler(this.TxtOsnovicaZaPorezZaPPDLeave);
            // 
            // txtBrutoPrihodZaPPD
            // 
            this.txtBrutoPrihodZaPPD.Location = new System.Drawing.Point(202, 19);
            this.txtBrutoPrihodZaPPD.Name = "txtBrutoPrihodZaPPD";
            this.txtBrutoPrihodZaPPD.Size = new System.Drawing.Size(100, 27);
            this.txtBrutoPrihodZaPPD.TabIndex = 33;
            this.txtBrutoPrihodZaPPD.Text = "0";
            this.txtBrutoPrihodZaPPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBrutoPrihodZaPPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBrutoPrihodZaPPD_KeyPress);
            this.txtBrutoPrihodZaPPD.Leave += new System.EventHandler(this.txtBrutoPrihodZaPPD_Leave);
            // 
            // txtBrojSati
            // 
            this.txtBrojSati.Location = new System.Drawing.Point(6, 160);
            this.txtBrojSati.Name = "txtBrojSati";
            this.txtBrojSati.Size = new System.Drawing.Size(35, 27);
            this.txtBrojSati.TabIndex = 32;
            this.txtBrojSati.Text = "176";
            this.txtBrojSati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBrojDana
            // 
            this.txtBrojDana.Location = new System.Drawing.Point(6, 128);
            this.txtBrojDana.Name = "txtBrojDana";
            this.txtBrojDana.Size = new System.Drawing.Size(35, 27);
            this.txtBrojDana.TabIndex = 31;
            this.txtBrojDana.Text = "31";
            this.txtBrojDana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSifraVrstePrihoda
            // 
            this.txtSifraVrstePrihoda.Location = new System.Drawing.Point(13, 74);
            this.txtSifraVrstePrihoda.Name = "txtSifraVrstePrihoda";
            this.txtSifraVrstePrihoda.Size = new System.Drawing.Size(165, 27);
            this.txtSifraVrstePrihoda.TabIndex = 30;
            this.txtSifraVrstePrihoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrezime
            // 
            this.lblPrezime.Location = new System.Drawing.Point(471, 19);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(100, 23);
            this.lblPrezime.TabIndex = 29;
            this.lblPrezime.Text = "//prezime";
            this.lblPrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIme
            // 
            this.lblIme.Location = new System.Drawing.Point(471, 44);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(100, 23);
            this.lblIme.TabIndex = 28;
            this.lblIme.Text = "//lblime";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirma
            // 
            this.lblFirma.Location = new System.Drawing.Point(13, 33);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(165, 23);
            this.lblFirma.TabIndex = 27;
            this.lblFirma.Text = "//ime firme";
            this.lblFirma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupPoslodavac
            // 
            this.groupPoslodavac.BackColor = System.Drawing.Color.Transparent;
            this.groupPoslodavac.Controls.Add(this.txtStopaPIOPoslodavacLEVO);
            this.groupPoslodavac.Controls.Add(this.txtStopaZdravstvoPoslodavacLEVO);
            this.groupPoslodavac.Controls.Add(this.txtStopaNezaposlenostPoslodavacLEVO);
            this.groupPoslodavac.Controls.Add(this.lblPIOPosl);
            this.groupPoslodavac.Controls.Add(this.lblZdravPosl);
            this.groupPoslodavac.Controls.Add(this.lblNezapPosl);
            this.groupPoslodavac.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPoslodavac.Location = new System.Drawing.Point(197, 321);
            this.groupPoslodavac.Name = "groupPoslodavac";
            this.groupPoslodavac.Size = new System.Drawing.Size(187, 107);
            this.groupPoslodavac.TabIndex = 62;
            this.groupPoslodavac.TabStop = false;
            this.groupPoslodavac.Text = "На терет послодавца";
            // 
            // groupZaposleni
            // 
            this.groupZaposleni.BackColor = System.Drawing.Color.Transparent;
            this.groupZaposleni.Controls.Add(this.txtStopaPIOZaposlenogLEVO);
            this.groupZaposleni.Controls.Add(this.txtStopaZdravstvoZaposlenogLEVO);
            this.groupZaposleni.Controls.Add(this.txtStopaNezaposlenostiZaposlenogLEVO);
            this.groupZaposleni.Controls.Add(this.lblPIOZaposl);
            this.groupZaposleni.Controls.Add(this.lblZdravsZaposl);
            this.groupZaposleni.Controls.Add(this.lblNezapZaposl);
            this.groupZaposleni.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupZaposleni.Location = new System.Drawing.Point(5, 321);
            this.groupZaposleni.Name = "groupZaposleni";
            this.groupZaposleni.Size = new System.Drawing.Size(186, 107);
            this.groupZaposleni.TabIndex = 63;
            this.groupZaposleni.TabStop = false;
            this.groupZaposleni.Text = "На терет запосленог";
            // 
            // groupIznosZaposleni
            // 
            this.groupIznosZaposleni.BackColor = System.Drawing.Color.Transparent;
            this.groupIznosZaposleni.Controls.Add(this.txtIznosPioZaposleniDESNO);
            this.groupIznosZaposleni.Controls.Add(this.txtIznosZdravstvoZaposleniDESNO);
            this.groupIznosZaposleni.Controls.Add(this.txtIznosNezaposlenostZaposleniDESNO);
            this.groupIznosZaposleni.Controls.Add(this.lblIznosPIOZap);
            this.groupIznosZaposleni.Controls.Add(this.lblIznosZdravZap);
            this.groupIznosZaposleni.Controls.Add(this.lblIznosNezapZap);
            this.groupIznosZaposleni.Location = new System.Drawing.Point(564, 126);
            this.groupIznosZaposleni.Name = "groupIznosZaposleni";
            this.groupIznosZaposleni.Size = new System.Drawing.Size(210, 101);
            this.groupIznosZaposleni.TabIndex = 0;
            this.groupIznosZaposleni.TabStop = false;
            this.groupIznosZaposleni.Text = "Износи /  запослени";
            // 
            // groupIznosPoslodavac
            // 
            this.groupIznosPoslodavac.BackColor = System.Drawing.Color.Transparent;
            this.groupIznosPoslodavac.Controls.Add(this.txtIznosPIOPoslodavacDESNO);
            this.groupIznosPoslodavac.Controls.Add(this.txtIznosZdravstvoPoslodavacDESNO);
            this.groupIznosPoslodavac.Controls.Add(this.txtIznosNezaposlenostPoslodavacDESNO);
            this.groupIznosPoslodavac.Controls.Add(this.lblIznosPIOPosl);
            this.groupIznosPoslodavac.Controls.Add(this.label1);
            this.groupIznosPoslodavac.Controls.Add(this.label2);
            this.groupIznosPoslodavac.Location = new System.Drawing.Point(780, 126);
            this.groupIznosPoslodavac.Name = "groupIznosPoslodavac";
            this.groupIznosPoslodavac.Size = new System.Drawing.Size(218, 103);
            this.groupIznosPoslodavac.TabIndex = 0;
            this.groupIznosPoslodavac.TabStop = false;
            this.groupIznosPoslodavac.Text = "Износи / послодавац";
            // 
            // btnUnesiUFormu
            // 
            this.btnUnesiUFormu.Location = new System.Drawing.Point(472, 98);
            this.btnUnesiUFormu.Name = "btnUnesiUFormu";
            this.btnUnesiUFormu.Size = new System.Drawing.Size(121, 50);
            this.btnUnesiUFormu.TabIndex = 76;
            this.btnUnesiUFormu.Text = "Унеси у форму";
            this.btnUnesiUFormu.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 478);
            this.Controls.Add(this.groupIznosPoslodavac);
            this.Controls.Add(this.groupIznosZaposleni);
            this.Controls.Add(this.groupZaposleni);
            this.Controls.Add(this.groupPoslodavac);
            this.Controls.Add(this.groupZaUnos);
            this.Controls.Add(this.lblNajnizaOsnovica);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIznosPoreskogUmanjenjaLEVO);
            this.Controls.Add(this.lblIznosPoreskogUmanjenja);
            this.Controls.Add(this.txtNajnizaOsnovicaLEVO);
            this.Controls.Add(this.txtNajvisaOsnovicaLEVO);
            this.Controls.Add(this.tabNetoBruto);
            this.Controls.Add(this.lblNajvisaOsnovica);
            this.Controls.Add(this.btnSnimiStope);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.lblStopaPoreza);
            this.Controls.Add(this.txtStopaPorezaLEVO);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iPayRoll - Trial version";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.tabNetoBruto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupZaUnos.ResumeLayout(false);
            this.groupZaUnos.PerformLayout();
            this.groupPoslodavac.ResumeLayout(false);
            this.groupPoslodavac.PerformLayout();
            this.groupZaposleni.ResumeLayout(false);
            this.groupZaposleni.PerformLayout();
            this.groupIznosZaposleni.ResumeLayout(false);
            this.groupIznosZaposleni.PerformLayout();
            this.groupIznosPoslodavac.ResumeLayout(false);
            this.groupIznosPoslodavac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMFP;
		private System.Windows.Forms.Label lblOsnovicazaDoprinose;
		private System.Windows.Forms.Label lblPIO;
		private System.Windows.Forms.Label lblZdravstvo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblBeneficiraniPIO;
		private System.Windows.Forms.Label lblPorez;
		private System.Windows.Forms.Label lblBrutoPrihod;
		private System.Windows.Forms.Label lblOsnovicazaPorez;
		private System.Windows.Forms.Label lblBrojDana;
		private System.Windows.Forms.Label lblBrojSati;
		private System.Windows.Forms.Label lblIme;
		private System.Windows.Forms.Label lblPrezime;
		private System.Windows.Forms.TextBox txtSifraVrstePrihoda;
		private System.Windows.Forms.TextBox txtBrojDana;
		private System.Windows.Forms.TextBox txtBrojSati;
		private System.Windows.Forms.TextBox txtBrutoPrihodZaPPD;
		private System.Windows.Forms.TextBox txtOsnovicaZaPorezZaPPD;
		private System.Windows.Forms.TextBox txtPorezZaPPD;
		private System.Windows.Forms.TextBox txtOsnovicaZaDoprinoseZaPPD;
		private System.Windows.Forms.TextBox txtMFPZaPPD;
		private System.Windows.Forms.TextBox txtPIOZaPPD;
		private System.Windows.Forms.TextBox txtZdravstvoZaPPD;
		private System.Windows.Forms.TextBox txtNezaposlenostZaPPD;
		private System.Windows.Forms.TextBox txtBeneficiraniPIOZaPPD;
		private System.Windows.Forms.Label lblFirma;
		private System.Windows.Forms.GroupBox groupIznosPoslodavac;
		private System.Windows.Forms.GroupBox groupIznosZaposleni;
		private System.Windows.Forms.GroupBox groupZaposleni;
		private System.Windows.Forms.GroupBox groupPoslodavac;
		private System.Windows.Forms.GroupBox groupZaUnos;
		private System.Windows.Forms.Label lblBrutoIznosTab;
		private System.Windows.Forms.TextBox txtBrutoIznosLEVO;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblNetoIznos;
		private System.Windows.Forms.TextBox txtNetoIznosDESNO;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabNetoBruto;
		private System.Windows.Forms.Label lblVrstaUgovora;
		private System.Windows.Forms.ComboBox cboVrstaUgovora;
		private System.Windows.Forms.Label lblBazaZaposlenih;
		private System.Windows.Forms.Label lblNajvisaOsnovica;
		private System.Windows.Forms.TextBox txtNajvisaOsnovicaLEVO;
		private System.Windows.Forms.Label lblNajnizaOsnovica;
		private System.Windows.Forms.TextBox txtNajnizaOsnovicaLEVO;
		private System.Windows.Forms.Button btnSpisakZaposlenih;
		private System.Windows.Forms.ComboBox cboImeZaposlenog;
		private System.Windows.Forms.ComboBox cboTipDohotka;
		private System.Windows.Forms.Label lblTipObracuna;
		private System.Windows.Forms.Label lblIznosPoreskogUmanjenja;
		private System.Windows.Forms.TextBox txtIznosPoreskogUmanjenjaLEVO;
		private System.Windows.Forms.Label lblImeIPrezime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblIznosPIOPosl;
		private System.Windows.Forms.TextBox txtIznosNezaposlenostPoslodavacDESNO;
		private System.Windows.Forms.TextBox txtIznosZdravstvoPoslodavacDESNO;
		private System.Windows.Forms.TextBox txtIznosPIOPoslodavacDESNO;
		private System.Windows.Forms.Label lblIznosNezapZap;
		private System.Windows.Forms.TextBox txtIznosNezaposlenostZaposleniDESNO;
		private System.Windows.Forms.Label lblIznosZdravZap;
		private System.Windows.Forms.TextBox txtIznosZdravstvoZaposleniDESNO;
		private System.Windows.Forms.Label lblIznosPIOZap;
		private System.Windows.Forms.TextBox txtIznosPioZaposleniDESNO;
		private System.Windows.Forms.Label lblIznosporeza;
		private System.Windows.Forms.TextBox txtIznosPorezaDESNO;
		private System.Windows.Forms.Button btnSnimiStope;
		private System.Windows.Forms.Button btnOtvoriFormu;
		private System.Windows.Forms.Button btnIzracunaj;
		private System.Windows.Forms.Label lblNezapPosl;
		private System.Windows.Forms.TextBox txtStopaNezaposlenostPoslodavacLEVO;
		private System.Windows.Forms.Label lblZdravPosl;
		private System.Windows.Forms.TextBox txtStopaZdravstvoPoslodavacLEVO;
		private System.Windows.Forms.Label lblPIOPosl;
		private System.Windows.Forms.TextBox txtStopaPIOPoslodavacLEVO;
		private System.Windows.Forms.Label lblNezapZaposl;
		private System.Windows.Forms.TextBox txtStopaNezaposlenostiZaposlenogLEVO;
		private System.Windows.Forms.Label lblZdravsZaposl;
		private System.Windows.Forms.TextBox txtStopaZdravstvoZaposlenogLEVO;
		private System.Windows.Forms.Label lblPIOZaposl;
		private System.Windows.Forms.TextBox txtStopaPIOZaposlenogLEVO;
		private System.Windows.Forms.Label lblBrutoIznos;
		private System.Windows.Forms.TextBox txtBrutoIznosDESNO;
		private System.Windows.Forms.Label lblStopaPoreza;
		private System.Windows.Forms.TextBox txtStopaPorezaLEVO;
		private System.Windows.Forms.Label lblNetoIznosTab;
		private System.Windows.Forms.TextBox txtNetoIznosLEVO;
        private System.Windows.Forms.Button btnUnesiUFormu;
		
		
	}
}
