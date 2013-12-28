
using System;

namespace ProgramZaPlatu
{
	public class SviPodaci
	{
		public SviPodaci(string piozap, string pioposl, string zdravzap,string zdravposl,string nezapzap, string nezapposl)
		{
			PIOZaposleniIznos = piozap;
			PIOPoslodavacIznos = pioposl;
			ZdravstvoZaposleniIznos = zdravzap;
			ZdravstvoPoslodavacIznos = zdravposl;
			NezaposlenostZaposleniIznos = nezapzap;
			NezaposlenostPoslodavacIznos = nezapposl;
		}
	
	string PIOZaposleniIznos;
	string PIOPoslodavacIznos;
	string ZdravstvoZaposleniIznos;
	string ZdravstvoPoslodavacIznos;
	string NezaposlenostZaposleniIznos;
	string NezaposlenostPoslodavacIznos;
	}
}
