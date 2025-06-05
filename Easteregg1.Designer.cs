namespace aplicatie_zainea_bogdan
{
    partial class Easteregg1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Easteregg1));
            button1 = new Button();
            label10 = new Label();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 219, 181);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(96, 63, 38);
            button1.Location = new Point(33, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 2;
            button1.Text = "log out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Rockwell", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 234, 197);
            label10.Location = new Point(372, 12);
            label10.Name = "label10";
            label10.Size = new Size(269, 46);
            label10.TabIndex = 19;
            label10.Text = "ZGB Delivery";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(115, 73);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(796, 498);
            axWindowsMediaPlayer1.TabIndex = 20;
            // 
            // Easteregg1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(96, 63, 38);
            ClientSize = new Size(1088, 600);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(label10);
            Controls.Add(button1);
            Name = "Easteregg1";
            Text = "Easteregg1";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label10;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}