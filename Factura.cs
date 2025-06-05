using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatie_zainea_bogdan
{
    [Serializable]
    public class Factura
    {
        public static int Counter=0;
        public int id_factura { get; set; }
        public int id_comanda { get; set; }
        public string nume_client { get; set; }
        public string prenume_client { get; set; }
        public string nr_telefon { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
        public string Adresa_Livrare { get; set; }
        public string Magazin { get; set; }
        public int[] Produse { get; set; }
        public int[] Preturi;
        public int[] produse_magazin;
        public string modalitate_plata { get; set; }
        public int Total_factura { get; set; }


        public Factura() { }



        public Factura (Comanda newcom,List<Magazin> lista_magazine)
        {
            Counter++;
            this.id_factura = Counter;
            this.id_comanda = newcom.id;
            this.nume_client = newcom.nume_client;
            this.prenume_client=newcom.prenume_client;
            this.nr_telefon = newcom.nr_telefon;
            this.Localitate = newcom.Localitate;
            this.Judet = newcom.Judet;
            this.Adresa_Livrare = newcom.Adresa_Livrare;
            this.Magazin = newcom.Magazin;
            this.Produse = newcom.Produse;
            foreach (Magazin maga in lista_magazine)
            {
                if(maga.nume_magazin==this.Magazin)
                {
                    this.produse_magazin = maga.coduri_produse;
                    this.Preturi = maga.preturi_produse;
                    break;
                }
            }
            this.modalitate_plata= newcom.modalitate_plata;
            this.Total_factura = calcul_total_factura();
        }

        private int calcul_total_factura()
        {
            int total=0;
            List<int> lista_indici = new List<int>();
            int index = 0;
            for (int i = 0; i < this.Produse.Length; i++)
            {
                for (int j = 0; j<this.produse_magazin.Length; j++)
                {
                    if(this.Produse[i]==this.produse_magazin[j])
                    {
                        total += this.Preturi[j];
                    }
                 
                }
            }


            return total;
        }


        public override string ToString()
        {
            return "Id factura: "+this.id_factura + " | Total Factura"+this.Total_factura;
        }


    }
}
