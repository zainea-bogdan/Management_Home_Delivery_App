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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;

namespace aplicatie_zainea_bogdan
{
    public partial class Client : Form
    {
        Form mainForm;
        Cont_Client client_logat;
        public Client(Form callingForm, Cont_Client cont_intrat)
        {
            InitializeComponent();
            mainForm = callingForm;
            client_logat = cont_intrat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(client_logat.ToString(), "Detalii cont");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plasare_comanda newForm = new Plasare_comanda(this, mainForm, client_logat);
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lista_Facturi newForm = new Lista_Facturi(this, mainForm, client_logat);
            newForm.Show();
            this.Hide();
        }

        /*aici am vrut sa pot avea obtinea ca clientul sa isi descarce intr un txt datele in caz ca le o vrea */
        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Salvează datele clientului logat";
            saveFileDialog.FileName = $"Client_{client_logat.username}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                string continut = $"Date Client Logat:\n" +
                                  $"Id: {client_logat.Id}\n" +
                                  $"Username: {client_logat.username}\n" +
                                  $"Nume: {client_logat.Nume}\n" +
                                  $"Prenume: {client_logat.Prenume}\n" +
                                  $"Telefon: {client_logat.Nr_telefon}\n" +
                                  $"Parola: {client_logat.parola}";

                File.WriteAllText(saveFileDialog.FileName, continut);
                MessageBox.Show("Datele clientului au fost salvate cu succes!");
            }
        }

        /*mai jos este codul pentru a vizualiza un grafic de tip scatter cu nr de comenzi per magazine pentru utilizatorul logat*/
        private void button7_Click(object sender, EventArgs e)
        {
            string path = "";//path istoric comenzi

            if (!File.Exists(path))
            {
                MessageBox.Show("Fișierul istoric_comenzi.json nu există.");
                return;
            }

            string json = File.ReadAllText(path);

            List<Comanda> toateComenzile;
            try
            {
                toateComenzile = JsonSerializer.Deserialize<List<Comanda>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea JSON-ului: " + ex.Message);
                return;
            }

          
            var comenziClient = toateComenzile
                .Where(c => c.nr_telefon == client_logat.Nr_telefon)
                .ToList();

            if (comenziClient.Count == 0)
            {
                MessageBox.Show("Clientul logat nu are comenzi.");
                return;
            }

            
            var comenziPeMagazin = comenziClient
                .GroupBy(c => c.Magazin?.Trim().ToLowerInvariant())
                .ToDictionary(
                    g => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(g.Key),
                    g => g.Count()
                );

           
            Form formGrafic = new Form { Text = "Număr comenzi per Magazin", Width = 800, Height = 400 };
            Chart chart = new Chart { Dock = DockStyle.Fill };

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Magazin";
            area.AxisY.Title = "Număr Comenzi";
            area.AxisX.Interval = 1;
            area.AxisY.Minimum = 0;
            chart.ChartAreas.Add(area);

            Series serie = new Series
            {
                ChartType = SeriesChartType.Point,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 10,
                Color = Color.Green,
                IsValueShownAsLabel = true,
                XValueType = ChartValueType.Int32,
                YValueType = ChartValueType.Int32
            };

            int index = 0;
            foreach (var pair in comenziPeMagazin)
            {
                serie.Points.AddXY(index, pair.Value);
                serie.Points[index].AxisLabel = pair.Key;              
                serie.Points[index].Label = pair.Value.ToString();     
                index++;
            }

            chart.Series.Clear();
            chart.Series.Add(serie);
            formGrafic.Controls.Add(chart);
            formGrafic.ShowDialog();


        }


    }
}
