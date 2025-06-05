using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_zainea_bogdan
{
    public partial class Lista_Facturi : Form
    {

        Form tabanterior;
        Form mainForm;
        Cont_Client client_logat;
        List<Factura> lista_facturi = new List<Factura>();
        public Lista_Facturi(Form tab_ant, Form mainform, Cont_Client user)
        {
            InitializeComponent();
            tabanterior = tab_ant;
            mainForm = mainform;
            client_logat = user;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.panelStergereFactura.AllowDrop = true;
            this.panelStergereFactura.DragEnter += new DragEventHandler(this.panelStergereFactura_DragEnter);
            this.panelStergereFactura.DragDrop += new DragEventHandler(this.panelStergereFactura_DragDrop);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabanterior.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        //button afisare lista facturi
        private void button3_Click(object sender, EventArgs e)
        {
            string path3 = "";//path local json for invoices
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

            listBox1.Items.Clear();
            foreach (Factura fact in lista_facturi)
                if (fact.nr_telefon == client_logat.Nr_telefon)
                {
                    listBox1.Items.Add(fact);
                }
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Nu ai nicio Factura pana acum. \n Hai sa facem prima comanda!");
            }
        }


        //afisare date client
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Factura facturaSelectata)
            {
                label8.Text = facturaSelectata.id_factura.ToString();
                label9.Text = facturaSelectata.nume_client;
                label11.Text = facturaSelectata.prenume_client;
                label12.Text = facturaSelectata.nr_telefon;
                label13.Text = facturaSelectata.Magazin;
                label14.Text = string.Join(", ", facturaSelectata.Produse);
                label15.Text = facturaSelectata.Total_factura.ToString();
            }
            else
            {
                MessageBox.Show("Selecteaza o comandă din lista");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mesaj = "\n Instructiuni vizualizare facturi\n" +
                "\n 1) Apasati pe butonul: 'Afiseaza Toate Facturi' ( Shorcut alt+a)." +
                "\n 2) Apoi selecteaza cu un singur click una dintre facturile pe care doresti sa le vizualizezi" +
                "\n 3) Apasa pe butonul  'Detalii factura selectata' ( shortcut alt+d) pentru a vedea in partea dreapta detaliile importante ale facturii" +
                 "\n extra) Daca vreti sa stergeti o factura atunci dati drag din listbox la lista dorita si da ti drop in chenarul denumit cos de gunoi si va fi stearsa si din listbox si din json cu facturi'" +
                "\n 4) Daca vreti sa va delogati apaosati pe 'Logout'" +
                "\n 5) Daca vreti SA INCHIDETI APLICATIA APASATI PE BUTONUL 'Close app' nu pe x pleaseeeeeeeeeeeee\n";




            MessageBox.Show(mesaj, "Help Center");
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1.SelectedItem, DragDropEffects.Move);
            }
        }

        private void panelStergereFactura_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Factura)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelStergereFactura_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Factura)))
            {
                Factura facturaDeSters = (Factura)e.Data.GetData(typeof(Factura));

                // Confirmare
                DialogResult confirm = MessageBox.Show(
                    $"Sigur dorești să ștergi factura #{facturaDeSters.id_factura}?",
                    "Confirmare ștergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // sterg din lista de facturi
                    lista_facturi.Remove(facturaDeSters);

                    // update json
                    string path3 = "D:\\micrsoft community\\proiecte\\prjt c# - comenzi\\aplicatie_zainea_bogdan\\lista_facturi.json";
                    string jsonNou = JsonSerializer.Serialize(lista_facturi, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(path3, jsonNou);

                    // sterg din ListBox
                    listBox1.Items.Remove(facturaDeSters);

                    // curat si etichetele 
                    label8.Text = label9.Text = label11.Text = label12.Text = label13.Text = label14.Text = label15.Text = "(Nicio factura selectata)";

                    MessageBox.Show("Factura a fost ștearsă cu succes!");
                }
            }
        }





    }
}
