using System;

namespace ProgramZaPlatu
{
	/// <summary>
	/// Description of Racunica.
	/// </summary>
	public class Racunica
	{
		decimal NetoIznos;
		decimal StopaPoreza; 						
		decimal StopaPIOZaposleni;			
		decimal StopaZdravstvoZaposleni;		
		decimal StopaNezaposlenostZaposleni;	
		decimal StopaPIOPoslodavac;		
		decimal StopaZdravstvoPoslodavac;	
		decimal StopaNezaposlenostPoslodavac;
		decimal NajnizaOsnovica;
		decimal NajvisaOsnovica;		
			
		decimal PoreskoOslobodjenje;
		
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
		NetoIznos 						= x;
		StopaPoreza 					= y; 						
		StopaPIOZaposleni				= z;			
		StopaZdravstvoZaposleni			= u;
		StopaNezaposlenostZaposleni		= v;
		StopaPIOPoslodavac				= w;		
		StopaZdravstvoPoslodavac		= a;	
		StopaNezaposlenostPoslodavac	= b; 	
		PoreskoOslobodjenje				= c;
		NajnizaOsnovica 				= m;
		NajvisaOsnovica					= n;
		
		// OVDE SE DODAJU SLUCAJEVI OBRACUNA
		if (x > NajnizaOsnovica && x < NajvisaOsnovica) 
			{ZaNetoNormalno();}
		else if (x <= NajnizaOsnovica)
			{ZaNetoIspodNajnize();}
		else if (x >= NajvisaOsnovica)
			{ZaNetoIznadNajvise();}
		
		}
		public void ZaNetoNormalno()
		//OVO JE NAJOBICNIJI SLUCAJ
		{
			decimal KoeficijentPoreskogOslobodjenja = PoreskoOslobodjenje*StopaPoreza;
			decimal Koeficijent = 1 - (StopaPIOZaposleni + StopaZdravstvoZaposleni + StopaNezaposlenostZaposleni + StopaPoreza);
			
			IznosBrutoIznos = Decimal.Round(((NetoIznos - KoeficijentPoreskogOslobodjenja)/Koeficijent),2);
		
			IznosPoreza 		 =  Decimal.Round(((IznosBrutoIznos - PoreskoOslobodjenje)*StopaPoreza),2);
		
			IznosPIOZaposleni 	 =  Decimal.Round((IznosBrutoIznos * StopaPIOZaposleni),2);
			IznosZdravstvoZaposleni  =  Decimal.Round((IznosBrutoIznos * StopaZdravstvoZaposleni),2);
			IznosNezaposlenostZaposleni  =  Decimal.Round((IznosBrutoIznos * StopaNezaposlenostZaposleni),2);
			
			IznosPIOPoslodavac 	 = Decimal.Round((IznosBrutoIznos * StopaPIOPoslodavac),2);
			IznosZdravstvoPoslodavac = Decimal.Round((IznosBrutoIznos * StopaZdravstvoPoslodavac),2);
			IznosNezaposlenostPoslodavac = Decimal.Round((IznosBrutoIznos * StopaNezaposlenostPoslodavac),2);
		}
		//OVO JE SLUCAJ ISPOD NAJNIZE
		public void ZaNetoIspodNajnize()
			{
			decimal KoeficijentPoreskogOslobodjenja = PoreskoOslobodjenje*StopaPoreza;
			decimal Koeficijent = 1 - (StopaPIOZaposleni + StopaZdravstvoZaposleni + StopaNezaposlenostZaposleni + StopaPoreza);
			
			IznosBrutoIznos = Decimal.Round(((NajnizaOsnovica - KoeficijentPoreskogOslobodjenja)/Koeficijent),2);
			IznosNetoIznos 	= Decimal.Round(NetoIznos);
			IznosPoreza 		 =  Decimal.Round(((IznosBrutoIznos - PoreskoOslobodjenje)*StopaPoreza),2);
		
			IznosPIOZaposleni 	 =  Decimal.Round((IznosBrutoIznos * StopaPIOZaposleni),2);
			IznosZdravstvoZaposleni  =  Decimal.Round((IznosBrutoIznos * StopaZdravstvoZaposleni),2);
			IznosNezaposlenostZaposleni  =  Decimal.Round((IznosBrutoIznos * StopaNezaposlenostZaposleni),2);
			
			IznosPIOPoslodavac 	 = Decimal.Round((IznosBrutoIznos * StopaPIOPoslodavac),2);
			IznosZdravstvoPoslodavac = Decimal.Round((IznosBrutoIznos * StopaZdravstvoPoslodavac),2);
			IznosNezaposlenostPoslodavac = Decimal.Round((IznosBrutoIznos * StopaNezaposlenostPoslodavac),2);
			}
		//OVO JE SLUCAJ IZNAD NAJVISE
		public void ZaNetoIznadNajvise()
			{
			decimal KoeficijentPoreskogOslobodjenja = PoreskoOslobodjenje*StopaPoreza;
			decimal Koeficijent = 1 - (StopaPIOZaposleni + StopaZdravstvoZaposleni + StopaNezaposlenostZaposleni + StopaPoreza);
			
			decimal BrutozaRacunicu = Decimal.Round(((NajvisaOsnovica - KoeficijentPoreskogOslobodjenja)/Koeficijent),2);
			IznosBrutoIznos = Decimal.Round(((BrutozaRacunicu + NetoIznos- NajvisaOsnovica)),2);
			IznosNetoIznos 	= Decimal.Round(NetoIznos);
			//za porez ide IznosBrutoIznos jer on enma granicu nego mora da raste zajendo sa njim
			IznosPoreza 		 =  Decimal.Round(((IznosBrutoIznos - PoreskoOslobodjenje)*StopaPoreza),2);
		
			IznosPIOZaposleni 	 =  Decimal.Round((BrutozaRacunicu * StopaPIOZaposleni),2);
			IznosZdravstvoZaposleni  =  Decimal.Round((BrutozaRacunicu * StopaZdravstvoZaposleni),2);
			IznosNezaposlenostZaposleni  =  Decimal.Round((BrutozaRacunicu * StopaNezaposlenostZaposleni),2);
			
			IznosPIOPoslodavac 	 = Decimal.Round((BrutozaRacunicu * StopaPIOPoslodavac),2);
			IznosZdravstvoPoslodavac = Decimal.Round((BrutozaRacunicu * StopaZdravstvoPoslodavac),2);
			IznosNezaposlenostPoslodavac = Decimal.Round((BrutozaRacunicu * StopaNezaposlenostPoslodavac),2);
			}
	}
}
