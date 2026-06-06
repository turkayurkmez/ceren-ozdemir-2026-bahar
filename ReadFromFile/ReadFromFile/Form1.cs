using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReadFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetAllTeams_Click(object sender, EventArgs e)
        {

            //1. Dosya diyaloğu bu uygulamanın bulunduğu yerden başlayacak:
            openFileDialogTakim.InitialDirectory = Environment.CurrentDirectory;
            //2. Eğer kullanıcı, dosyayı seçip "Open" derse:
            if (openFileDialogTakim.ShowDialog() == DialogResult.OK)
            {
                //3. seçilen dosyanın adresini al:
                string teamsFilePath = openFileDialogTakim.FileName;
                //4. dosyanın doğruluğunu kontrol et:
                if (!File.Exists(teamsFilePath))
                {
                    MessageBox.Show("Belirtilen dosya bulunamdı");
                    return;
                }

                //5. Tüm satırları oku ve bir array'a al:
                var teams = File.ReadAllLines(teamsFilePath);

                //6. array içindeki tüm satırlarda dön:
                foreach (var team in teams)
                {
                    //her bir satırı listbox'a ekle
                    listBoxTeams.Items.Add(team);
                    buttonRandom.Enabled = true;
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listbox içinde hiç takım yoksa, rastgele butonuna basamasın!
            buttonRandom.Enabled = listBoxTeams.Items.Count > 0;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            //en küçük index:
            int min = 0;
            //en büyük index:
            int max = listBoxTeams.Items.Count;

            //Rastgele bir index seç:
            Random rastgele = new Random();
            int index = rastgele.Next(min, max);
            //seçtiğin indexteki takımı label'a yaz:
            labelTeam.Text = listBoxTeams.Items[index].ToString();


        }
    }
}
