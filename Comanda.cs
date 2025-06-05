using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace aplicatie_zainea_bogdan
{
    [Serializable]
    public class Comanda
    {
        public int id { get; set; }
        public string nume_client { get; set; }
        public string prenume_client { get; set; }
        public string nr_telefon { get; set; }
        public static int counter=0;
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Adresa_Livrare { get; set; }
        public string Magazin { get; set; }
        public int[] Produse { get; set; }
        public string modalitate_plata { get; set; }


        public Comanda()
        {
            counter++;
            this.nume_client="anonim";
            this.prenume_client = "anonim";
            this.nr_telefon="0744444444";
            this.Localitate = "Jupitera";
            this.Judet = "Saturneala";
            this.Magazin = "MagazinDeLaColt";
            this.Produse = new int[] { };
            this.modalitate_plata = "Dineros";
            this.id = counter;
        }

        public Comanda(Cont_Client client, string localitate, string judet, string adresa_Livrare, string magazin, int[] produse,string modalitate)
        {
            counter++;
            this.nume_client = client.Nume;
            this.prenume_client = client.Prenume;
            this.nr_telefon = client.Nr_telefon;
            this.Localitate = localitate;
            this.Judet = judet;
            this.Adresa_Livrare = adresa_Livrare;
            this.Magazin = magazin;
            this.Produse = produse;
            this.modalitate_plata = modalitate;
            this.id = counter;
        }

        public override string ToString()
        {
            return "Id comanda: "+this.id+"\nNr telefon: "+ nr_telefon
                + " \nLocalitate: " + this.Localitate+ "\n Judet: " + this.Judet+ " \nAdresa: " + this.Adresa_Livrare
                + " \nMagazin: " + this.Magazin+ "\n Produse: " + string.Join(":",this.Produse)+ "\n Modalitate_plata: " + this.modalitate_plata;
        }

    }
}
