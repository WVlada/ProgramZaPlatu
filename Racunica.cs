using System;

namespace ProgramZaPlatu
{
	/// <summary>
	/// Description of Racunica.
	/// </summary>
	public class Racunica
	{
		decimal OvdeNetoIznos;
		decimal OvdeStopaPoreza;
        decimal OvdeStopaPIOZaposleni;
        decimal OvdeStopaZdravstvoZaposleni;
        decimal OvdeStopaNezaposlenostZaposleni;
        decimal OvdeStopaPIOPoslodavac;
        decimal OvdeStopaZdravstvoPoslodavac;
        decimal OvdeStopaNezaposlenostPoslodavac;
        decimal OvdeNajnizaOsnovica;
        decimal OvdeNajvisaOsnovica;

        decimal OvdePoreskoOslobodjenje;
		
		// ovi iznosi se vracaju MAIN formi
		public decimal IznosNetoIznos;
		public decimal IznosPoreza; 						
		public decimal IznosPIOZaposleni;			
		public decimal IznosZdravstvoZaposleni;		
		public decimal IznosNezaposlenostZaposleni;	
		public decimal IznosPIOPoslodavac;		
		public decimal IznosZdravstvoPoslodavac;	
		public decimal IznosNezaposlenostPoslodavac;
		public decimal IznosBrutoIznos;		
						
		public Racunica(decimal x, decimal y, decimal z, decimal u, decimal v, decimal w, decimal a, decimal b, decimal c,decimal m,decimal n)
		{
            OvdeNetoIznos                       = x;
            OvdeStopaPoreza                     = y / 100;
            OvdeStopaPIOZaposleni               = z / 100;
            OvdeStopaZdravstvoZaposleni         = u / 100;
            OvdeStopaNezaposlenostZaposleni     = v / 100;
            OvdeStopaPIOPoslodavac              = w / 100;
            OvdeStopaZdravstvoPoslodavac        = a / 100;
            OvdeStopaNezaposlenostPoslodavac    = b / 100;
            OvdePoreskoOslobodjenje             = c;
            OvdeNajnizaOsnovica                 = m;
            OvdeNajvisaOsnovica                 = n;
		
		// OVDE SE DODAJU SLUCAJEVI OBRACUNA
            if (x > OvdeNajnizaOsnovica && x < OvdeNajvisaOsnovica) 
			{ZaNetoNormalno();}
            else if (x <= OvdeNajnizaOsnovica)
			{ZaNetoIspodNajnize();}
            else if (x >= OvdeNajvisaOsnovica)
			{ZaNetoIznadNajvise();}
		
		}
		public void ZaNetoNormalno()
		//OVO JE NAJOBICNIJI SLUCAJ
		{
            decimal KoeficijentPoreskogOslobodjenja = OvdePoreskoOslobodjenje * OvdeStopaPoreza;// ovo je 1.100 (11.000*10%)
            decimal Koeficijent = 1 - (OvdeStopaPIOZaposleni + OvdeStopaZdravstvoZaposleni + OvdeStopaNezaposlenostZaposleni + OvdeStopaPoreza);// ovo je 0.701 (1 - (10 + 13 + 6.15 + 0.75))

            IznosBrutoIznos = Decimal.Round(((OvdeNetoIznos - KoeficijentPoreskogOslobodjenja) / Koeficijent), 2);

            IznosPoreza = Decimal.Round(((IznosBrutoIznos - OvdePoreskoOslobodjenje) * OvdeStopaPoreza), 2);

            IznosPIOZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOZaposleni), 2);
            IznosZdravstvoZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoZaposleni), 2);
            IznosNezaposlenostZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostZaposleni), 2);

            IznosPIOPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOPoslodavac), 2);
            IznosZdravstvoPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoPoslodavac), 2);
            IznosNezaposlenostPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostPoslodavac), 2);
		}
		//OVO JE SLUCAJ ISPOD NAJNIZE
		public void ZaNetoIspodNajnize()
			{
                decimal KoeficijentPoreskogOslobodjenja = OvdePoreskoOslobodjenje * OvdeStopaPoreza;
                decimal Koeficijent = 1 - OvdeStopaPoreza;

                decimal SD = OvdeNajnizaOsnovica * (OvdeStopaNezaposlenostPoslodavac + OvdeStopaNezaposlenostZaposleni + OvdeStopaPIOPoslodavac + OvdeStopaPIOZaposleni + OvdeStopaZdravstvoPoslodavac + OvdeStopaZdravstvoZaposleni);
			
			IznosBrutoIznos = Decimal.Round(((OvdeNajnizaOsnovica - KoeficijentPoreskogOslobodjenja + SD)/Koeficijent),2);
			IznosNetoIznos 	= Decimal.Round(OvdeNetoIznos);
            IznosPoreza = Decimal.Round(((OvdeNetoIznos - OvdePoreskoOslobodjenje) * OvdeStopaPoreza), 2);

            IznosPIOZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOZaposleni), 2);
            IznosZdravstvoZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoZaposleni), 2);
            IznosNezaposlenostZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostZaposleni), 2);

            IznosPIOPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOPoslodavac), 2);
            IznosZdravstvoPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoPoslodavac), 2);
            IznosNezaposlenostPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostPoslodavac), 2);
			}
		//OVO JE SLUCAJ IZNAD NAJVISE
		public void ZaNetoIznadNajvise()
			{
                decimal KoeficijentPoreskogOslobodjenja = OvdePoreskoOslobodjenje * OvdeStopaPoreza;
                decimal Koeficijent = 1 - OvdeStopaPoreza;

                decimal SD = OvdeNajvisaOsnovica * (OvdeStopaNezaposlenostPoslodavac + OvdeStopaNezaposlenostZaposleni + OvdeStopaPIOPoslodavac + OvdeStopaPIOZaposleni + OvdeStopaZdravstvoPoslodavac + OvdeStopaZdravstvoZaposleni);

                IznosBrutoIznos = Decimal.Round(((OvdeNajvisaOsnovica - KoeficijentPoreskogOslobodjenja + SD) / Koeficijent), 2);
                IznosNetoIznos = Decimal.Round(OvdeNetoIznos);
                IznosPoreza = Decimal.Round(((OvdeNetoIznos - OvdePoreskoOslobodjenje) * OvdeStopaPoreza), 2);

                IznosPIOZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOZaposleni), 2);
                IznosZdravstvoZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoZaposleni), 2);
                IznosNezaposlenostZaposleni = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostZaposleni), 2);

                IznosPIOPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaPIOPoslodavac), 2);
                IznosZdravstvoPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaZdravstvoPoslodavac), 2);
                IznosNezaposlenostPoslodavac = Decimal.Round((IznosBrutoIznos * OvdeStopaNezaposlenostPoslodavac), 2);
            }
	}
}
