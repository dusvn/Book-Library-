using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Biblioteke
{
    internal class Knjiga : INotifyPropertyChanged
    {
        private string naziv_kn;
        private string autor;
        private int godina_izdanja;

        public event PropertyChangedEventHandler PropertyChanged;



        private void NotifyPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
        public Knjiga()
        {
            this.naziv_kn = "";
            this.autor = "";
            this.Godina_izdanja = -1;
        }

        public Knjiga(string n,string a,int gi)
        {
            this.naziv_kn = n;
            this.autor = a;
            this.Godina_izdanja = gi;
        }

        // ********Propertiji*******//
        public string Naziv_kn
        {
            get { return naziv_kn; }

            set
            {
                if (value != naziv_kn) naziv_kn = value;
                this.NotifyPropertyChanged("Naziv_kn");
            }
        }

        public string Autor
        {
            get { return autor; }

            set
            {
                if (value != autor) autor = value;
                this.NotifyPropertyChanged("Autor");
            }
        }

        public int Godina_izdanja
        {
            get { return godina_izdanja; }

            set
            {
                if (value != godina_izdanja) godina_izdanja = value;
                this.NotifyPropertyChanged("Godina_izdanja");
            }
        }

        public override string? ToString()      //?
        {
            string kn="";

            kn += Naziv_kn + "," + Autor + "," + Godina_izdanja.ToString(); 

            return kn;
        }

     






        // ********Propertiji*******//



    }
}
