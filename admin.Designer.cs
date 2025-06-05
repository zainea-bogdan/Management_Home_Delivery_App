namespace aplicatie_zainea_bogdan
{
    partial class admin
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            button3 = new Button();
            button1 = new Button();
            textBox7 = new TextBox();
            label9 = new Label();
            button2 = new Button();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label10 = new Label();
            button4 = new Button();
            helP_btn1 = new HELP_btn();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 181);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-7, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(1433, 629);
            panel1.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1212, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 22;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(453, 111);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(363, 404);
            listBox2.TabIndex = 21;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(363, 404);
            listBox1.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(108, 78, 49);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 234, 197);
            button3.Location = new Point(453, 10);
            button3.Name = "button3";
            button3.Size = new Size(209, 80);
            button3.TabIndex = 19;
            button3.Text = "Afiseaza Users din JSON";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(108, 78, 49);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(255, 234, 197);
            button1.Location = new Point(19, 10);
            button1.Name = "button1";
            button1.Size = new Size(209, 80);
            button1.TabIndex = 18;
            button1.Text = "Afiseaza Users din DB";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1212, 112);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(209, 27);
            textBox7.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(964, 111);
            label9.Name = "label9";
            label9.Size = new Size(156, 28);
            label9.TabIndex = 16;
            label9.Text = "Nume Magazin";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(108, 78, 49);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(255, 234, 197);
            button2.Location = new Point(1212, 271);
            button2.Name = "button2";
            button2.Size = new Size(209, 80);
            button2.TabIndex = 11;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(964, 215);
            label7.Name = "label7";
            label7.Size = new Size(245, 28);
            label7.TabIndex = 12;
            label7.Text = "Pret Produse( cu spatiu )";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1212, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(209, 27);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(964, 163);
            label6.Name = "label6";
            label6.Size = new Size(250, 28);
            label6.TabIndex = 7;
            label6.Text = "Lista Produse( cu spatiu )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(108, 78, 49);
            label4.Location = new Point(964, 27);
            label4.Name = "label4";
            label4.Size = new Size(384, 41);
            label4.TabIndex = 6;
            label4.Text = "Adauga Magazin Partener";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 234, 197);
            label10.Location = new Point(494, 18);
            label10.Name = "label10";
            label10.Size = new Size(269, 46);
            label10.TabIndex = 19;
            label10.Text = "ZGB Delivery";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 219, 181);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(96, 63, 38);
            button4.Location = new Point(21, 18);
            button4.Name = "button4";
            button4.Size = new Size(152, 44);
            button4.TabIndex = 22;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // helP_btn1
            // 
            helP_btn1.Location = new Point(1172, 18);
            helP_btn1.Name = "helP_btn1";
            helP_btn1.Size = new Size(212, 48);
            helP_btn1.TabIndex = 23;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 63, 38);
            ClientSize = new Size(1426, 711);
            Controls.Add(helP_btn1);
            Controls.Add(button4);
            Controls.Add(label10);
            Controls.Add(panel1);
            Name = "admin";
            Text = "admin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox7;
        private Label label9;
        private Button button2;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private Label label4;
        private Label label10;
        private ListBox listBox2;
        private ListBox listBox1;
        private Button button3;
        private Button button1;
        private Button button4;
        private TextBox textBox1;
        private HELP_btn helP_btn1;
    }
}