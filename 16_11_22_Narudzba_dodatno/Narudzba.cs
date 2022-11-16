using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_11_22_Narudzba_dodatno
{
    internal class Narudzba : IComparable
    {
        public double CIJENA = 19.95;
        public int BrojNarudzbe { get; set; }

        public string ImeKupca { get; set; }

        public int kolicina;

        public virtual int Kolicina
        {
            get { return kolicina; }
            set
            {
                kolicina = value;
                ukupnaCijena = kolicina * CIJENA;
            }
        }
        public double ukupnaCijena;

        public double UkupnaCijena
        {
            get { return ukupnaCijena; }
            set { }
        }
    //KONSTRUKTOR KLASE
        public Narudzba(int BrNarudzbe, string ImeKupca, int kol)
        {
            this.BrojNarudzbe = BrNarudzbe;
            this.ImeKupca = ImeKupca;
            this.Kolicina = kol;
        }
    //EQUALS OVERRIDE
        public override bool Equals(object obj)
        {
            Narudzba nar = (Narudzba)obj;
            if (this.BrojNarudzbe == nar.BrojNarudzbe)
                return true;
            else
                return false;
        }
    //GETHASHCODE OVERRIDE
        public override int GetHashCode()
        {
            return BrojNarudzbe;
        }
    //METODA ZA ISPIS
        public override string ToString()
        {
            return GetType().Name + "BrNar: " + GetHashCode() + " Kupac: " + ImeKupca + " - Količina: " + Kolicina + " - Ukupno: " + UkupnaCijena.ToString("C");
        }
    //SORITARANJE S OBZIROM NA BRNARUDZBE
        int IComparable.CompareTo(object obj)
        {
            Narudzba temp = (Narudzba)obj;
            if (this.BrojNarudzbe > temp.BrojNarudzbe)
                return 1;
            else if (this.BrojNarudzbe < temp.BrojNarudzbe)
                return -1;
            else 
                return 0;
        }

    }
    //IZVEDENA KLASA POSLANANARUDZBA
   class PoslanaNarudzba : Narudzba
    {
       public PoslanaNarudzba(int BrNarudzbe, string ImeKupca, int kol) : base(BrNarudzbe, ImeKupca, kol)
        {
           
        }

        const double POSTARINA = 40;

        public override int Kolicina
        {
            get { return kolicina; }
            set
            {
                kolicina = value;
                ukupnaCijena = kolicina * CIJENA + POSTARINA;
            }
        }

        public override string ToString()
        {
            return GetType().Name + "BrNar: " + GetHashCode() + " - Kupac: " + ImeKupca + " - Količina: " + Kolicina + " - Poštarina: " + POSTARINA.ToString("C") + " - Ukupno: " + UkupnaCijena.ToString("C");
        }


    } 
}
