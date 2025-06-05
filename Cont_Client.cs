using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatie_zainea_bogdan
{
    [Serializable]
    public class Cont_Client
    {
            public string username { get; set; }
            public string Nume { get; set; }
            public string Prenume { get; set; }
            public int Id { get; set; }
            public string Nr_telefon { get; set; }
            private static int Counter = 0;
            public string parola { get; set; }

            public Cont_Client()
            {
                Counter += 1;
                this.username = "User";
                this.Nume = "Anonim";
                this.Prenume = "Anonim2";
                this.Nr_telefon = "0123456789";
                this.Id = Counter;
                this.parola = "useranonim";
            }
            public Cont_Client(string Nume, string Prenume, string Nr_telefon, string parola, string username)
            {
                Counter += 1;
                this.username = username;
                this.Nume = Nume;
                this.Prenume = Prenume;
                this.Nr_telefon = Nr_telefon;
                this.Id = Counter;
                this.parola = parola;
            }


            public override string ToString()
            {
                return ("\n Id: " + this.Id + 
                        "\n Nume: " + this.Nume +
                        "\n Prenume: " + this.Prenume +
                        "\n telefon: " + this.Nr_telefon)+
                        "\n Password: " + this.parola;
            }
        }
    
}
