using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatie_zainea_bogdan
{
    [Serializable]
    public  class Magazin
    {
        public static int counter = 0;
        public int id_magazin { get; set; }
        public string nume_magazin { get; set; }
        public int[] coduri_produse { get; set; }
        public int[] preturi_produse { get; set; }


        public Magazin()
        {
            counter++;
            this.id_magazin = counter;
            this.nume_magazin = "Anonim magazin";
            this.coduri_produse = new int[] { };
            this.preturi_produse= new int[] { };
        }

        public Magazin( string nume_magazin, int[] coduri_produse, int[] preturi_produse)
        {
            counter++;
            this.id_magazin = counter;
            this.nume_magazin = nume_magazin;
            this.coduri_produse = coduri_produse;
            this.preturi_produse=preturi_produse;
        }

        public string Arata_nume_magazin()
        {
            return "\nNume_Magazin: " + this.nume_magazin;
        }
        public string Arata_produse_magazin()
        {
            return "\nProduse: " + string.Join(" : ", this.coduri_produse);
        }
        public string Arata_preturi()
        {
            return "\nPreturi: " + string.Join(" : " , this.preturi_produse);
        }
    }
}
