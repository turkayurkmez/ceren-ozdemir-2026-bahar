namespace switchCase2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxRenkler = new ComboBox();
            buttonRenk = new Button();
            comboBoxIskambil = new ComboBox();
            buttonKartRengi = new Button();
            buttonGunler = new Button();
            SuspendLayout();
            // 
            // comboBoxRenkler
            // 
            comboBoxRenkler.FormattingEnabled = true;
            comboBoxRenkler.Items.AddRange(new object[] { "Pembe", "Yeşil", "Mor" });
            comboBoxRenkler.Location = new Point(257, 123);
            comboBoxRenkler.Name = "comboBoxRenkler";
            comboBoxRenkler.Size = new Size(151, 28);
            comboBoxRenkler.TabIndex = 0;
            comboBoxRenkler.SelectionChangeCommitted += comboBoxRenkler_SelectionChangeCommitted;
            // 
            // buttonRenk
            // 
            buttonRenk.Location = new Point(430, 124);
            buttonRenk.Name = "buttonRenk";
            buttonRenk.Size = new Size(94, 29);
            buttonRenk.TabIndex = 1;
            buttonRenk.UseVisualStyleBackColor = true;
            // 
            // comboBoxIskambil
            // 
            comboBoxIskambil.FormattingEnabled = true;
            comboBoxIskambil.Items.AddRange(new object[] { "Sinek", "Karo", "Kupa", "Maça" });
            comboBoxIskambil.Location = new Point(326, 221);
            comboBoxIskambil.Name = "comboBoxIskambil";
            comboBoxIskambil.Size = new Size(151, 28);
            comboBoxIskambil.TabIndex = 2;
            comboBoxIskambil.SelectionChangeCommitted += comboBoxIskambil_SelectionChangeCommitted;
            // 
            // buttonKartRengi
            // 
            buttonKartRengi.Location = new Point(326, 262);
            buttonKartRengi.Name = "buttonKartRengi";
            buttonKartRengi.Size = new Size(151, 84);
            buttonKartRengi.TabIndex = 3;
            buttonKartRengi.UseVisualStyleBackColor = true;
            // 
            // buttonGunler
            // 
            buttonGunler.Location = new Point(628, 271);
            buttonGunler.Name = "buttonGunler";
            buttonGunler.Size = new Size(302, 59);
            buttonGunler.TabIndex = 4;
            buttonGunler.Text = "Hafta sonu mu yoksa hafta içi mi?";
            buttonGunler.UseVisualStyleBackColor = true;
            buttonGunler.Click += buttonGunler_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 450);
            Controls.Add(buttonGunler);
            Controls.Add(buttonKartRengi);
            Controls.Add(comboBoxIskambil);
            Controls.Add(buttonRenk);
            Controls.Add(comboBoxRenkler);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxRenkler;
        private Button buttonRenk;
        private ComboBox comboBoxIskambil;
        private Button buttonKartRengi;
        private Button buttonGunler;
    }
}
