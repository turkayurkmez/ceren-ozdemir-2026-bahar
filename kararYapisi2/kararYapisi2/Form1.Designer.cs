namespace kararYapisi2
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
            buttonTikla = new Button();
            buttonYakala = new Button();
            SuspendLayout();
            // 
            // buttonTikla
            // 
            buttonTikla.BackColor = Color.FromArgb(0, 192, 192);
            buttonTikla.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTikla.ForeColor = Color.White;
            buttonTikla.Location = new Point(250, 211);
            buttonTikla.Name = "buttonTikla";
            buttonTikla.Size = new Size(171, 93);
            buttonTikla.TabIndex = 0;
            buttonTikla.Text = "Tıklayın";
            buttonTikla.UseVisualStyleBackColor = false;
            buttonTikla.Click += buttonTikla_Click;
            // 
            // buttonYakala
            // 
            buttonYakala.Font = new Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonYakala.Location = new Point(531, 693);
            buttonYakala.Name = "buttonYakala";
            buttonYakala.Size = new Size(241, 77);
            buttonYakala.TabIndex = 1;
            buttonYakala.Text = "Yakala beni!";
            buttonYakala.UseVisualStyleBackColor = true;
            buttonYakala.MouseEnter += buttonYakala_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 836);
            Controls.Add(buttonYakala);
            Controls.Add(buttonTikla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTikla;
        private Button buttonYakala;
    }
}
