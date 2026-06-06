namespace ReadFromFile
{
    partial class Form1
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
            listBoxTeams = new ListBox();
            buttonGetAllTeams = new Button();
            openFileDialogTakim = new OpenFileDialog();
            buttonRandom = new Button();
            labelTeam = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxTeams
            // 
            listBoxTeams.FormattingEnabled = true;
            listBoxTeams.Location = new Point(99, 61);
            listBoxTeams.Name = "listBoxTeams";
            listBoxTeams.Size = new Size(572, 164);
            listBoxTeams.TabIndex = 0;
            // 
            // buttonGetAllTeams
            // 
            buttonGetAllTeams.Location = new Point(99, 244);
            buttonGetAllTeams.Name = "buttonGetAllTeams";
            buttonGetAllTeams.Size = new Size(263, 29);
            buttonGetAllTeams.TabIndex = 1;
            buttonGetAllTeams.Text = "Takımları Getir";
            buttonGetAllTeams.UseVisualStyleBackColor = true;
            buttonGetAllTeams.Click += buttonGetAllTeams_Click;
            // 
            // openFileDialogTakim
            // 
            openFileDialogTakim.Filter = "Metin dosyası|*.txt";
            // 
            // buttonRandom
            // 
            buttonRandom.Location = new Point(388, 249);
            buttonRandom.Name = "buttonRandom";
            buttonRandom.Size = new Size(262, 29);
            buttonRandom.TabIndex = 2;
            buttonRandom.Text = "Rastgele Getir";
            buttonRandom.UseVisualStyleBackColor = true;
            buttonRandom.Click += buttonRandom_Click;
            // 
            // labelTeam
            // 
            labelTeam.AutoSize = true;
            labelTeam.Location = new Point(375, 309);
            labelTeam.Name = "labelTeam";
            labelTeam.Size = new Size(50, 20);
            labelTeam.TabIndex = 3;
            labelTeam.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 309);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Seçilen Takım:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(labelTeam);
            Controls.Add(buttonRandom);
            Controls.Add(buttonGetAllTeams);
            Controls.Add(listBoxTeams);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTeams;
        private Button buttonGetAllTeams;
        private OpenFileDialog openFileDialogTakim;
        private Button buttonRandom;
        private Label labelTeam;
        private Label label2;
    }
}