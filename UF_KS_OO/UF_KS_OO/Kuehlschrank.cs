using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UF_KS_OO
{
    internal class Kuehlschrank
    {
        private List<Lebensmittel> lebensmittelListe=new List<Lebensmittel>();
        public double Temperatur { get; set; }

        public Kuehlschrank(double temp)
        {
            Temperatur = temp;
        }

        public void BefuelleKS(Lebensmittel l)
        {
            lebensmittelListe.Add(l);   
        }

        public string ZeigeInhalt()
        {
            string s = $"Kühltemperatur: {Temperatur} Grad \n\n im Kühlschrank befindet sich: \n\n";
            foreach (Lebensmittel item in lebensmittelListe)
            {
                s += item + "\n";
            }
            return s;
        }
    }
}
