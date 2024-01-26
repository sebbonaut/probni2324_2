using System;

namespace probni2324_2
{
    public class Linija
    {
        public string polaziste { get; set; }
        public string odrediste { get; set; }
        public decimal cijena { get; set; }
        public DateTime vrijeme { get; set; }
        public int slobodnih_mjesta;
        public Linija(string polaziste, string odrediste, decimal cijena, 
            DateTime vrijeme, int slobodnih_mjesta)
        {
            this.polaziste = polaziste;
            this.odrediste = odrediste;
            this.cijena = cijena;
            this.vrijeme = vrijeme;
            this.slobodnih_mjesta = slobodnih_mjesta;
        }
        public override string ToString()
        {
            string poruka = "Mjesto polaska: " + polaziste
                + "\nMjesto dolaska: " + odrediste
                + "\nCijena: " + cijena + " EUR"
                + "\nVrijeme polaska: " + vrijeme
                + "\nBroj slobodnih mjesta: " + slobodnih_mjesta;
            return poruka;
        }
    }
}
