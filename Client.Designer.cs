namespace aplicatie_zainea_bogdan
{
    partial class Client
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
            button1 = new Button();
            label10 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 219, 181);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(86, 41);
            button1.TabIndex = 1;
            button1.Text = "logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 234, 197);
            label10.Location = new Point(395, 14);
            label10.Name = "label10";
            label10.Size = new Size(269, 46);
            label10.TabIndex = 19;
            label10.Text = "ZGB Delivery";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 219, 181);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1041, 499);
            panel1.TabIndex = 20;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(108, 78, 49);
            button6.Cursor = Cursors.Hand;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(255, 234, 197);
            button6.Location = new Point(617, 255);
            button6.Name = "button6";
            button6.Size = new Size(340, 156);
            button6.TabIndex = 2;
            button6.Text = "Salveaza date cont ca fisier";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(108, 78, 49);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 234, 197);
            button3.Location = new Point(617, 60);
            button3.Name = "button3";
            button3.Size = new Size(340, 156);
            button3.TabIndex = 1;
            button3.Text = "Afiseaza Date Cont";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 78, 49);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 496);
            panel2.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 219, 181);
            button5.Cursor = Cursors.Hand;
            button5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(108, 78, 49);
            button5.Location = new Point(97, 253);
            button5.Name = "button5";
            button5.Size = new Size(340, 156);
            button5.TabIndex = 1;
            button5.Text = "Lista Facturi";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 219, 181);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(108, 78, 49);
            button2.Location = new Point(97, 58);
            button2.Name = "button2";
            button2.Size = new Size(340, 156);
            button2.TabIndex = 0;
            button2.Text = "Plaseaza o comanda";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 219, 181);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(886, 14);
            button4.Name = "button4";
            button4.Size = new Size(141, 41);
            button4.TabIndex = 21;
            button4.Text = "Close App";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 219, 181);
            button7.Cursor = Cursors.Hand;
            button7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(108, 78, 49);
            button7.Location = new Point(363, 600);
            button7.Name = "button7";
            button7.Size = new Size(340, 156);
            button7.TabIndex = 2;
            button7.Text = "Nr comenzi per magazin";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 63, 38);
            ClientSize = new Size(1039, 779);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(button1);
            Name = "Client";
            Text = "Client";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label10;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}