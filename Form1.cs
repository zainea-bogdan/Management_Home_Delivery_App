using System.Net;
using System.Text.Json;
using Npgsql;
using System;
using System.Windows.Forms;



namespace aplicatie_zainea_bogdan
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Cont_Client> lista_conturi = new List<Cont_Client>();

        private void button1_Click(object sender, EventArgs e)
        {
            /*m-am distrat putin cu acest proiect, chiar va invit sa folositi acest username si parola ca sa vedeti*/
            if(textBox1.Text=="easteregg1" && textBox2.Text=="easteregg1")
            {
                Easteregg1 newForm = new Easteregg1(this, "easteregg1");
                newForm.Show();
                textBox2.Clear();
                textBox1.Clear();
                this.Hide();

                return;
            }
            if (textBox1.Text == "easteregg2" && textBox2.Text == "easteregg2")
            {
                Easteregg1 newForm = new Easteregg1(this, "easteregg2");
                newForm.Show();
                textBox2.Clear();
                textBox1.Clear();
                this.Hide();

                return;
            }

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                admin newForm = new admin(this);
                newForm.Show();
                textBox2.Clear();
                textBox1.Clear();
                this.Hide();
                return;
            }



            int validare_login_credetials = 1;

            //validare_login_credetials = validareLogin(textBox1.Text, textBox2.Text);

            if (validare_login_credetials == 1)
            {
                string path = "";//path to local json file that contains conturi clienti

                if (File.Exists(path))
                {
                    string existingJson = File.ReadAllText(path);
                    if (!string.IsNullOrWhiteSpace(existingJson))
                    {
                        lista_conturi = JsonSerializer.Deserialize<List<Cont_Client>>(existingJson);
                    }
                }

                if (lista_conturi != null)
                {
                    int este_numele = 0;
                    int este_parola = 0;
                    Cont_Client client_gasit = null;
                    foreach (Cont_Client client in lista_conturi)
                    {
                        if (client.username == textBox1.Text)
                        {
                            este_numele = 1;
                        }
                        if (client.parola == textBox2.Text)
                        {
                            este_parola = 1;
                        }
                        if (client.username == textBox1.Text && client.parola == textBox2.Text)
                        {
                            client_gasit = client;
                        }
                    }


                    if (este_numele == 1 && este_parola == 1)
                    {
                        Client newForm = new Client(this, client_gasit);
                        newForm.Show();
                        textBox2.Clear();
                        textBox1.Clear();
                        this.Hide();

                    }
                    else
                    {
                        if (este_numele != 1 && este_parola != 1)
                        {
                            errorLogin.SetError(button1, "Contul nu exista. Please Sign in first!");

                            textBox2.Clear();
                        }
                        if ((este_numele != 1 && este_parola == 1) || (este_numele == 1 && este_parola != 1))
                        {
                            errorLogin.SetError(button1, "Username sau parola gresita");

                            textBox2.Clear();
                        }

                    }
                }


            }

        }




        int validareCredetianls(string Nume, string Prenume, string Nr_telefon, string parola, string username)
        {
            //coduri erori:
            //-1=texbox gol
            //-2=lungimea textului incorecta
            //-3=Tip de data invalid pentru campul respectiv 


            //validare username
            if (username == "")
            {
                errorUsernameSign.SetError(textBox7, "Introduceti un username");
                textBox7.ForeColor = Color.Red;
                textBox7.Focus();
                return -1;
            }
            else
            {
                if (username.Length < 10 || username.Length > 20)
                {
                    errorUsernameSign.SetError(textBox7, "Username prea scurt. Trebuie minim 10 caractere");
                    textBox7.ForeColor = Color.Red;
                    textBox7.Focus();
                    return -2;
                }
                else
                {
                    errorUsernameSign.Clear();
                    textBox7.ForeColor = SystemColors.WindowText;
                }
            }


            //validare nume;


            if (Nume == "")
            {
                errorNameSign.SetError(textBox4, "Introduceti un Nume");
                textBox4.Focus();
                return -1;
            }
            else
            {
                int validare_litere = 1;

                foreach (char c in Nume)
                {
                    if (!char.IsLetter(c))
                    {
                        validare_litere = 0;
                        break;
                    }
                }

                if (validare_litere == 1)
                {
                    Nume = char.ToUpper(Nume[0]) + Nume.Substring(1).ToLower();
                    textBox4.ForeColor = SystemColors.WindowText;
                    errorNameSign.Clear();
                }
                else
                {
                    errorNameSign.SetError(textBox4, "Numele trebuie sa aiba doar litere");
                    textBox4.Focus();
                    textBox4.ForeColor = Color.Red;
                    return -3;
                }


            }

            //validare prenume

            if (Prenume == "")
            {
                errorPrenumeSign.SetError(textBox5, "Introduceti un Prenume");
                textBox7.Focus();
                return -1;
            }
            else
            {
                //verificam daca contine doar cifre
                int validare_litere = 1;

                foreach (char c in Prenume)
                {
                    if (!char.IsLetter(c))
                    {
                        validare_litere = 0;
                        break;
                    }
                }

                if (validare_litere == 1)
                {
                    Prenume = char.ToUpper(Prenume[0]) + Prenume.Substring(1).ToLower();
                    textBox5.ForeColor = SystemColors.WindowText;
                    errorPrenumeSign.Clear();
                }
                else
                {
                    errorPrenumeSign.SetError(textBox5, "Prenume trebuie sa aiba doar litere");
                    textBox5.Focus();
                    textBox5.ForeColor = Color.Red;
                    return -3;
                }


            }

            //validare nr telefon
            if (Nr_telefon == "")
            {
                errorTelefonSign.SetError(textBox6, "Introduceti un Nr de telefon");
                textBox6.ForeColor = Color.Red;
                textBox6.Focus();
                return -1;
            }
            else
            {
                if (Nr_telefon.Length != 10)
                {
                    errorTelefonSign.SetError(textBox6, "Nr telefon nu are nr corespunzator de cifre. Trebuie fix 10 cifre");
                    textBox6.ForeColor = Color.Red;
                    textBox6.Focus();
                    return -2;
                }
                else
                {
                    //verificam daca contine doar cifre
                    int validare_cifre = 1;

                    foreach (char c in Nr_telefon)
                    {
                        if (!char.IsDigit(c))
                        {
                            validare_cifre = 0;
                            break;
                        }
                    }


                    if (validare_cifre != 1)
                    {
                        errorTelefonSign.SetError(textBox6, "Nr telefon trebuie sa contina doar cifre");
                        textBox6.ForeColor = Color.Red;
                        textBox6.Focus();
                        return -3;
                    }
                    else
                    {
                        errorTelefonSign.Clear();
                        textBox6.ForeColor = SystemColors.WindowText;
                    }

                }
            }

            //validare parola:
            if (parola == "")
            {
                errorParolaSign.SetError(textBox3, "Introduceti o parola");
                return -1;
            }
            else
            {
                int nr_litere_mari = 0;
                int nr_cifre = 0;


                foreach (char c in parola)
                {
                    if (char.IsLetter(c) && char.IsUpper(c))
                    {
                        nr_litere_mari++;
                    }
                    else
                    {
                        if (char.IsDigit(c))
                        {
                            nr_cifre++;
                        }
                    }
                }

                if (nr_litere_mari >= 1 && nr_cifre > 3 && parola.Length > 9)
                {
                    errorParolaSign.Clear();
                    textBox3.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    if (nr_litere_mari == 0)
                    {
                        errorParolaSign.SetError(textBox3, "Minim 1 litera Mare");
                        textBox3.Focus();
                        textBox3.ForeColor = Color.Red;
                        return -2;
                    }
                    else
                    {
                        if (nr_cifre <= 3)
                        {
                            errorParolaSign.SetError(textBox3, "Minim 4 cifre");
                            textBox3.Focus();
                            textBox3.ForeColor = Color.Red;
                            return -2;
                        }
                        else
                        {
                            if (parola.Length <= 9)
                            {
                                errorParolaSign.SetError(textBox3, "Parola trebuie sa aiba mini 10 caractere");
                                textBox3.Focus();
                                textBox3.ForeColor = Color.Red;
                                return -2;
                            }
                            else
                            {
                                errorParolaSign.Clear();
                                textBox3.ForeColor = SystemColors.WindowText;
                            }
                        }
                    }

                }

            }
            return 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int valid = 1;
            valid = validareCredetianls(textBox4.Text, textBox5.Text, textBox6.Text, textBox3.Text, textBox7.Text);
            if (valid == 1)
            {
                string path = "";//path to local clienti json

                if (File.Exists(path))
                {
                    string existingJson = File.ReadAllText(path);
                    if (!string.IsNullOrWhiteSpace(existingJson))
                    {
                        lista_conturi = JsonSerializer.Deserialize<List<Cont_Client>>(existingJson);
                    }
                }


                Cont_Client clientnou = new Cont_Client(textBox4.Text, textBox5.Text, textBox6.Text, textBox3.Text, textBox7.Text);

                if (lista_conturi != null)
                {
                    int este_username = 0;
                    int verificare_nr_tel = 0;
                    foreach (Cont_Client client in lista_conturi)
                    {
                        if (client.username == clientnou.username)
                        {
                            este_username = 1;
                            break;
                        }

                        if (client.Nr_telefon == clientnou.Nr_telefon)
                        {
                            verificare_nr_tel = 1;
                            break;
                        }
                    }


                    if (este_username == 1)
                    {
                        errorSignIn.Clear();
                        errorSignIn.SetError(textBox7, "Username folosit");
                        MessageBox.Show("Username deja folosit");
                        textBox7.Clear();
                    }
                    if (verificare_nr_tel == 1)
                    {
                        errorSignIn.Clear();
                        errorSignIn.SetError(textBox6, "Exista cont cu nr asta de telefon");
                        MessageBox.Show("Nr de telefon deja folosit");
                        textBox6.Clear();
                    }
                    if (este_username == 0 && verificare_nr_tel == 0)
                    {
                        lista_conturi.Add(clientnou);


                        var options = new JsonSerializerOptions { WriteIndented = true };
                        string newJson = JsonSerializer.Serialize(lista_conturi, options);


                        File.WriteAllText(path, newJson);

                        string connString = "Host=placholder;Port=placeholder;Username=placeholder;Password=placeholder;Database=placeholder";

                        using (var conn = new NpgsqlConnection(connString))
                        {
                            conn.Open();

                            string query = @"INSERT INTO csharp_comenzi.users (username, nume, prenume, nr_tel, id, parola)
                                VALUES (@username, @nume, @prenume, @nr_tel, @id, @parola)";

                            using (var cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("username", clientnou.username);
                                cmd.Parameters.AddWithValue("nume", clientnou.Nume);
                                cmd.Parameters.AddWithValue("prenume", clientnou.Prenume);
                                cmd.Parameters.AddWithValue("nr_tel", clientnou.Nr_telefon);
                                cmd.Parameters.AddWithValue("id", clientnou.Id);
                                cmd.Parameters.AddWithValue("parola", clientnou.parola);

                                cmd.ExecuteNonQuery();
                            }
                        }




                        MessageBox.Show("Username Succesfully created ");

                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                        errorSignIn.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Date introduse gresit");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mesaj = "\nBine ai venit la ZGB Delivery\n" +
                "\n 1) Sign in:" +
                "\n  - Numele si Prenume trebuie scrise cu prima litera mare"+
                "\n  - Username-ul trebuie sa aiba minim 10 caractere" +
                "\n  - Nr de telefon trebuie sa aiba 10 cifre" +
                "\n  - Parola trebuie sa aiba minim : " +
                "\n    -- 1 litera Mare " +
                "\n    -- 4 cifre " +
                "\n    -- 10 caractere minim" +
                "\n  - Apoi apasa pe Sign In si felicitari ti-ai creat primul cont la ZGB Delivery!" +
                "\n 2) Log in:\n" +
                "\n  - Dupa ce ti-ai facut/Daca ai deja cont introdu username si parola pentru a intra in contul personal" +
                "\n 3) Enjoy the experience on our app! Thanks!";

                


            MessageBox.Show(mesaj, "Help Center");
        }
    }
}
