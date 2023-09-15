using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Biblioteke
{
    internal class Korisnik : INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private string jmbg;
        private string datum_uclanjena;
        private string slika_korisnika; // path do slike 

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public Korisnik(){
            this.ime = "";
            this.prezime = "";
            this.jmbg = "";
            this.datum_uclanjena = "";
            this.slika_korisnika = "";
        }

        public Korisnik(string ime, string prezime, string jmbg, string datum_uclanjena, string slika_korisnika)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.jmbg = jmbg;
            this.datum_uclanjena = datum_uclanjena;
            this.slika_korisnika = slika_korisnika;
        }

        // ********Propertiji*******//
    
        public string Ime
        {
            get { return this.ime; }
            set
            {
                if (this.ime != value)
                {
                    this.ime = value;
                    this.NotifyPropertyChanged("Ime");
                }
            }
        }

        public string Prezime
        {
            get { return this.prezime; }
            set
            {
                if (this.prezime != value)
                {
                    this.prezime = value;
                    this.NotifyPropertyChanged("Prezime");
                }
            }
        }
        public string Jmbg
        {
            get { return jmbg; }

            set
            {
                if (value != jmbg) jmbg = value;
                this.NotifyPropertyChanged("jmbg");
            }
        }

        public string Datum_uclanjenja
        {
            get { return datum_uclanjena; }

            set
            {
                if (value != datum_uclanjena) datum_uclanjena = value;
                this.NotifyPropertyChanged("Datum_uclanjenja");
            }
        }

        public string Slika_korisnika
        {
            get { return slika_korisnika; }

            set
            {
                if (value != slika_korisnika) slika_korisnika = value;
                this.NotifyPropertyChanged("Slika_korisnika");
            }
        }

        

        public override string? ToString()
        {
            string korisnik="";

            korisnik += Ime + "," + Prezime + "," + Jmbg + "," + Datum_uclanjenja + "," + Slika_korisnika;


            return korisnik;
        }
        /*
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Korisnik k = (Korisnik)obj;

            if (k.Jmbg.Equals(jmbg))
            {
                return true;
            }
            return false;
        }
        */



    }
}
