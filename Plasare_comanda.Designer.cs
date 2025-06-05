namespace aplicatie_zainea_bogdan
{
    partial class Plasare_comanda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label10 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button5 = new Button();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            clearListToolStripMenuItem = new ToolStripMenuItem();
            sorteazaDupaToolStripMenuItem = new ToolStripMenuItem();
            magazinToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            panel2 = new Panel();
            button10 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label12 = new Label();
            textBox9 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            errorLocalitate = new ErrorProvider(components);
            errorJudet = new ErrorProvider(components);
            errorAdresa = new ErrorProvider(components);
            errorMagazin = new ErrorProvider(components);
            errorCoduriProduse = new ErrorProvider(components);
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            helP_btn1 = new HELP_btn();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorLocalitate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorJudet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAdresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorMagazin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorCoduriProduse).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 234, 197);
            label10.Location = new Point(448, 4);
            label10.Name = "label10";
            label10.Size = new Size(269, 46);
            label10.TabIndex = 20;
            label10.Text = "ZGB Delivery";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 181);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(-1, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1623, 677);
            panel1.TabIndex = 21;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(108, 78, 49);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 234, 197);
            button2.Location = new Point(375, 593);
            button2.Name = "button2";
            button2.Size = new Size(352, 55);
            button2.TabIndex = 6;
            button2.Text = "&Vezi detalii comanda selectata";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(108, 78, 49);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(255, 234, 197);
            button5.Location = new Point(17, 593);
            button5.Name = "button5";
            button5.Size = new Size(221, 55);
            button5.TabIndex = 5;
            button5.Text = "&Toate comenzile";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // listBox1
            // 
            listBox1.ContextMenuStrip = contextMenuStrip1;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(17, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(710, 504);
            listBox1.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { clearListToolStripMenuItem, sorteazaDupaToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 52);
            // 
            // clearListToolStripMenuItem
            // 
            clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            clearListToolStripMenuItem.Size = new Size(181, 24);
            clearListToolStripMenuItem.Text = "Clear List";
            clearListToolStripMenuItem.Click += clearListToolStripMenuItem_Click;
            // 
            // sorteazaDupaToolStripMenuItem
            // 
            sorteazaDupaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { magazinToolStripMenuItem });
            sorteazaDupaToolStripMenuItem.Name = "sorteazaDupaToolStripMenuItem";
            sorteazaDupaToolStripMenuItem.Size = new Size(181, 24);
            sorteazaDupaToolStripMenuItem.Text = "Sorteaza dupa: ";
            // 
            // magazinToolStripMenuItem
            // 
            magazinToolStripMenuItem.Name = "magazinToolStripMenuItem";
            magazinToolStripMenuItem.Size = new Size(149, 26);
            magazinToolStripMenuItem.Text = "Magazin";
            magazinToolStripMenuItem.Click += magazinToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(108, 78, 49);
            label6.Location = new Point(13, 30);
            label6.Name = "label6";
            label6.Size = new Size(115, 20);
            label6.TabIndex = 1;
            label6.Text = "Istoric comenzi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 78, 49);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(751, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 677);
            panel2.TabIndex = 0;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 219, 181);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button10.ForeColor = Color.FromArgb(108, 78, 49);
            button10.Location = new Point(16, 593);
            button10.Name = "button10";
            button10.Size = new Size(264, 55);
            button10.TabIndex = 26;
            button10.Text = "P&rinteaza date comanda";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 219, 181);
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(108, 78, 49);
            button4.Location = new Point(182, 344);
            button4.Name = "button4";
            button4.Size = new Size(165, 29);
            button4.TabIndex = 25;
            button4.Text = "Magazine Partenere";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 219, 181);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(108, 78, 49);
            button3.Location = new Point(330, 593);
            button3.Name = "button3";
            button3.Size = new Size(218, 55);
            button3.TabIndex = 24;
            button3.Text = "&Plaseaza comanda";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 219, 181);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(108, 78, 49);
            button1.Location = new Point(182, 412);
            button1.Name = "button1";
            button1.Size = new Size(165, 29);
            button1.TabIndex = 23;
            button1.Text = "Lista Produse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(255, 234, 197);
            label12.ImageAlign = ContentAlignment.BottomRight;
            label12.Location = new Point(55, 379);
            label12.Name = "label12";
            label12.Size = new Size(120, 48);
            label12.TabIndex = 21;
            label12.Text = "Coduri produse ( cu spatiu )";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(181, 379);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(308, 27);
            textBox9.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(255, 234, 197);
            label9.Location = new Point(55, 314);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 17;
            label9.Text = "Magazin";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(181, 311);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(308, 27);
            textBox7.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(255, 234, 197);
            label8.ImageAlign = ContentAlignment.BottomRight;
            label8.Location = new Point(55, 216);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 15;
            label8.Text = "Judet";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(181, 213);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(308, 27);
            textBox6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(255, 234, 197);
            label7.ImageAlign = ContentAlignment.BottomRight;
            label7.Location = new Point(55, 168);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 13;
            label7.Text = "Localitate";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(181, 165);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(308, 27);
            textBox5.TabIndex = 14;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton3.ForeColor = Color.FromArgb(255, 234, 197);
            radioButton3.Location = new Point(198, 528);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(143, 24);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Vouchere Cadou";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton2.ForeColor = Color.FromArgb(255, 234, 197);
            radioButton2.Location = new Point(198, 498);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 24);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Numerar";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radioButton1.ForeColor = Color.FromArgb(255, 234, 197);
            radioButton1.Location = new Point(198, 468);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(114, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Card Bancar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 234, 197);
            label5.ImageAlign = ContentAlignment.BottomRight;
            label5.Location = new Point(55, 468);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 9;
            label5.Text = "Metoda de plata";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 234, 197);
            label4.ImageAlign = ContentAlignment.BottomRight;
            label4.Location = new Point(55, 266);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 7;
            label4.Text = "Adresa Livrare";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(181, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 27);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 234, 197);
            label3.ImageAlign = ContentAlignment.BottomRight;
            label3.Location = new Point(55, 120);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Nr_telefon";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 117);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 27);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 234, 197);
            label2.Location = new Point(55, 71);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Prenume";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 27);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 234, 197);
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Nume";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 27);
            textBox1.TabIndex = 2;
            // 
            // errorLocalitate
            // 
            errorLocalitate.ContainerControl = this;
            // 
            // errorJudet
            // 
            errorJudet.ContainerControl = this;
            // 
            // errorAdresa
            // 
            errorAdresa.ContainerControl = this;
            // 
            // errorMagazin
            // 
            errorMagazin.ContainerControl = this;
            // 
            // errorCoduriProduse
            // 
            errorCoduriProduse.ContainerControl = this;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 219, 181);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1103, 9);
            button6.Name = "button6";
            button6.Size = new Size(86, 41);
            button6.TabIndex = 26;
            button6.Text = "logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 219, 181);
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(12, 9);
            button7.Name = "button7";
            button7.Size = new Size(86, 41);
            button7.TabIndex = 27;
            button7.Text = "&Back";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 219, 181);
            button8.Cursor = Cursors.Hand;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(1205, 9);
            button8.Name = "button8";
            button8.Size = new Size(120, 41);
            button8.TabIndex = 28;
            button8.Text = "Close App";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(255, 219, 181);
            button9.Cursor = Cursors.Hand;
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(997, 9);
            button9.Name = "button9";
            button9.Size = new Size(86, 41);
            button9.TabIndex = 29;
            button9.Text = "&Help?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // helP_btn1
            // 
            helP_btn1.Location = new Point(767, 9);
            helP_btn1.Name = "helP_btn1";
            helP_btn1.Size = new Size(216, 41);
            helP_btn1.TabIndex = 30;
            // 
            // Plasare_comanda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 63, 38);
            ClientSize = new Size(1337, 737);
            Controls.Add(helP_btn1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Name = "Plasare_comanda";
            Text = "Plasare_comandacs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorLocalitate).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorJudet).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAdresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorMagazin).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorCoduriProduse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label8;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox9;
        private Button button1;
        private Button button3;
        private Button button4;
        private ErrorProvider errorLocalitate;
        private ErrorProvider errorJudet;
        private ErrorProvider errorAdresa;
        private ErrorProvider errorMagazin;
        private ErrorProvider errorCoduriProduse;
        private ListBox listBox1;
        private Button button5;
        private Button button2;
        private Button button7;
        private Button button6;
        private Button button8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem clearListToolStripMenuItem;
        private ToolStripMenuItem sorteazaDupaToolStripMenuItem;
        private ToolStripMenuItem magazinToolStripMenuItem;
        private Button button9;
        private Button button10;
        private HELP_btn helP_btn1;
    }
}