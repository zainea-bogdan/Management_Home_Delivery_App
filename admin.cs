using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace aplicatie_zainea_bogdan
{
    public partial class admin : Form
    {
        Form1 mainFrame;
        List<Cont_Client> clienti_din_json = new List<Cont_Client>();
        List<Magazin> lista_magazine = new List<Magazin>();
        public admin(Form1 mainFrame1)
        {
            InitializeComponent();
            mainFrame = mainFrame1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Host=placeholder;Port=placeholder;Username=placeholder;Password=placeholder;Database=placeholder";

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT username, nume, prenume, nr_tel, id, parola FROM csharp_comenzi.users";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        listBox1.Items.Clear(); // Clear old list

                        while (reader.Read())
                        {
                            string line = $"ID: {reader["id"]}, " +
                                          $"Username: {reader["username"]}, " +
                                          $"Nume: {reader["nume"]}, " +
                                          $"Prenume: {reader["prenume"]}, " +
                                          $"Nr Telefon: {reader["nr_tel"]}, " +
                                          $"Parola: {reader["parola"]}";

                            listBox1.Items.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainFrame.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path2 = "";//path to lcoal client json

            if (File.Exists(path2))
            {
                string existingJson = File.ReadAllText(path2);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    clienti_din_json = JsonSerializer.Deserialize<List<Cont_Client>>(existingJson);
                }
            }

            listBox2.Items.Clear();
            foreach (Cont_Client client in clienti_din_json)
            {
                listBox2.Items.Add(client);
            }
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("Nu ai niciun client pana acum. \n Hai sa facem onboard la primul client !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path1 = "";//path to local json file with stores partners

            if (File.Exists(path1))
            {
                string existingJson = File.ReadAllText(path1);
                if (!string.IsNullOrWhiteSpace(existingJson))
                {
                    lista_magazine = JsonSerializer.Deserialize<List<Magazin>>(existingJson);
                }
            }

            string nume_magazin = textBox7.Text;
            int[] produse = textBox4.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] pret = textBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            Magazin magazin_nou = new Magazin(nume_magazin,produse,pret);
          
            lista_magazine.Add(magazin_nou);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string newJson = JsonSerializer.Serialize(lista_magazine, options);


            File.WriteAllText(path1, newJson);

            textBox1.Clear();
            textBox4.Clear();
            textBox7.Clear();

            MessageBox.Show("Magazin partener adaugat cu succes");

        }
    }
}
