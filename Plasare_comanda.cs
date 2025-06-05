using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace aplicatie_zainea_bogdan
{
    public partial class Plasare_comanda : Form
    {
        Form mainForm;
        Form FormContClient;
        Cont_Client client_logat;
        List<Magazin> lista_magazine = new List<Magazin>();
        List<Comanda> comenzi_plasate = new List<Comanda>();
        List<Comanda> comenzi_plasate_istoric = new List<Comanda>();
        List<Factura> lista_facturi = new List<Factura>();


        public Plasare_comanda(Form formanterior, Form callingForm, Cont_Client user_logat)
        {
            InitializeComponent();

            mainForm = callingForm;
            client_logat = user_logat;
            FormContClient = formanterior;

            textBox1.Text = user_logat.Nume;
            textBox2.Text = user_logat.Prenume;
            textBox3.Text = user_logat.Nr_telefon;

            string path1 = "";//json for invoices

            if (File.Exists(path1))
            {
                string existingJson = File.ReadAllText(path1);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    lista_magazine = JsonSerializer.Deserialize<List<Magazin>>(existingJson);
                }
            }

            //codul de mai jos cu magazin nou este pentru a crea jsonul pentru magazine partenere.

            //Magazin magazin_nou = new Magazin("Altex", [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [10,20,30,40,50,60,70,80,90,100]);
            //Magazin magazin_nou2 = new Magazin("Flanco", [1, 2, 3, 4, 5, 6, 7, 8, 9, 10], [10, 20, 30, 40, 50, 60, 70, 80, 90, 100]);
            //Magazin magazin_nou3 = new Magazin("Lidl", [11, 22, 33, 44, 55, 66, 77, 88, 99, 100], [5,6,7,8,9,10,11,12,15,17]);

            //lista_magazine.Add(magazin_nou);
            //lista_magazine.Add(magazin_nou2);
            //lista_magazine.Add(magazin_nou3);


            //var options = new JsonSerializerOptions { WriteIndented = true };
            //string newJson = JsonSerializer.Serialize(lista_magazine, options);


            //File.WriteAllText(path, newJson);
        }



        int validarecampuri(string Adresa, string Localitate, string Judet, string Produse, string Magazin)
        {

            if (Adresa == "")
            {
                errorAdresa.SetError(textBox4, "Introduceti o adresa");
                textBox4.Clear();
                return -1;
            }
            else
            {
                if (!(Adresa.Trim().ToLower().Contains("bulevard") || Adresa.Trim().ToLower().Contains("bd") || Adresa.Trim().ToLower().Contains("strada") || Adresa.Trim().ToLower().Contains("str")))
                {
                    errorAdresa.SetError(textBox4, "Introduceti un Bulevard/Strada ");
                    textBox4.ForeColor = Color.Red;
                    return -1;
                }
                else
                {
                    if (!(Adresa.Trim().ToLower().Contains("bloc") || Adresa.Trim().ToLower().Contains("bl") || Adresa.Trim().ToLower().Contains("casa") || Adresa.Trim().ToLower().Contains("cs")))
                    {
                        errorAdresa.SetError(textBox4, "Introduceti un Bloc/Casa");
                        textBox4.ForeColor = Color.Red;
                        return -1;
                    }
                    else
                    {
                        textBox4.ForeColor = SystemColors.WindowText;
                    }
                }
            }


            if (Localitate == "")
            {
                errorLocalitate.SetError(textBox5, "Introduceti o Localitate");
                textBox5.Clear();
                return -1;
            }
            if (Judet == "")
            {
                errorJudet.SetError(textBox6, "Introduceti o Localitate");
                textBox6.Clear();
                return -1;
            }

            if (Magazin == "")
            {
                errorMagazin.SetError(textBox7, "Introduceti  un magazin ");
                textBox7.Clear();
                return -1;
            }

            if (Produse == "")
            {
                errorCoduriProduse.SetError(textBox9, "Introduceti produse");
                textBox9.Clear();
                return -1;
            }

            return 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            errorCoduriProduse.Clear();
            errorAdresa.Clear();
            errorLocalitate.Clear();
            errorJudet.Clear();
            errorMagazin.Clear();

            string path2 = "";//path for local json for comenzi
            if (File.Exists(path2))
            {
                string existingJson = File.ReadAllText(path2);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    comenzi_plasate = JsonSerializer.Deserialize<List<Comanda>>(existingJson);

                    if (comenzi_plasate.Any())
                    {
                        Comanda.counter = comenzi_plasate.Max(c => c.id);
                    }

                }
            }



            int validat;
            int magazin_gasit = 0;
            validat = validarecampuri(textBox4.Text, textBox5.Text, textBox6.Text, textBox9.Text, textBox7.Text);
            if (validat == 1)
            {
                int[] coduri_produse = textBox9.Text.Split(' ').Select(int.Parse).ToArray();
                foreach (Magazin partener in lista_magazine)
                {
                    if (char.ToUpper(textBox7.Text[0]) + textBox7.Text.Substring(1).ToLower() == partener.nume_magazin && coduri_produse.All(x => partener.coduri_produse.Contains(x)))
                    {
                        magazin_gasit = 1;
                        break;
                    }
                }

                if (magazin_gasit == 1)
                {
                    string adresa = textBox4.Text;
                    string localitate = char.ToUpper(textBox5.Text[0]) + textBox5.Text.Substring(1).ToLower();
                    string judet = char.ToUpper(textBox6.Text[0]) + textBox6.Text.Substring(1).ToLower();

                    string magazin = char.ToUpper(textBox7.Text[0]) + textBox7.Text.Substring(1).ToLower();
                    string modalitate_plata = "";
                    if (radioButton1.Checked)
                    {
                        modalitate_plata = "Card Bancar";
                    }
                    if (radioButton2.Checked)
                    {
                        modalitate_plata = "Numerar";
                    }
                    if (radioButton3.Checked)
                    {
                        modalitate_plata = "Vouchere cadou";
                    }





                    Comanda newcom = new Comanda(client_logat, localitate, judet, adresa, magazin, coduri_produse, modalitate_plata);


                    //facem factura pentru comanda
                    string path3 = "";////path to local invoices
                    if (File.Exists(path3))
                    {
                        string existingJson1 = File.ReadAllText(path3);
                        if (!string.IsNullOrWhiteSpace(existingJson1))
                        {
                            lista_facturi = JsonSerializer.Deserialize<List<Factura>>(existingJson1);

                            if (lista_facturi.Any())
                            {
                                Factura.Counter = lista_facturi.Max(c => c.id_factura);
                            }

                        }
                    }






                    Factura newfact = new Factura(newcom, lista_magazine);

                    lista_facturi.Add(newfact);

                    var options2 = new JsonSerializerOptions { WriteIndented = true };
                    string newJson1 = JsonSerializer.Serialize(lista_facturi, options2);
                    File.WriteAllText(path3, newJson1);


                    //aici se incheie creearea de noi facturi;





                    comenzi_plasate.Add(newcom);


                    var options = new JsonSerializerOptions { WriteIndented = true };
                    string newJson = JsonSerializer.Serialize(comenzi_plasate, options);
                    File.WriteAllText(path2, newJson);




                    //clear-up
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    textBox7.Clear();
                    textBox9.Clear();
                }
                else
                {
                    errorMagazin.SetError(textBox7, "Magazinul sau produse nu sunt corecte");
                    textBox7.Clear();
                    textBox9.Clear();
                }



            }



        }



        private void button4_Click(object sender, EventArgs e)
        {
            string magazine = "";
            if (magazine == "")
            {
                foreach (Magazin test in lista_magazine)
                {
                    magazine = magazine + test.Arata_nume_magazin() + "\n";
                }
                MessageBox.Show(magazine, "Magazine partere");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Magazin item in lista_magazine)
            {
                if (char.ToUpper(textBox7.Text[0]) + textBox7.Text.Substring(1).ToLower() == item.nume_magazin)
                {
                    MessageBox.Show(item.Arata_produse_magazin() + "\n" + item.Arata_preturi());
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path2 = "";//path to comenzi hostory

            if (File.Exists(path2))
            {
                string existingJson = File.ReadAllText(path2);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    comenzi_plasate_istoric = JsonSerializer.Deserialize<List<Comanda>>(existingJson);
                }
            }

            listBox1.Items.Clear();
            foreach (Comanda comanda in comenzi_plasate_istoric)
                if (comanda.nr_telefon == client_logat.Nr_telefon)
                {
                    listBox1.Items.Add(comanda);
                }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nu ai nicio comanda pana acum. \n Hai sa facem prima comanda!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Comanda comandaSelectata)
            {

                MessageBox.Show(comandaSelectata.ToString(), "Detalii Comanda");
            }
            else
            {
                MessageBox.Show("Selecteaza o comandă din lista");
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            FormContClient.Close();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormContClient.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void magazinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var comenziFiltrate = comenzi_plasate_istoric
                .Where(c => c.nr_telefon == client_logat.Nr_telefon)
                .OrderBy(c => c.Magazin.ToUpper())
                .ToList();

            foreach (var comanda in comenziFiltrate)
            {
                listBox1.Items.Add(comanda);
            }

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Mai întâi fă o comandă, după aceea dai sortare. Uff, grea e viața!");
            }
        }


        private void PrinteazaComanda(Graphics g, Comanda c)
        {
            Font titlu = new Font("Arial", 16, FontStyle.Bold);
            Font text = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            int y = 60;
            int x = 60;
            int spacing = 30;

            g.DrawString("Fișă Comandă", titlu, brush, x, y);
            y += spacing + 10;

            g.DrawString($"ID Comandă: {c.id}", text, brush, x, y); y += spacing;
            g.DrawString($"Nume: {c.nume_client}", text, brush, x, y); y += spacing;
            g.DrawString($"Prenume: {c.prenume_client}", text, brush, x, y); y += spacing;
            g.DrawString($"Telefon: {c.nr_telefon}", text, brush, x, y); y += spacing;
            g.DrawString($"Localitate: {c.Localitate}", text, brush, x, y); y += spacing;
            g.DrawString($"Județ: {c.Judet}", text, brush, x, y); y += spacing;
            g.DrawString($"Adresă livrare: {c.Adresa_Livrare}", text, brush, x, y); y += spacing;
            g.DrawString($"Magazin: {c.Magazin}", text, brush, x, y); y += spacing;

            string produse = c.Produse != null && c.Produse.Length > 0
                ? string.Join(", ", c.Produse)
                : "Nicio valoare";
            g.DrawString($"Produse: {produse}", text, brush, x, y); y += spacing;

            g.DrawString($"Modalitate plată: {c.modalitate_plata}", text, brush, x, y);
        }





        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Comanda comandaSelectata)
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += (s, ev) => PrinteazaComanda(ev.Graphics, comandaSelectata);

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = doc;
                preview.Width = 800;
                preview.Height = 600;
                preview.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selectează o comandă din listă.");

            }

        }




        private void button9_Click(object sender, EventArgs e)
        {
            string mesaj = "\n Instructiuni plasare comanda\n" +
                "\n 1) Sectiunea pentru introducere date:\n" +
                "\n  - Numele, Prenume si Nr de telefon sunt preluate automat din datele contului" +
                "\n  - Trebuie completate toate campurile" +
                "\n  - Adresa trebuie sa aiba minim : " +
                "\n    -- 1 bulevard ( scris folosind fie 'bulevard' sau 'bd') / 1 strada (scris folosind 'str' sau 'strada') + denumirea ei" +
                "\n    -- 1 bloc ( scris folosind fie 'bloc' sau 'bl') / 1 casa( scris folosind 'casa' sau 'cs' ) + numarul si/sau litera" +
                "\n  - Magazinul trebuie sa fie din lista magazinelor partenere vizibile daca apasati butonul de 'Magazine partenere' " +
                "\n  - Produsele trebuie sa fie preluate din lista de produse vizibila daca apasati butonul de 'Lista produse' si pe prima linie apar codurile(ne imaginam ca sunt denumiri :) )  produselor" +
                "\n  - Apoi alegeti o metoda de plata: card, numerar sau folosind vouchere cadou" +
                "\n 2) Apasati pe butonul 'Toate comenzile' ( Shortcut: alt+t) pentru a vedea toate comenzile\n" +
                "\n 2.1) Daca apesi pe printeaza datele firmei va deschide un popup de preview unde veti vedea cum va arata datele coenzi imprimate\n"
                +
                "\n 3) Selectati o comanda din lista afisata in chenar si apoi apasati pe butonul 'Vezi detalii comanda selectata'(Shortcut alt+v) pentru a vedea detaliile comenzi dorite\n" +
                "\n 4) Daca vreti sa va delogati apaosati pe 'Logout'\n" +
                "\n 5) Daca vreti SA INCHIDETI APLICATIA APASATI PE BUTONUL 'Close app' nu pe x pleaseeeeeeeeeeeee\n";




            MessageBox.Show(mesaj, "Help Center");
        }

}
}
