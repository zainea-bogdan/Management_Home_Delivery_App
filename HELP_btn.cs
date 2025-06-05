using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_zainea_bogdan
{
    public partial class HELP_btn : UserControl
    {
        public HELP_btn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mesaj =
               "Bine ai venit la ZGB Delivery\n\n" +

               "=== 1) Sign In ===                       === 2) Log In ===\n" +
               " - Nume/Prenume cu literă mare          - Dacă ai cont, introdu datele\n" +
               " - Username: minim 10 caractere         - Username + Parola → acces cont\n" +
               " - Nr. telefon: exact 10 cifre\n" +
               " - Parola trebuie să conțină:\n" +
               "     • 1 literă mare                    - Felicitări, ai acces în aplicație!\n" +
               "     • 4 cifre\n" +
               "     • minim 10 caractere\n" +
               " - Apasă pe 'Sign In' pentru creare cont\n\n" +

               "=== Admin: Utilizatori ===              === Admin: Magazine Partenere ===\n" +
               " - 'Afiseaza Users din DB'              - Completare: Nume magazin\n" +
               "   → PostgreSQL                         - Lista Produse separate prin spațiu\n" +
               " - 'Afiseaza Users din JSON'            - Prețuri: în aceeași ordine, cu spațiu\n" +
               "   → date locale                        - Apasă butonul maro 'Adaugare'\n" +
               " - Delogare: butonul 'Logout'           - Închidere: Delogare si dupa aceea X-ul din meniul de logare\n\n" +

               "=== Comandă: Date Client ===            === Comandă: Produse & Plată ===\n" +
               " - Nume/Prenume/Nr → preluate automat   - Magazin: selectat din listă\n" +
               " - Completează toate câmpurile          - Produse: din listă cu coduri\n" +
               " - Adresa trebuie să conțină:           - Metodă plată: card / numerar / voucher\n" +
               "     • bd/str + denumire\n" +
               "     • bl/cs + nr sau literă\n\n" + 

               "=== Comandă: Vizualizare ===            === Comandă: Detalii ===\n" +
               " - 'Toate comenzile' (Alt+T)            - Selectează comanda din listă\n" +
               " - 'Printează date firmă' → preview     - 'Vezi detalii comandă' (Alt+V)\n" +
               " - Închidere aplicație: 'Close app'\n\n" +

               "=== Facturi: Vizualizare ===            === Facturi: Ștergere ===\n" +
               " - 'Afiseaza Toate Facturi' (Alt+A)     - Selectează o factură cu un click\n" +
               " - 'Detalii factura selectata' (Alt+D)  - Drag & drop în 'coș de gunoi'\n" +
               " - Vezi detaliile în partea dreaptă     - Ștergere din JSON și listă\n" +
               " - Logout / Close app pentru ieșire\n";

            MessageBox.Show(mesaj, "Help Center");


        }
    }
}
