namespace aplicatie_zainea_bogdan
{
    partial class HELP_btn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 219, 181);
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(225, 55);
            button1.TabIndex = 0;
            button1.Text = "Help_Mic_Unealta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // HELP_btn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Name = "HELP_btn";
            Size = new Size(223, 54);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}
