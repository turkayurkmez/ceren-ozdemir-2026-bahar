namespace SlotMakinesi
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
            components = new System.ComponentModel.Container();
            labelKart1 = new Label();
            labelKart2 = new Label();
            labelKart3 = new Label();
            buttonBaslat = new Button();
            buttonDurdur = new Button();
            timerZamanlayici = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelKart1
            // 
            labelKart1.BorderStyle = BorderStyle.FixedSingle;
            labelKart1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKart1.Location = new Point(175, 150);
            labelKart1.Name = "labelKart1";
            labelKart1.Size = new Size(141, 134);
            labelKart1.TabIndex = 0;
            labelKart1.Text = "0";
            labelKart1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelKart2
            // 
            labelKart2.BorderStyle = BorderStyle.FixedSingle;
            labelKart2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKart2.Location = new Point(322, 150);
            labelKart2.Name = "labelKart2";
            labelKart2.Size = new Size(141, 134);
            labelKart2.TabIndex = 1;
            labelKart2.Text = "0";
            labelKart2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelKart3
            // 
            labelKart3.BorderStyle = BorderStyle.FixedSingle;
            labelKart3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelKart3.Location = new Point(469, 150);
            labelKart3.Name = "labelKart3";
            labelKart3.Size = new Size(141, 134);
            labelKart3.TabIndex = 2;
            labelKart3.Text = "0";
            labelKart3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonBaslat
            // 
            buttonBaslat.Location = new Point(269, 316);
            buttonBaslat.Name = "buttonBaslat";
            buttonBaslat.Size = new Size(94, 29);
            buttonBaslat.TabIndex = 3;
            buttonBaslat.Text = "Başlat";
            buttonBaslat.UseVisualStyleBackColor = true;
            buttonBaslat.Click += buttonBaslat_Click;
            // 
            // buttonDurdur
            // 
            buttonDurdur.Location = new Point(369, 316);
            buttonDurdur.Name = "buttonDurdur";
            buttonDurdur.Size = new Size(94, 29);
            buttonDurdur.TabIndex = 4;
            buttonDurdur.Text = "Durdur";
            buttonDurdur.UseVisualStyleBackColor = true;
            buttonDurdur.Click += buttonDurdur_Click;
            // 
            // timerZamanlayici
            // 
            timerZamanlayici.Interval = 10;
            timerZamanlayici.Tick += timerZamanlayici_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDurdur);
            Controls.Add(buttonBaslat);
            Controls.Add(labelKart3);
            Controls.Add(labelKart2);
            Controls.Add(labelKart1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelKart1;
        private Label labelKart2;
        private Label labelKart3;
        private Button buttonBaslat;
        private Button buttonDurdur;
        private System.Windows.Forms.Timer timerZamanlayici;
    }
}
