using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteke
{
    internal class Biblioteka : INotifyPropertyChanged
    {
        private string naziv;
        private string adresa;
        private int godina_osnivanja;
        private string logo; // path do logo-a 

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Knjiga> knjige;
        private ObservableCollection<Korisnik> korisnici_knjiga;

        private void NotifyPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public Biblioteka()
        {
            this.Naziv = "";
            this.Adresa = "";
            this.Godina_osnivanja = -1;
            this.Logo = "";
            knjige = new ObservableCollection<Knjiga>();
            korisnici_knjiga = new ObservableCollection<Korisnik>();

        }

        public Biblioteka(string naziv, string adresa, int godina_osnivanja, string logo)
        {
            this.Naziv = naziv;
            this.Adresa = adresa;
            this.Godina_osnivanja = godina_osnivanja;
            this.Logo = logo;
            knjige = new ObservableCollection<Knjiga>();
            korisnici_knjiga = new ObservableCollection<Korisnik>();

        }




        // ********Propertiji*******//
        public string Naziv
        {
            get {return naziv;}
            
            set{
                if (value != naziv) naziv= value;
                this.NotifyPropertyChanged("Naziv");
            }
        }  

        public string Adresa
        {
            get { return adresa; }

            set
            {
                if (value != adresa) adresa = value;
                this.NotifyPropertyChanged("Adresa");
            }
        }

        public int Godina_osnivanja
        {
            get { return godina_osnivanja; }

            set
            {
                if (value != godina_osnivanja) godina_osnivanja = value;
                this.NotifyPropertyChanged("Godina_osnivanja");
            }
        }

        public string Logo
        {
            get { return logo; }

            set
            {
                if (value != logo) logo = value;
                this.NotifyPropertyChanged("Logo");
            }
        }

        internal ObservableCollection<Knjiga> Knjige { get => knjige; set => knjige = value; }
        internal ObservableCollection<Korisnik> Korisnici_knjiga { get => korisnici_knjiga; set => korisnici_knjiga = value; }


        // ********Propertiji*******//


        public override string ToString()      //sto je ovdje ??
        {
            string b = "";

            b += Naziv + "," +Adresa+ "," + Godina_osnivanja.ToString() + "," + Logo + "\n";

            b += String.Join("|", knjige);

            b += "\n";

            b += String.Join("|", korisnici_knjiga);

            b += "\n";

            return b;
        }
        







    }
}
